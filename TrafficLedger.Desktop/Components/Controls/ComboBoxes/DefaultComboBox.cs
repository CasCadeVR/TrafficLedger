using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.TextBoxes
{
    /// <summary>
    /// Обычный <see cref="BaseComboBox"/>
    /// </summary>
    public class DefaultComboBox : BaseComboBox
    {
        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            BackColor = ColorScheme.InputBackground;
        }
    }
}
