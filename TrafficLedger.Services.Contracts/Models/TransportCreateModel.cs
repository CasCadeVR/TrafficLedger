using System.ComponentModel.DataAnnotations;
using TrafficLedger.Entities;
using TrafficLedger.Entities.ValidationRules;
using TrafficLedger.Services.Contracts.Models.Ownerships;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса транспорта
/// </summary>
public class TransportCreateModel
{
    /// <summary>
    /// Регистрационный номер
    /// </summary>
    [Required(ErrorMessage = "Это поле обязательно")]
    [StringLength(TransportValidationRules.TransportCodeLength, 
        MinimumLength = TransportValidationRules.TransportCodeLength, 
        ErrorMessage = "Регистрационный номер должен быть длиной 9 символов")]
    public string TransportCode { get; set; } = string.Empty;

    /// <summary>
    /// Регион изготовления
    /// </summary>
    [StringLength(TransportValidationRules.RegionMaxLength,
    MinimumLength = TransportValidationRules.RegionMinLength,
        ErrorMessage = "Регион изготовления должен быть от 3 до 255 символов")]
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Марка
    /// </summary>
    [Required(ErrorMessage = "Это поле обязательно")]
    [StringLength(TransportValidationRules.BrandMaxLength,
        MinimumLength = TransportValidationRules.BrandMinLength,
        ErrorMessage = "Марка должна быть от 3 до 255 символов")]
    public string Brand { get; set; } = string.Empty;

    /// <summary>
    /// Год выпуска
    /// </summary>
    [StringLength(TransportValidationRules.YearLength,
        MinimumLength = TransportValidationRules.YearLength,
        ErrorMessage = "Год выпуска должен быть длиной 4 символов")]
    public string Year { get; set; } = string.Empty;

    /// <summary>
    /// Модель
    /// </summary>
    [StringLength(TransportValidationRules.ModelMaxLength,
        MinimumLength = TransportValidationRules.ModelMinLength,
        ErrorMessage = "Модель должна быть от 3 до 255 символов")]
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Пробег
    /// </summary>
    public int MileAge { get; set; }

    /// <summary>
    /// Идентификатор <see cref="TransportCategory"/>
    /// </summary>
    public Guid TransportCategoryId { get; set; }

    /// <summary>
    /// Объект передачи данных <see cref="OwnershipDriverCreateModel"/>
    /// </summary>
    public ICollection<OwnershipDriverCreateModel> Ownerships { get; set; } = null!;
}