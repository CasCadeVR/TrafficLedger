using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.TextBoxes
{
    /// <summary>
    /// Обычный <see cref="BaseTextBox">
    /// </summary>
    public class DefaultTextBox : BaseTextBox
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}
