namespace TrafficLedger.Common.Core.Contracts.Models
{
    /// <summary>
    /// Многотипная сущность
    /// </summary>
    public abstract class MultiTypedEntity
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
