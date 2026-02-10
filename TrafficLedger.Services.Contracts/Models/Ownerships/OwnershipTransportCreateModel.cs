using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models.Ownerships;

/// <summary>
/// Модель запроса владения <see cref="Transport"/>'ом
/// </summary>
public class OwnershipTransportCreateModel : OwnershipBaseCreateModel
{
    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }
}
