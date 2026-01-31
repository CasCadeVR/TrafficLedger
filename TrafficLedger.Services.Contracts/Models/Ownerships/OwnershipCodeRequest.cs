using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса владения <see cref="Transport"/>'ом по коду
/// </summary>
public class OwnershipCodeRequest : OwnershipBaseRequest
{
    /// <summary>
    /// Код <see cref="Transport"/>
    /// </summary>
    public string TransportCode { get; set; } = string.Empty;
}
