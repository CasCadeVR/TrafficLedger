using Microsoft.Extensions.DependencyInjection;
using System;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers.Ownerships
{
    public partial class OwnershipView : BasePanelView
    {
        private readonly INavigationService navigationService;
        private Driver currentDriver;

        public OwnershipView(INavigationService navigationService)
        {
            InitializeComponent();
            this.navigationService = navigationService;
        }

        /// <summary>
        /// Инициализирует необходимые параметры
        /// </summary>
        public void Initialize(Driver entity)
        {
            currentDriver = entity;
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            var listView = navigationService.ServiceProvider.GetRequiredService<OwnershipListView>();
            listView.Initialize(currentDriver);

            var navigationItem = new NavigationItem()
            {
                Title = buttonList.Text,
                ViewType = null,
                ViewInstance = listView,
                Parent = CurrentNavigationItem,
            };

            navigationService.NavigateTo(navigationItem);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var createView = navigationService.ServiceProvider.GetRequiredService<OwnershipCreateView>();
            createView.Initialize(currentDriver, null);

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