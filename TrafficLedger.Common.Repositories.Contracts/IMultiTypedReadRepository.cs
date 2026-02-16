namespace TrafficLedger.Common.Repositories.Contracts;

/// <summary>
/// Интерфейс репозитория для чтения из базы данных для мультитипных сущностей
/// </summary>
public interface IMultiTypedReadRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Получает список не удалённых <see cref="TEntity"/> по идентификатору сущности
    /// </summary>
    Task<IReadOnlyCollection<TEntity>> GetAllByEntityId(Guid entityId, string entityType, CancellationToken cancellationToken);

    /// <summary>
    /// Получает первый попавшийся не удалённый <see cref="TEntity"/> по идентификатору сущности
    /// </summary>
    Task<TEntity?> GetByEntityId(Guid entityId, string entityType, CancellationToken cancellationToken);
}