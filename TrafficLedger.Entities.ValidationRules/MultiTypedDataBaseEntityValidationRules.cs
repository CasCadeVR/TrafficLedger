using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="MultiTypedDataBaseEntity"/>
/// </summary>
public static class MultiTypedDataBaseEntityValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="MultiTypedDataBaseEntity.EntityType"/>
    /// </summary>
    public const int EntityTypeMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="MultiTypedDataBaseEntity.EntityType"/>
    /// </summary>
    public const int EntityTypeMaxLength = 255;
}