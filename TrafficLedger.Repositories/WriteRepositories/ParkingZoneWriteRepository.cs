using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IParkingZoneWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="ParkingZoneWriteRepository"/>
/// </remarks>
public class ParkingZoneWriteRepository(IWriter writer)
    : BaseWriteRepository<ParkingZone>(writer), IParkingZoneWriteRepository { }