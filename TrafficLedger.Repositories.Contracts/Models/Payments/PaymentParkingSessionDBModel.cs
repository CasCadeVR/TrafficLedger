using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.Models.Payments;

public class PaymentParkingSessionDBModel : Payment
{
    /// <summary>
    /// Парковка
    /// </summary>
    public ParkingSession ParkingSession { get; set; } = null!;
}
