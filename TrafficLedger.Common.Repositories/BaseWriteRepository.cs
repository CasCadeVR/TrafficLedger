using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities.Contracts;

namespace TrafficLedger.Common.Repositories
{
    /// <summary>
    /// Базовый репозиторий для записи данных
    /// </summary>
    public class BaseWriteRepository<T> : IDBWriter<T> where T : class
    {
        private readonly IWriter writer;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="BaseWriteRepository{T}"/>
        /// </summary>
        public BaseWriteRepository(IWriter writer)
        {
            this.writer = writer;
        }

        void IDBWriter<T>.Add(T entity)
        {
            BaseWriteRepository<T>.AuditCreate(entity);
            BaseWriteRepository<T>.AuditUpdate(entity);
            writer.Add(entity);
        }

        void IDBWriter<T>.Update(T entity)
        {
            BaseWriteRepository<T>.AuditUpdate(entity);
            writer.Update(entity);

            // Защита от ошибок
            if (entity is IEntityWithProtectedProperties protectable)
            {
                var entry = ((TrafficLedgerContext)writer).Entry(entity);
                foreach (var prop in protectable.GetProtectedProperties())
                {
                    entry.Property(prop).IsModified = false;
                }
            }
        }

        void IDBWriter<T>.Delete(T entity)
        {
            if (entity is IEntitySoftDeleted softEntity)
            {
                BaseWriteRepository<T>.AuditUpdate(entity);
                softEntity.DeletedAt = DateTime.UtcNow;
                writer.Update(entity);

                // Защита от ошибок
                if (entity is IEntityWithProtectedProperties protectable)
                {
                    var entry = ((TrafficLedgerContext)writer).Entry(entity);
                    foreach (var prop in protectable.GetProtectedProperties())
                    {
                        entry.Property(prop).IsModified = false;
                    }
                }
            }
            else
            {
                writer.Delete(entity);
            }
        }

        private static void AuditCreate(T entity)
        {
            if (entity is IEntityWithAudit auditCreated)
            {
                auditCreated.CreatedAt = DateTime.UtcNow;
            }
        }

        private static void AuditUpdate(T entity)
        {
            if (entity is IEntityWithAudit auditCreated)
            {
                auditCreated.UpdatedAt = DateTime.UtcNow;
            }
        }
    }
}