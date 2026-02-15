using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IParkingSessionWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="ParkingSessionWriteRepository"/>
/// </remarks>
public class ParkingSessionWriteRepository(IWriter writer)
    : BaseWriteRepository<ParkingSession>(writer), IParkingSessionWriteRepository { }