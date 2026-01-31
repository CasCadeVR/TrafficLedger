using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IViolationWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="ViolationWriteRepository"/>
/// </remarks>
public class ViolationWriteRepository(IWriter writer)
    : BaseWriteRepository<Violation>(writer), IViolationWriteRepository { }