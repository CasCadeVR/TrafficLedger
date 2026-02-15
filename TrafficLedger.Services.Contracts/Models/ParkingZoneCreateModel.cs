namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса зоны платной парковки
/// </summary>
public class ParkingZoneCreateModel
{
    /// <summary>
    /// Адрес места парковки
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// координаты для WKT
    /// </summary>
    public string? GeometryWkt { get; set; }

    /// <summary>
    /// Цена парковки в час
    /// </summary>
    public decimal HourlyRate { get; set; }

    /// <summary>
    /// Активность
    /// </summary>
    public bool IsActive { get; set; } = true;
}
