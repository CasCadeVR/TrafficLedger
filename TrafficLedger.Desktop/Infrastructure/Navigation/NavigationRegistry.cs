using TrafficLedger.Desktop.Views.PanelViews;
using TrafficLedger.Desktop.Views.PanelViews.FineCreate;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Infrastructure.Navigation
{
    /// <summary>
    /// Конфигурация структуры пермещения по приложению
    /// </summary>
    public static class NavigationRegistry
    {
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
                    ViewType = typeof(TransportUserListView)
                },

                new NavigationItem
                {
                    Title = "Парковки",
                    Icon = ImageResources.Parking,
                    ViewType = typeof(TransportUserListView)
                },

                new NavigationItem
                {
                    Title = "Оформление штрафа",
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