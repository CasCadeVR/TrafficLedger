using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using TrafficLedger.Context.Contracts;

namespace TrafficLedger.Context.Tests
{
    /// <summary>
    /// Фикстура базы данных для unit-тестов
    /// </summary>
    public abstract class TrafficLedgerContextInMemory : IAsyncDisposable
    {
        /// <summary>
        /// Контекст <see cref="TrafficLedgerContext"/>
        /// </summary>
        protected TrafficLedgerContext Context { get; }

        /// <inheritdoc cref="IUnitOfWork"/>
        protected IUnitOfWork UnitOfWork => Context;

        /// <summary>
        /// Инициализирует новый экземпляр <see cref="TrafficLedgerContextInMemory"/>
        /// </summary>
        protected TrafficLedgerContextInMemory()
        {
            var optionsBuilder = new DbContextOptionsBuilder<TrafficLedgerContext>()
              .UseInMemoryDatabase($"TrafficLedgerContextTests{Guid.NewGuid()}")
              .ConfigureWarnings(w => w.Ignore(InMemoryEventId.TransactionIgnoredWarning));

            Context = new TrafficLedgerContext(optionsBuilder.Options);
        }

        /// <inheritdoc cref="IDisposable"/>
        public async ValueTask DisposeAsync()
        {
            await Context.Database.EnsureDeletedAsync();
            await Context.DisposeAsync();
        }
    }
}