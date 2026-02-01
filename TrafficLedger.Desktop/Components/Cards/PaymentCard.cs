using System;
using System.Net;
using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="Payment"/>
    /// </summary>
    public partial class PaymentCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка одобрения
        /// </summary>
        public event Action ApproveClicked;

        /// <summary>
        /// Нажата кнопка отклонения
        /// </summary>
        public event Action RejectClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action DeletedClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="FineCard"/>
        /// </summary>
        public PaymentCard(Payment request, bool asOwnPayment)
        {
            InitializeComponent();
            FillFields(request);

            buttonApprove.Visible = !asOwnPayment && request.Status == Status.InProgress
                && AuthenticationService.Instance.HasAccessTo(Role.Admin);

            buttonReject.Visible = !asOwnPayment && request.Status == Status.InProgress
                && AuthenticationService.Instance.HasAccessTo(Role.Admin);

            buttonDelete.Visible = !asOwnPayment && AuthenticationService.Instance.HasAccessTo(Role.Admin);
        }

        private void FillFields(Payment request)
        {
            status.Text = request.Status == Status.InProgress
                ? "В процессе"
                : "Оплачен";

            paymentDate.Text = request.Date.DateTime.ToLongDateString();
            fineDate.Text = request.Fine.Date.DateTime.ToLongDateString();
            violationName.Text = request.Fine.Violation.Name;
            code.Text = request.Fine.Violation.ViolationCode;
            finePrice.Text = request.Fine.Violation.FinePrice.ToString();
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