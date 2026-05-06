using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Views.PanelViews;
using TrafficLedger.Desktop.Views.PanelViews.Admin.Transports;
using TrafficLedger.Desktop.Views.PanelViews.FineCreate;
using TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Desktop.Infrastructure.Navigation
{
    /// <summary>
    /// Конфигурация структуры пермещения по приложению
    /// </summary>
    public static class NavigationRegistry
    {
        public static NavigationItem AuthorizationView
            = new NavigationItem
            {
                Title = "Авторизация",
                ViewType = typeof(AuthorizeView)
            };

        /// <summary>
        /// Получить пункты меню
        /// </summary>
        public static List<NavigationItem> GetMenuItems()
            => new List<NavigationItem>
            {
                new NavigationItem
                {
                    Title = "Учётная запись",
                    Icon = ImageResources.User,
                    ViewType = typeof(UserView)
                },

                new NavigationItem
                {
                    Title = "Автомобили",
                    Icon = ImageResources.Car,
                    ViewType = typeof(TransportUserView)
                },

                new NavigationItem
                {
                    Title = "Парковки",
                    Icon = ImageResources.Parking,
                    ViewType = typeof(ParkingSessionView)
                },

                new NavigationItem
                {
                    Title = "Оформление\nштрафа",
                    Icon = ImageResources.Police,
                    RequiredRole = Role.TrafficPolice,
                    ViewType = typeof(TransportListView)
                },

                new NavigationItem
                {
                    Title = "Администрирование",
                    Icon = ImageResources.Admin,
                    RequiredRole = Role.Admin,
                    ViewType = typeof(AdminView)
                }
            };

    }
}