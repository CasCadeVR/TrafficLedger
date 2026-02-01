using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    /// <summary>
    /// Форма создания редактирования для <see cref="PaymentRequest"/>
    /// </summary>
    public partial class PaymentCreateView : BaseCreateView<PaymentRequest>
    {
        private readonly IPaymentService paymentService;
        private Payment currentPayment;
        private Guid currentUserId;
        private Fine currentFine;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="FineCreateView"/>
        /// </summary>
        public PaymentCreateView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Fine currentFine, Guid currentUserId, Payment currentPayment)
        {
            this.currentFine = currentFine;
            this.currentUserId = currentUserId;
            this.currentPayment = currentPayment;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentPayment != null)
            {
                var fine = await paymentService.GetById(currentPayment.Id, CancellationToken.None);

                EntityId = fine.Id;
                CurrentModel = new PaymentRequest
                {
                    Date = fine.Date,
                    Status = fine.Status,
                    FineId = fine.FineId,
                    UserId = fine.UserId,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new PaymentRequest
                {
                    Date = DateTimeOffset.UtcNow,
                    Status = Status.InProgress,
                    FineId = currentFine.Id,
                    UserId = currentUserId,
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
            textBoxFinePrice.Text = currentFine.Violation.FinePrice.ToString();
            textBoxDescription.Text = currentFine.Violation.Description;
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