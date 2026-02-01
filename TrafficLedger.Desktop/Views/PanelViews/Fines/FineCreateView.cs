using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Fines
{
    /// <summary>
    /// Форма создания редактирования для <see cref="FineRequest"/>
    /// </summary>
    public partial class FineCreateView : BaseCreateView<FineRequest>
    {
        private readonly IFineService fineService;
        private readonly IViolationService violationService;
        private Transport currentTransport;
        private Fine currentFine;
        private List<Violation> currentViolations;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="FineCreateView"/>
        /// </summary>
        public FineCreateView(IFineService fineService, IViolationService violationService)
        {
            InitializeComponent();
            this.fineService = fineService;

            comboBoxViolation.SelectedIndexChanged += OnViolationSelected;
            this.violationService = violationService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Transport currentTransport, Fine currentFine)
        {
            this.currentTransport = currentTransport;
            this.currentFine = currentFine;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentFine != null)
            {
                var fine = await fineService.GetById(currentFine.Id, CancellationToken.None);

                EntityId = fine.Id;
                CurrentModel = new FineRequest
                {
                    Date = fine.Date,
                    Address = fine.Address,
                    Description = fine.Description,
                    Status = fine.Status,
                    ViolationId = fine.ViolationId,
                    TransportId = fine.TransportId,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new FineRequest
                {
                    Address = string.Empty,
                    Description = string.Empty,
                    Date = DateTimeOffset.UtcNow,
                    Status = Status.InProgress,
                    ViolationId = Guid.Empty,
                    TransportId = currentTransport.Id,
                };
            }
        }

        protected override void SetupBindings()
        {
            comboBoxViolation.DataBindings.Clear();

            textBoxAddress.AddBindings(x => x.Text, CurrentModel, x => x.Address, errorProvider);
            textBoxFineDescription.AddBindings(x => x.Text, CurrentModel, x => x.Description, errorProvider);

            dateTimePickerDate.AddBindingWithConversion(
                x => x.Value,
                CurrentModel,
                x => x.Date,
                dto => dto.DateTime,
                dt => new DateTimeOffset(dt, TimeSpan.Zero),
                errorProvider);

            comboBoxViolation.DataBindings.Add(
               nameof(comboBoxViolation.SelectedValue),
               CurrentModel,
               nameof(CurrentModel.ViolationId),
               false,
               DataSourceUpdateMode.OnPropertyChanged);
        }

        private void OnViolationSelected(object sender, EventArgs e)
        {
            var selectedViolation = comboBoxViolation.SelectedItem as Violation;
            textBoxCode.Text = selectedViolation?.ViolationCode ?? ". . .";
            textBoxFinePrice.Text = selectedViolation?.FinePrice.ToString() ?? ". . .";
            textBoxDescription.Text = selectedViolation?.Description ?? ". . .";
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

            comboBoxViolation.DataSource = currentViolations;
            comboBoxViolation.DisplayMember = nameof(Violation.Name);
            comboBoxViolation.ValueMember = nameof(Violation.Id);

            if (currentFine == null)
            {
                return;
            }

            comboBoxViolation.SelectedValue = currentFine.ViolationId;
            textBoxCode.Text = CurrentModel.Address;
            textBoxFineDescription.Text = CurrentModel.Description;
            dateTimePickerDate.Value = CurrentModel.Date.DateTime;
        }

        protected override async Task OnSaveAsync()
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
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(dateTimePickerDate, textBoxAddress);
        }
    }
}