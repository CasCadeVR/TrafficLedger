using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    /// <summary>
    /// Форма создания редактирования для <see cref="PaymentCreateModel"/>
    /// </summary>
    public partial class PaymentFineCreateView : PaymentCreateWrapper
    {
        private readonly IPaymentService paymentService;
        private Payment currentPayment;
        private AppUser currentUser;
        private Fine currentFine;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="FineCreateView"/>
        /// </summary>
        public PaymentFineCreateView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            currentUser = AuthenticationService.Instance.CurrentUser;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Fine currentFine, Payment currentPayment)
        {
            this.currentFine = currentFine;
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
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new PaymentCreateModel
                {
                    Date = DateTimeOffset.UtcNow,
                    Status = RequestStatus.Pending,
                    EntityId = currentFine.Id,
                    UserId = currentUser.Id,
                };
            }
        }

        protected override void SetupBindings() { }

        protected override void FillControls()
        {
            textBoxTransportCode.Text = currentFine.Transport.TransportCode;
            textBoxDate.Text = currentFine.Date.DateTime.ToLongDateString();
            textBoxName.Text = currentFine.Violation.Name;
            textBoxAddress.Text = currentFine.Address;
            textBoxFineDescription.Text = currentFine.Description;
            textBoxCode.Text = currentFine.Violation.ViolationCode;
            textBoxFinePrice.Text = currentFine.Violation.MinFinePrice.ToString();
            textBoxDescription.Text = currentFine.Violation.Description;
            textBoxStatus.Text = Enum.GetName(CurrentModel.Status);
        }

        protected override async Task OnSaveAsync()
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
                MessageBox.Show("Штраф успешно оплачен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            NavigateToParent();
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync();
        }
    }
}