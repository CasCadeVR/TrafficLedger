using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IWriteRepositories;

/// <summary>
/// Репозиторий записи для <see cref="LicenseCategory"/>
/// </summary>
public interface ILicenseCategoryWriteRepository : IDBWriter<LicenseCategory> { }
