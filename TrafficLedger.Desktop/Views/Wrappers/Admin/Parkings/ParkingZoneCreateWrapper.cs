using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Views.Wrappers
{
    public partial class ParkingZoneCreateWrapper : BaseCreateView<ParkingZoneCreateModel>
    {
        public ParkingZoneCreateWrapper()
        {
            InitializeComponent();
        }
    }
}
