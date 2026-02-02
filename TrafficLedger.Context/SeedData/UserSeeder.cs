using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Context.SeedData
{
    /// <summary>
    /// Загрузчик исходных данных для <see cref="User"/>
    /// </summary>
    public static class UserSeeder
    {
        // TODO: В production обязательно удалить его

        /// <summary>
        /// Загрузить данные <see cref="User"/> асинхнронно
        /// </summary>
        public static async Task SeedAsync(TrafficLedgerContext context, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {
                return;
            }

            if (await context.Set<User>().AnyAsync()) {
                return;
            }

            // TODO: В production обязательно удалить его

            var saltValue = SecurityHelper.GenerateSalt32();
            var passwordHash = SecurityHelper.HashPassword32("admin", saltValue);
            var admin = new User() 
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Role = Role.Admin,
                PasswordSalt = saltValue,
                PasswordHash = passwordHash,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

             await context.Set<User>().AddAsync(admin);
        }

        /// <summary>
        /// Загрузить данные <see cref="User"/>
        /// </summary>
        public static void Seed(TrafficLedgerContext context)
        {
            if (context.Set<User>().Any())
            {
                return;
            }

            var saltValue = SecurityHelper.GenerateSalt32();
            var passwordHash = SecurityHelper.HashPassword32("admin", saltValue);
            var admin = new User()
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Role = Role.Admin,
                PasswordSalt = saltValue,
                PasswordHash = passwordHash,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            context.Set<User>().Add(admin);
        }

    }
}