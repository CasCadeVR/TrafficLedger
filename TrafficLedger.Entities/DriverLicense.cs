using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность водительского удостверения
/// </summary>
public class DriverLicense : RequestedDataBaseEntity
{
    /// <summary>
    /// Номер удостоверения
    /// </summary>
    public string LicenseNumber { get; set; } = string.Empty;

    /// <summary>
    /// Дата выдачи
    /// </summary>
    public DateTimeOffset DateOfIssue { get; set; }

    /// <summary>
    /// Кем выдан
    /// </summary>
    public string IssuedBy { get; set; } = string.Empty;

    /// <summary>
    /// Город
    /// </summary>
    public string Residence { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор <see cref="Driver"/>
    /// </summary>
    public Guid DriverId { get; set; }

    /// <summary>
    /// Навигационное свойтво <see cref="Driver"/>
    /// </summary>
    public Driver Driver { get; set; } = null!;

    /// <summary>
    /// Навигационное свойство списка <see cref="LicenseCategory"/>
    /// </summary>
    public ICollection<LicenseCategory> LicenseCategories { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="Attachment"/>
    /// </summary>
    public Guid AttachmentId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Attachment"/>
    /// </summary>
    public virtual Attachment? Attachment { get; set; } = null;
}