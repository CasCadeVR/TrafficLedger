using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Violations
{
    public partial class ViolationListView : BaseListView<Violation>
    {
        private readonly INavigationService navigationService;
        private readonly IViolationService violationService;

        public ViolationListView(INavigationService navigationService, IViolationService violationService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.violationService = violationService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            NoItemsMessage = "Кодекс нарушений пустой";
        }

        protected override async Task<IEnumerable<Violation>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await violationService.GetAll(cancellationToken);
        }

        protected override IEnumerable<Violation> FilterItems(string searchQuery, IEnumerable<Violation> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.ViolationCode?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Name?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.FinePrice.ToString() == lowerQuery
            );
        }

        protected override Control CreateItemControl(Violation item)
        {
            var card = new ViolationCard(item);

            card.EditClicked += () => Edit(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private void Edit(Violation item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<ViolationCreateView>();
            createView.Initialize(item);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование нарушения",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Delete(Violation item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить нарушение с номером {item.ViolationCode}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                violationService.Delete(item.Id, CancellationToken.None);
                MessageBox.Show($"Нарушение {item.ViolationCode} успешно удалёно", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }
    }
}
