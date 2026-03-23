using Microsoft.Extensions.DependencyInjection;
using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Contracts;
using TrafficLedger.Desktop.Contracts.Interfaces;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Desktop.Infrastructure.Navigation;
using TrafficLedger.Desktop.Services;

namespace TrafficLedger.Desktop
{
    /// <summary>
    /// Главное окно приложения
    /// </summary>
    public partial class MainView : BaseForm, INavigationService
    {
        private List<NavigationItem> navigationItems;
        private readonly IServiceProvider serviceProvider;

        private Panel ContentPanel => splitContainer.Panel2;

        public IServiceProvider ServiceProvider => serviceProvider;

        private BasePanelView currentPanelView;

        /// <summary>
        /// Инициализирует новый экземляр <see cref="MainView"/>
        /// </summary>
        public MainView(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
            InitializeComponent();
            splitContainer.Panel1Collapsed = true;

            AuthenticationService.Instance.AuthStateChanged += BuildNavigationMenu;
            NavigateCoreTo(NavigationRegistry.AuthorizationView);
            BuildNavigationMenu();
        }

        private void BuildNavigationMenu()
        {
            splitContainer.Panel1Collapsed = !AuthenticationService.Instance.IsAuthorized;
            flowLayoutPanelButtons.Controls.Clear();

            if (!AuthenticationService.Instance.IsAuthorized)
            {
                NavigateCoreTo(NavigationRegistry.AuthorizationView);
                return;
            }

            int buttonSize = flowLayoutPanelButtons.Width-2;
            navigationItems = NavigationRegistry.GetMenuItems();

            foreach (var item in navigationItems)
            {
                if (!AuthenticationService.Instance.HasAccessTo(item.RequiredRole))
                    continue;

                var menuButton = new MenuButton(item);
                menuButton.Clicked += NavigateCoreTo;
                menuButton.Size = new Size(buttonSize, buttonSize);
                menuButton.MaximumSize = new Size(buttonSize, buttonSize);

                flowLayoutPanelButtons.Controls.Add(menuButton);
            }
        }

        void INavigationService.NavigateTo(NavigationItem item)
        {
            NavigateCoreTo(item);
        }

        private void NavigateCoreTo(NavigationItem item)
        {
            if (currentPanelView != null)
            {
                currentPanelView.RequestNavigate -= NavigateCoreTo;
            }

            ContentPanel.Controls.Clear();

            BasePanelView view;

            if (item.ViewInstance != null)
            {
                view = item.ViewInstance;
            }
            else if (item.ViewType != null)
            {
                view = (BasePanelView)serviceProvider.GetRequiredService(item.ViewType);
            }
            else
            {
                throw new InvalidOperationException("Ошибка сервера: не было установлено значение у навигационной модели");
            }

            view.RequestNavigate += NavigateCoreTo;
            currentPanelView = view;

            view.OnNavigation(item);
            view.Dock = DockStyle.Fill;
            ContentPanel.Controls.Add(view);
        }
    }
}