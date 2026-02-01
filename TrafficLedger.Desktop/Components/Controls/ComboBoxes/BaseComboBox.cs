using System.ComponentModel;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.TextBoxes
{
    /// <summary>
    /// Базовый <see cref="ComboBox"/>
    /// </summary>
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseComboBox : ComboBox
    {
        /// <summary>
        /// Иницилизирует новый экземпляр <see cref="BaseComboBox"/>
        /// </summary>
        public BaseComboBox()
        {
            ApplyBaseStyles();
        }

        protected virtual void ApplyBaseStyles()
        {
            Font = FontScheme.Default;
            ForeColor = ColorScheme.TextPrimary;
            BackColor = ColorScheme.InputBackground;
            DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
