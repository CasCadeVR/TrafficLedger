using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class AuthorizeView : BasePanelView
    {
        private readonly Lazy<INavigationService> navigationService;
        private readonly IUserService userService;
        private bool isRegistration;
        private int debugRoleState = 2; // Represents role

        private readonly string loginTitle = "Авторизация";
        private readonly string regisrtationTitle = "Регистрация";
        private readonly string buttonLoginTitle = "Войти";
        private readonly string buttonRegisrtationTitle = "Зарегистрироваться";
        private readonly string buttonRegisterText = "Нет аккаунта? Зарегестируйтесь";
        private readonly string buttonBackText = "Назад";

        private readonly string loginSuccessText = "Вы успешно вошли!";
        private readonly string registrationSuccessText = "Вы успешно зарегестрировались!";

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="AuthorizeView"/>
        /// </summary>
        public AuthorizeView(Lazy<INavigationService> navigationService, IUserService userService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.userService = userService;

            isRegistration = false;
            roleDebugButton_Click(this, null!);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            isRegistration = !isRegistration;

            title.Text = isRegistration ? regisrtationTitle : loginTitle;
            buttonLogin.Text = isRegistration ? buttonRegisrtationTitle : buttonLoginTitle;
            buttonRegister.Text = isRegistration ? buttonBackText : buttonRegisterText;
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            if (isRegistration)
            {
                var userCreateModel = new UserCreateModel()
                {
                    Login = textBoxLogin.Text.Trim(),
                    Password = textBoxPassword.Text.Trim(),
                    Role = Role.Default,
                };

                try
                {
                    await userService.Create(userCreateModel, CancellationToken.None);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(registrationSuccessText, "Успех", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }
            else
            {
                var loginModel = new LoginModel()
                {
                    Login = textBoxLogin.Text.Trim(),
                    Password = textBoxPassword.Text.Trim(),
                };

                try
                {
                    var user = await userService.GetByLoginAndPassword(loginModel, CancellationToken.None);

                    AuthenticationService.Instance.Login(new AppUser()
                    {
                        Id = user.Id,
                        Login = user.Login,
                        Role = user.Role,
                    });
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show(loginSuccessText, "Успех", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                navigationService.Value.NavigateTo(NavigationRegistry.GetMenuItems()[1]);
            }
        }

        private void roleDebugButton_Click(object sender, EventArgs e)
        {
            switch(debugRoleState)
            {
                case 0:
                    textBoxLogin.Text = "user";
                    textBoxPassword.Text = "user";
                    break;

                case 1:
                    textBoxLogin.Text = "police";
                    textBoxPassword.Text = "police";
                    break;

                case 2:
                    textBoxLogin.Text = "admin";
                    textBoxPassword.Text = "admin";
                    break;
            }


            debugRoleState++;
            if (debugRoleState >= 3)
            {
                debugRoleState = 0;
            }
        }
    }
}
