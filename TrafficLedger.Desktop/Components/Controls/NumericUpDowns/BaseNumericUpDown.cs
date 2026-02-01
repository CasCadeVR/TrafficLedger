using System.ComponentModel;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.NumericUpDowns
{
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseNumericUpDown : NumericUpDown
    {
        public BaseNumericUpDown()
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
