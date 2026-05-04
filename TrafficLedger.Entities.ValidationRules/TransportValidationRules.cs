namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="Transport"/>
/// </summary>
public static class TransportValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="Transport.TransportCode"/>
    /// </summary>
    public const int TransportCodeMinLength = 8;

    /// <summary>
    /// Максимальная длина <see cref="Transport.TransportCode"/>
    /// </summary>
    public const int TransportCodeMaxLength = 9;

    /// <summary>
    /// Минимальная длина <see cref="Transport.Region"/>
    /// </summary>
    public const int RegionMinLength = 1;

    /// <summary>
    /// Максимальная длина <see cref="Transport.Region"/>
    /// </summary>
    public const int RegionMaxLength = 255;

    /// <summary>
    /// Минимальная длина <see cref="Transport.Model"/>
    /// </summary>
    public const int ModelMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Transport.Model"/>
    /// </summary>
    public const int ModelMaxLength = 255;

    /// <summary>
    /// Минимальная длина <see cref="Transport.Brand"/>
    /// </summary>
    public const int BrandMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Transport.Brand"/>
    /// </summary>
    public const int BrandMaxLength = 255;

    /// <summary>
    /// Длина <see cref="Transport.Year"/>
    /// </summary>
    public const int YearLength = 4;
}
