using System;
using System.Windows.Forms;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Contracts.Views.PanelViews
{
    /// <summary>
    /// Базовая вкладка
    /// </summary>
    public partial class BasePanelView : UserControl
    {
        /// <summary>
        /// Текущая модель навигации
        /// </summary>
        public NavigationItem CurrentNavigationItem;

        /// <summary>
        /// Инициализирует новый экземляр <see cref="BasePanelView"/>
        /// </summary>
        public BasePanelView()
        {
            InitializeComponent();
            InitializeView("Название вкладки");
        }

        /// <summary>
        /// Запрос навигации
        /// </summary>
        public event Action<NavigationItem> RequestNavigate;

        /// <summary>
        /// Инициализирует новый экземляр <see cref="BasePanelView"/>
        /// </summary>
        public BasePanelView(NavigationItem item)
        {
            InitializeComponent();
            InitializeView("Название вкладки");
            CurrentNavigationItem = item;
            OnNavigation(item);
        }

        /// <summary>
        /// Инициализация панели всякий раз, когда на неё приходят
        /// </summary>
        public virtual void OnNavigation(NavigationItem item)
        {
            CurrentNavigationItem = item;

            title.Text = item.Title;

            BackButton.Visible = item.Parent != null;

            if (item.Parent != null)
            {
                BackButton.Click -= OnBackButtonClick;
                BackButton.Click += OnBackButtonClick;
            }
        }

        private void InitializeView(string defaultTitle)
        {
            splitContainer.Panel2.BackColor = ColorScheme.MainPanelBackground;
            title.Font = FontScheme.Heading1;
            title.Text = defaultTitle;
        }

        private void OnBackButtonClick(object sender, EventArgs e)
        {
            NavigateToParent();
        }

        /// <summary>
        /// Перейти к родителю
        /// </summary>
        protected void NavigateToParent()
        {
            if (CurrentNavigationItem?.Parent != null)
            {
                RequestNavigate?.Invoke(CurrentNavigationItem.Parent);
            }
        }
    }
}