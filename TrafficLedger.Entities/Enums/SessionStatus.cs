namespace TrafficLedger.Entities;

/// <summary>
/// Статус сессии (по времени)
/// </summary>
public enum SessionStatus
{
    /// <summary>
    /// В обработке
    /// </summary>
    Active = 0,

    /// <summary>
    /// Завершён
    /// </summary>
    Completed = 1,

    /// <summary>
    /// Просрочен
    /// </summary>
    Expired = 2
}