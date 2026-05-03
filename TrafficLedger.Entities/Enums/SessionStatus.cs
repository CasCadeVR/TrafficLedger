using System.ComponentModel;

namespace TrafficLedger.Entities.Enums;

/// <summary>
/// Статус сессии (по времени)
/// </summary>
public enum SessionStatus
{
    /// <summary>
    /// В обработке
    /// </summary>
    [Description("В обработке")]
    Active = 0,

    /// <summary>
    /// Завершён
    /// </summary>
    [Description("Завершён")]
    Completed = 1,

    /// <summary>
    /// Просрочен
    /// </summary>
    [Description("Просрочен")]
    Expired = 2
}