using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность оплаты
/// </summary>
public class Payment : DataBaseEntity
{
    /// <summary>
    /// Дата оплаты
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Статус оплаты
    /// </summary>
    public Status Status { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Fine"/>
    /// </summary>
    public Guid FineId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Fine"/>
    /// </summary>
    public Fine Fine { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="User"/>
    /// </summary>
    public User User { get; set; } = null!;
}