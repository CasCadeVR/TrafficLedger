using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IWriteRepositories;

/// <summary>
/// Репозиторий записи для <see cref="TransportCategory"/>
/// </summary>
public interface ITransportCategoryWriteRepository : IDBWriter<TransportCategory> { }
