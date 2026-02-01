using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.CheckBoxes
{
    /// <summary>
    /// Обычный <see cref="BaseCheckBox">
    /// </summary>
    public class DefaultCheckBox : BaseCheckBox
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}