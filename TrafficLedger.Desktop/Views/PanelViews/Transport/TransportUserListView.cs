using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Enums;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.PanelViews.Fines;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class TransportUserListView : BaseListView<Transport>
    {
        private readonly Lazy<INavigationService> navigationService;
        private readonly ITransportService transportService;
        private readonly IDriverService driverService;
        private readonly AppUser currentUser;

        public TransportUserListView(
            Lazy<INavigationService> navigationService, 
            ITransportService transportService, 
            IDriverService driverService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.transportService = transportService;
            this.driverService = driverService;
            currentUser = AuthenticationService.Instance.CurrentUser;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            NoItemsMessage = "У вас не зарегистрирован не один транспорт. Обратитесь к пункту гибдд с уникальным идентификатором водителя и документами о владении транспортом для регистрации транспорта";
        }

        protected override async Task<IEnumerable<Transport>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            var driver = await driverService.GetByUserId(currentUser.Id, cancellationToken);

            if (driver == null)
                return new List<Transport>();

            return await transportService.GetAllByDriverId(driver.Id, cancellationToken);
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
            var card = new TransportCard(item, TransportCardRoleContext.OwnerList);

            card.ListFineClicked += () => ListFine(item);

            return card;
        }

        private void ListFine(Transport item)
        {
            var createView = navigationService.Value.ServiceProvider.GetRequiredService<FineTransportListView>();
            createView.Initialize(item, ownTransport: true);

            var navigationItem = new NavigationItem()
            {
                Title = $"Штрафы транспорта с номером {item.TransportCode}",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.Value.NavigateTo(navigationItem);
        }
    }
}
