using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="ITransportCategoryWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="TransportCategoryWriteRepository"/>
/// </remarks>
public class TransportCategoryWriteRepository(IWriter writer)
    : BaseWriteRepository<TransportCategory>(writer), ITransportCategoryWriteRepository { }