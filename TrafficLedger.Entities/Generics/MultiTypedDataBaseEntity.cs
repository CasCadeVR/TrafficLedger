using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities.Generics
{
    /// <summary>
    /// Сущность привязанная к множеству типов сущностей
    /// </summary>
    public abstract class MultiTypedDataBaseEntity : DataBaseEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        public Guid EntityId { get; set; }

        /// <summary>
        /// Тип сущности
        /// </summary>
        public string EntityType { get; set; } = string.Empty;
    }
}
