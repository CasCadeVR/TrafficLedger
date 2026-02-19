using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities
{
    /// <summary>
    /// Сущность водителя
    /// </summary>
    public class Driver : DataBaseEntity, IEntityWithProtectedProperties
    {
        /// <summary>
        /// Уникальный номер для идентификации в пунктах гибдд
        /// </summary>
        public int UniqueId { get; private set; }

        /// <summary>
        /// ФИО водителя
        /// </summary>
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTimeOffset BirthDate { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string BirthPlace { get; set; } = string.Empty;

        /// <summary>
        /// Идентификатор <see cref="User"/>
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Навигационное свойство <see cref="User"/>
        /// </summary>
        public virtual User User { get; set; } = null!;

        /// <summary>
        /// Навигационное свойство списка <see cref="Ownership"/>
        /// </summary>
        public ICollection<Ownership> Ownerships { get; set; } = null!;

        /// <summary>
        /// Идентификатор <see cref="Attachment"/>
        /// </summary>
        public Guid AttachmentId { get; set; }

        /// <summary>
        /// Навигационное свойство <see cref="Attachment"/>
        /// </summary>
        public virtual Attachment? Attachment { get; set; } = null;

        /// <inheritdoc <see cref="IEntityWithProtectedProperties.GetProtectedProperties"/>/>
        public string[] GetProtectedProperties() => [nameof(UniqueId)];
    }
}