using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IDriverWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="DriverWriteRepository"/>
/// </remarks>
public class DriverWriteRepository(IWriter writer)
    : BaseWriteRepository<Driver>(writer), IDriverWriteRepository { }