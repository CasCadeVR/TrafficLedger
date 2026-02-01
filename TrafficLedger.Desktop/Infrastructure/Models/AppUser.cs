using System;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Infrastructure.Models
{
    /// <summary>
    /// Модель пользователя приложения
    /// </summary>
    public class AppUser
    {
        /// <summary>
        /// ID пользователя
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        /// Роль пользователя
        /// </summary>
        public Role Role { get; set; }
    }
}