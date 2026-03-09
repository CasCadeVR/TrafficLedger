using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    /// <summary>
    /// Форма создания редактирования для <see cref="DriverLicenseCreateModel"/>
    /// </summary>
    public partial class DriverLicenseCreateView : DriverLicenseCreateWrapper
    {
        private readonly IDriverLicenseService driverLicenseService;
        private readonly ITransportCategoryService transportCategoryService;
        private readonly AppUser currentUser;
        private bool isInitializingCategories = false;
        private Driver currentDriver;
        private DriverLicense? currentDriverLicense;
        private bool isOwnDriver;


        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="BaseCreateView"/>
        /// </summary>
        public DriverLicenseCreateView(IDriverLicenseService driverLicenseService, ITransportCategoryService transportCategoryService)
        {
            InitializeComponent();
            this.driverLicenseService = driverLicenseService;
            this.transportCategoryService = transportCategoryService;
            currentUser = AuthenticationService.Instance.CurrentUser;
        }

        public void Initialize(Driver currentDriver, DriverLicense? currentDriverLicense, bool isOwnDriver)
        {
            this.currentDriver = currentDriver;
            this.currentDriverLicense = currentDriverLicense;
            this.isOwnDriver = isOwnDriver;
        }

        protected override async Task LoadModelAsync()
        {
            if (currentDriverLicense != null)
            {
                var license = await driverLicenseService.GetById(currentDriverLicense.Id, CancellationToken.None);

                EntityId = license.Id;
                CurrentModel = new DriverLicenseCreateModel
                {
                    LicenseNumber = license.LicenseNumber,
                    DateOfIssue = license.DateOfIssue,
                    IssuedBy = license.IssuedBy,
                    Residence = license.Residence,
                    DriverId = license.DriverId,
                    Status = license.Status,
                    UserId = license.UserId,
                    Commentary = license.Commentary,
                    ProcessedAt = license.ProcessedAt,
                    ProcessedById = license.ProcessedById,
                    Attachment = license.Attachment == null ? null : new AttachmentCreateModel()
                    {
                        EntityId = license.Attachment!.EntityId,
                        EntityType = license.Attachment.EntityType,
                        Content = license.Attachment.Content,
                        ContentType = license.Attachment.ContentType,
                        FileName = license.Attachment.FileName,
                    },
                    LicenseCategories = license.LicenseCategories.Select(x => new LicenseCategoryCreateModel()
                    {
                        Date = x.Date,
                        DriverLicenseId = x.DriverLicenseId,
                        TransportCategoryId = x.TransportCategoryId,
                    }).ToList()
                };
            }
            else
            {
                EntityId = Guid.Empty;
                CurrentModel = new DriverLicenseCreateModel
                {
                    LicenseNumber = string.Empty,
                    DateOfIssue = DateTimeOffset.UtcNow,
                    IssuedBy = string.Empty,
                    Residence = string.Empty,
                    DriverId = currentDriver.Id,
                    UserId = currentUser.Id,
                    Attachment = new AttachmentCreateModel(),
                    LicenseCategories = new List<LicenseCategoryCreateModel>()
                };
            }
        }

        protected override void SetupBindings()
        {

            textBoxLicenseNumber.AddBindings(x => x.Text, CurrentModel, x => x.LicenseNumber, errorProvider);
            textBoxIssuedBy.AddBindings(x => x.Text, CurrentModel, x => x.IssuedBy, errorProvider);
            textBoxResidence.AddBindings(x => x.Text, CurrentModel, x => x.Residence, errorProvider);

            dateTimePickerDateOfIssue.AddBindingWithConversion(
                x => x.Value,
                CurrentModel,
                x => x.DateOfIssue,
                dto => dto.DateTime,
                dt => new DateTimeOffset(dt, TimeSpan.Zero),
                errorProvider);

            licensePhoto.ResetImageBindings();
            licensePhoto.ImageChanged += (sender, attachment) => CurrentModel.Attachment = attachment;
        }

        private void FillListBoxSelectedItems()
        {
            isInitializingCategories = true;

            try
            {
                listBoxCategories.SelectedItems.Clear();

                foreach (var category in CurrentModel.LicenseCategories)
                {
                    var existingItem = listBoxCategories.Items
                        .Cast<TransportCategory>()
                        .FirstOrDefault(x => x.Id == category.TransportCategoryId);

                    if (existingItem != null)
                    {
                        listBoxCategories.SelectedItems.Add(existingItem);
                    }
                }
            }
            finally
            {
                isInitializingCategories = false;
            }
        }

        private void OnSelectedItemChanged()
        {
            CurrentModel.LicenseCategories.Clear();

            var selectedCategories = listBoxCategories.SelectedItems;

            foreach (var category in selectedCategories)
            {
                CurrentModel.LicenseCategories.Add(new LicenseCategoryCreateModel()
                {
                    Date = CurrentModel.DateOfIssue,
                    DriverLicenseId = EntityId,
                    TransportCategoryId = (category as TransportCategory).Id
                });
            }
        }

        protected override async void FillControls()
        {
            var categories = await transportCategoryService.GetAll(CancellationToken.None);

            listBoxCategories.DisplayMember = nameof(TransportCategory.CategoryName);
            listBoxCategories.ValueMember = nameof(TransportCategory.Id);

            foreach (var category in categories)
            {
                listBoxCategories.Items.Add(category);
            }

            FillListBoxSelectedItems();

            textBoxLicenseNumber.Text = CurrentModel.LicenseNumber;
            textBoxIssuedBy.Text = CurrentModel.IssuedBy;
            textBoxResidence.Text = CurrentModel.Residence;
            dateTimePickerDateOfIssue.Value = CurrentModel.DateOfIssue.DateTime;

            labelStatus.Visible = currentDriverLicense != null;
            textBoxStatus.Visible = currentDriverLicense != null;
            textBoxStatus.Text = CurrentModel.Status.ToString();

            if (CurrentModel.Attachment != null)
            {
                licensePhoto.SetImageFromBytes(CurrentModel.Attachment.Content);
            }
            else
            {
                licensePhoto.ResetToPlaceholder();
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
                await driverLicenseService.Update(EntityId, CurrentModel, CancellationToken.None);
                MessageBox.Show("Данные водительского удостоверения обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                currentDriverLicense = await driverLicenseService.Create(CurrentModel, CancellationToken.None);
                EntityId = currentDriverLicense.Id;
                MessageBox.Show("Водительское удостоверение успешно создано.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxLicenseNumber, textBoxIssuedBy, dateTimePickerDateOfIssue);
        }

        private void listBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializingCategories)
            {
                return;
            }

            OnSelectedItemChanged();
        }
    }
}