using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IPaymentReadRepository"/>
public class PaymentReadRepository : IPaymentReadRepository
{
    private readonly IReader reader;

    public PaymentReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    async Task<IReadOnlyCollection<Payment>> IPaymentReadRepository.GetAllByUserId(Guid userId, CancellationToken cancellationToken)
    {
        var payments = await reader.Read<Payment>()
                    .NotDeletedAt()
                    .Where(x => x.UserId == userId)
                    .Include(x => x.Fine)
                    .Include(x => x.User)
                    .OrderByDescending(x => x.Date)
                    .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var payment in payments)
        {
            if (payment != null)
            {
                var transport = await reader.Read<Transport>()
                   .NotDeletedAt()
                   .Where(x => x.Id == payment.Fine.TransportId)
                   .Include(x => x.TransportCategory)
                   .FirstOrDefaultAsync(cancellationToken);

                payment.Fine.Transport = transport;

                var violation = await reader.Read<Violation>()
                   .NotDeletedAt()
                   .Where(x => x.Id == payment.Fine.ViolationId)
                   .FirstOrDefaultAsync(cancellationToken);

                payment.Fine.Violation = violation;
            }
        }

        return payments;
    }

    async Task<Payment?> IBaseReadRepository<Payment>.GetById(Guid id, CancellationToken cancellationToken)
    {
        var payment = await reader.Read<Payment>()
            .NotDeletedAt()
            .ById(id)
            .Include(x => x.Fine)
            .Include(x => x.User)
            .FirstOrDefaultAsync(cancellationToken);

        if (payment != null)
        {
            var transport = await reader.Read<Transport>()
                .NotDeletedAt()
                .Where(x => x.Id == payment.Fine.TransportId)
                .Include(x => x.TransportCategory)
                .FirstOrDefaultAsync(cancellationToken);

            payment.Fine.Transport = transport;

            var violation = await reader.Read<Violation>()
                .NotDeletedAt()
                .Where(x => x.Id == payment.Fine.ViolationId)
                .FirstOrDefaultAsync(cancellationToken);

            payment.Fine.Violation = violation;
        }

        return payment;
    }

    async Task<IReadOnlyCollection<Payment>> IBaseReadRepository<Payment>.GetAll(CancellationToken cancellationToken)
    {
        var payments = await reader.Read<Payment>()
              .NotDeletedAt()
               .Include(x => x.Fine)
               .Include(x => x.User)
               .OrderByDescending(x => x.Date)
               .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var payment in payments)
        {
            if (payment != null)
            {
                var transport = await reader.Read<Transport>()
                   .NotDeletedAt()
                   .Where(x => x.Id == payment.Fine.TransportId)
                   .Include(x => x.TransportCategory)
                   .FirstOrDefaultAsync(cancellationToken);

                payment.Fine.Transport = transport;

                var violation = await reader.Read<Violation>()
                   .NotDeletedAt()
                   .Where(x => x.Id == payment.Fine.ViolationId)
                   .FirstOrDefaultAsync(cancellationToken);

                payment.Fine.Violation = violation;
            }
        }

        return payments;
    }
}