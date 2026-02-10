using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность штрафа
/// </summary>
public class Fine : RequestedDataBaseEntity
{
    /// <summary>
    /// Дата получения штрафа
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Адрес, по которому произошло нарушение
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Примечание
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор <see cref="Violation"/>
    /// </summary>
    public Guid ViolationId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Violation"/>
    /// </summary>
    public Violation Violation { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Transport"/>
    /// </summary>
    public Transport Transport { get; set; } = null!;
}