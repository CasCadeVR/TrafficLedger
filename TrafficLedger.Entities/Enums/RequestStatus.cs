namespace TrafficLedger.Entities.Enums;

/// <summary>
/// Статус запроса
/// </summary>
public enum RequestStatus
{
    /// <summary>
    /// В обработке
    /// </summary>
    Pending = 0,

    /// <summary>
    /// Одобрено
    /// </summary>
    Approved = 1,

    /// <summary>
    /// Отклонено
    /// </summary>
    Rejected = 2,
}