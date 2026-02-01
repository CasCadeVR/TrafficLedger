using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Enums;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Transports;
using TrafficLedger.Desktop.Views.PanelViews.Fines;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.FineCreate
{
    public partial class TransportListView : BaseListView<Transport>
    {
        private readonly INavigationService navigationService;
        private readonly ITransportService transportService;

        public TransportListView(INavigationService navigationService, ITransportService transportService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.transportService = transportService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        protected override async Task<IEnumerable<Transport>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await transportService.GetAll(cancellationToken);
        }

        protected override IEnumerable<Transport> FilterItems(string searchQuery, IEnumerable<Transport> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.TransportCode?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Brand?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Model?.ToLowerInvariant().Contains(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(Transport item)
        {
            var card = new TransportCard(item, TransportCardRoleContext.RoleList);

            card.EditClicked += () => EditTransport(item);
            card.DeletedClicked += () => DeleteTransport(item);
            card.CreateFineClicked += () => CreateFine(item);
            card.ListFineClicked += () => ListFine(item);

            return card;
        }

        private void EditTransport(Transport item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<TransportCreateView>();
            createView.Initialize(item);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование транспорта",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void DeleteTransport(Transport item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить транспорт с номером {item.TransportCode}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                transportService.Delete(item.Id, CancellationToken.None);
                MessageBox.Show($"Транспорт {item.TransportCode} успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void CreateFine(Transport item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<FineCreateView>();
            createView.Initialize(item, null);

            var navigationItem = new NavigationItem()
            {
                Title = $"Оформление штрафа на транспорт с номером {item.TransportCode}",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void ListFine(Transport item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<FineTransportListView>();
            createView.Initialize(item, ownTransport: false);

            var navigationItem = new NavigationItem()
            {
                Title = $"Штрафы транспорта с номером {item.TransportCode}",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
