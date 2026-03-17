using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Transport"/>
/// </summary>
public interface ITransportReadRepository : IBaseReadRepository<Transport>
{
    /// <summary>
    /// Существует ли уже такой код
    /// </summary>
    Task<bool> IsCodeExists(string сode, CancellationToken cancellationToken);

    /// <summary>
    /// Владеет ли водитель транспортом
    /// </summary>
    Task<bool> IsDriverOwnsTransport(Guid driverId, Guid transportId, CancellationToken cancellationToken);

    /// <summary>
    /// Получает список <see cref="Transport"/> по идентификаторам
    /// </summary>
    Task<IReadOnlyCollection<Transport>> GetByIds(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken);

    /// <summary>
    /// Получает список <see cref="Transport"/> по идентификатору водителя
    /// </summary>
    Task<IReadOnlyCollection<Transport>> GetAllByDriverId(Guid driverId, CancellationToken cancellationToken);

    /// <summary>
    /// Получает <see cref="Transport"/> по коду
    /// </summary>
    Task<Transport?> GetByTransportCode(string transportCode, CancellationToken cancellationToken);
}
