using Microsoft.EntityFrameworkCore;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Context.SeedData
{
    /// <summary>
    /// Загрузчик исходных данных для <see cref="Transport"/>
    /// </summary>
    public static class TransportSeeder
    {
        private static List<Transport> Transports =>
             [
                new Transport
                {
                    TransportCode = "E012AA192",
                    Region = "RU",
                    Brand = "ALFA ROMEO",
                    Model = "STELVIO",
                    Year = "2010",
                    MileAge = 150000,
                    Status = RequestStatus.Approved,
                    TransportCategoryId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                    UserId = Guid.Parse("aaa85f64-5717-4562-b3fc-2c963f66afa6"),
                },

                new Transport
                {
                    TransportCode = "A931BT89",
                    Region = "RU",
                    Brand = "RENAULT",
                    Model = "SR",
                    Year = "2008",
                    MileAge = 25000,
                    Status = RequestStatus.Approved,
                    TransportCategoryId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                    UserId = Guid.Parse("aaa85f64-5717-4562-b3fc-2c963f66afa6"),
                },

            new Transport
                {
                    TransportCode = "B557TM177",
                    Region = "RU",
                    Brand = "FORD",
                    Model = "FOCUS",
                    Year = "2024",
                    MileAge = 10000,
                    Status = RequestStatus.Approved,
                    TransportCategoryId = Guid.Parse("3fa85f64-5717-4562-b3fc-2c963f66afa6"),
                    UserId = Guid.Parse("aaa85f64-5717-4562-b3fc-2c963f66afa6"),
                },
            ];

        /// <summary>
        /// Загрузить данные <see cref="Transport"/> асинхронно
        /// </summary>
        public static async Task SeedAsync(TrafficLedgerContext context, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            if (await context.Set<Transport>().AnyAsync())
            {
                return;
            }

            foreach (var transport in Transports)
            {
                transport.CreatedAt = DateTimeOffset.UtcNow;
                transport.UpdatedAt = DateTimeOffset.UtcNow;
                await context.Set<Transport>().AddAsync(transport);
            }
        }

        /// <summary>
        /// Загрузить данные <see cref="Transport"/>
        /// </summary>
        public static void Seed(TrafficLedgerContext context)
        {
            if (context.Set<Transport>().Any())
            {
                return;
            }

            foreach (var transport in Transports)
            {
                transport.CreatedAt = DateTimeOffset.UtcNow;
                transport.UpdatedAt = DateTimeOffset.UtcNow;
                context.Set<Transport>().Add(transport);
            }
        }
    }
}