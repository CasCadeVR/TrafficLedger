using System.ComponentModel.DataAnnotations;
using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Services.Contracts.Models.Fines;

/// <summary>
/// Модель запроса штрафа
/// </summary>
public class FineCreateModel
{
    /// <summary>
    /// Дата получения штрафа
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Адрес, по которому произошло нарушение
    /// </summary>
    [Required(ErrorMessage = "Это поле обязательно")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Примечание
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Статус штрафа
    /// </summary>
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Violation"/>
    /// </summary>
    public Guid ViolationId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }
}
