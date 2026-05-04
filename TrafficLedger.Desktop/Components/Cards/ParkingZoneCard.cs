using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="ParkingZone"/>
    /// </summary>
    public partial class ParkingZoneCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка редактирования
        /// </summary>
        public event Action EditClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked;

        /// <summary>
        /// Нажата кнопка выбора
        /// </summary>
        public event Action ChooseClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ParkingZoneCard"/>
        /// </summary>
        public ParkingZoneCard(ParkingZone request, bool asAdmin)
        {
            InitializeComponent();
            FillFields(request);
            buttonChoose.Visible = !asAdmin;
        }

        private void FillFields(ParkingZone request)
        {
            buttonDelete.Visible = AuthenticationService.Instance.HasAccessTo(Role.Admin);
            buttonEdit.Visible = AuthenticationService.Instance.HasAccessTo(Role.Admin);

            address.Text = request.Address;
            hourlyRate.Text = request.HourlyRate.ToString();
            active.Text = request.IsActive ? "Да" : "Нет";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletedClicked?.Invoke();
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            ChooseClicked?.Invoke();
        }
    }
}
