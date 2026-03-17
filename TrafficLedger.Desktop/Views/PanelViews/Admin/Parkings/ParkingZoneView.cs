using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Parkings;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Parkings
{
    public partial class ParkingZoneView : BasePanelView
    {
        private readonly INavigationService navigationService;

        public ParkingZoneView(INavigationService navigationService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            var instance = navigationService.ServiceProvider.GetRequiredService<ParkingZoneListView>();
            instance.Initialize(asAdmin: true);

            var listView = new NavigationItem()
            {
                Title = buttonList.Text,
                ViewType = null!,
                ViewInstance = instance,
                Parent = CurrentNavigationItem
            };

            navigationService.NavigateTo(listView);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<ParkingZoneCreateView>();
            createView.Initialize(null!);

            var navigationItem = new NavigationItem()
            {
                Title = buttonAdd.Text,
                ViewType = null!,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}