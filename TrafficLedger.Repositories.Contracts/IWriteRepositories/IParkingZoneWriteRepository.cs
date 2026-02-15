using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IWriteRepositories;

/// <summary>
/// Репозиторий записи для <see cref="ParkingZone"/>
/// </summary>
public interface IParkingZoneWriteRepository : IDBWriter<ParkingZone> { }
