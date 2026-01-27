using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Payment"/>
/// </summary>
public interface IPaymentReadRepository : IBaseReadRepository<Payment>
{
    /// <summary>
    /// Получает список <see cref="Payment"/> по идентификатору пользователя
    /// </summary>
    Task<IReadOnlyCollection<Payment>> GetAllByUserId(Guid userId, CancellationToken cancellationToken);
}
