using System;
using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Violations
{
    public partial class ViolationView : BasePanelView
    {
        private readonly INavigationService navigationService;

        public ViolationView(INavigationService navigationService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            var listView = new NavigationItem()
            {
                Title = buttonList.Text,
                ViewType = typeof(ViolationListView),
                Parent = CurrentNavigationItem
            };

            navigationService.NavigateTo(listView);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<ViolationCreateView>();
            createView.Initialize(null);

            var navigationItem = new NavigationItem()
            {
                Title = buttonAdd.Text,
                ViewType = null,
                ViewInstance = createView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }
    }
}