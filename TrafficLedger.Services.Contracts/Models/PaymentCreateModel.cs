using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Services.Contracts.Models.Generics;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса оплаты
/// </summary>
public class PaymentCreateModel : MultiTypedRequestedCreateModel
{
    /// <summary>
    /// Дата оплаты
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }
}
