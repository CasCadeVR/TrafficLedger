using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    /// <summary>
    /// Форма создания редактирования для <see cref="DriverRequest"/>
    /// </summary>
    public partial class DriverCreateView : BaseCreateView<DriverRequest>
    {
        private readonly IDriverService driverService;
        private readonly AppUser currentUser;
        private Driver currentDriver;
        private int uniqueId;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="BaseCreateView"/>
        /// </summary>
        public DriverCreateView(IDriverService driverService)
        {
            InitializeComponent();
            this.driverService = driverService;
            this.currentUser = AuthenticationService.Instance.CurrentUser;
        }

        public void Initialize(Driver driver)
        {
            this.currentDriver = driver;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentDriver != null)
            {
                var existingDriver = await driverService.GetById(currentDriver.Id, CancellationToken.None);

                EntityId = existingDriver.Id;
                uniqueId = existingDriver.UniqueId;
                CurrentModel = new DriverRequest
                {
                    FullName = existingDriver.FullName,
                    BirthDate = existingDriver.BirthDate,
                    BirthPlace = existingDriver.BirthPlace,
                    UserId = currentUser.Id,
                    Ownerships = new List<OwnershipTransportRequest>()
                };
            }
            else
            {
                EntityId = Guid.Empty;
                uniqueId = 0;
                CurrentModel = new DriverRequest
                {
                    FullName = string.Empty,
                    BirthDate = DateTimeOffset.UtcNow,
                    BirthPlace = string.Empty,
                    UserId = currentUser.Id,
                    Ownerships = new List<OwnershipTransportRequest>()
                };
            }
        }

        protected override void SetupBindings()
        {
            textBoxFullName.AddBindings(x => x.Text, CurrentModel, x => x.FullName, errorProvider);
            textBoxBirthPlace.AddBindings(x => x.Text, CurrentModel, x => x.BirthPlace, errorProvider);

            dateTimePickerBirthDate.AddBindingWithConversion(
                x => x.Value,
                CurrentModel,
                x => x.BirthDate,
                dto => dto.DateTime,
                dt => new DateTimeOffset(dt, TimeSpan.Zero),
                errorProvider);
        }

        protected override void FillControls()
        {
            labelUniqueId.Visible = uniqueId != 0;
            textBoxUniqueId.Visible = uniqueId != 0;
            textBoxFullName.Focus();

            textBoxFullName.Text = CurrentModel.FullName;
            textBoxBirthPlace.Text = CurrentModel.BirthPlace;
            dateTimePickerBirthDate.Value = CurrentModel.BirthDate.DateTime;
            textBoxUniqueId.Text = uniqueId.ToString();
        }

        protected override async Task OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                await driverService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные водителя обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentDriver = await driverService.Create(CurrentModel, CancellationToken.None);
                EntityId = currentDriver.Id;
                uniqueId = currentDriver.UniqueId;
                textBoxUniqueId.Text = uniqueId.ToString();
                MessageBox.Show("Водитель успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxFullName, textBoxBirthPlace, dateTimePickerBirthDate);
        }
    }
}