using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.DateTimePickers
{
    /// <summary>
    /// Обычный <see cref="BaseDateTimePicker"/>
    /// </summary>
    public class DefaultDateTimePicker : BaseDateTimePicker
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}
