namespace TrafficLedger.Common.Repositories.Contracts;

/// <summary>
/// Общий интерфейс репозитория для чтения из базы данных
/// </summary>
public interface IBaseReadRepository<TEntity> where TEntity : class
{
    /// <summary>
    /// Получает <see cref="TEntity"/> по идентификатору
    /// </summary>
    Task<TEntity> GetById(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Получает коллекцию <see cref="TEntity"/>
    /// </summary>
    Task<IReadOnlyCollection<TEntity>> GetAll(CancellationToken cancellationToken);
}