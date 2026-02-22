using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Services.Contracts.Models.Generics
{
    /// <summary>
    /// Сущность, нуждающая в подтверждении уполномоченного лица
    /// </summary>
    public abstract class RequestedCreateModel
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
    }
}
