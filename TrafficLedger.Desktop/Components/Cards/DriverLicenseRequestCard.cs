using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="Driver"/>
    /// </summary>
    public partial class DriverLicenseRequestCard : BaseCard
    {
        private readonly DriverLicense request;

        /// <summary>
        /// Нажата кнопка одобрения
        /// </summary>
        public event Action ApproveClicked;

        /// <summary>
        /// Нажата кнопка отклонения
        /// </summary>
        public event Action RejectClicked;

        /// <summary>
        /// Нажата кнопка удаления
        /// </summary>
        public event Action AboutClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="DriverLicenseRequestCard"/>
        /// </summary>
        public DriverLicenseRequestCard(DriverLicense request)
        {
            InitializeComponent();
            this.request = request;
            FillFields();
        }

        private void FillFields()
        {
            fullName.Text = request.Driver.FullName;
            uniqueId.Text = request.Driver.UniqueId.ToString();
            licenseNumberTextBox.Text = request.LicenseNumber;
            residenseTextBox.Text = request.Residence;
            categoryNames.Text = String.Join(", ", request.LicenseCategories.Select(x => x.TransportCategory.CategoryName));

            if (request.Status == Entities.Enums.RequestStatus.Rejected)
            {
                buttonReject.Visible = false;
            }

            if (request.Status == Entities.Enums.RequestStatus.Approved)
            {
                buttonApprove.Visible = false;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutClicked?.Invoke();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            ApproveClicked?.Invoke();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            RejectClicked?.Invoke();
        }
    }
}