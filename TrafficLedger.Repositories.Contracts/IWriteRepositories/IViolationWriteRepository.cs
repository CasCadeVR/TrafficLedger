using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IWriteRepositories;

/// <summary>
/// Репозиторий записи для <see cref="Violation"/>
/// </summary>
public interface IViolationWriteRepository : IDBWriter<Violation> { }
