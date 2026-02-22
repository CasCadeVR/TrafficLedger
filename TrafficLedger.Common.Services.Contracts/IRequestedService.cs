namespace TrafficLedger.Common.Services.Contracts;

/// <summary>
/// Интерфейс сервиса для запрашиваемых сущностей
/// </summary>
public interface IRequestedService<TEntity, TRequestEntity> : IBaseService<TEntity, TRequestEntity>
    where TEntity : class
    where TRequestEntity : class
{
    /// <summary>
    /// Одобряет запрос <see cref="TEntity"/>
    /// </summary>
    Task Approve(Guid id, Guid processedById, CancellationToken cancellationToken);

    /// <summary>
    /// Отклоняет запрос <see cref="TEntity"/>
    /// </summary>
    Task Reject(Guid id, Guid processedById, string commentary, CancellationToken cancellationToken);
}