using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="ParkingZone"/>
    /// </summary>
    public partial class ParkingSessionCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка оплаты
        /// </summary>
        public event Action PayClicked;

        /// <summary>
        /// Нажата кнопка подробнее
        /// </summary>
        public event Action AboutClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ParkingSessionCard"/>
        /// </summary>
        public ParkingSessionCard(ParkingSession request, bool asAdmin)
        {
            InitializeComponent();
            FillFields(request);

            buttonDelete.Visible = asAdmin;
            buttonPay.Visible = !asAdmin;
        }

        private void FillFields(ParkingSession request)
        {
            startDate.Text = request.StartTime.DateTime.ToLongDateString() + ", " + request.StartTime.DateTime.ToShortTimeString();
            transportCode.Text = request.Transport.TransportCode;
            address.Text = request.ParkingZone.Address;
            status.Text = Enum.GetName(request.Status);

            var isEnded = request.EndTime != null && request.EndTime.HasValue;

            endDate.Visible = isEnded;
            labelEndDate.Visible = isEnded;

            if (isEnded)
            {
                endDate.Text = request.EndTime!.Value.DateTime.ToLongDateString() + ", " + request.EndTime.Value.DateTime.ToShortTimeString();
            }

            var isCapturedPrice = request.CapturedTotalCost != null && request.CapturedTotalCost.HasValue && request.CapturedTotalCost > 0;

            capturedPrice.Visible = isCapturedPrice;
            labelCapturedPrice.Visible = isCapturedPrice;

            if (isCapturedPrice)
            {
                capturedPrice.Text = request.CapturedTotalCost!.Value.ToString();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletedClicked?.Invoke();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutClicked?.Invoke();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            PayClicked?.Invoke();
        }
    }
}
