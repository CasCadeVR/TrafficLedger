using TrafficLedger.Desktop.Views.PanelViews;
using TrafficLedger.Repositories.Contracts.Models.Payments;

namespace TrafficLedger.Desktop.Views.Wrappers
{
    public partial class PaymentFineListWrapper : BaseListView<PaymentFineDBModel>
    {
        public PaymentFineListWrapper()
        {
            InitializeComponent();
        }
    }
}
