using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions;

public partial class ParkingSessionView : BasePanelView
{
    private readonly Lazy<INavigationService> navigationService;

    public ParkingSessionView(Lazy<INavigationService> navigationService)
    {
        InitializeComponent();
        this.navigationService = navigationService;
    }

    private void buttonListUserSessions_Click(object sender, EventArgs e)
    {
        var listView = new NavigationItem()
        {
            Title = buttonListUserSessions.Text,
            ViewType = typeof(ParkingSessionUserListView),
            Parent = CurrentNavigationItem
        };

        navigationService.Value.NavigateTo(listView);
    }

    private void buttonParkingZones_Click(object sender, EventArgs e)
    {
        var instance = navigationService.Value.ServiceProvider.GetRequiredService<ParkingZoneListView>();
        instance.Initialize(asAdmin: false);

        var listView = new NavigationItem()
        {
            Title = "Выберите парковочное место",
            ViewType = null!,
            ViewInstance = instance,
            Parent = CurrentNavigationItem
        };

        navigationService.Value.NavigateTo(listView);
    }
}