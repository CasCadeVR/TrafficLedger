using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса пользователя
/// </summary>
public class UserRequest
{
    /// <summary>
    /// Имя входа
    /// </summary>
    public string Login { get; set; } = string.Empty;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Роль пользователя
    /// </summary>
    public Role Role { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Driver"/>
    /// </summary>
    public Guid? DriverId { get; set; }
}