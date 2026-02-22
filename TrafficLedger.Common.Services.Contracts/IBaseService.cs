namespace TrafficLedger.Common.Services.Contracts;

/// <summary>
/// Общий интерфейс сервиса
/// </summary>
public interface IBaseService<TEntity, TRequestEntity>
    where TEntity : class
    where TRequestEntity : class
{
    /// <summary>
    /// Возвращает <see cref="TEntity"/> по идентификатору
    /// </summary>
    Task<TEntity> GetById(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Возвращает список <see cref="TEntity"/>
    /// </summary>
    Task<IReadOnlyCollection<TEntity>> GetAll(CancellationToken cancellationToken);

    /// <summary>
    /// Добавляет новый <see cref="TEntity"/>
    /// </summary>
    Task<TEntity> Create(TRequestEntity model, CancellationToken cancellationToken);

    /// <summary>
    /// Редактирует существующий <see cref="TEntity"/>
    /// </summary>
    Task<TEntity> Update(Guid id, TRequestEntity model, CancellationToken cancellationToken);

    /// <summary>
    /// Удаляет существующий <see cref="TEntity"/>
    /// </summary>
    Task Delete(Guid id, CancellationToken cancellationToken);
}