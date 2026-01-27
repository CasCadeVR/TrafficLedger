using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность владения транспортом
/// </summary>
public class Ownership : DataBaseEntity
{
    /// <summary>
    /// Дата подписания договора о владении
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Transport"/>
    /// </summary>
    public Transport Transport { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="Driver"/>
    /// </summary>
    public Guid DriverId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Driver"/>
    /// </summary>
    public Driver Driver { get; set; } = null!;
}