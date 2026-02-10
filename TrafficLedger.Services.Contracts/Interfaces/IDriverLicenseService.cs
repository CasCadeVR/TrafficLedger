using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="DriverLicense"/>
/// </summary>
public interface IDriverLicenseService : IBaseService<DriverLicense, DriverLicenseCreateModel>
{
    /// <summary>
    /// Получает <see cref="DriverLicense"/> по идентификатору водителя
    /// </summary>
    Task<DriverLicense> GetByDriverId(Guid driverId, CancellationToken cancellationToken);
}
