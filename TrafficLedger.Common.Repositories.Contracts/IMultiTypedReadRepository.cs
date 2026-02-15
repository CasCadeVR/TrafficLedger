namespace TrafficLedger.Common.Repositories.Contracts;

/// <summary>
/// Интерфейс репозитория для чтения из базы данных для мультитипных сущностей
/// </summary>
public interface IMultiTypedReadRepository<TEntity> where TEntity : class
{
    // <summary>
    /// Получает список <see cref="TEntity"/> по идентификаторам сущностей
    /// </summary>
    Task<IReadOnlyCollection<TEntity>> GetAllByEntityId(Guid entityId, string entityType, CancellationToken cancellationToken);
}