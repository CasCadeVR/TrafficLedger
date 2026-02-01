using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    public partial class PaymentUserListView : BaseListView<Payment>
    {
        private readonly IPaymentService paymentService;
        private bool ownPayment;
        private Guid currentUserId;

        public PaymentUserListView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        public void Initialize(Guid userId, bool ownPayment)
        {
            currentUserId = userId;
            this.ownPayment = ownPayment;
        }

        protected override async Task<IEnumerable<Payment>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await paymentService.GetAllByUserId(currentUserId, cancellationToken);
        }

        protected override IEnumerable<Payment> FilterItems(string searchQuery, IEnumerable<Payment> items)
        {
            var filteredByStatus = checkBoxShowUnactive.Checked
               ? items
               : items.Where(f => f.Status != Status.Finished);

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return filteredByStatus;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return filteredByStatus.Where(t =>
                t.Fine.Violation.ViolationCode.ToString() == lowerQuery ||
                t.Fine.Transport.TransportCode.ToString().ToLowerInvariant().Contains(lowerQuery) ||
                t.Fine.Violation.FinePrice.ToString() == lowerQuery ||
                t.Date.ToString() == lowerQuery
            );
        }

        protected override Control CreateItemControl(Payment item)
        {
            return new PaymentCard(item, asOwnPayment: ownPayment);
        }

        private void checkBoxShowUnactive_CheckedChanged(object sender, System.EventArgs e)
        {
            PerformSearch();
        }
    }
}