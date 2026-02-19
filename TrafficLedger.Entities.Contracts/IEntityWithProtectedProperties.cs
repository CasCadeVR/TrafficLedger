namespace TrafficLedger.Entities.Contracts;

/// <summary>
/// Сущность с защищёнными полями
/// </summary>
public interface IEntityWithProtectedProperties
{
    /// <summary>
    /// Получить защищённые поля
    /// </summary>
    string[] GetProtectedProperties();
}
