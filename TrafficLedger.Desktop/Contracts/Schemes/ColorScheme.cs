using System.Drawing;

namespace TrafficLedger.Desktop.Contracts
{
    /// <summary>
    /// Цветовая схема приложения
    /// </summary>
    public static class ColorScheme
    {
        /// <summary>
        /// Цвет заднего фона приложения
        /// </summary>
        public static readonly Color FormBackground = ColorTranslator.FromHtml("#F5F7FA");

        /// <summary>
        /// Цвет заднего фона главной панели
        /// </summary>
        public static readonly Color MainPanelBackground = Color.GhostWhite;

        /// <summary>
        /// Цвет главных кнопок
        /// </summary>
        public static readonly Color PrimaryButton = Color.BlueViolet;

        /// <summary>
        /// Цвет кнопок меню
        /// </summary>
        public static readonly Color MenuButton = Color.DarkSeaGreen;

        /// <summary>
        /// Цвет картинок кнопок меню
        /// </summary>
        public static readonly Color MenuButtonImage = Color.WhiteSmoke;

        /// <summary>
        /// Цвет основного текста
        /// </summary>
        public static readonly Color ButtonPrimary = Color.White;

        /// <summary>
        /// Цвет основного текста
        /// </summary>
        public static readonly Color ButtonBorder = Color.DarkGray;

        /// <summary>
        /// Фон карточки (card) — для блоков с данными, форм и т.д.
        /// </summary>
        public static readonly Color CardBackground = Color.White;

        /// <summary>
        /// Цвет фона полей ввода
        /// </summary>
        public static readonly Color InputBackground = Color.White;

        /// <summary>
        /// Цвет границы поля ввода
        /// </summary>
        public static readonly Color InputBorder =  ColorTranslator.FromHtml("#CCCCCC");

        /// <summary>
        /// Цвет фокуса (активного поля)
        /// </summary>
        public static readonly Color InputFocus = TextAccent;

        /// <summary>
        /// Граница карточки
        /// </summary>
        public static readonly Color CardBorder = ColorTranslator.FromHtml("#E5E5E5");

        /// <summary>
        /// Фон второстепенной панели (например, боковая панель, фильтры)
        /// </summary>
        public static readonly Color SecondaryPanelBackground = ColorTranslator.FromHtml("#F8F9FA");

        /// <summary>
        /// Фон группового блока (например, "Личные данные", "Транспорт")
        /// </summary>
        public static readonly Color GroupPanelBackground = ColorTranslator.FromHtml("#FAFAFA");

        /// <summary>
        /// Цвет основного текста
        /// </summary>
        public static readonly Color TextPrimary = ColorTranslator.FromHtml("#000000");

        /// <summary>
        /// Цвет второстепенного текста (описания, подсказки)
        /// </summary>
        public static readonly Color TextSecondary = ColorTranslator.FromHtml("#666666");

        /// <summary>
        /// Цвет акцентного (важного) текста
        /// </summary>
        public static readonly Color TextAccent = ColorTranslator.FromHtml("#0078D7");

        /// <summary>
        /// Цвет ошибки
        /// </summary>
        public static readonly Color TextError = ColorTranslator.FromHtml("#E53935");

        /// <summary>
        /// Цвет успеха
        /// </summary>
        public static readonly Color TextSuccess = ColorTranslator.FromHtml("#43A047");

        /// <summary>
        /// Цвет предупреждения
        /// </summary>
        public static readonly Color TextWarning = ColorTranslator.FromHtml("#FFB300");
    }
}