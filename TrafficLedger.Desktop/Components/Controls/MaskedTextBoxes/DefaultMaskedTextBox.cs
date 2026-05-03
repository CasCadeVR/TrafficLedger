using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.MaskedTextBoxes
{
    /// <summary>
    /// Обычный <see cref="BaseMaskedTextBox">
    /// </summary>
    public class DefaultMaskedTextBox : BaseMaskedTextBox
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}
