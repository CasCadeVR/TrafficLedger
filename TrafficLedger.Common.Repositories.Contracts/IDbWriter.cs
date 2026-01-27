namespace TrafficLedger.Common.Repositories.Contracts;

/// <summary>
/// Интерфейс создания и модификации записей в контексте базы данных
/// </summary>
public interface IDBWriter<in TEntity> where TEntity : class
{
    /// <summary>
    /// Добавляет новую запись
    /// </summary>
    void Add(TEntity entity);

    /// <summary>
    /// Изменить запись
    /// </summary>
    void Update(TEntity entity);

    /// <summary>
    /// Удалить запись
    /// </summary>
    void Delete(TEntity entity);
}