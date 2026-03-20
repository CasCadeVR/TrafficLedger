using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="Fine"/>
    /// </summary>
    public partial class FineCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка редактирования
        /// </summary>
        public event Action EditClicked = null!;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked = null!;

        /// <summary>
        /// Нажата кнопка оплаты
        /// </summary>
        public event Action PayClicked = null!;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="FineCard"/>
        /// </summary>
        public FineCard(Fine request, bool ownTransport, bool withTransportCode = false)
        {
            InitializeComponent();
            FillFields(request);
            buttonEdit.Visible = !ownTransport && AuthenticationService.Instance.HasAccessTo(Role.TrafficPolice);
            buttonDelete.Visible = !ownTransport && AuthenticationService.Instance.HasAccessTo(Role.TrafficPolice);
            buttonPay.Visible = ownTransport;

            status.Visible = !ownTransport && AuthenticationService.Instance.HasAccessTo(Role.TrafficPolice);
            labelStatusTitle.Visible = !ownTransport && AuthenticationService.Instance.HasAccessTo(Role.TrafficPolice);

            transportCode.Visible = withTransportCode;
            transportCodeTitle.Visible = withTransportCode;
        }

        private void FillFields(Fine request)
        {
            status.Text = request.Status == SessionStatus.Active
                ? "В процессе"
                : "Окончен";

            date.Text = request.Date.DateTime.ToLongDateString();
            address.Text = request.Address;
            fineDescription.Text = request.Description;
            violationName.Text = request.Violation.Name;
            description.Text = request.Violation.Description;
            code.Text = request.Violation.ViolationCode;
            finePrice.Text = request.Violation.MinFinePrice.ToString();
            transportCode.Text = request.Transport.TransportCode;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            EditClicked?.Invoke();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletedClicked?.Invoke();
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            PayClicked?.Invoke();
        }
    }
}