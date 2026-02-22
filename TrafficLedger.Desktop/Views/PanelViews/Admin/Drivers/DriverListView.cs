using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers.Ownerships;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers
{
    public partial class DriverListView : DriverListWrapper
    {
        private readonly INavigationService navigationService;
        private readonly IDriverService driverService;
        private readonly IDriverLicenseService driverLicenseService;

        public DriverListView(INavigationService navigationService,
            IDriverLicenseService driverLicenseService,
            IDriverService driverService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.driverLicenseService = driverLicenseService;
            this.driverService = driverService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        protected override async Task<IEnumerable<Driver>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await driverService.GetAll(cancellationToken);
        }

        protected override IEnumerable<Driver> FilterItems(string searchQuery, IEnumerable<Driver> items)
        {
            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return items;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return items.Where(t =>
                t.FullName?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.UniqueId.ToString().Equals(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(Driver driver)
        {
            var card = new DriverCard(driver);

            card.EditClicked += () => EditDriver(driver);
            card.DeleteClicked += () => DeleteDriver(driver);
            card.ConnectTransportClicked += () => ConnectDriver(driver);
            card.ConnectDriverLicenseClicked += () => ConnectDriverLicense(driver);

            return card;
        }

        private void EditDriver(Driver driver)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<DriverCreateView>();
            createView.Initialize(driver);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование водителя",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void DeleteDriver(Driver driver)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить водителя {driver.FullName}?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                driverService.Delete(driver.Id, CancellationToken.None);
                MessageBox.Show($"Водитель {driver.FullName} успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void ConnectDriver(Driver driver)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<OwnershipView>();
            createView.Initialize(driver);

            var navigationItem = new NavigationItem()
            {
                Title = "Редактирование владениями",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private async void ConnectDriverLicense(Driver driver)
        {
            var driverLicense = await driverLicenseService.GetByDriverId(driver.Id, CancellationToken.None);
            var createView = navigationService.ServiceProvider.GetRequiredService<DriverLicenseCreateView>();
            createView.Initialize(driver, driverLicense, isOwnDriver: false);

            var createTitle = driverLicense == null ? "Создание" : "Редактирование";

            var navigationItem = new NavigationItem()
            {
                Title = $"{createTitle} лизенции",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
