using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Views;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Repositories.Contracts.Models.Payments;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Payments
{
    public partial class PaymentFineListView : PaymentListWrapper
    {
        private readonly IPaymentService paymentService;
        private readonly AppUser currentUser;

        public PaymentFineListView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;

            currentUser = AuthenticationService.Instance.CurrentUser;
        }

        protected override async Task<IEnumerable<PaymentFineDBModel>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await paymentService.GetAllFines(cancellationToken);
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
            var card = new PaymentFineCard(item, asOwnPayment: false);

            card.ApproveClicked += () => Approve(item);
            card.RejectClicked += () => Reject(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private void Reject(Payment item)
        {
            var rejectForm = new RejectForm();
            if (rejectForm.ShowDialog() == DialogResult.OK)
            {
                paymentService.Reject(item.Id, currentUser.Id, rejectForm.Commentary, CancellationToken.None);
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
                paymentService.Approve(item.Id, currentUser.Id, CancellationToken.None);
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