using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.Models.Payments;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Payment"/>
/// </summary>
public interface IPaymentReadRepository : IBaseReadRepository<Payment>
{
    /// <summary>
    /// Получает список <see cref="PaymentFineDBModel"/> по идентификатору пользователя
    /// </summary>
    Task<IReadOnlyCollection<PaymentFineDBModel>> GetAllFinesByUserId(Guid userId, CancellationToken cancellationToken);

    /// <summary>
    /// Получает список <see cref="PaymentParkingSessionDBModel"/> по идентификатору пользователя
    /// </summary>
    Task<IReadOnlyCollection<PaymentParkingSessionDBModel>> GetAllParkingSessionsByUserId(Guid userId, CancellationToken cancellationToken);

    /// <summary>
    /// Получает список <see cref="PaymentFineDBModel"/>
    /// </summary>
    Task<IReadOnlyCollection<PaymentFineDBModel>> GetAllFines(CancellationToken cancellationToken);

    /// <summary>
    /// Получает список <see cref="PaymentParkingSessionDBModel"/>
    /// </summary>
    Task<IReadOnlyCollection<PaymentParkingSessionDBModel>> GetAllParkingSessions(CancellationToken cancellationToken);
}
