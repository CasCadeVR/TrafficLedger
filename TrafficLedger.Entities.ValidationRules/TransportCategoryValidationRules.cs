namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="TransportCategory"/>
/// </summary>
public static class TransportCategoryValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="TransportCategory.CategoryName"/>
    /// </summary>
    public const int NameMinLength = 1;

    /// <summary>
    /// Максимальная длина <see cref="TransportCategory.CategoryName"/>
    /// </summary>
    public const int NameMaxLength = 5;

    /// <summary>
    /// Максимальная длина <see cref="TransportCategory.Description"/>
    /// </summary>
    public const int DescriptionMaxLength = 2047;
}
