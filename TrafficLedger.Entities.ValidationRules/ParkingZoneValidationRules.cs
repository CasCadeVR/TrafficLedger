namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="ParkingZone"/>
/// </summary>
public static class ParkingZoneValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="ParkingZone.Address"/>
    /// </summary>
    public const int AddressMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="ParkingZone.Address"/>
    /// </summary>
    public const int AddressMaxLength = 2047;
}