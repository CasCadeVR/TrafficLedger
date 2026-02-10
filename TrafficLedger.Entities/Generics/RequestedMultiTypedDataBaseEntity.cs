using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Entities.Generics
{
    /// <summary>
    /// Сущность, нуждающая в подтверждении уполномоченного лица и также мультипная
    /// </summary>
    public abstract class RequestedMultiTypedDataBaseEntity : MultiTypedDataBaseEntity
    {
        /// <summary>
        /// Статус обработки
        /// </summary>
        public RequestStatus Status { get; set; }

        /// <summary>
        /// Когда запрос был обработан
        /// </summary>
        public DateTimeOffset? ProcessedAt { get; set; }

        /// <summary>
        /// Комментарий об обработки запроса от уполномоченного лица
        /// </summary>
        public string? Commentary { get; set; }

        /// <summary>
        /// Идентификатор отправителя запроса (User)
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Идентификатор обработчика запроса (User)
        /// </summary>
        public Guid? ProcessedById { get; set; }

        /// <summary>
        /// Навигационное свойтво <see cref="User"/>-отправителя
        /// </summary>
        public virtual User? User { get; set; }

        /// <summary>
        /// Навигационное свойтво <see cref="User"/>-обработчика
        /// </summary>
        public virtual User? ProcessedBy { get; set; }
    }
}
