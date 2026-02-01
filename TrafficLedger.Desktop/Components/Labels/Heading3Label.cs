using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для текста заголовков 3 уровня
    /// </summary>
    public class Heading3Label : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="Heading3Label"/>
        /// </summary>
        public Heading3Label()
        {
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Heading3;
        }
    }
}
