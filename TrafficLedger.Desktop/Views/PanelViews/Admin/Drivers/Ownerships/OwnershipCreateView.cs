using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Desktop.Services;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers
{
    /// <summary>
    /// Форма создания редактирования для <see cref="OwnershipCodeRequest"/>
    /// </summary>
    public partial class OwnershipCreateView : BaseCreateView<OwnershipCodeRequest>
    {
        private readonly IDriverService driverService;
        private readonly ITransportService transportService;
        private OwnershipCodeRequest currentOwnershipCodeRequest;
        private Driver currentDriver;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="ViolationCreateView"/>
        /// </summary>
        public OwnershipCreateView(IDriverService driverService, ITransportService transportService)
        {
            InitializeComponent();
            this.driverService = driverService;
            this.transportService = transportService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Driver entity, OwnershipCodeRequest ownershipCodeRequest)
        {
            currentDriver = entity;
            currentOwnershipCodeRequest = ownershipCodeRequest;
        }

        protected override Task LoadModelAsync()
        {
            if (currentOwnershipCodeRequest != null)
            {
                EntityId = Guid.Empty;
                CurrentModel = new OwnershipCodeRequest
                {
                    Date = currentOwnershipCodeRequest.Date,
                    TransportCode = currentOwnershipCodeRequest.TransportCode,
                };
            } 
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new OwnershipCodeRequest
                {
                    Date = DateTime.Now,
                    TransportCode = string.Empty,
                };
            }

            return Task.CompletedTask;
        }

        protected override void SetupBindings()
        {
            textBoxTransportCode.AddBindings(x => x.Text, CurrentModel, x => x.TransportCode, errorProvider);

            dateTimePickerDate.AddBindingWithConversion(
                x => x.Value,
                CurrentModel,
                x => x.Date,
                dto => dto.DateTime,
                dt => new DateTimeOffset(dt, TimeSpan.Zero),
                errorProvider);
        }

        protected override void FillControls()
        {
            if (currentDriver == null)
            {
                return;
            }

            textBoxTransportCode.Text = CurrentModel.TransportCode;
            dateTimePickerDate.Value = CurrentModel.Date.DateTime;
        }

        protected override async Task OnSaveAsync()
        {
            var transport = await transportService.GetByTransportCode(CurrentModel.TransportCode, CancellationToken.None);

            var ownerships = currentDriver.Ownerships.ToList();

            ownerships.Add(new Ownership()
            {
                Date = CurrentModel.Date,
                TransportId = transport.Id,
                DriverId = currentDriver.Id,
            });

            var newRequest = new DriverRequest()
            {
                FullName = currentDriver.FullName,
                BirthDate = currentDriver.BirthDate,
                BirthPlace = currentDriver.BirthPlace,
                UserId = currentDriver.UserId,
                Ownerships = ownerships.Select(x => 
                    new OwnershipTransportRequest()
                        {
                            TransportId = x.TransportId,
                            Date = x.Date,
                        }).ToList()
            };

            var response = await driverService.Update(currentDriver.Id, newRequest, CancellationToken.None);
            EntityId = response.Id;
            currentDriver = response;
            MessageBox.Show($"Теперь {currentDriver.FullName} владеет транспортом с кодом {CurrentModel.TransportCode} с датой {CurrentModel.Date}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxTransportCode, dateTimePickerDate);
        }
    }
}