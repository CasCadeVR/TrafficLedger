using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность категории транспорта
/// </summary>
public class TransportCategory : DataBaseEntity
{
    /// <summary>
    /// Название категории
    /// </summary>
    public string CategoryName { get; set; } = string.Empty;

    /// <summary>
    /// Описание категории
    /// </summary>
    public string Description { get; set; } = string.Empty;
}