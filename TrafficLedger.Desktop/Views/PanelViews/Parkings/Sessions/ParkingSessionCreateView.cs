using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions
{
    /// <summary>
    /// Форма создания редактирования для <see cref="ViolationCreateModel"/>
    /// </summary>
    public partial class ParkingSessionCreateView : ParkingSessionCreateWrapper
    {
        private readonly IParkingSessionService parkingSessionService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        private ParkingZone currentParkingZone;
        private ParkingSession currentParkingSession;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="ViolationCreateView"/>
        /// </summary>
        public ParkingSessionCreateView(IParkingSessionService parkingSessionService)
        {
            InitializeComponent();
            this.parkingSessionService = parkingSessionService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(ParkingZone zone, ParkingSession entity)
        {
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
                    TransportCode = session.Transport.TransportCode,
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
                    TransportCode = string.Empty,
                    ParkingZoneId = currentParkingZone.Id,
                };
            }
        }

        protected override void SetupBindings()
        {
            textBoxTransportCode.AddBindings(x => x.Text, CurrentModel, x => x.TransportCode, errorProvider);
        }

        protected override void FillControls()
        {
            textBoxAddress.Text = currentParkingZone.Address;
            numericUpDownHourlyRate.Text = currentParkingZone.HourlyRate.ToString();
            Uri.TryCreate(currentParkingZone.CoordinatesLink, UriKind.Absolute, out var uri);
            webView.Source = uri;

            if (currentParkingSession == null)
            {
                return;
            }

            textBoxTransportCode.Text = CurrentModel.TransportCode;
        }

        protected override async Task OnSaveAsync()
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
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxTransportCode);
        }
    }
}