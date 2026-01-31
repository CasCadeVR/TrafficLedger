using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="DriverLicense"/>
/// </summary>
public interface IDriverLicenseReadRepository : IBaseReadRepository<DriverLicense>
{
    /// <summary>
    /// Получает <see cref="DriverLicense"/> по идентификатору водителя
    /// </summary>
    Task<DriverLicense?> GetByDriverId(Guid driverId, CancellationToken cancellationToken);

    /// <summary>
    /// Проверяет существование номера удостоверения
    /// </summary>
    Task<bool> IsLicenseNumberExists(string licenseNumber, CancellationToken cancellationToken);
}
