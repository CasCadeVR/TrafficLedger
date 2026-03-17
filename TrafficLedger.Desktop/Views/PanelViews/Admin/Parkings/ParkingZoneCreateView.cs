using Microsoft.Web.WebView2.Core;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Parkings
{
    /// <summary>
    /// Форма создания редактирования для <see cref="ViolationCreateModel"/>
    /// </summary>
    public partial class ParkingZoneCreateView : ParkingZoneCreateWrapper
    {
        private readonly IParkingZoneService parkingZoneService;
        private ParkingZone currentParkingZone;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="ParkingZoneCreateView"/>
        /// </summary>
        public ParkingZoneCreateView(IParkingZoneService violationService)
        {
            InitializeComponent();
            this.parkingZoneService = violationService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(ParkingZone entity)
        {
            currentParkingZone = entity;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentParkingZone != null)
            {
                var zone = await parkingZoneService.GetById(currentParkingZone.Id, CancellationToken.None);

                EntityId = zone.Id;
                CurrentModel = new ParkingZoneCreateModel
                {
                    Address = zone.Address,
                    CoordinatesLink = zone.CoordinatesLink,
                    HourlyRate = zone.HourlyRate,
                    IsActive = zone.IsActive,
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new ParkingZoneCreateModel
                {
                    Address = string.Empty,
                    CoordinatesLink = string.Empty,
                    HourlyRate = 10,
                    IsActive = true,
                };
            }
        }

        protected override void SetupBindings()
        {
            textBoxAddress.AddBindings(x => x.Text, CurrentModel, x => x.Address!, errorProvider);
            textBoxLink.AddBindings(x => x.Text, CurrentModel, x => x.CoordinatesLink!, errorProvider);
            checkBoxActive.AddBindings(x => x.Checked, CurrentModel, x => x.IsActive, errorProvider);
            numericUpDownPrice.AddBindings(x => x.Value, CurrentModel, x => x.HourlyRate, errorProvider);

            webView.NavigationStarting -= EnsureHttps!;
            webView.NavigationStarting += EnsureHttps!;
        }

        void EnsureHttps(object sender, CoreWebView2NavigationStartingEventArgs args)
        {
            var uri = args.Uri;
            if (!uri.StartsWith("https://"))
            {
                webView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} не безопасно. Попробуйте другую ссылку')");
                args.Cancel = true;
            }
        }

        protected override void FillControls()
        {
            if (currentParkingZone == null)
            {
                return;
            }

            textBoxAddress.Text = CurrentModel.Address;
            numericUpDownPrice.Value = CurrentModel.HourlyRate;
            checkBoxActive.Checked = CurrentModel.IsActive;
            textBoxLink.Text = CurrentModel.CoordinatesLink;

            Uri.TryCreate(CurrentModel.CoordinatesLink, UriKind.Absolute, out var uri);
            webView.Source = uri;
        }

        protected override async Task OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                await parkingZoneService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные парковочного места обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var request = await parkingZoneService.Create(CurrentModel, CancellationToken.None);
                EntityId = request.Id;
                MessageBox.Show("Парковочное место успешно создано.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxAddress, numericUpDownPrice);
        }

        private void linkCheckButton_Click(object sender, EventArgs e)
        {
            if (webView != null && webView.CoreWebView2 != null)
            {
                try
                {
                    webView.CoreWebView2.Navigate(textBoxLink.Text);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show($"Не удалось найти указанный ресурс: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}