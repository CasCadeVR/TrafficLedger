using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.TextBoxes
{
    /// <summary>
    /// Textbox только для чтения от <see cref="BaseTextBox">
    /// </summary>
    public class ReadOnlyTextBox : BaseTextBox
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="ReadOnlyTextBox"/>
        /// </summary>
        public ReadOnlyTextBox()
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
            BorderStyle = BorderStyle.None;
        }
    }
}
