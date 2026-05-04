using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Services.Contracts.Models.Ownerships;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    /// <summary>
    /// Форма создания редактирования для <see cref="UserCreateModel"/>
    /// </summary>
    public partial class TransportCreateView : TransportCreateWrapper
    {
        private readonly ITransportCategoryService transportCategoryService;
        private readonly IDriverService driverService;
        private readonly ITransportService transportService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;
        private Transport currentTransport;
        private Driver currentDriver;
        private bool isUserAdding;
        private bool isInitializingAttachments;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="BaseCreateView"/>
        /// </summary>
        public TransportCreateView(ITransportService transportService,
            IDriverService driverService,
            ITransportCategoryService transportCategoryService)
        {
            InitializeComponent();
            this.transportService = transportService;
            this.driverService = driverService;
            this.transportCategoryService = transportCategoryService;

            comboBoxCategory.SelectedIndexChanged += OnCategorySelected;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Transport entity, bool isUserAdding = false, Driver currentDriver = null!)
        {
            currentTransport = entity;
            this.currentDriver = currentDriver;
            this.isUserAdding = isUserAdding;

            if (isUserAdding && currentDriver == null)
            {
                throw new InvalidOperationException("Вам нужно сперва заполнить данные водителя");
            }
        }

        protected override async Task LoadModelAsync()
        {
            if (currentTransport != null)
            {
                var transport = await transportService.GetById(currentTransport.Id, CancellationToken.None);

                EntityId = transport.Id;
                CurrentModel = new TransportCreateModel
                {
                    TransportCode = transport.TransportCode,
                    Region = transport.Region,
                    Brand = transport.Brand,
                    Year = transport.Year,
                    Model = transport.Model,
                    MileAge = transport.MileAge,
                    TransportCategoryId = transport.TransportCategoryId,
                    Status = transport.Status,
                    UserId = transport.UserId,
                    Commentary = transport.Commentary,
                    ProcessedAt = transport.ProcessedAt,
                    ProcessedById = transport.ProcessedById,

                    Attachments = transport.Attachments.Select(x =>
                        new AttachmentCreateModel()
                        {
                            EntityId = x.Id,
                            EntityType = x.EntityType,
                            Content = x.Content,
                            ContentType = x.ContentType,
                            FileName = x.FileName
                        }).ToList(),

                    Ownerships = transport.Ownerships.Select(x =>
                        new OwnershipDriverCreateModel()
                        {
                            Date = x.Date,
                            DriverId = x.DriverId,
                        }).ToList(),
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new TransportCreateModel
                {
                    TransportCode = string.Empty,
                    Region = string.Empty,
                    Brand = string.Empty,
                    Year = string.Empty,
                    Model = string.Empty,
                    MileAge = 0,
                    UserId = currentUser.Id,
                    TransportCategoryId = Guid.Empty,
                    Attachments = new List<AttachmentCreateModel>(),
                    Ownerships = new List<OwnershipDriverCreateModel>()
                };
            }
        }

        protected override void SetupBindings()
        {
            textBoxCode.AddBindings(x => x.Text, CurrentModel, x => x.TransportCode, errorProvider);
            textBoxRegion.AddBindings(x => x.Text, CurrentModel, x => x.Region, errorProvider);
            textBoxYear.AddBindings(x => x.Text, CurrentModel, x => x.Year, errorProvider);
            textBoxBrand.AddBindings(x => x.Text, CurrentModel, x => x.Brand, errorProvider);
            textBoxModel.AddBindings(x => x.Text, CurrentModel, x => x.Model, errorProvider);
            numericUpDownMileAge.AddBindings(x => x.Value, CurrentModel, x => x.MileAge, errorProvider);

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

        private void OnCategorySelected(object sender, EventArgs e)
        {
            var selectedCategory = comboBoxCategory.SelectedItem as TransportCategory;
            textBoxCategoryDescription.Text = selectedCategory?.Description ?? string.Empty;
        }

        protected override async void FillControls()
        {
            var categories = await transportCategoryService.GetAll(CancellationToken.None);
            var currentCategories = categories.ToList();

            comboBoxCategory.DataSource = currentCategories;
            comboBoxCategory.DisplayMember = nameof(TransportCategory.CategoryName);
            comboBoxCategory.ValueMember = nameof(TransportCategory.Id);

            comboBoxCategory.DataBindings.Clear();
            comboBoxCategory.DataBindings.Add(
               nameof(comboBoxCategory.SelectedValue),
               CurrentModel,
               nameof(CurrentModel.TransportCategoryId),
               false,
               DataSourceUpdateMode.OnPropertyChanged);

            textBoxCode.Text = CurrentModel.TransportCode;
            textBoxRegion.Text = CurrentModel.Region;
            textBoxYear.Text = CurrentModel.Year;
            textBoxBrand.Text = CurrentModel.Brand;
            textBoxModel.Text = CurrentModel.Model;
            numericUpDownMileAge.Value = CurrentModel.MileAge;

            labelStatus.Visible = currentTransport != null;
            textBoxStatus.Visible = currentTransport != null;
            textBoxStatus.Text = CurrentModel.Status.GetDescription();

            var isUserOwned = false;
            if (currentTransport != null)
            {
                var creatorDriver = await driverService.GetByUserId(currentTransport.UserId, CancellationToken.None);
                isUserOwned = currentTransport.Ownerships.Any(x => x.DriverId == creatorDriver?.Id);
            }

            ownershipCheckBox.Checked = isUserOwned;
            labelOwnershipDate.Enabled = ownershipCheckBox.Checked;
            ownershipDateTimePicker.Enabled = ownershipCheckBox.Checked;

            if (isUserAdding)
            {
                comboBoxCategory.SelectedIndex = 0;
            }

            isInitializingAttachments = true;

            multiImageUploader.Clear();

            if (CurrentModel.Attachments != null && CurrentModel.Attachments.Count != 0)
            {
                multiImageUploader.SetImagesFromAttachments(CurrentModel.Attachments);
            }

            isInitializingAttachments = false;

            if (CurrentModel.Status == RequestStatus.Rejected)
            {
                MessageBox.Show(CurrentModel.Commentary + ", Но вы ещё можете поменять данные и переслать запрос, тогда он попадёт в конец очереди",
                    "Ваш запрос был отклонён. Причина: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected override async Task<bool> OnSaveAsync()
        {
            if (MessageBox.Show("Вы уверены что хотите отправить запрос? Ещё раз проверьте все данные. Запрос будет расмотрен в ближайшие сроки",
                "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return false;
            }

            if (EntityId != Guid.Empty)
            {
                await transportService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные транспорта обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var transport = await transportService.Create(CurrentModel, CancellationToken.None);
                EntityId = transport.Id;
                MessageBox.Show("Транспорт успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return true;
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxCode, textBoxRegion, textBoxYear, textBoxBrand, textBoxModel, ownershipDateTimePicker, numericUpDownMileAge);
        }

        private async void ownershipCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            labelOwnershipDate.Enabled = ownershipCheckBox.Checked;
            ownershipDateTimePicker.Enabled = ownershipCheckBox.Checked;

            var creatorDriver = await driverService.GetByUserId(CurrentModel.UserId, CancellationToken.None); 
            if (creatorDriver == null)
            {
                return;
            }

            if (ownershipCheckBox.Checked && !CurrentModel.Ownerships.Any(x => x.DriverId == creatorDriver.Id))
            {
                var model = new OwnershipDriverCreateModel()
                {
                    Date = DateTimeOffset.Now,
                    DriverId = creatorDriver.Id
                };

                CurrentModel.Ownerships.Add(model);

                ownershipDateTimePicker.DataBindings.Clear();
                ownershipDateTimePicker.AddBindingWithConversion(
                    x => x.Value,
                    model,
                    x => model.Date,
                    dto => dto.DateTime,
                    dt => new DateTimeOffset(dt, TimeSpan.Zero),
                    errorProvider);
            }
            else
            {
                var foundOwnership = CurrentModel.Ownerships.FirstOrDefault(x => x.DriverId == creatorDriver.Id);
                if (foundOwnership != null)
                {
                    CurrentModel.Ownerships.Remove(foundOwnership);
                }
            }
        }
    }
}