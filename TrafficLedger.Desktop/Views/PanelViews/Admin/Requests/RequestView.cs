using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Payments;
using TrafficLedger.Desktop.Views.PanelViews.FineCreate;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Requests
{
    public partial class RequestView : BasePanelView
    {
        private readonly INavigationService navigationService;

        public RequestView(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            InitializeComponent();
        }

        private void buttonDriverLicenses_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список заявок удостоверений водителей",
                ViewType = typeof(DriverLicenseListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonTransports_Click(object sender, EventArgs e)
        {
            var listView = navigationService.ServiceProvider.GetRequiredService<TransportListView>();
            listView.Initialize(requestsOnly: true);

            var navigationItem = new NavigationItem()
            {
                Title = "Список заявок владений автомобилей",
                ViewInstance = listView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonPaymentsFines_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список заявок чеков оплат штрафов",
                ViewType = typeof(PaymentFineListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonPaymentsParkingSessions_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список заявок чеков оплат парковок",
                ViewType = typeof(PaymentParkingSessionListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
