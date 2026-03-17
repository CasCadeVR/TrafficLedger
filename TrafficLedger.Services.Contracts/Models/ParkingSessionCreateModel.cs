using System.ComponentModel.DataAnnotations;
using TrafficLedger.Entities;
using TrafficLedger.Entities.ValidationRules;

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
    /// Номер транспорта
    /// </summary>
    [Required(ErrorMessage = "Это поле обязательно")]
        [StringLength(TransportValidationRules.TransportCodeLength,
        MinimumLength = TransportValidationRules.TransportCodeLength,
        ErrorMessage = "Регистрационный номер должен быть длиной 9 символов")]
    public string TransportCode { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="ParkingZone"/>
    /// </summary>
    public Guid ParkingZoneId { get; set; }
}
