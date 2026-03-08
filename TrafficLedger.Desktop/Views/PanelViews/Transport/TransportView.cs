using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Services;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    public partial class TransportUserView : BasePanelView
    {
        private readonly Lazy<INavigationService> navigationService;
        private readonly IDriverService driverService;
        private readonly AppUser currentUser;

        public TransportUserView(Lazy<INavigationService> navigationService, IDriverService driverService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.driverService = driverService;

            this.currentUser = AuthenticationService.Instance.CurrentUser;
        }

        private void buttonListTransport_Click(object sender, EventArgs e)
        {
            var listView = new NavigationItem()
            {
                Title = buttonListTransport.Text,
                ViewType = typeof(TransportUserListView),
                Parent = CurrentNavigationItem
            };

            navigationService.Value.NavigateTo(listView);
        }

        private async void buttonAddTransport_Click(object sender, EventArgs e)
        {
            try {
                var driver = await driverService.GetByUserId(currentUser.Id, CancellationToken.None);

                var createView = navigationService.Value.ServiceProvider.GetRequiredService<TransportCreateView>();
                createView.Initialize(null!, isUserAdding: currentUser.Role != Entities.Role.Admin, currentDriver: driver!);

                var navigationItem = new NavigationItem()
                {
                    Title = buttonAddTransport.Text,
                    ViewType = null,
                    ViewInstance = createView,
                    Parent = CurrentNavigationItem,
                };

                navigationService.Value.NavigateTo(navigationItem);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}