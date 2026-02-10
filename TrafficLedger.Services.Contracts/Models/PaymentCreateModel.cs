using TrafficLedger.Entities;
using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Common.Core.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса оплаты
/// </summary>
public class PaymentCreateModel : MultiTypedEntity
{
    /// <summary>
    /// Дата оплаты
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Статус оплаты
    /// </summary>
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }
}
