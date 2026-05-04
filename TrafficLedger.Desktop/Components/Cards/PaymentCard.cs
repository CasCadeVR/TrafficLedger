using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Repositories.Contracts.Models.Payments;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="PaymentFineDBModel"/>
    /// </summary>
    public partial class PaymentFineCard : BaseCard
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
        public PaymentFineCard(PaymentFineDBModel request, bool asOwnPayment)
        {
            InitializeComponent();
            FillFields(request);

            buttonApprove.Visible = !asOwnPayment && request.Status == RequestStatus.Pending
                && AuthenticationService.Instance.HasAccessTo(Role.Admin);

            buttonReject.Visible = !asOwnPayment && request.Status == RequestStatus.Pending
                && AuthenticationService.Instance.HasAccessTo(Role.Admin);

            buttonDelete.Visible = !asOwnPayment && AuthenticationService.Instance.HasAccessTo(Role.Admin);
        }

        private void FillFields(PaymentFineDBModel request)
        {
            status.Text = request.Status.GetDescription();
            paymentDate.Text = request.Date.DateTime.ToLongDateString();
            fineDate.Text = request.Fine.Date.DateTime.ToLongDateString();
            violationName.Text = request.Fine.Violation.Name;
            code.Text = request.Fine.Violation.ViolationCode;
            finePrice.Text = request.CapturedPrice.ToString();
            transportCode.Text = request.Fine.Transport.TransportCode;
            address.Text = request.Fine.Address;
            description.Text = request.Fine.Description;
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