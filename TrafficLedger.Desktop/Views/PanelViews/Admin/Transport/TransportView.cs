using System;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Views.PanelViews.FineCreate;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    public partial class TransportView : BasePanelView
    {
        private readonly INavigationService navigationService;

        public TransportView(INavigationService navigationService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
        }

        private void buttonListTransport_Click(object sender, EventArgs e)
        {
            var listView = new NavigationItem()
            {
                Title = buttonListTransport.Text,
                ViewType = typeof(TransportListView),
                Parent = CurrentNavigationItem
            };

            navigationService.NavigateTo(listView);
        }

        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            var createView = new NavigationItem()
            {
                Title = buttonAddTransport.Text,
                ViewType = typeof(TransportCreateView),
                Parent = CurrentNavigationItem
            };

            navigationService.NavigateTo(createView);
        }
    }
}