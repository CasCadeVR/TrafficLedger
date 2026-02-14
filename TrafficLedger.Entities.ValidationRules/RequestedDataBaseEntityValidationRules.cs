using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="RequestedDataBaseEntity"/>
/// </summary>
public static class RequestedDataBaseEntityValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="RequestedDataBaseEntity.Commentary"/>
    /// </summary>
    public const int CommentaryMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="RequestedDataBaseEntity.Commentary"/>
    /// </summary>
    public const int CommentaryMaxLength = 2047;
}