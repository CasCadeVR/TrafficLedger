using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для номеров и кода
    /// </summary>
    public class MonospaceLabel : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="StatusLabel"/>
        /// </summary>
        public MonospaceLabel()
        {
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Monospace;
        }
    }
}