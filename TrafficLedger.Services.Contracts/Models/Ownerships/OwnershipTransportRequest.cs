using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса владения <see cref="Transport"/>'ом
/// </summary>
public class OwnershipTransportRequest : OwnershipBaseRequest
{
    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }
}
