using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="DriverCard"/>
    /// </summary>
    public partial class DriverCard : BaseCard
    {
        private readonly Driver request;

        /// <summary>
        /// Нажата кнопка редактирования
        /// </summary>
        public event Action EditClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeleteClicked;

        /// <summary>
        /// Нажата кнопка привязки транспорта
        /// </summary>
        public event Action ConnectTransportClicked;

        /// <summary>
        /// Нажата кнопка привязки водительского удостоверения
        /// </summary>
        public event Action ConnectDriverLicenseClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="TransportCard"/>
        /// </summary>
        public DriverCard(Driver request)
        {
            InitializeComponent();
            this.request = request;
            FillFields();
            buttonConnectTransport.Visible = AuthenticationService.Instance.HasAccessTo(Role.Admin);
        }

        private void FillFields()
        {
            fullName.Text = request.FullName;
            birthDate.Text = request.BirthDate.Date.ToLongDateString();
            birthPlace.Text = request.BirthPlace;
            uniqueId.Text = request.UniqueId.ToString();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DeleteClicked?.Invoke();
        }

        private void buttonConnectTransport_Click(object sender, EventArgs e)
        {
            ConnectTransportClicked?.Invoke();
        }

        private void buttonConnectDriverLicense_Click(object sender, EventArgs e)
        {
            ConnectDriverLicenseClicked?.Invoke();
        }
    }
}