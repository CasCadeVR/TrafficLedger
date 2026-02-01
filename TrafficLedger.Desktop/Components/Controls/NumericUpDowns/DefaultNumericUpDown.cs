using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.NumericUpDowns
{
    /// <summary>
    /// Обычный <see cref="BaseNumericUpDown">
    /// </summary>
    public class DefaultNumericUpDown : BaseNumericUpDown
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}
