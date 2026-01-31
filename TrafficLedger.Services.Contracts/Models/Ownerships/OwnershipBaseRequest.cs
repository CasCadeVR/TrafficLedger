using TrafficLedger.Common.Services.Contracts.Extensions;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Базовая модель запроса владения транспортом
/// </summary>
public class OwnershipBaseRequest
{
    /// <summary>
    /// Дата подписания договора о владении
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }
}
