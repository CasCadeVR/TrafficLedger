using System.ComponentModel;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components
{
    /// <summary>
    /// Обычная <see cref="Button"/>
    /// </summary>
    [DefaultEvent("Click")]
    public class CommonButton : Button
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="CommonButton"/>
        /// </summary>
        public CommonButton()
        {
            ApplyAppStyles();
        }

        private void ApplyAppStyles()
        {
            base.Font = FontScheme.Emphasis;

            base.BackColor = Color.Green;
            base.ForeColor = ColorScheme.ButtonPrimary;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderColor = ColorScheme.ButtonBorder;
            FlatAppearance.BorderSize = 1;
            Padding = new Padding(8, 4, 8, 4);
        }

        /// <inheritdoc cref="Control.OnHandleCreated(EventArgs)"/>
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            if (!DesignMode)
            {
                ApplyAppStyles();
            }
        }
    }
}