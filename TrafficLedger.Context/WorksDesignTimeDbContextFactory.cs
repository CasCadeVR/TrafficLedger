using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TrafficLedger.Context.SeedData;

namespace TrafficLedger.Context
{
    /// <summary>
    /// Создание контекста <see cref="TrafficLedgerContext"/> для миграций
    /// </summary>
    public class TrafficLedgerDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TrafficLedgerContext>
    {
        /// <summary>
        /// Создаёт контекст для миграции базы данных
        /// </summary>
        /// <remarks>
        /// 1) dotnet toWebApplication1ol install --global dotnet-ef
        /// 2) dotnet tool update --global dotnet-ef
        /// 3) dotnet ef migrations add [name] --project TrafficLedger.Context
        /// 4) dotnet ef database update --project TrafficLedger.Context --connection "Data Source=gogs.wsr.ru;User ID=689-23;Password=pK9HgDB689#;Initial Catalog=TrafficLedgerDBStorage;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;"
        /// 5) dotnet ef migrations update [targetMigrationName] --project TrafficLedger.Context --connection "Data Source=gogs.wsr.ru;User ID=689-23;Password=pK9HgDB689#;Initial Catalog=TrafficLedgerDBStorage;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False;"
        /// 6) dotnet ef migrations remove --project TrafficLedger.Context
        /// </remarks>
        public TrafficLedgerContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<TrafficLedgerContext>()
                .UseSqlServer()
                .UseSeeding((context, _) =>
                {
                    UserSeeder.Seed(context);
                    TransportCategorySeeder.Seed(context);
                    context.SaveChanges();
                })
                .UseAsyncSeeding(async (context, _, cancellationToken) =>
                {
                    await UserSeeder.SeedAsync(context, cancellationToken);
                    await TransportCategorySeeder.SeedAsync(context, cancellationToken);
                    await context.SaveChangesAsync(cancellationToken);
                })
                .LogTo(Console.WriteLine)
                .Options;

            return new TrafficLedgerContext(options);
        }
    }
}