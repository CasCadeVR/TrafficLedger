using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Fine"/>
/// </summary>
public interface IFineReadRepository : IBaseReadRepository<Fine>
{
    /// <summary>
    /// Получает список <see cref="Fine"/> по идентификатору транспорта
    /// </summary>
    Task<IReadOnlyCollection<Fine>> GetAllByTransportId(Guid transportId, CancellationToken cancellationToken);
}
