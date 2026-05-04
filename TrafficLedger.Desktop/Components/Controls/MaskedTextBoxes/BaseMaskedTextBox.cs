using System.ComponentModel;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.MaskedTextBoxes
{
    [DefaultProperty("Text")]
    [ToolboxItem(true)]
    [DesignerCategory("Code")]
    public class BaseMaskedTextBox : MaskedTextBox
    {
        public BaseMaskedTextBox()
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
