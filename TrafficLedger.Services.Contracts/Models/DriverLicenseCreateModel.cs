using System.ComponentModel.DataAnnotations;
using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Entities.ValidationRules;
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
    [Required(ErrorMessage = "Номер удостоверения обязателен")]
    [StringLength(DriverLicenseValidationRules.LicenseNumberLength,
        ErrorMessage = "Номер удостоверения должен быть 12 символов")]
    public string LicenseNumber { get; set; } = string.Empty;

    /// <summary>
    /// Дата выдачи
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset DateOfIssue { get; set; }

    /// <summary>
    /// Кем выдан
    /// </summary>
    [Required(ErrorMessage = "Кем выдан обязателен")]
    [StringLength(DriverLicenseValidationRules.IssuedByMaxLength,
        MinimumLength = DriverLicenseValidationRules.IssuedByMinLength,
        ErrorMessage = "Кем выдан должен быть от 3 до 255 символов")]
    public string IssuedBy { get; set; } = string.Empty;

    /// <summary>
    /// Город
    /// </summary>
    [Required(ErrorMessage = "Город обязателен")]
    [StringLength(DriverLicenseValidationRules.ResidenceMaxLength,
        MinimumLength = DriverLicenseValidationRules.ResidenceMinLength,
        ErrorMessage = "Город должен быть от 3 до 255 символов")]
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
