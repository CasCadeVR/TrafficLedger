using TrafficLedger.Entities.Contracts;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Entities
{
    /// <summary>
    /// Сессия парковки
    /// </summary>
    public class ParkingSession : DataBaseEntity
    {
        /// <summary>
        /// Начало сессии
        /// </summary>
        public DateTimeOffset StartTime { get; set; }

        /// <summary>
        /// Конец сессии
        /// </summary>
        public DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// Запечатлённая цена на момент окончания сессии
        /// </summary>
        public decimal? CapturedTotalCost { get; set; }

        /// <summary>
        /// Статус сессии
        /// </summary>
        public SessionStatus Status { get; set; }

        /// <summary>
        /// Идентификатор <see cref="User"/>
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Навигационное свойство <see cref="User"/>
        /// </summary>
        public virtual User User { get; set; } = null!;

        /// <summary>
        /// Идентификатор <see cref="Transport"/>
        /// </summary>
        public Guid TransportId { get; set; }

        /// <summary>
        /// Навигационное свойство <see cref="Transport"/>
        /// </summary>
        public virtual Transport Transport { get; set; } = null!;

        /// <summary>
        /// Идентификатор <see cref="ParkingZone"/>
        /// </summary>
        public Guid ParkingZoneId { get; set; }

        /// <summary>
        /// Навигационное свойство <see cref="Transport"/>
        /// </summary>
        public virtual ParkingZone ParkingZone { get; set; } = null!;
    }
}
