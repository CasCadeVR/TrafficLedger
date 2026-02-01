using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.PanelViews.Payments;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Fines
{
    public partial class FineTransportListView : BaseListView<Fine>
    {
        private readonly INavigationService navigationService;
        private readonly IFineService fineService;
        private Transport currentTransport;
        private bool ownTransport;

        public FineTransportListView(INavigationService navigationService, IFineService fineService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.fineService = fineService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Transport currentTransport, bool ownTransport)
        {
            this.currentTransport = currentTransport;
            this.ownTransport = ownTransport;

            NoItemsMessage = $"На транспорт с номером {currentTransport.TransportCode} не зарегистрировано ни одного штрафа";
        }

        protected override async Task<IEnumerable<Fine>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            var allFines = await fineService.GetAllByTransportId(currentTransport.Id, cancellationToken);
            var activeFines = allFines.Where(x => x.Status == Status.InProgress);
            return activeFines;
        }

        protected override IEnumerable<Fine> FilterItems(string searchQuery, IEnumerable<Fine> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.Date.ToString().ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Violation.Name?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Violation.ViolationCode.ToString() == lowerQuery
            );
        }

        protected override Control CreateItemControl(Fine item)
        {
            var card = new FineCard(item, ownTransport);

            card.EditClicked += () => Edit(item);
            card.DeletedClicked += () => Delete(item);
            card.PayClicked += () => Pay(item);

            return card;
        }

        private void Edit(Fine item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<FineCreateView>();
            createView.Initialize(currentTransport, item);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование штрафа",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Delete(Fine item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить штраф с номером {item.Violation.ViolationCode}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                fineService.Delete(item.Id, CancellationToken.None);
                MessageBox.Show($"Штраф {item.Violation.ViolationCode} успешно удалёно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void Pay(Fine item)
        {
            var userId = AuthenticationService.Instance.CurrentUser.Id;
            var createView = navigationService.ServiceProvider.GetRequiredService<PaymentCreateView>();
            createView.Initialize(item, userId, null);

            var navigationItem = new NavigationItem()
            {
                Title = "Оплата штрафа",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
