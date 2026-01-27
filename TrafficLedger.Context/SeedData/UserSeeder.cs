using TrafficLedger.Common.Services;
using TrafficLedger.Entities;

namespace TrafficLedger.Context.SeedData
{
    /// <summary>
    /// Загрузчик исходных данных для <see cref="User"/>
    /// </summary>
    public static class UserSeeder
    {
        /// <summary>
        /// Загрузить данные <see cref="User"/>
        /// </summary>
        public static void Seed(TrafficLedgerContext context)
        {
            if (context.Set<User>().Any()) {
                return;
            }

            // TODO: В production обязательно удалить его

            var saltValue = SecurityHelper.GenerateSalt32();
            var passwordHash = SecurityHelper.HashPassword32("admin", saltValue);

            var user = new User
            {
                Id = Guid.NewGuid(),
                Login = "admin",
                PasswordHash = passwordHash,
                PasswordSalt = saltValue,
                Role = Role.Admin,
                CreatedAt = DateTimeOffset.UtcNow,
                UpdatedAt = DateTimeOffset.UtcNow
            };

            context.Set<User>().Add(user);
        }
    }
}