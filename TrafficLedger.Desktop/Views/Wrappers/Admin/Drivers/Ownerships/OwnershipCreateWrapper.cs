using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Services.Contracts.Models.Ownerships;

namespace TrafficLedger.Desktop.Views.Wrappers
{
    public partial class OwnershipCreateWrapper : BaseCreateView<OwnershipCodeCreateModel>
    {
        public OwnershipCreateWrapper()
        {
            InitializeComponent();
        }
    }
}
