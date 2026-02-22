using TrafficLedger.Desktop.Contracts.Views.Cards;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Components.Cards
{
    /// <summary>
    /// Карточка <see cref="Transport"/>
    /// </summary>
    public partial class TransportRequestCard : BaseCard
    {
        /// <summary>
        /// Нажата кнопка одобрения
        /// </summary>
        public event Action ApproveClicked;

        /// <summary>
        /// Нажата кнопка отклонения
        /// </summary>
        public event Action RejectClicked;

        /// <summary>
        /// Нажата кнопка подробнее
        /// </summary>
        public event Action AboutClicked;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="TransportCard"/>
        /// </summary>
        public TransportRequestCard(Transport request)
        {
            InitializeComponent();
            FillFields(request);
        }

        private void FillFields(Transport request)
        {
            brand.Text = request.Brand;
            model.Text = request.Model;
            number.Text = request.TransportCode;
            category.Text = request.TransportCategory.CategoryName;
            toolTip.SetToolTip(category, request.TransportCategory.Description);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            AboutClicked?.Invoke();
        }

        private void buttonReject_Click(object sender, EventArgs e)
        {
            RejectClicked?.Invoke();
        }

        private void buttonApprove_Click(object sender, EventArgs e)
        {
            ApproveClicked?.Invoke();
        }
    }
}
