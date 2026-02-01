using System.Drawing;
using System.Windows.Forms;

namespace TrafficLedger.Desktop.Contracts
{
    /// <summary>
    /// Базовое окно
    /// </summary>
    public partial class BaseForm : Form
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="BaseForm"/>
        /// </summary>
        protected BaseForm()
        {
            InitializeComponent();
            Font = FontScheme.Default;
            MinimumSize = new Size(800, 600);
            BackColor = ColorScheme.FormBackground;
            ForeColor = ColorScheme.TextPrimary;
        }
    }
}