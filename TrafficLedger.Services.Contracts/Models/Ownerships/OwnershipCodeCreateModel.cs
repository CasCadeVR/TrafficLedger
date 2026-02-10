using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models.Ownerships;

/// <summary>
/// Модель запроса владения <see cref="Transport"/>'ом по коду
/// </summary>
public class OwnershipCodeCreateModel : OwnershipBaseCreateModel
{
    /// <summary>
    /// Код <see cref="Transport"/>
    /// </summary>
    public string TransportCode { get; set; } = string.Empty;
}
