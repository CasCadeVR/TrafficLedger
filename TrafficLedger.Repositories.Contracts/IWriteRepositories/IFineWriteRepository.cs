using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IWriteRepositories;

/// <summary>
/// Репозиторий записи для <see cref="Fine"/>
/// </summary>
public interface IFineWriteRepository : IDBWriter<Fine> { }
