using Microsoft.EntityFrameworkCore;
using TrafficLedger.Entities;

namespace TrafficLedger.Context.SeedData
{
    /// <summary>
    /// Загрузчик исходных данных для <see cref="ParkingZone"/>
    /// </summary>
    public static class ParkingZoneSeeder
    {
        private static List<ParkingZone> ParkingZones =>
             [
                new ParkingZone
                {
                    Address = "Платная парковка ТЦ Владимирский пассаж. Автомобильная стоянка, ул. Рубинштейна, 28, Санкт-Петербург, 191002",
                    CoordinatesLink = "https://maps.app.goo.gl/f7rwg1k6AJ95pmQGA",
                    HourlyRate = 200,
                    IsActive = true,
                },

                new ParkingZone
                {
                    Address = "Московский вокзал, парковка у платформы. Невский пр., 85Д, Санкт-Петербург, 191036",
                    CoordinatesLink = "https://maps.app.goo.gl/xWMBuVQXiMqRLqto8",
                    HourlyRate = 400,
                    IsActive = true,
                },

                new ParkingZone
                {
                    Address = "Охраняемая парковка. Литовская ул., 1, Санкт-Петербург, 194353",
                    CoordinatesLink = "https://maps.app.goo.gl/VLpSqURmaZm2vqLh6",
                    HourlyRate = 100,
                    IsActive = true,
                },
            ];

        /// <summary>
        /// Загрузить данные <see cref="ParkingZone"/> асинхронно
        /// </summary>
        public static async Task SeedAsync(TrafficLedgerContext context, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            if (await context.Set<ParkingZone>().AnyAsync())
            {
                return;
            }

            foreach (var parkingZone in ParkingZones)
            {
                parkingZone.CreatedAt = DateTimeOffset.UtcNow;
                parkingZone.UpdatedAt = DateTimeOffset.UtcNow;
                await context.Set<ParkingZone>().AddAsync(parkingZone);
            }
        }

        /// <summary>
        /// Загрузить данные <see cref="ParkingZone"/>
        /// </summary>
        public static void Seed(TrafficLedgerContext context)
        {
            if (context.Set<ParkingZone>().Any())
            {
                return;
            }

            foreach (var parkingZones in ParkingZones)
            {
                parkingZones.CreatedAt = DateTimeOffset.UtcNow;
                parkingZones.UpdatedAt = DateTimeOffset.UtcNow;
                context.Set<ParkingZone>().Add(parkingZones);
            }
        }
    }
}