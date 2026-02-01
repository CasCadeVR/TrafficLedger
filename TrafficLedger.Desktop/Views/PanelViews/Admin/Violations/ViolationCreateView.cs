using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Violations
{
    /// <summary>
    /// Форма создания редактирования для <see cref="ViolationRequest"/>
    /// </summary>
    public partial class ViolationCreateView : BaseCreateView<ViolationRequest>
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
                CurrentModel = new ViolationRequest
                {
                    ViolationCode = violation.ViolationCode,
                    Name = violation.Name,
                    Description = violation.Description,
                    FinePrice = violation.FinePrice,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new ViolationRequest
                {
                    ViolationCode = string.Empty,
                    Name = string.Empty,
                    Description = string.Empty,
                    FinePrice = 0,
                };
            }
        }

        protected override void SetupBindings()
        {
            textBoxCode.AddBindings(x => x.Text, CurrentModel, x => x.ViolationCode, errorProvider);
            textBoxName.AddBindings(x => x.Text, CurrentModel, x => x.Name, errorProvider);
            textBoxDescription.AddBindings(x => x.Text, CurrentModel, x => x.Description, errorProvider);
            numericUpDownFinePrice.AddBindings(x => x.Value, CurrentModel, x => x.FinePrice, errorProvider);
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
            numericUpDownFinePrice.Value = CurrentModel.FinePrice;
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
    }
}