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
    public partial class PaymentFineCreateView : PaymentCreateWrapper
    {
        private readonly IPaymentService paymentService;
        private Payment currentPayment;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        private Fine currentFine;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="FineCreateView"/>
        /// </summary>
        public PaymentFineCreateView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;
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
                    EntityType = EntityTypes.FineType,
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
                    EntityType = EntityTypes.FineType,
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
            textBoxFinePrice.Text = currentFine.Price.ToString();
            textBoxDescription.Text = currentFine.Violation.Description;

            statusLabel.Visible = currentPayment != null;
            textBoxStatus.Visible = currentPayment != null;

            if (currentPayment != null)
            {
                textBoxStatus.Text = Enum.GetName(currentPayment.Status);
            }

            multiImageUploader.Clear();

            if (currentFine.Attachments != null && currentFine.Attachments.Count != 0)
            {
                multiImageUploader.SetImagesFromAttachments(currentFine.Attachments.Select(x =>
                        new AttachmentCreateModel()
                        {
                            EntityId = x.Id,
                            EntityType = x.EntityType,
                            Content = x.Content,
                            ContentType = x.ContentType,
                            FileName = x.FileName
                        }).ToList(), asReadonlyImages: true);
            }

            multiImageUploader.HideAddButton();

            if (CurrentModel.Status == RequestStatus.Rejected)
            {
                MessageBox.Show(CurrentModel.Commentary, "Ваш запрос был отклонён. Причина: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Штраф успешно оплачен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
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