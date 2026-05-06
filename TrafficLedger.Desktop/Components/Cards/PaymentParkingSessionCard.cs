using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Repositories.Contracts.Models.Payments;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="PaymentParkingSessionDBModel"/>
    /// </summary>
    public partial class PaymentParkingSessionCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка одобрения
        /// </summary>
        public event Action ApproveClicked = null!;

        /// <summary>
        /// Нажата кнопка отклонения
        /// </summary>
        public event Action RejectClicked = null!;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked = null!;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="PaymentFineCard"/>
        /// </summary>
        public PaymentParkingSessionCard(PaymentParkingSessionDBModel request, bool asOwnPayment)
        {
            InitializeComponent();
            FillFields(request);

            buttonApprove.Visible = !asOwnPayment && request.Status == RequestStatus.Pending
                && AuthenticationService.Instance.HasAccessTo(Role.Admin);

            buttonReject.Visible = !asOwnPayment && request.Status == RequestStatus.Pending
                && AuthenticationService.Instance.HasAccessTo(Role.Admin);

            buttonDelete.Visible = !asOwnPayment && AuthenticationService.Instance.HasAccessTo(Role.Admin);
        }

        private void FillFields(PaymentParkingSessionDBModel request)
        {
            status.Text = request.Status.GetDescription();
            paymentDate.Text = request.Date.DateTime.ToLongDateString();
            startDate.Text = request.ParkingSession.StartTime.DateTime.ToLongDateString()
                + ", " + request.ParkingSession.StartTime.DateTime.ToShortTimeString();

            if (request.ParkingSession.EndTime.HasValue)
            {
                endDate.Text = request.ParkingSession.EndTime.Value.DateTime.ToLongDateString()
                    + ", " + request.ParkingSession.EndTime.Value.DateTime.ToShortTimeString();
            }
            else
            {
                labelEndDate.Visible = false;
                endDate.Visible = false;
            }
            
            finePrice.Text = request.CapturedPrice.ToString();
            transportCode.Text = request.ParkingSession.Transport.TransportCode;
            address.Text = request.ParkingSession.ParkingZone.Address;
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            ApproveClicked?.Invoke();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeletedClicked?.Invoke();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            RejectClicked?.Invoke();
        }
    }
}