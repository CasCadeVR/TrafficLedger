using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для основного текста
    /// </summary>
    public class PrimaryLabel : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="PrimaryLabel"/>
        /// </summary>
        public PrimaryLabel()
        {
            ForeColor = ColorScheme.TextPrimary;
            Font = FontScheme.Default;
        }
    }
}
