using TrafficLedger.Entities.Contracts;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность пользователя
/// </summary>
public class User : DataBaseEntity
{
    /// <summary>
    /// Имя входа
    /// </summary>
    public string Login { get; set; } = string.Empty;

    /// <summary>
    /// Хещ пароля
    /// </summary>
    public string PasswordHash { get; set; } = string.Empty;

    /// <summary>
    /// Соль пароля
    /// </summary>
    public string PasswordSalt { get; set; } = string.Empty;

    /// <summary>
    /// Роль пользователя
    /// </summary>
    public Role Role { get; set; }
}