using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

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
        /// 1) dotnet tool update --global dotnet-ef
        /// 2) dotnet ef migrations add [name] --project TrafficLedger.Context --connection "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrafficLedgerDBStorage;Integrated Security=True;" providerName="System.Data.SqlClient"
        /// 3) dotnet ef database update --project TrafficLedger.Context --connection "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrafficLedgerDBStorage;Integrated Security=True;" providerName="System.Data.SqlClient"
        /// 4) dotnet ef migrations update [targetMigrationName] --project TrafficLedger.Context --connection "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrafficLedgerDBStorage;Integrated Security=True;" providerName="System.Data.SqlClient"
        /// 5) dotnet ef migrations remove --project TrafficLedger.Context --connection "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TrafficLedgerDBStorage;Integrated Security=True;" providerName="System.Data.SqlClient"
        /// </remarks>
        public TrafficLedgerContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<TrafficLedgerContext>()
                .UseSqlServer()
                .LogTo(Console.WriteLine)
                .Options;

            return new TrafficLedgerContext(options);
        }
    }
}