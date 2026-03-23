using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions;
using TrafficLedger.Desktop.Views.PanelViews.Payments;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class ParkingSessionUserListView : ParkingSessionUserListWrapper
    {
        private readonly INavigationService navigationService;
        private readonly ITransportService transportService;
        private readonly IParkingSessionService parkingSessionService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        public ParkingSessionUserListView(
            INavigationService navigationService,
            ITransportService transportService,
            IParkingSessionService parkingSessionService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.transportService = transportService;
            this.parkingSessionService = parkingSessionService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        protected override async Task<IEnumerable<ParkingSession>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await parkingSessionService.GetAllByUserId(currentUser.Id, cancellationToken);
        }

        protected override IEnumerable<ParkingSession> FilterItems(string searchQuery, IEnumerable<ParkingSession> items)
        {
            items = checkBoxShowCompleted.Checked
                 ? items
                 : items.Where(f => f.Status != SessionStatus.Completed);

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.CapturedTotalCost?.ToString().ToLowerInvariant().Contains(lowerQuery) == true ||
                t.ParkingZone.Address?.ToString().ToLowerInvariant().Contains(lowerQuery) == true ||
                t.Transport.TransportCode?.ToLowerInvariant().Contains(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(ParkingSession item)
        {
            var card = new ParkingSessionCard(item, false);

            card.PayClicked += () => Pay(item);
            card.AboutClicked += () => About(item);

            return card;
        }

        private void About(ParkingSession item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<ParkingSessionCreateView>();
            createView.Initialize(item.ParkingZone, item);

            var navigationItem = new NavigationItem()
            {
                Title = "Просмотр сенса парковки",
                ViewType = null!,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Pay(ParkingSession item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<PaymentParkingSessionCreateView>();
            createView.Initialize(item, null!);

            var navigationItem = new NavigationItem()
            {
                Title = "Оплата парковки",
                ViewType = null!,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void checkBoxShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}
