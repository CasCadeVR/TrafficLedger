using System.ComponentModel.DataAnnotations;
using TrafficLedger.Entities.ValidationRules;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса нарушения
/// </summary>
public class ViolationCreateModel
{
    /// <summary>
    /// Код нарушения
    /// </summary>
    [Required(ErrorMessage = "Код нарушения обязателен")]
    [StringLength(ViolationValidationRules.CodeMaxLength,
       MinimumLength = ViolationValidationRules.CodeMinLength,
       ErrorMessage = "Код нарушения должен быть длиной от 3 до 255 символов")]
    public string ViolationCode { get; set; } = string.Empty;

    /// <summary>
    /// Название нарушения
    /// </summary>
    [Required(ErrorMessage = "Название нарушения обязательно")]
    [StringLength(ViolationValidationRules.NameMaxLength,
       MinimumLength = ViolationValidationRules.NameMinLength,
       ErrorMessage = "Название нарушения должно быть длиной от 3 до 255 символов")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Описание нарушения
    /// </summary>
    [Required(ErrorMessage = "Описание нарушения обязательно")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Минимальная сумма штрафа за нарушение
    /// </summary>
    [Required(ErrorMessage = "Минимальная сумма штрафа обязательно")]
    public decimal MinFinePrice { get; set; }

    /// <summary>
    /// Максимальная сумма штрафа за нарушение
    /// </summary>
    public decimal MaxFinePrice { get; set; }
}