using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;
using TrafficLedger.Desktop.Views.PanelViews.Payments;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions;

public partial class ParkingSessionView : BasePanelView
{
    private readonly INavigationService navigationService;
    private AppUser currentUser => AuthenticationService.Instance.CurrentUser;

    public ParkingSessionView(INavigationService navigationService)
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

        navigationService.NavigateTo(listView);
    }

    private void buttonParkingZones_Click(object sender, EventArgs e)
    {
        var instance = navigationService.ServiceProvider.GetRequiredService<ParkingZoneListView>();
        instance.Initialize(asAdmin: false);

        var listView = new NavigationItem()
        {
            Title = "Выберите парковочное место",
            ViewType = null!,
            ViewInstance = instance,
            Parent = CurrentNavigationItem
        };

        navigationService.NavigateTo(listView);
    }

    private void buttonListUserParkingSessionsPayments_Click(object sender, EventArgs e)
    {
        var listView = navigationService.ServiceProvider.GetRequiredService<PaymentParkingSessionUserListView>();
        listView.Initialize(currentUser.Id, ownPayment: true);

        var navigationItem = new NavigationItem()
        {
            Title = $"Оплаченные парковки пользователя {currentUser.Login}",
            ViewType = null,
            ViewInstance = listView,
            Parent = CurrentNavigationItem,
        };

        navigationService.NavigateTo(navigationItem);
    }
}