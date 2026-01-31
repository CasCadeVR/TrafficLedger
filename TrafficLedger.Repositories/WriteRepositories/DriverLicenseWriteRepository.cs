using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IDriverLicenseWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="DriverLicenseWriteRepository"/>
/// </remarks>
public class DriverLicenseWriteRepository(IWriter writer)
    : BaseWriteRepository<DriverLicense>(writer), IDriverLicenseWriteRepository { }