using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="ITransportWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="TransportWriteRepository"/>
/// </remarks>
public class TransportWriteRepository(IWriter writer)
    : BaseWriteRepository<Transport>(writer), ITransportWriteRepository { }