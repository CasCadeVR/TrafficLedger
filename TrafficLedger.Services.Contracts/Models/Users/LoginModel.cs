namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель авторизации пользователя
/// </summary>
public class LoginModel
{
    /// <summary>
    /// Имя входа
    /// </summary>
    public string Login { get; set; } = string.Empty;

    /// <summary>
    /// Пароль
    /// </summary>
    public string Password { get; set; } = string.Empty;
}