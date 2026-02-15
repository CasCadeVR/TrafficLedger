using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса зоны платной парковки
/// </summary>
public class ParkingSessionCreateModel
{
    /// <summary>
    /// Начало сессии
    /// </summary>
    public DateTimeOffset StartTime { get; set; }

    /// <summary>
    /// Конец сессии
    /// </summary>
    public DateTimeOffset? EndTime { get; set; }

    /// <summary>
    /// Статус сессии
    /// </summary>
    public SessionStatus Status { get; set; }

    /// <summary>
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="ParkingZone"/>
    /// </summary>
    public Guid ParkingZoneId { get; set; }
}
