using TrafficLedger.Common.Services.Contracts.Extensions;

namespace TrafficLedger.Services.Contracts.Models.Ownerships;

/// <summary>
/// Базовая модель запроса владения транспортом
/// </summary>
public class OwnershipBaseCreateModel
{
    /// <summary>
    /// Дата подписания договора о владении
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }
}
