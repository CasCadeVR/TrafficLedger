namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="Driver"/>
/// </summary>
public static class DriverValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="Driver.FullName"/>
    /// </summary>
    public const int FullNameMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Driver.FullName"/>
    /// </summary>
    public const int FullNameMaxLength = 255;

    /// <summary>
    /// Минимальная длина <see cref="Driver.BirthPlace"/>
    /// </summary>
    public const int BirthPlaceMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Driver.BirthPlace"/>
    /// </summary>
    public const int BirthPlaceMaxLength = 255;
}
