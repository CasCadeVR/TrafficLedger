using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions
{
    /// <summary>
    /// Форма создания редактирования для <see cref="ParkingSessionCreateModel"/>
    /// </summary>
    public partial class ParkingSessionCreateView : ParkingSessionCreateWrapper
    {
        private readonly IParkingSessionService parkingSessionService;
        private readonly ITransportService transportService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        private Driver currentDriver;
        private ParkingZone currentParkingZone;
        private ParkingSession currentParkingSession;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="ViolationCreateView"/>
        /// </summary>
        public ParkingSessionCreateView(IParkingSessionService parkingSessionService, ITransportService transportService)
        {
            InitializeComponent();
            this.parkingSessionService = parkingSessionService;
            this.transportService = transportService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Driver currentDriver, ParkingZone zone, ParkingSession entity)
        {
            this.currentDriver = currentDriver;
            currentParkingSession = entity;
            currentParkingZone = zone;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentParkingZone == null)
            {
                throw new InvalidOperationException("Не удалось подгрузить парковучную зону. Попробуйте позже");
            }

            if (currentParkingSession != null)
            {
                var session = await parkingSessionService.GetById(currentParkingSession.Id, CancellationToken.None);

                EntityId = session.Id;
                CurrentModel = new ParkingSessionCreateModel
                {
                    StartTime = session.StartTime,
                    EndTime = session.EndTime,
                    Status = session.Status,
                    UserId = session.UserId,
                    TransportId = session.TransportId,
                    ParkingZoneId = session.ParkingZoneId,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new ParkingSessionCreateModel
                {
                    StartTime = DateTimeOffset.Now,
                    EndTime = null,
                    Status = SessionStatus.Active,
                    UserId = currentUser.Id,
                    TransportId = Guid.Empty,
                    ParkingZoneId = currentParkingZone.Id,
                };
            }
        }

        protected override void SetupBindings() { }

        protected override async void FillControls()
        {
            var transports = await transportService.GetAllByDriverId(currentDriver.Id, CancellationToken.None);
            var driverTransport = transports.ToList();

            comboBoxTransport.DataSource = driverTransport;
            comboBoxTransport.DisplayMember = nameof(Transport.TransportCode);
            comboBoxTransport.ValueMember = nameof(Transport.Id);

            comboBoxTransport.DataBindings.Clear();
            comboBoxTransport.DataBindings.Add(
               nameof(comboBoxTransport.SelectedValue),
               CurrentModel,
               nameof(CurrentModel.TransportId),
               false,
               DataSourceUpdateMode.OnPropertyChanged);

            textBoxAddress.Text = currentParkingZone.Address;
            numericUpDownHourlyRate.Text = currentParkingZone.HourlyRate.ToString();
            Uri.TryCreate(currentParkingZone.CoordinatesLink, UriKind.Absolute, out var uri);
            webView.Source = uri;

            buttonSave.Enabled = comboBoxTransport.SelectedIndex != -1;


            if (currentParkingSession == null)
            {
                return;
            }
        }

        protected override async Task<bool> OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                await parkingSessionService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные парковочной сессии обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var request = await parkingSessionService.Create(CurrentModel, CancellationToken.None);
                EntityId = request.Id;
                MessageBox.Show("Парковочная сессия начата.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync();
        }

        private void comboBoxTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonSave.Enabled = comboBoxTransport.SelectedIndex != -1;
        }
    }
}