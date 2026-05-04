using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Repositories.Contracts.Models.Payments;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    public partial class PaymentFineUserListView : PaymentFineUserListWrapper
    {
        private readonly IPaymentService paymentService;
        private bool ownPayment;
        private Guid currentUserId;

        public PaymentFineUserListView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            SearchHintMessage = "Введите статью нарушения, номер транспорта, цену или дату чека";
        }

        public void Initialize(Guid userId, bool ownPayment)
        {
            currentUserId = userId;
            this.ownPayment = ownPayment;
        }

        protected override async Task<IEnumerable<PaymentFineDBModel>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await paymentService.GetAllFinesByUserId(currentUserId, cancellationToken);
        }

        protected override IEnumerable<PaymentFineDBModel> FilterItems(string searchQuery, IEnumerable<PaymentFineDBModel> items)
        {
            var filteredByStatus = checkBoxShowUnactive.Checked
               ? items
               : items.Where(f => f.Status != RequestStatus.Approved);

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return filteredByStatus;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return filteredByStatus.Where(t =>
                t.Fine.Violation.ViolationCode.ToString() == lowerQuery ||
                t.Fine.Transport.TransportCode.ToString().ToLowerInvariant().Contains(lowerQuery) ||
                t.CapturedPrice.ToString() == lowerQuery ||
                t.Date.ToString() == lowerQuery
            );
        }

        protected override Control CreateItemControl(PaymentFineDBModel item)
        {
            return new PaymentFineCard(item, asOwnPayment: ownPayment);
        }

        private void checkBoxShowUnactive_CheckedChanged(object sender, System.EventArgs e)
        {
            PerformSearch();
        }
    }
}