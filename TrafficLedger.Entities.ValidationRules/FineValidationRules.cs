namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="Fine"/>
/// </summary>
public static class FineValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="Fine.Address"/>
    /// </summary>
    public const int AddressMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Fine.Address"/>
    /// </summary>
    public const int AddressMaxLength = 2047;
}