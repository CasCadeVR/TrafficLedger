using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.Wrappers
{
    public partial class DriverLicenseCreateWrapper : BaseCreateView<DriverLicenseCreateModel>
    {
        public DriverLicenseCreateWrapper()
        {
            InitializeComponent();
        }
    }
}
