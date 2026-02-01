using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.NumericUpDowns
{
    /// <summary>
    /// NumericUpDown только для чтения от <see cref="BaseNumericUpDown">
    /// </summary>
    public class ReadOnlyNumericUpDown : BaseNumericUpDown
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ReadOnlyNumericUpDown"/>
        /// </summary>
        public ReadOnlyNumericUpDown()
        {
            ReadOnly = true;
        }

        protected override void ApplyBaseStyles()
        {
            base.ApplyBaseStyles();
            ReadOnly = true;
            BackColor = ColorScheme.MainPanelBackground;
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Monospace;
            BorderStyle = System.Windows.Forms.BorderStyle.None;
        }
    }
}
