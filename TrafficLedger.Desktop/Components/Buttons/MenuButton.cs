using TrafficLedger.Desktop.Contracts;
using TrafficLedger.Desktop.Infrastructure.Navigation;

namespace TrafficLedger.Desktop.Components
{
    /// <summary>
    /// Кнопка меню
    /// </summary>
    public partial class MenuButton : UserControl
    {
        /// <summary>
        /// Событие по нажатию
        /// </summary>
        public event Action<NavigationItem> Clicked;

        private readonly NavigationItem item;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="MenuButton"/>
        /// </summary>
        public MenuButton(NavigationItem item)
        {
            InitializeComponent();
            ApplyStylings();
            this.item = item;

            title.Text = this.item.Title;
            pictureBox.BackgroundImage = this.item.Icon;

            // для кликов
            title.Enabled = false;
            pictureBox.Enabled = false;
            tableLayoutPanel.Enabled = false;
        }

        private void ApplyStylings()
        {
            tableLayoutPanel.BackColor = ColorScheme.MenuButton;
            title.BackColor = ColorScheme.MenuButton;
            pictureBox.BackColor = ColorScheme.MenuButtonImage;
            title.Font = FontScheme.Caption;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Clicked?.Invoke(item);
        }
    }
}