using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для текста заголовков 2 уровня
    /// </summary>
    public class Heading2Label : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Heading2Label"/>
        /// </summary>
        public Heading2Label()
        {
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Heading2;
        }
    }
}
