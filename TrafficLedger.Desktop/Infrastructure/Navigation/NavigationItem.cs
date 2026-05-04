using System;
using System.Drawing;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Desktop.Infrastructure.Navigation
{
    /// <summary>
    /// Модель навигации
    /// </summary>
    public class NavigationItem
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Изображение
        /// </summary>
        public Image Icon { get; set; } = null;
        
        /// <summary>
        /// Необходимый минимум роли
        /// </summary>
        public Role RequiredRole { get; set; } = Role.Default;

        /// <summary>
        /// Тип раздела, который нужно показать пользователю
        /// </summary>
        public Type ViewType { get; set; }

        /// <summary>
        /// Экземпляр раздела, который нужно показать пользователю
        /// </summary>
        public BasePanelView ViewInstance { get; set; } = null;

        /// <summary>
        /// Родительская форма
        /// </summary>
        public NavigationItem Parent { get; set; } = null;
    }
}