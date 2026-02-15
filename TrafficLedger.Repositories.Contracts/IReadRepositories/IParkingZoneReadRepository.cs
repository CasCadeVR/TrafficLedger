using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="ParkingZone"/>
/// </summary>
public interface IParkingZoneReadRepository : IBaseReadRepository<ParkingZone>
{
    /// <summary>
    /// Существует ли уже такой адрес
    /// </summary>
    Task<bool> IsAddressExists(string address, CancellationToken cancellationToken);
}
