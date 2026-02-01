using System.ComponentModel;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.TextBoxes
{
    [DefaultProperty("Text")]
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseTextBox : TextBox
    {
        public BaseTextBox()
        {
            ApplyBaseStyles();
        }

        protected virtual void ApplyBaseStyles()
        {
            Font = FontScheme.Default;
            ForeColor = ColorScheme.TextPrimary;
            BackColor = ColorScheme.InputBackground;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
