using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для второстепенного текста
    /// </summary>
    public class SecondaryLabel : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="SecondaryLabel"/>
        /// </summary>
        public SecondaryLabel()
        {
            ForeColor = ColorScheme.TextSecondary;
            Font = FontScheme.Caption;
        }
    }
}
