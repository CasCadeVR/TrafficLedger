using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Payments;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Requests
{
    public partial class PaymentView : BasePanelView
    {
        private readonly INavigationService navigationService;

        public PaymentView(INavigationService navigationService)
        {
            this.navigationService = navigationService;
            InitializeComponent();
        }

        private void buttonPaymentsFines_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список чеков оплат штрафов",
                ViewType = typeof(PaymentFineListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonPaymentsParkingSessions_Click(object sender, EventArgs e)
        {
            var navigationItem = new NavigationItem()
            {
                Title = "Список чеков оплат парковок",
                ViewType = typeof(PaymentParkingSessionListView),
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
