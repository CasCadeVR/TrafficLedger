using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность нарушения
/// </summary>
public class Violation : DataBaseEntity
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
    /// Сумма штрафа за нарушение
    /// </summary>
    public decimal FinePrice { get; set; }
}