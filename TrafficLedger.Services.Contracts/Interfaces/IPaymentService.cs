using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="Payment"/>
/// </summary>
public interface IPaymentService : IBaseService<Payment, PaymentRequest>
{
    /// <summary>
    /// Получает список <see cref="Payment"/> по идентификатору пользователя
    /// </summary>
    Task<IReadOnlyCollection<Payment>> GetAllByUserId(Guid userId, CancellationToken cancellationToken);

    /// <summary>
    /// Одобряет оплату по чеку <see cref="Payment"/> по идентификатору чека
    /// </summary>
    Task ApprovePayment(Guid paymentId, CancellationToken cancellationToken);

    /// <summary>
    /// Отклоняет оплату по чеку <see cref="Payment"/> по идентификатору чека
    /// </summary>
    Task RejectPayment(Guid paymentId, CancellationToken cancellationToken);
}