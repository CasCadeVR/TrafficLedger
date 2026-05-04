using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Repositories.Contracts.Models.Payments;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    public partial class PaymentParkingSessionUserListView : PaymentParkingSessionUserListWrapper
    {
        private readonly IPaymentService paymentService;
        private bool ownPayment;
        private Guid currentUserId;

        public PaymentParkingSessionUserListView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            SearchHintMessage = "Введите адрес парковки, номер транспорта, цену или дату чека";
        }

        public void Initialize(Guid userId, bool ownPayment)
        {
            currentUserId = userId;
            this.ownPayment = ownPayment;
        }

        protected override async Task<IEnumerable<PaymentParkingSessionDBModel>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await paymentService.GetAllParkingSessionsByUserId(currentUserId, cancellationToken);
        }

        protected override IEnumerable<PaymentParkingSessionDBModel> FilterItems(string searchQuery, IEnumerable<PaymentParkingSessionDBModel> items)
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
                t.ParkingSession.ParkingZone.Address == lowerQuery ||
                t.ParkingSession.Transport.TransportCode.ToString().ToLowerInvariant().Contains(lowerQuery) ||
                t.CapturedPrice.ToString() == lowerQuery ||
                t.Date.ToString() == lowerQuery
            );
        }

        protected override Control CreateItemControl(PaymentParkingSessionDBModel item)
        {
            return new PaymentParkingSessionCard(item, asOwnPayment: ownPayment);
        }

        private void checkBoxShowUnactive_CheckedChanged(object sender, System.EventArgs e)
        {
            PerformSearch();
        }
    }
}