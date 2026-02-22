using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.Models.Payments;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="Payment"/>
/// </summary>
public interface IPaymentService : IRequestedService<Payment, PaymentCreateModel>
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