using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities.Configuration;

namespace TrafficLedger.Context
{
    /// <summary>
    /// Контекст для базы данных
    /// </summary>
    public class TrafficLedgerContext : DbContext, IReader, IWriter, IUnitOfWork
    {
        /// <summary>
        /// Инициализирует новый экземпляр <see cref="TrafficLedgerContext"/>
        /// </summary>
        public TrafficLedgerContext(DbContextOptions<TrafficLedgerContext> options)
            : base(options) { }

        /// <inheritdoc cref="DbContext.OnModelCreating"/>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(IEntityConfigurationAnchor).Assembly);
        }

        IQueryable<TEntity> IReader.Read<TEntity>()
            where TEntity : class
            => base.Set<TEntity>()
            .AsNoTracking()
            .AsQueryable();

        void IWriter.Add<TEntity>([NotNull] TEntity entity)
            => base.Entry(entity).State = EntityState.Added;

        void IWriter.Update<TEntity>([NotNull] TEntity entity)
            => base.Entry(entity).State = EntityState.Modified;

        void IWriter.Delete<TEntity>([NotNull] TEntity entity)
            => base.Entry(entity).State = EntityState.Deleted;

        async Task<int> IUnitOfWork.SaveChangesAsync(CancellationToken cancellationToken)
        {
            var count = await base.SaveChangesAsync(cancellationToken);

            foreach (var entry in base.ChangeTracker.Entries().ToArray())
            {
                entry.State = EntityState.Detached;
            }

            return count;
        }
    }
}