using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IFineWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="FineWriteRepository"/>
/// </remarks>
public class FineWriteRepository(IWriter writer)
    : BaseWriteRepository<Fine>(writer), IFineWriteRepository { }