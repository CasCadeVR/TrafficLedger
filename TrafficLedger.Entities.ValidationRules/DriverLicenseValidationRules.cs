namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="DriverLicense"/>
/// </summary>
public static class DriverLicenseValidationRules
{
    /// <summary>
    /// Длина <see cref="DriverLicense.LicenseNumber"/>
    /// </summary>
    public const int LicenseNumberLength = 12;

    /// <summary>
    /// Минимальная длина <see cref="DriverLicense.IssuedBy"/>
    /// </summary>
    public const int IssuedByMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="DriverLicense.IssuedBy"/>
    /// </summary>
    public const int IssuedByMaxLength = 255;

    /// <summary>
    /// Минимальная длина <see cref="DriverLicense.Residence"/>
    /// </summary>
    public const int ResidenceMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="DriverLicense.Residence"/>
    /// </summary>
    public const int ResidenceMaxLength = 255;
}