using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities
{
    /// <summary>
    /// Зона платной парковки
    /// </summary>
    public class ParkingZone : DataBaseEntity
    {
        /// <summary>
        /// Адрес места парковки
        /// </summary>
        public string? Address { get; set; }
        
        /// <summary>
        /// координаты для GeoJSON/WKT
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
}
