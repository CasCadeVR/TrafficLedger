using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.Models.Payments;

public class PaymentFineDBModel : Payment
{
    /// <summary>
    /// Штраф
    /// </summary>
    public Fine Fine { get; set; } = null!;
}
