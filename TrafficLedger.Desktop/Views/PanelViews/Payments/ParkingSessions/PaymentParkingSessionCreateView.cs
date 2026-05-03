using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Entities.Typing;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    /// <summary>
    /// Форма создания редактирования для <see cref="PaymentCreateModel"/>
    /// </summary>
    public partial class PaymentParkingSessionCreateView : PaymentCreateWrapper
    {
        private readonly IPaymentService paymentService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        private Payment currentPayment;
        private ParkingSession currentParkingSession;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="FineCreateView"/>
        /// </summary>
        public PaymentParkingSessionCreateView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(ParkingSession currentParkingSession, Payment currentPayment)
        {
            this.currentParkingSession = currentParkingSession;
            this.currentPayment = currentPayment;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentPayment != null)
            {
                var payment = await paymentService.GetById(currentPayment.Id, CancellationToken.None);

                EntityId = payment.Id;
                CurrentModel = new PaymentCreateModel
                {
                    Date = payment.Date,
                    Status = payment.Status,
                    EntityId = payment.EntityId,
                    UserId = payment.UserId,
                    Commentary = payment.Commentary,
                    EntityType = payment.EntityType,
                    ProcessedAt = payment.ProcessedAt,
                    ProcessedById = payment.ProcessedById,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new PaymentCreateModel
                {
                    Date = DateTimeOffset.Now,
                    Status = RequestStatus.Pending,
                    EntityType = EntityTypes.ParkingSessionType,
                    EntityId = currentParkingSession.Id,
                    UserId = currentUser.Id,
                };
            }
        }

        protected override void SetupBindings() { }

        protected override void FillControls()
        {
            textBoxTransportCode.Text = currentParkingSession.Transport.TransportCode;
            textBoxAddress.Text = currentParkingSession.ParkingZone.Address;
            textBoxDate.Text = currentParkingSession.StartTime.DateTime.ToLongDateString();

            var passedHours = (int)(CurrentModel.Date - currentParkingSession.StartTime).TotalHours + 1;
            var price = passedHours * currentParkingSession.ParkingZone.HourlyRate;

            textBoxSessionPrice.Text = price.ToString();

            Uri.TryCreate(currentParkingSession.ParkingZone.CoordinatesLink, UriKind.Absolute, out var uri);
            webView.Source = uri;

            statusLabel.Visible = currentPayment != null;
            textBoxStatus.Visible = currentPayment != null;

            if (currentPayment != null)
            {
                textBoxStatus.Text = currentPayment.Status.GetDescription();
            }
        }

        protected override async Task<bool> OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                var response = await paymentService.Update(EntityId, CurrentModel, CancellationToken.None);
                currentPayment = response;
                MessageBox.Show("Данные чека обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // TODO: Здесь будет происходить логика оплаты, но пока просто заглушка с созданием чека
                var request = await paymentService.Create(CurrentModel, CancellationToken.None);
                EntityId = request.Id;
                MessageBox.Show("Парковка успешно оплачена.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            NavigateToParent();
            return true;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync();
        }
    }
}