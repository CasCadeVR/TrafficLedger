using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components.Cards;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.Views;
using TrafficLedger.Desktop.Views.Wrappers;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews.FineCreate
{
    public partial class DriverLicenseListView : DriverLicenseListWrapper
    {
        private readonly INavigationService navigationService;
        private readonly IDriverLicenseService driverLicenseService;
        private AppUser currentUser => AuthenticationService.Instance.CurrentUser;

        public DriverLicenseListView(INavigationService navigationService, IDriverLicenseService driverLicenseService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
            this.driverLicenseService = driverLicenseService;

            ItemsContainer = flowLayoutPanel;
            SearchBar = searchBar;
            SearchHintMessage = "Введите номер, категории ВУ или имя водителя";
        }

        protected override async Task<IEnumerable<DriverLicense>> LoadItemsAsync(CancellationToken cancellationToken)
        {
            return await driverLicenseService.GetAll(cancellationToken);
        }

        protected override IEnumerable<DriverLicense> FilterItems(string searchQuery, IEnumerable<DriverLicense> items)
        {
            var filteredByApproved = checkBoxShowApproved.Checked
               ? items
               : items.Where(f => f.Status != RequestStatus.Approved);

            var filteredByReject = checkBoxShowRejected.Checked
               ? filteredByApproved
               : filteredByApproved.Where(f => f.Status != RequestStatus.Rejected);

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                return filteredByReject;
            }

            var lowerQuery = searchQuery.ToLowerInvariant();

            return filteredByReject.Where(t =>
                t.LicenseNumber?.ToLowerInvariant().Contains(lowerQuery) == true ||
                t.LicenseCategories?.Select(x => x.TransportCategory.CategoryName).Contains(lowerQuery) == true ||
                t.Driver.FullName?.ToLowerInvariant().Contains(lowerQuery) == true
            );
        }

        protected override Control CreateItemControl(DriverLicense item)
        {
            var card = new DriverLicenseRequestCard(item);
            card.AboutClicked += () => AboutDriverLicense(item);
            card.ApproveClicked += () => Approve(item);
            card.RejectClicked += () => Reject(item);

            return card;
        }

        private void AboutDriverLicense(DriverLicense item)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<DriverLicenseCreateView>();
            createView.Initialize(item.Driver, item, isOwnDriver: false);

            var navigationItem = new NavigationItem()
            {
                Title = "Просмотр заявки",
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void Reject(DriverLicense item)
        {
            var rejectForm = new RejectForm();
            if (rejectForm.ShowDialog() == DialogResult.OK)
            {
                driverLicenseService.Reject(item.Id, currentUser.Id, rejectForm.Commentary, CancellationToken.None);
                MessageBox.Show($"Удостоверение {item.LicenseNumber} успешно отклонённо", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void Approve(DriverLicense item)
        {
            var result = MessageBox.Show(
              $"Вы действительно хотите подтвердить удостоверение с номером {item.LicenseNumber}?",
              "Выход",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                driverLicenseService.Approve(item.Id, currentUser.Id, CancellationToken.None);
                MessageBox.Show($"Удостоверение {item.LicenseNumber} успешно подтверждён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                base.OnNavigation(CurrentNavigationItem);
            }
        }

        private void checkBoxShowApproved_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void checkBoxShowRejected_CheckedChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }
    }
}
