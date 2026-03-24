using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Entities.Generics;
using TrafficLedger.Services.Contracts.Interfaces;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    public partial class StatsView : BasePanelView
    {
        private readonly IUserService userService;
        private readonly IDriverService driverService;
        private readonly IDriverLicenseService driverLicenseService;
        private readonly ITransportService transportService;
        private readonly IFineService fineService;
        private readonly IParkingZoneService parkingZoneService;
        private readonly IParkingSessionService parkingSessionService;
        private readonly IPaymentService paymentService;

        private int allUserCount = 0;
        private int allDriverCount = 0;
        private int allLicenseCount = 0;
        private int allTransportCount = 0;

        private int allActiveFinesCount = 0;
        private int allPayedFinesCount = 0;
        private decimal allPayedFinesSum = 0;
        private string mostCommonFineName = string.Empty;

        private int allParkingZoneCount = 0;
        private decimal allZonesSum = 0;
        private string mostCommonParkingZone = string.Empty;

        private int allPendingRequestsCount = 0;
        private int allApprovedRequestsCount = 0;
        private int allRejectedRequestsCount = 0;

        public StatsView
            (
                IUserService userService,
                IDriverService driverService,
                IDriverLicenseService driverLicenseService,
                ITransportService transportService,
                IFineService fineService,
                IParkingZoneService parkingZoneService,
                IParkingSessionService parkingSessionService,
                IPaymentService paymentService
            )
        {
            InitializeComponent();

            this.userService = userService;
            this.driverService = driverService;
            this.driverLicenseService = driverLicenseService;
            this.transportService = transportService;
            this.fineService = fineService;
            this.parkingZoneService = parkingZoneService;
            this.parkingSessionService = parkingSessionService;
            this.paymentService = paymentService;

            ShowStats();
        }

        private async Task SaveStats(CancellationToken cancellationToken)
        {
            var allUsers = await userService.GetAll(cancellationToken);
            var allDrivers = await driverService.GetAll(cancellationToken);
            var allLicenses = await driverLicenseService.GetAll(cancellationToken);
            var allTransports = await transportService.GetAll(cancellationToken);

            allUserCount = allUsers.Count;
            allDriverCount = allDrivers.Count;
            allLicenseCount = allLicenses.Count;
            allTransportCount = allTransports.Count;

            var allFines = await fineService.GetAll(cancellationToken);
            var allFinePayments = await paymentService.GetAllFines(cancellationToken);

            allActiveFinesCount = allFines.Where(x => x.Status == SessionStatus.Active).Count();
            allPayedFinesCount = allFines.Where(x => x.Status == SessionStatus.Completed).Count();
            allPayedFinesSum = allFinePayments.Select(x => x.CapturedPrice).Sum();
            mostCommonFineName = allFines.GroupBy(f => f.ViolationId)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()!.Select(x => x.Violation.Name).First();

            var allZones = await parkingZoneService.GetAll(cancellationToken);
            var allSessions = await parkingSessionService.GetAll(cancellationToken);
            var allSessionPayments = await paymentService.GetAllParkingSessions(cancellationToken);

            allParkingZoneCount = allZones.Count;
            allZonesSum = allSessionPayments.Select(x => x.CapturedPrice).Sum();
            mostCommonParkingZone = allSessions.GroupBy(f => f.ParkingZoneId)
                .OrderByDescending(g => g.Count())
                .FirstOrDefault()!.Select(x => x.ParkingZone.Address).First()!;

            var allPayments = await paymentService.GetAll(cancellationToken);

            allPendingRequestsCount = allLicenses.Where(x => x.Status == RequestStatus.Pending).Count() +
                allTransports.Where(x => x.Status == RequestStatus.Pending).Count() +
                allPayments.Where(x => x.Status == RequestStatus.Pending).Count();

            var now = DateTime.Now;

            var rejectedLastWeek = (RequestedDataBaseEntity x) =>
                x.Status == RequestStatus.Rejected && x.ProcessedAt.HasValue && x.ProcessedAt < now && x.ProcessedAt > now.AddDays(-7);

            allRejectedRequestsCount = allLicenses.Where(rejectedLastWeek).Count() +
                allTransports.Where(rejectedLastWeek).Count() +
                allPayments.Where(x => x.Status == RequestStatus.Rejected && x.ProcessedAt.HasValue && x.ProcessedAt < now && x.ProcessedAt > now.AddDays(-7)).Count();

            var acceptedLastWeek = (RequestedDataBaseEntity x) =>
               x.Status == RequestStatus.Approved && x.ProcessedAt.HasValue && x.ProcessedAt < now && x.ProcessedAt > now.AddDays(-7);

            allApprovedRequestsCount = allLicenses.Where(acceptedLastWeek).Count() +
                allTransports.Where(acceptedLastWeek).Count() +
                allPayments.Where(x => x.Status == RequestStatus.Approved && x.ProcessedAt.HasValue && x.ProcessedAt < now && x.ProcessedAt > now.AddDays(-7)).Count();
        }

        private async void ShowStats()
        {
            await SaveStats(CancellationToken.None);

            userCount.Text = allUserCount.ToString();
            driverCount.Text = allDriverCount.ToString();
            licenseCount.Text = allLicenseCount.ToString();
            transportCount.Text = allTransportCount.ToString();

            activeFinesCount.Text = allActiveFinesCount.ToString();
            payedFinesCount.Text = allPayedFinesCount.ToString();
            totalFinePaymentSum.Text = allPayedFinesSum.ToString();
            mostCommonFine.Text = mostCommonFineName;

            zoneCount.Text = allParkingZoneCount.ToString();
            parkingTotalSum.Text = allZonesSum.ToString();
            mostPopularZone.Text = mostCommonParkingZone;

            pendingRequestsCount.Text = allPendingRequestsCount.ToString();
            rejectedRequestsCount.Text = allRejectedRequestsCount.ToString();
            acceptedRequestsCount.Text = allApprovedRequestsCount.ToString();
        }

        private void ExportStats(string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("sdf"); 
            using var package = new ExcelPackage(new FileInfo(filePath));
            var worksheet = package.Workbook.Worksheets.Add("ОтчётПоСтатистике");

            int row = 1;
            for (int r = 0; r < tableLayoutPanelMain.RowCount - 3; r++)
            {
                int col = 1;
                for (int c = 0; c < tableLayoutPanelMain.ColumnCount; c++)
                {
                    Control control = tableLayoutPanelMain.GetControlFromPosition(c, r)!;
                    worksheet.Cells[row, col].Value = control?.Text ?? "";
                    col++;
                }
                row++;
            }

            worksheet.Cells.AutoFitColumns();
            package.Save();
        }

        private void exportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Excel files (*.xlsx)|*.xlsx",
                FileName = "ОтчётПоСтатистике.xlsx"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                ExportStats(saveDialog.FileName);
                MessageBox.Show("Экспорт завершен!");
            }
        }
    }
}
