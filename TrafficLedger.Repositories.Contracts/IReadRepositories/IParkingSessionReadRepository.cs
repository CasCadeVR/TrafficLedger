using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="ParkingSession"/>
/// </summary>
public interface IParkingSessionReadRepository : IBaseReadRepository<ParkingSession>
{
    /// <summary>
    /// Получает список <see cref="ParkingSession"/> по идентификатору транспорта
    /// </summary>
    Task<IReadOnlyCollection<ParkingSession>> GetAllByTransportId(Guid transportId, CancellationToken cancellationToken);
}
