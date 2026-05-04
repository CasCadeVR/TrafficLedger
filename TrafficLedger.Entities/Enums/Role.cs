using System.ComponentModel;

namespace TrafficLedger.Entities.Enums;

/// <summary>
/// Роль пользователя
/// </summary>
public enum Role
{
    /// <summary>
    /// Обычный водитель, просмотр и оплата штрафов
    /// </summary>
    [Description("Обычный водитель")]
    Default = 0,

    /// <summary>
    /// Сотрудник дпс, создание штрафов на транспорт + обычный водитель
    /// </summary>
    [Description("Сотрудник дпс")]
    TrafficPolice = 1,

    /// <summary>
    /// Администратор, привязка автомобилей, проверка оплат
    /// </summary>
    [Description("Администратор")]
    Admin = 2,
}