using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="User"/>
/// </summary>
public interface IUserReadRepository : IBaseReadRepository<User>
{
    /// <summary>
    /// Получает <see cref="User"/> по идентификатору
    /// </summary>
    Task<User> GetByLogin(string login, CancellationToken cancellationToken);

    /// <summary>
    /// Проверяет существование логина
    /// </summary>
    Task<bool> IsLoginExists(string login, CancellationToken cancellationToken);
}
