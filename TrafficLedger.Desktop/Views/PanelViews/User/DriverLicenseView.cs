using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class DriverLicenseView : BasePanelView
    {
        private readonly AppUser currentUser;

        public DriverLicenseView(INavigationService navigationService)
        {
            InitializeComponent();
            currentUser = AuthenticationService.Instance.CurrentUser;
        }

        public override void OnNavigation(NavigationItem item)
        {
            base.OnNavigation(item);
        }
    }
}
