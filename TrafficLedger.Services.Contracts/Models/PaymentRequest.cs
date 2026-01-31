using TrafficLedger.Entities;
using TrafficLedger.Common.Services.Contracts.Extensions;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса оплаты
/// </summary>
public class PaymentRequest
{
    /// <summary>
    /// Дата оплаты
    /// </summary>
    [NotFutureDate]
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
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }
}
