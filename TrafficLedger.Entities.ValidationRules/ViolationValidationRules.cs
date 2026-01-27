namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="Violation"/>
/// </summary>
public static class ViolationValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="Violation.ViolationCode"/>
    /// </summary>
    public const int CodeMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Violation.ViolationCode"/>
    /// </summary>
    public const int CodeMaxLength = 255;

    /// <summary>
    /// Максимальная длина <see cref="Violation.Name"/>
    /// </summary>
    public const int NameMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Violation.Name"/>
    /// </summary>
    public const int NameMaxLength = 255;
}