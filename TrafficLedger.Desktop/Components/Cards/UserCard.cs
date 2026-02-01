using System;
using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="User"/>
    /// </summary>
    public partial class UserCard : BaseCard
    {
        private readonly User request;

        /// <summary>
        /// Нажата кнопка редактирования
        /// </summary>
        public event Action EditClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeleteClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="TransportCard"/>
        /// </summary>
        public UserCard(User request)
        {
            InitializeComponent();
            this.request = request;
            FillFields();
            buttonDeleteUser.Enabled = AuthenticationService.Instance.CurrentUser.Login != request.Login;
            buttonEdit.Enabled = AuthenticationService.Instance.CurrentUser.Login != request.Login;
        }

        private void FillFields()
        {
            login.Text = request.Login;
            role.Text = request.Role.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke();
        }
    }
}
