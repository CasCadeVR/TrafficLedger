using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Parkings;
using TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings
{
    public partial class ParkingZoneListView : ParkingZoneListWrapper
    {
        private readonly INavigationService navigationService;
        private readonly IParkingZoneService parkingZoneService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        private bool asAdmin;

        public ParkingZoneListView(INavigationService navigationService, IParkingZoneService parkingZoneService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.parkingZoneService = parkingZoneService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(bool asAdmin)
        {
            this.asAdmin = asAdmin;
        }

        protected override async Task<IEnumerable<ParkingZone>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            var allEntities = await parkingZoneService.GetAll(cancellationToken);
            return allEntities.Where(x => x.IsActive);
        }

        protected override IEnumerable<ParkingZone> FilterItems(string searchQuery, IEnumerable<ParkingZone> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.Address?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.HourlyRate.ToString().ToLowerInvariant().Contains(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(ParkingZone item)
        {
            var card = new ParkingZoneCard(item, asAdmin);

            card.ChooseClicked += () => Choose(item);
            card.EditClicked += () => Edit(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private void Choose(ParkingZone item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<ParkingSessionCreateView>();
            createView.Initialize(item, null!);

            var navigationItem = new NavigationItem()
            {
                Title = "Начало сессии парковки",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Edit(ParkingZone item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<ParkingZoneCreateView>();
            createView.Initialize(item);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование парковочной зоны",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Delete(ParkingZone item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить зону с адресом {item.Address}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                parkingZoneService.Delete(item.Id, CancellationToken.None);
                MessageBox.Show($"Зона {item.Address} успешно удалёна", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }
    }
}
