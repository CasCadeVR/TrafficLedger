using System.ComponentModel;

namespace TrafficLedger.Entities.Enums;

/// <summary>
/// Статус запроса
/// </summary>
public enum RequestStatus
{
    /// <summary>
    /// В обработке
    /// </summary>
    [Description("В обработке")]
    Pending = 0,

    /// <summary>
    /// Одобрено
    /// </summary>
    [Description("Одобрено")]
    Approved = 1,

    /// <summary>
    /// Отклонено
    /// </summary>
    [Description("Отклонено")]
    Rejected = 2,
}