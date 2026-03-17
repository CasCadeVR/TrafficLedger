using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Violations
{
    /// <summary>
    /// Форма создания редактирования для <see cref="ViolationCreateModel"/>
    /// </summary>
    public partial class ViolationCreateView : ViolationCreateWrapper
    {
        private readonly IViolationService violationService;
        private Violation currentViolation;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="ViolationCreateView"/>
        /// </summary>
        public ViolationCreateView(IViolationService violationService)
        {
            InitializeComponent();
            this.violationService = violationService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Violation entity)
        {
            currentViolation = entity;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentViolation != null)
            {
                var violation = await violationService.GetById(currentViolation.Id, CancellationToken.None);

                EntityId = violation.Id;
                CurrentModel = new ViolationCreateModel
                {
                    ViolationCode = violation.ViolationCode,
                    Name = violation.Name,
                    Description = violation.Description,
                    MinFinePrice = violation.MinFinePrice,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new ViolationCreateModel
                {
                    ViolationCode = string.Empty,
                    Name = string.Empty,
                    Description = string.Empty,
                    MinFinePrice = 0,
                };
            }
        }

        protected override void SetupBindings()
        {
            textBoxCode.AddBindings(x => x.Text, CurrentModel, x => x.ViolationCode, errorProvider);
            textBoxName.AddBindings(x => x.Text, CurrentModel, x => x.Name, errorProvider);
            textBoxDescription.AddBindings(x => x.Text, CurrentModel, x => x.Description, errorProvider);
            numericUpDownFinePrice.AddBindings(x => x.Value, CurrentModel, x => x.MinFinePrice, errorProvider);
        }

        protected override void FillControls()
        {
            if (currentViolation == null)
            {
                return;
            }

            textBoxCode.Text = CurrentModel.ViolationCode;
            textBoxName.Text = CurrentModel.Name;
            textBoxDescription.Text = CurrentModel.Description;
            numericUpDownFinePrice.Value = CurrentModel.MinFinePrice;
        }

        protected override async Task OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                await violationService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные нарушения обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var request = await violationService.Create(CurrentModel, CancellationToken.None);
                EntityId = request.Id;
                MessageBox.Show("Нарушение успешно создано.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxCode, textBoxName, textBoxDescription);
        }

        private void radioEndPrice_CheckedChanged(object sender, EventArgs e)
        {
            labelFinePrice.Enabled = radioEndPrice.Checked;
            labelMaxFinePrice.Enabled = !radioEndPrice.Checked;
            labelMaxFinePrice.Enabled = !radioEndPrice.Checked;

            numericUpDownFinePrice.Enabled = radioEndPrice.Checked;
            numericUpDownMinFinePrice.Enabled = !radioEndPrice.Checked;
            numericUpDownMaxFinePrice.Enabled = !radioEndPrice.Checked;
        }
    }
}