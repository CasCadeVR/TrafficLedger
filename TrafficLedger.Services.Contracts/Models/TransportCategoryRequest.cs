namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса категории транспорта
/// </summary>
public class TransportCategoryRequest
{
    /// <summary>
    /// Название категории
    /// </summary>
    public string CategoryName { get; set; } = string.Empty;

    /// <summary>
    /// Описание категории
    /// </summary>
    public string Description { get; set; } = string.Empty;
}
