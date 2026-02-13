using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Services.Contracts.Models.Fines;

namespace TrafficLedger.Desktop.Views.Wrappers
{
    public partial class FineCreateWrapper : BaseCreateView<FineCreateModel>
    {
        public FineCreateWrapper()
        {
            InitializeComponent();
        }
    }
}
