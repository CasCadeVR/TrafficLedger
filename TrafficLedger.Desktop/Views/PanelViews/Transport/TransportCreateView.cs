using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
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
        private readonly ITransportService transportService;
        private readonly AppUser currentUser;
        private Transport currentTransport;
        private Driver currentDriver;
        private List<TransportCategory> currentCategories;
        private bool isUserAdding;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="BaseCreateView"/>
        /// </summary>
        public TransportCreateView(ITransportService transportService, ITransportCategoryService transportCategoryService)
        {
            InitializeComponent();
            this.transportService = transportService;
            this.transportCategoryService = transportCategoryService;
            currentUser = AuthenticationService.Instance.CurrentUser;

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

                if (isUserAdding)
                {
                    CurrentModel.Ownerships.Add(new OwnershipDriverCreateModel()
                    {
                        Date = DateTimeOffset.Now,
                        DriverId = currentDriver.Id
                    });
                }
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

            if (isUserAdding)
            {
                var selfOwnership = CurrentModel.Ownerships.First();

                ownershipDateTimePicker.AddBindingWithConversion(
                    x => x.Value,
                    selfOwnership,
                    x => selfOwnership.Date,
                    dto => dto.DateTime,
                    dt => new DateTimeOffset(dt, TimeSpan.Zero),
                    errorProvider);
            }

            multiImageUploader.ResetImageBindings();
            multiImageUploader.ImagesChanged += (sender, attachments) => CurrentModel.Attachments = attachments;
        }

        private void OnCategorySelected(object sender, EventArgs e)
        {
            var selectedCategory = comboBoxCategory.SelectedItem as TransportCategory;
            textBoxCategoryDescription.Text = selectedCategory?.Description ?? string.Empty;
        }

        protected override async void FillControls()
        {
            var categories = await transportCategoryService.GetAll(CancellationToken.None);

            currentCategories = categories.ToList();

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
            textBoxStatus.Text = CurrentModel.Status.ToString();

            if (!isUserAdding)
            {
                labelOwnershipDate.Visible = false;
                ownershipDateTimePicker.Visible = false;
            }
            else
            {
                ownershipDateTimePicker.Value = CurrentModel.Ownerships.First()!.Date.DateTime;
            }

            if (CurrentModel.Attachments != null && CurrentModel.Attachments.Count != 0)
            {
                multiImageUploader.SetImagesFromBytes(CurrentModel.Attachments.Select(x => x.Content ?? []));
            }
            else
            {
                multiImageUploader.Clear();
            }

            if (CurrentModel.Status == RequestStatus.Rejected)
            {
                MessageBox.Show(CurrentModel.Commentary + ", Но вы ещё можете поменять данные и переслать запрос, тогда он попадёт в конец очереди",
                    "Ваш запрос был отклонён. Причина: ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        protected override async Task OnSaveAsync()
        {
            if (MessageBox.Show("Вы уверены что хотите отправить запрос? Ещё раз проверьте все данные. Запрос будет расмотрен в ближайшие сроки",
                "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
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
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxCode, textBoxRegion, textBoxYear, textBoxBrand, textBoxModel);
        }
    }
}