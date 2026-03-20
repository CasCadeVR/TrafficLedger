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
        /// Событие по смене состояния авторизации
        /// </summary>
        public event Action AuthStateChanged;

        /// <summary>
        /// Авторизован ли пользователь
        /// </summary>
        public bool IsAuthorized => CurrentUser != null;

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
            AuthStateChanged.Invoke();
        }

        /// <summary>
        /// Выйти из учётной записи
        /// </summary>
        public void Logout()
        {
            CurrentUser = null!;
            AuthStateChanged.Invoke();
        }

        /// <summary>
        /// Имеет доступ, как у указанной роли?
        /// </summary>
        public bool HasAccessTo(Role targetRole) => CurrentUser.Role >= targetRole;
    }
}