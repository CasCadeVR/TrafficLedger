using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Services.Contracts.Models.Fines;

namespace TrafficLedger.Desktop.Views.PanelViews.Fines
{
    /// <summary>
    /// Форма создания редактирования для <see cref="FineCreateModel"/>
    /// </summary>
    public partial class FineCreateView : FineCreateWrapper
    {
        private readonly IFineService fineService;
        private readonly IViolationService violationService;
        private Transport currentTransport;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;

        private Fine currentFine;
        private List<Violation> currentViolations;
        private bool isInitializingAttachments;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="FineCreateView"/>
        /// </summary>
        public FineCreateView(IFineService fineService, IViolationService violationService)
        {
            InitializeComponent();

            this.fineService = fineService;
            this.violationService = violationService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Transport currentTransport, Fine currentFine)
        {
            this.currentTransport = currentTransport;
            this.currentFine = currentFine;

            comboBoxViolation.SelectedValueChanged += OnViolationSelected;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentFine != null)
            {
                var fine = await fineService.GetById(currentFine.Id, CancellationToken.None);

                EntityId = fine.Id;
                CurrentModel = new FineCreateModel
                {
                    Date = fine.Date,
                    Address = fine.Address,
                    Description = fine.Description,
                    Status = fine.Status,
                    Price = fine.Price,
                    ViolationId = fine.ViolationId,
                    TransportId = fine.TransportId,
                    UserId = fine.UserId,
                    Attachments = fine.Attachments.Select(x =>
                        new AttachmentCreateModel()
                        {
                            EntityId = x.Id,
                            EntityType = x.EntityType,
                            Content = x.Content,
                            ContentType = x.ContentType,
                            FileName = x.FileName
                        }).ToList(),
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new FineCreateModel
                {
                    Address = string.Empty,
                    Description = string.Empty,
                    Date = DateTimeOffset.Now,
                    Price = 10,
                    Status = SessionStatus.Active,
                    ViolationId = Guid.Empty,
                    UserId = currentUser.Id,
                    TransportId = currentTransport.Id,
                    Attachments = [],
                };
            }
        }

        protected override async void SetupBindings()
        {
            textBoxAddress.AddBindings(x => x.Text, CurrentModel, x => x.Address, errorProvider);
            textBoxFineDescription.AddBindings(x => x.Text, CurrentModel, x => x.Description, errorProvider);
            
            dateTimePickerDate.AddBindingWithConversion(
                x => x.Value,
                CurrentModel,
                x => x.Date,
                dto => dto.DateTime,
                dt => new DateTimeOffset(dt, TimeSpan.Zero),
                errorProvider);

            multiImageUploader.ResetImageBindings();
            multiImageUploader.ImagesChanged += (sender, attachments) =>
            {
                if (isInitializingAttachments)
                {
                    return;
                }

                CurrentModel.Attachments = attachments;
            };
        }

        private void OnViolationSelected(object sender, EventArgs e)
        {
            numericUpDownPrice.DataBindings.Clear();

            var selectedViolation = comboBoxViolation.SelectedItem as Violation;
            textBoxCode.Text = selectedViolation?.ViolationCode ?? ". . .";
            textBoxDescription.Text = selectedViolation?.Description ?? ". . .";

            numericUpDownPrice.Minimum = selectedViolation?.MinFinePrice ?? 10;
            numericUpDownPrice.Maximum = selectedViolation?.MaxFinePrice ?? selectedViolation?.MinFinePrice ?? 10;
            numericUpDownPrice.Value = numericUpDownPrice.Minimum;

            if (currentFine == null)
            {
                CurrentModel.Price = numericUpDownPrice.Minimum;
            }

            numericUpDownPrice.AddBindings(x => x.Value, CurrentModel, x => x.Price, errorProvider);

            numericUpDownPrice.Value = CurrentModel.Price;
        }

        protected override async void FillControls()
        {
            var violations = await violationService.GetAll(CancellationToken.None);
            currentViolations = violations.ToList();

            buttonSave.Enabled = currentViolations.Count != 0;

            if (currentViolations.Count == 0)
            {
                return;
            }

            comboBoxViolation.DataSource = violations;
            comboBoxViolation.DisplayMember = nameof(Violation.Name);
            comboBoxViolation.ValueMember = nameof(Violation.Id);

            comboBoxViolation.DataBindings.Clear();
            comboBoxViolation.DataBindings.Add(
               nameof(comboBoxViolation.SelectedValue),
               CurrentModel,
               nameof(CurrentModel.ViolationId),
               false,
               DataSourceUpdateMode.OnPropertyChanged);

            if (currentFine == null)
            {
                comboBoxViolation.SelectedIndex = 0;
                return;
            }

            textBoxCode.Text = CurrentModel.Address;
            textBoxFineDescription.Text = CurrentModel.Description;
            dateTimePickerDate.Value = CurrentModel.Date.DateTime;
            
            isInitializingAttachments = true;

            multiImageUploader.Clear();

            if (CurrentModel.Attachments != null && CurrentModel.Attachments.Count != 0)
            {
                multiImageUploader.SetImagesFromAttachments(CurrentModel.Attachments);
            }

            isInitializingAttachments = false;
        }

        protected override async Task<bool> OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                var response = await fineService.Update(EntityId, CurrentModel, CancellationToken.None);
                currentFine = response;
                MessageBox.Show("Данные штрафа обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var request = await fineService.Create(CurrentModel, CancellationToken.None);
                EntityId = request.Id;
                MessageBox.Show("Штраф успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(dateTimePickerDate, textBoxAddress);
        }
    }
}