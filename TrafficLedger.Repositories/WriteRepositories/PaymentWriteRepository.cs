using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IPaymentWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="PaymentWriteRepository"/>
/// </remarks>
public class PaymentWriteRepository(IWriter writer)
    : BaseWriteRepository<Payment>(writer), IPaymentWriteRepository { }