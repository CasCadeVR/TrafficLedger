using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Entities.Generics
{
    /// <summary>
    /// Многотипная сущность
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
