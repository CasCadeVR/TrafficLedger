using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность категории для водительсокого удостоверения 
/// </summary>
public class LicenseCategory : DataBaseEntity
{
    /// <summary>
    /// Дата присуждения определённой категории
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Идентификатор <see cref="DriverLicense"/>
    /// </summary>
    public Guid DriverLicenseId { get; set; }

    /// <summary>
    /// Навигационное свойтво <see cref="DriverLicense"/>
    /// </summary>
    public DriverLicense DriverLicense { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="TransportCategory"/>
    /// </summary>
    public Guid TransportCategoryId { get; set; }

    /// <summary>
    /// Навигационное свойтво <see cref="TransportCategory"/>
    /// </summary>
    public TransportCategory TransportCategory { get; set; } = null!;
}