using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Driver"/>
/// </summary>
public interface IDriverReadRepository : IBaseReadRepository<Driver>
{
    /// <summary>
    /// Получает список <see cref="Driver"/> по идентификаторам
    /// </summary>
    Task<IReadOnlyCollection<Driver>> GetByIds(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken);

    /// <summary>
    /// Получает <see cref="Driver"/> по идентификатору пользователя
    /// </summary>
    Task<Driver?> GetByUserId(Guid userId, CancellationToken cancellationToken);
}
