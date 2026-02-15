using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="ParkingZone"/>
/// </summary>
public interface IParkingZoneService : IBaseService<ParkingZone, ParkingZoneCreateModel>
{

}
