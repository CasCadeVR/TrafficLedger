using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Users
{
    /// <summary>
    /// Форма создания редактирования для <see cref="UserRequest"/>
    /// </summary>
    public partial class UserCreateView : BaseCreateView<UserRequest>
    {
        private readonly IUserService userService;
        private User currentUser;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="BaseCreateView"/>
        /// </summary>
        public UserCreateView(IUserService userService)
        {
            InitializeComponent();
            this.userService = userService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(User user)
        {
            currentUser = user;
        }

        protected override async Task LoadModelAsync()
        {
            var dbUser = await userService.GetById(currentUser.Id, CancellationToken.None);

            EntityId = dbUser.Id;
            CurrentModel = new UserRequest
            {
                Login = dbUser.Login,
                Role = dbUser.Role,
            };
        }

        protected override void SetupBindings()
        {
            textBoxLogin.AddBindings(x => x.Text, CurrentModel, x => x.Login, errorProvider);
            comboBoxRole.AddBindings(x => x.SelectedItem, CurrentModel, x => x.Role, errorProvider);
        }

        protected override void FillControls()
        {
            comboBoxRole.DataSource = Enum.GetValues(typeof(Role));

            comboBoxRole.SelectedItem = CurrentModel.Role;
            textBoxLogin.Text = CurrentModel.Login;
        }

        protected override async Task OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                await userService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные пользователя обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync();
        }
    }
}
