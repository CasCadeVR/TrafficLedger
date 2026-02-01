using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Payments
{
    public partial class PaymentListView : BaseListView<Payment>
    {
        private readonly IPaymentService paymentService;

        public PaymentListView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
        }

        protected override async Task<IEnumerable<Payment>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await paymentService.GetAll(cancellationToken);
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
            var card = new PaymentCard(item, asOwnPayment: false);

            card.ApproveClicked += () => Approve(item);
            card.RejectClicked += () => Reject(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private void Reject(Payment item)
        {
            var result = MessageBox.Show(
              $"Вы действительно хотите отклонить оплату по чеку с датой {item.Date}?",
              "Выход",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                paymentService.RejectPayment(item.Id, CancellationToken.None);
                MessageBox.Show($"Чек {item.Date} успешно отклонён, штраф в силе", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void Approve(Payment item)
        {
            var result = MessageBox.Show(
              $"Вы действительно хотите подтвердить оплату по чеку с датой {item.Date}?",
              "Выход",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                paymentService.ApprovePayment(item.Id, CancellationToken.None);
                MessageBox.Show($"Чек {item.Date} успешно подтверждён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void Delete(Payment item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить чек с датой {item.Date}?. Это удалит чек безвозвратно, а не завершает его",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                paymentService.Delete(item.Id, CancellationToken.None);
                MessageBox.Show($"Чек {item.Date} успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void checkBoxShowUnactive_CheckedChanged(object sender, System.EventArgs e)
        {
            PerformSearch();
        }
    }
}