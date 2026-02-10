namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса нарушения
/// </summary>
public class ViolationCreateModel
{
    /// <summary>
    /// Код нарушения
    /// </summary>
    public string ViolationCode { get; set; } = string.Empty;

    /// <summary>
    /// Название нарушения
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Описание нарушения
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Минимальная сумма штрафа за нарушение
    /// </summary>
    public decimal MinFinePrice { get; set; }

    /// <summary>
    /// Максимальная сумма штрафа за нарушение
    /// </summary>
    public decimal MaxFinePrice { get; set; }
}