using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.RadioButtons
{
    /// <summary>
    /// Обычный <see cref="BaseRadioButton">
    /// </summary>
    public class DefaultRadioButton : BaseRadioButton
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}