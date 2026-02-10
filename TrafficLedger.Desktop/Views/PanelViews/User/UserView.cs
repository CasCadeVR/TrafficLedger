using System;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.PanelViews.Fines;
using TrafficLedger.Desktop.Views.PanelViews.Payments;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class UserView : BasePanelView
    {
        private readonly INavigationService navigationService;
        private readonly IDriverService driverService;
        private readonly AppUser currentUser;

        public UserView(INavigationService navigationService, IDriverService driverService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.driverService = driverService;

            currentUser = AuthenticationService.Instance.CurrentUser;
        }

        //private void LoadUserData()
        //{
        //    lblLoginValue.Text = _currentUser.Login;
        //    lblFullNameValue.Text = _currentUser.FullName;

        //    string roleText = string.Empty;

        //    switch (_currentUser.Role)
        //    {
        //        case Role.Admin:
        //            roleText = "Администратор";
        //            break;

        //        case Role.TrafficPolice:
        //            roleText = "Сотрудник ДПС";
        //            break;

        //        default:
        //            roleText = "Пользователь";
        //            break;
        //    }

        //    lblRoleValue.Text = roleText;

        //    // Пример: админ видит доп. информацию
        //    panelAdminInfo.Visible = (_currentUser.Role == UserRole.Admin);
        //}

        private async void buttonDriver_Click(object sender, EventArgs e)
        {
            var driver = await driverService.GetByUserId(currentUser.Id, CancellationToken.None);

            var createView = navigationService.ServiceProvider.GetRequiredService<DriverCreateView>();
            createView.Initialize(driver);

            var navigationItem = new NavigationItem()
            {
                Title = buttonDriver.Text,
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonDriverLicense_Click(object sender, EventArgs e)
        {
            var driverLicenseCreate = new NavigationItem()
            {
                Title = buttonDriverLicense.Text,
                ViewType = typeof(DriverLicenseView),
                Parent = CurrentNavigationItem
            };

            navigationService.NavigateTo(driverLicenseCreate);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
               "Вы действительно хотите выйти из системы?",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (result == DialogResult.Yes)
            {
                AuthenticationService.Instance.Logout();

                var loginForm = navigationService.ServiceProvider.GetRequiredService<AuthorizeForm>();

                loginForm.ShowDialog();
                this.Hide();
            }
        }

        private void buttonListUserPayments_Click(object sender, EventArgs e)
        {
            var listView = navigationService.ServiceProvider.GetRequiredService<PaymentFineUserListView>();
            listView.Initialize(currentUser.Id, ownPayment: true);

            var navigationItem = new NavigationItem()
            {
                Title = $"Оплаченные штрафы пользователя {currentUser.Login}",
                ViewType = null,
                ViewInstance = listView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}
