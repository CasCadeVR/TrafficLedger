namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="User"/>
/// </summary>
public static class UserValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="User.Login"/>
    /// </summary>
    public const int LoginMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="User.Login"/>
    /// </summary>
    public const int LoginMaxLength = 255;
}