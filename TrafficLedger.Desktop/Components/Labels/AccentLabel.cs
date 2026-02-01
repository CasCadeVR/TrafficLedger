using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для текста важных подписей
    /// </summary>
    public class AccentLabel : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="AccentLabel"/>
        /// </summary>
        public AccentLabel()
        {
            ForeColor = ColorScheme.TextAccent;
            Font = FontScheme.Emphasis;
        }
    }
}
