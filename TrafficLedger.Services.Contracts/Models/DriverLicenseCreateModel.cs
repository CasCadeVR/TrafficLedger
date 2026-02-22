using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models.Generics;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса водительского удостверения
/// </summary>
public class DriverLicenseCreateModel : RequestedCreateModel
{
    /// <summary>
    /// Номер удостоверения
    /// </summary>
    public string LicenseNumber { get; set; } = string.Empty;

    /// <summary>
    /// Дата выдачи
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset DateOfIssue { get; set; }

    /// <summary>
    /// Кем выдан
    /// </summary>
    public string IssuedBy { get; set; } = string.Empty;

    /// <summary>
    /// Номер удостоверения
    /// </summary>
    public string Code { get; set; } = string.Empty;

    /// <summary>
    /// Город
    /// </summary>
    public string Residence { get; set; } = string.Empty;

    /// <summary>
    /// Фото удостоверения
    /// </summary>
    public AttachmentCreateModel? Attachment { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Driver"/>
    /// </summary>
    public Guid DriverId { get; set; }

    /// <summary>
    /// Навигационное свойство списка <see cref="LicenseCategoryCreateModel"/>
    /// </summary>
    public ICollection<LicenseCategoryCreateModel> LicenseCategories { get; set; } = null!;
}
