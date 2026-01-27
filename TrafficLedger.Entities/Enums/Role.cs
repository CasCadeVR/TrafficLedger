namespace TrafficLedger.Entities;

/// <summary>
/// Роль пользователя
/// </summary>
public enum Role
{
    /// <summary>
    /// Обычный водитель, просмотр и оплата штрафов
    /// </summary>
    Default = 0,

    /// <summary>
    /// Сотрудник дпс, создание штрафов на транспорт + обычный водитель
    /// </summary>
    TrafficPolice = 1,

    /// <summary>
    /// Администратор, привязка автомобилей, проверка оплат
    /// </summary>
    Admin = 2,
}