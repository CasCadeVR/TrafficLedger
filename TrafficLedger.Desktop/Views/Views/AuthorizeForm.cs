using System;
using System.Threading;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Desktop.Infrastructure.Models;

namespace TrafficLedger.Desktop.Views
{
    /// <summary>
    /// Форма авторизации пользователя
    /// </summary>
    public partial class AuthorizeForm : BaseForm
    {
        private readonly IUserService userService;
        private bool isRegistration;

        private readonly string loginTitle = "Авторизация";
        private readonly string regisrtationTitle = "Регистрация";
        private readonly string buttonLoginTitle = "Войти";
        private readonly string buttonRegisrtationTitle = "Зарегистрироваться";
        private readonly string buttonRegisterText = "Нет аккаунта? Зарегестируйтесь";
        private readonly string buttonBackText = "Назад";

        private readonly string loginSuccessText = "Вы успешно вошли!";
        private readonly string registrationSuccessText = "Вы успешно зарегестрировались!";

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="AuthorizeForm"/>
        /// </summary>
        public AuthorizeForm(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;

            isRegistration = false;
            textBoxLogin.Text = "admin";
            textBoxPassword.Text = "admin";
            //buttonLogin_Click(null, null);
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            isRegistration = !isRegistration;

            labelTitle.Text = isRegistration ? regisrtationTitle : loginTitle;
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
                    MessageBox.Show(exception.Message);
                    return;
                }

                MessageBox.Show(registrationSuccessText);
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
                    MessageBox.Show(exception.Message);
                    return;
                }

                MessageBox.Show(loginSuccessText);
                DialogResult = DialogResult.OK;
            }
        }
    }
}