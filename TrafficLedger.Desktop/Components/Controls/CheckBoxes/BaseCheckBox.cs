using System.ComponentModel;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.CheckBoxes
{
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseCheckBox : CheckBox
    {
        public BaseCheckBox()
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
