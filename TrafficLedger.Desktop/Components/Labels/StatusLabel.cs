using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Labels
{
    /// <summary>
    /// Кастомный <see cref="BaseLabel"/> для текста статусов
    /// </summary>
    public class StatusLabel : BaseLabel
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="StatusLabel"/>
        /// </summary>
        public StatusLabel()
        {
            Font = FontScheme.Caption;
        }

        /// <summary>
        /// Установить как успех
        /// </summary>
        public void SetSuccess(string text)
        {
            Text = text;
            ForeColor = ColorScheme.TextSuccess;
        }

        /// <summary>
        /// Установить как ошибку
        /// </summary>
        public void SetError(string text)
        {
            Text = text;
            ForeColor = ColorScheme.TextError;
        }

        /// <summary>
        /// Установить как предупреждение
        /// </summary>
        public void SetWarning(string text)
        {
            Text = text;
            ForeColor = ColorScheme.TextWarning;
        }
    }
}
