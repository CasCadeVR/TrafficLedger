using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models.Ownerships;

/// <summary>
/// Модель запроса владения <see cref="Driver"/>'ом
/// </summary>
public class OwnershipDriverCreateModel : OwnershipBaseCreateModel
{
    /// <summary>
    /// Идентификатор <see cref="Driver"/>
    /// </summary>
    public Guid DriverId { get; set; }
}
