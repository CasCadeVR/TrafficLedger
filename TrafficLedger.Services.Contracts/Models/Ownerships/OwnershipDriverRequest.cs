using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса владения <see cref="Driver"/>'ом
/// </summary>
public class OwnershipDriverRequest : OwnershipBaseRequest
{
    /// <summary>
    /// Идентификатор <see cref="Driver"/>
    /// </summary>
    public Guid DriverId { get; set; }
}
