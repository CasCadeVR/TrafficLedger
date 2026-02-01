using System;
using TrafficLedger.Desktop.Infrastructure.Models;
using TrafficLedger.Entities;

namespace TrafficLedger.Desktop.Services
{
    /// <summary>
    /// Сервис для работы с пользователем приложения
    /// </summary>
    public class AuthenticationService
    {
        private static readonly Lazy<AuthenticationService> _instance =
            new Lazy<AuthenticationService>(() => new AuthenticationService());

        /// <summary>
        /// Подгрузка экземпляра по появлению пользователя
        /// </summary>
        public static AuthenticationService Instance => _instance.Value;

        /// <summary>
        /// Текущий пользователь
        /// </summary>
        public AppUser CurrentUser { get; private set; }

        private AuthenticationService() { }

        /// <summary>
        /// Авторизировать пользователя
        /// </summary>
        public void Login(AppUser user)
        {
            CurrentUser = user;
        }

        /// <summary>
        /// Выйти из учётной записи
        /// </summary>
        public void Logout()
        {
            CurrentUser = null;
        }

        /// <summary>
        /// Имеет доступ, как у указанной роли?
        /// </summary>
        public bool HasAccessTo(Role targetRole) => CurrentUser.Role >= targetRole;
    }
}