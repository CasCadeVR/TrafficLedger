using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="TransportCategory"/>
/// </summary>
public interface ITransportCategoryReadRepository : IBaseReadRepository<TransportCategory> 
{
    /// <summary>
    /// Существует ли уже имя
    /// </summary>
    Task<bool> IsNameExists(string name, CancellationToken cancellationToken);

    /// <summary>
    /// Получает список <see cref="TransportCategory"/> по идентификаторам
    /// </summary>
    Task<IReadOnlyCollection<TransportCategory>> GetByIds(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken);
}