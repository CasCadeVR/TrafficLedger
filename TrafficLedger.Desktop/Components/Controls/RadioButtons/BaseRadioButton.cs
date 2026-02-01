using System.ComponentModel;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.RadioButtons
{
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseRadioButton : RadioButton
    {
        public BaseRadioButton()
        {
            ApplyBaseStyles();
        }

        protected virtual void ApplyBaseStyles()
        {
            Font = FontScheme.Default;
            ForeColor = ColorScheme.TextPrimary;
            BackColor = ColorScheme.InputBackground;
        }
    }
}
