using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IWriteRepositories;

/// <summary>
/// Репозиторий записи для <see cref="ParkingSession"/>
/// </summary>
public interface IParkingSessionWriteRepository : IDBWriter<ParkingSession> { }
