namespace TrafficLedger.Entities;

/// <summary>
/// Статус операции
/// </summary>
public enum Status
{
    /// <summary>
    /// В обработке
    /// </summary>
    InProgress = 0,

    /// <summary>
    /// Завершено
    /// </summary>
    Finished = 1,
}