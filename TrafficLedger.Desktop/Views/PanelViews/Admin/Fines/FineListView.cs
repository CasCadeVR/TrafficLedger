using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Fines;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Fines
{
    public partial class FineListView : BaseListView<Fine>
    {
        private readonly INavigationService navigationService;
        private readonly IFineService fineService;

        public FineListView(INavigationService navigationService, IFineService fineService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.fineService = fineService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        protected override async Task<IEnumerable<Fine>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await fineService.GetAll(cancellationToken);
        }

        protected override IEnumerable<Fine> FilterItems(string searchQuery, IEnumerable<Fine> items)
        {
            var filteredByStatus = checkBoxShowUnactive.Checked
                ? items
                : items.Where(f => f.Status == RequestStatus.Pending);

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return filteredByStatus;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return filteredByStatus.Where(t =>
                t.Transport.TransportCode.ToString() == lowerQuery ||
                t.Date.ToString().ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Violation.Name?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Violation.ViolationCode.ToString() == lowerQuery
            );
        }

        protected override Control CreateItemControl(Fine item)
        {
            var card = new FineCard(item, ownTransport: false, withTransportCode: true);

            card.EditClicked += () => Edit(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private void Edit(Fine item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<FineCreateView>();
            createView.Initialize(item.Transport, item);

            var navigationItem = new NavigationItem()
            {
                Title = $"Редактирование штрафа на транспорт с номером {item.Transport.TransportCode}",
                ViewType = null!,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Delete(Fine item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить штраф с номером {item.Violation.ViolationCode}?. Это удалит штраф безвозвратно, а не завершает его",
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

        private void checkBoxShowUnactive_CheckedChanged(object sender, System.EventArgs e)
        {
            PerformSearch();
        }
    }
}