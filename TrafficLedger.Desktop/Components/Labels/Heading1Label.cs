using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для текста заголовков 1 уровня
    /// </summary>
    public class Heading1Label : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Heading1Label"/>
        /// </summary>
        public Heading1Label()
        {
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Heading1;
        }
    }
}
