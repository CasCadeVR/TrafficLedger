using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Services.Contracts.Models.Ownerships;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    /// <summary>
    /// Форма создания редактирования для <see cref="UserCreateModel"/>
    /// </summary>
    public partial class TransportCreateView : BaseCreateView<TransportCreateModel>
    {
        private readonly ITransportCategoryService transportCategoryService;
        private readonly ITransportService transportService;
        private Transport currentTransport;
        private List<TransportCategory> currentCategories;

        /// <summary>
        /// Инициализирует новый экзмепляр <see cref="BaseCreateView"/>
        /// </summary>
        public TransportCreateView(ITransportService transportService, ITransportCategoryService transportCategoryService)
        {
            InitializeComponent();
            this.transportService = transportService;
            this.transportCategoryService = transportCategoryService;

            comboBoxCategory.SelectedIndexChanged += OnCategorySelected;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Transport entity)
        {
            currentTransport = entity;
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
                    Ownerships = new List<OwnershipDriverCreateModel>()
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
                    TransportCategoryId = Guid.Empty,
                    Ownerships = new List<OwnershipDriverCreateModel>()
                };
            }
        }

        protected override void SetupBindings()
        {
            comboBoxCategory.DataBindings.Clear();

            textBoxCode.AddBindings(x => x.Text, CurrentModel, x => x.TransportCode, errorProvider);
            textBoxRegion.AddBindings(x => x.Text, CurrentModel, x => x.Region, errorProvider);
            textBoxYear.AddBindings(x => x.Text, CurrentModel, x => x.Year, errorProvider);
            textBoxBrand.AddBindings(x => x.Text, CurrentModel, x => x.Brand, errorProvider);
            textBoxModel.AddBindings(x => x.Text, CurrentModel, x => x.Model, errorProvider);
            numericUpDownMileAge.AddBindings(x => x.Value, CurrentModel, x => x.MileAge, errorProvider);

            comboBoxCategory.DataBindings.Add(
                nameof(comboBoxCategory.SelectedValue),
                CurrentModel,
                nameof(CurrentModel.TransportCategoryId),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
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

            if (currentTransport == null)
            {
                return;
            }

            comboBoxCategory.SelectedValue = currentTransport.TransportCategoryId;
            textBoxCode.Text = CurrentModel.TransportCode;
            textBoxRegion.Text = CurrentModel.Region;
            textBoxYear.Text = CurrentModel.Year;
            textBoxBrand.Text = CurrentModel.Brand;
            textBoxModel.Text = CurrentModel.Model;
            numericUpDownMileAge.Value = CurrentModel.MileAge;
        }

        protected override async Task OnSaveAsync()
        {
            if (EntityId != Guid.Empty)
            {
                var response = await transportService.Update(EntityId, CurrentModel, CancellationToken.None);
                currentTransport = response;
                MessageBox.Show("Данные транспорта обновлены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                var driver = await transportService.Create(CurrentModel, CancellationToken.None);
                EntityId = driver.Id;
                MessageBox.Show("Транспорт успешно создан.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            await HandleSaveAsync(textBoxCode, textBoxRegion, textBoxYear, textBoxBrand, textBoxModel);
        }
    }
}