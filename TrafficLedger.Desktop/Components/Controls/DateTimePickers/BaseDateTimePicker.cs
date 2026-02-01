using System.ComponentModel;
using System.Windows.Forms;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.DateTimePickers
{
    [DefaultProperty("Text")]
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseDateTimePicker : DateTimePicker
    {
        public BaseDateTimePicker()
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
