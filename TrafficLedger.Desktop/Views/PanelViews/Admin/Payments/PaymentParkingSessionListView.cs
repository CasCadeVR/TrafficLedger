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
    public partial class PaymentParkingSessionListView : PaymentParkingSessionListWrapper
    {
        private readonly IPaymentService paymentService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;

        public PaymentParkingSessionListView(IPaymentService paymentService)
        {
            InitializeComponent();
            this.paymentService = paymentService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            SearchHintMessage = "Введите адрес парковки, номер транспорта, сумму или дату чека";
        }

        protected override async Task<IEnumerable<PaymentParkingSessionDBModel>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await paymentService.GetAllParkingSessions(cancellationToken);
        }

        protected override IEnumerable<PaymentParkingSessionDBModel> FilterItems(string searchQuery, IEnumerable<PaymentParkingSessionDBModel> items)
        {
            var filteredByStatus = checkBoxShowApproved.Checked
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
            var card = new PaymentParkingSessionCard(item, asOwnPayment: false);

            card.ApproveClicked += () => Approve(item);
            card.RejectClicked += () => Reject(item);
            card.DeletedClicked += () => Delete(item);

            return card;
        }

        private async void Reject(Payment item)
        {
            var rejectForm = new RejectForm();
            if (rejectForm.ShowDialog() == DialogResult.OK)
            {
                await paymentService.Reject(item.Id, currentUser.Id, rejectForm.Commentary, CancellationToken.None);
                MessageBox.Show($"Чек {item.Date} успешно отклонён, парковка в силе", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private async void Approve(Payment item)
        {
            var result = MessageBox.Show(
              $"Вы действительно хотите подтвердить оплату по чеку с датой {item.Date}?",
              "Выход",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                await paymentService.Approve(item.Id, currentUser.Id, CancellationToken.None);
                MessageBox.Show($"Чек {item.Date} успешно подтверждён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private async void Delete(Payment item)
        {
            var result = MessageBox.Show(
               $"Вы действительно хотите удалить чек с датой {item.Date}?. Это удалит чек безвозвратно, а не завершает его",
               "Выход",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                await paymentService.Delete(item.Id, CancellationToken.None);
                MessageBox.Show($"Чек {item.Date} успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void checkBoxShowApproved_CheckedChanged(object sender, System.EventArgs e)
        {
            PerformSearch();
        }
    }
}