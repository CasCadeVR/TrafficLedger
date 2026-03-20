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

            await context.Set<User>().AddRangeAsync(GetUsers());
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

            context.Set<User>().AddRange(GetUsers());
        }

        // TODO: В production обязательно удалить их
        private static List<User> GetUsers()
        {
            var adminSaltValue = SecurityHelper.GenerateSalt32();
            var adminPasswordHash = SecurityHelper.HashPassword32("admin", adminSaltValue);
            var admin = new User()
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                Role = Role.Admin,
                PasswordSalt = adminSaltValue,
                PasswordHash = adminPasswordHash,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            var userSaltValue = SecurityHelper.GenerateSalt32();
            var userPasswordHash = SecurityHelper.HashPassword32("user", userSaltValue);
            var user = new User()
            {
                Id = Guid.NewGuid(),
                Login = "user",
                Role = Role.Default,
                PasswordSalt = userSaltValue,
                PasswordHash = userPasswordHash,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            var policeSaltValue = SecurityHelper.GenerateSalt32();
            var policePasswordHash = SecurityHelper.HashPassword32("police", policeSaltValue);
            var police = new User()
            {
                Id = Guid.NewGuid(),
                Login = "police",
                Role = Role.TrafficPolice,
                PasswordSalt = policeSaltValue,
                PasswordHash = policePasswordHash,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            return [admin, user, police];
        }
    }
}