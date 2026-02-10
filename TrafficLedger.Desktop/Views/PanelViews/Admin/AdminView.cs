using System;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Admin;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Fines;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Payments;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Transports;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Violations;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class AdminView : BasePanelView
    {
        private readonly INavigationService navigationService;

        public AdminView(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список пользователей",
                ViewType = typeof(UserListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonDrivers_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список водителей",
                ViewType = typeof(DriverListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonTransports_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = buttonTransports.Text,
                ViewType = typeof(TransportView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonViolations_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = buttonViolations.Text,
                ViewType = typeof(ViolationView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonFines_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = buttonFines.Text,
                ViewType = typeof(FineListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonPayments_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = buttonPayments.Text,
                ViewType = typeof(PaymentFineListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
