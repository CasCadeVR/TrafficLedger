using System.Windows.Forms;

namespace TrafficLedger.Desktop.Contracts.Views.Cards
{
    /// <summary>
    /// Базовая карточка
    /// </summary>
    public partial class BaseCard : UserControl
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="BaseCard"/>
        /// </summary>
        public BaseCard()
        {
            InitializeComponent();
            BackColor = ColorScheme.CardBackground;
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Default;
        }

        private void BaseCard_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, ColorScheme.CardBorder, ButtonBorderStyle.Solid);
        }
    }
}