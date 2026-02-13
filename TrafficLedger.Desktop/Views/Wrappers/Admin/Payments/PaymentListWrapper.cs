using TrafficLedger.Desktop.Views.PanelViews;
using TrafficLedger.Repositories.Contracts.Models.Payments;

namespace TrafficLedger.Desktop.Views.Wrappers
{
    public partial class PaymentListWrapper : BaseListView<PaymentFineDBModel>
    {
        public PaymentListWrapper()
        {
            InitializeComponent();
        }
    }
}
