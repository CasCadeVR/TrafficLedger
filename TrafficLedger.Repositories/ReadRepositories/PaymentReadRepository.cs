using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Typing;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.Models.Payments;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IPaymentReadRepository"/>
public class PaymentReadRepository : IPaymentReadRepository
{
    private readonly IReader reader;

    public PaymentReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    async Task<IReadOnlyCollection<PaymentFineDBModel>> IPaymentReadRepository.GetAllFinesByUserId(Guid userId, CancellationToken cancellationToken)
    {
        var payments = await reader.Read<Payment>()
                    .NotDeletedAt()
                    .Where(x => x.UserId == userId)
                    .ByEntityType(EntityTypes.FineType)
                    .Include(x => x.User)
                    .OrderByDescending(x => x.Date)
                    .ToReadOnlyCollectionAsync(cancellationToken);

        if (!payments.Any())
        {
            return [];
        }

        var fines = await reader.Read<Fine>()
            .NotDeletedAt()
            .Where(f => payments.Select(p => p.EntityId).Contains(f.Id))
            .Include(f => f.Transport).ThenInclude(t => t.TransportCategory)
            .Include(f => f.Violation)
            .ToDictionaryAsync(f => f.Id, cancellationToken);

        var result = new List<PaymentFineDBModel>();

        foreach (var payment in payments)
        {
            if (fines.TryGetValue(payment.EntityId, out var fine))
            {
                result.Add(new PaymentFineDBModel
                {
                    Id = payment.Id,
                    Date = payment.Date,
                    Status = payment.Status,
                    CapturedPrice = payment.CapturedPrice,
                    Commentary = payment.Commentary,
                    EntityId = payment.EntityId,
                    EntityType = payment.EntityType,
                    ProcessedAt = payment.ProcessedAt,
                    CreatedAt = payment.CreatedAt,
                    DeletedAt = payment.DeletedAt,
                    ProcessedById = payment.ProcessedById,
                    UpdatedAt = payment.UpdatedAt,
                    Fine = fine,
                });
            }
        }

        return result;
    }

    async Task<IReadOnlyCollection<PaymentFineDBModel>> IPaymentReadRepository.GetAllFines(CancellationToken cancellationToken)
    {
        var payments = await reader.Read<Payment>()
                    .NotDeletedAt()
                    .ByEntityType(EntityTypes.FineType)
                    .Include(x => x.User)
                    .OrderByDescending(x => x.Date)
                    .ToReadOnlyCollectionAsync(cancellationToken);

        if (!payments.Any())
        {
            return [];
        }

        var fines = await reader.Read<Fine>()
            .NotDeletedAt()
            .Where(f => payments.Select(p => p.EntityId).Contains(f.Id))
            .Include(f => f.Transport).ThenInclude(t => t.TransportCategory)
            .Include(f => f.Violation)
            .ToDictionaryAsync(f => f.Id, cancellationToken);

        var result = new List<PaymentFineDBModel>();

        foreach (var payment in payments)
        {
            if (fines.TryGetValue(payment.EntityId, out var fine))
            {
                result.Add(new PaymentFineDBModel
                {
                    Id = payment.Id,
                    Date = payment.Date,
                    Status = payment.Status,
                    CapturedPrice = payment.CapturedPrice,
                    Commentary = payment.Commentary,
                    EntityId = payment.EntityId,
                    EntityType = payment.EntityType,
                    ProcessedAt = payment.ProcessedAt,
                    CreatedAt = payment.CreatedAt,
                    DeletedAt = payment.DeletedAt,
                    ProcessedById = payment.ProcessedById,
                    UpdatedAt = payment.UpdatedAt,
                    Fine = fine,
                });
            }
        }

        return result;
    }

    async Task<IReadOnlyCollection<PaymentParkingSessionDBModel>> IPaymentReadRepository.GetAllParkingSessionsByUserId(Guid userId, CancellationToken cancellationToken)
    {
        var payments = await reader.Read<Payment>()
                    .NotDeletedAt()
                    .Where(x => x.UserId == userId)
                    .ByEntityType(EntityTypes.ParkingSessionType)
                    .Include(x => x.User)
                    .OrderByDescending(x => x.Date)
                    .ToReadOnlyCollectionAsync(cancellationToken);

        if (!payments.Any())
        {
            return [];
        }

        var parkingSessions = await reader.Read<ParkingSession>()
            .NotDeletedAt()
            .Where(f => payments.Select(x => x.EntityId).Contains(f.Id))
            .Include(f => f.Transport).ThenInclude(t => t.TransportCategory)
            .Include(f => f.User)
            .Include(f => f.ParkingZone)
            .ToDictionaryAsync(f => f.Id, cancellationToken);

        var result = new List<PaymentParkingSessionDBModel>();

        foreach (var payment in payments)
        {
            if (parkingSessions.TryGetValue(payment.EntityId, out var parkingSession))
            {
                result.Add(new PaymentParkingSessionDBModel
                {
                    Id = payment.Id,
                    Date = payment.Date,
                    Status = payment.Status,
                    CapturedPrice = payment.CapturedPrice,
                    Commentary = payment.Commentary,
                    EntityId = payment.EntityId,
                    EntityType = payment.EntityType,
                    ProcessedAt = payment.ProcessedAt,
                    CreatedAt = payment.CreatedAt,
                    DeletedAt = payment.DeletedAt,
                    ProcessedById = payment.ProcessedById,
                    UpdatedAt = payment.UpdatedAt,
                    ParkingSession = parkingSession,
                });
            }
        }

        return result;
    }

    async Task<IReadOnlyCollection<PaymentParkingSessionDBModel>> IPaymentReadRepository.GetAllParkingSessions(CancellationToken cancellationToken)
    {
        var payments = await reader.Read<Payment>()
                    .NotDeletedAt()
                    .ByEntityType(EntityTypes.ParkingSessionType)
                    .Include(x => x.User)
                    .OrderByDescending(x => x.Date)
                    .ToReadOnlyCollectionAsync(cancellationToken);

        if (!payments.Any())
        {
            return [];
        }

        var parkingSessions = await reader.Read<ParkingSession>()
            .NotDeletedAt()
            .Where(f => payments.Select(x => x.EntityId).Contains(f.Id))
            .Include(f => f.Transport).ThenInclude(t => t.TransportCategory)
            .Include(f => f.User)
            .Include(f => f.ParkingZone)
            .ToDictionaryAsync(f => f.Id, cancellationToken);

        var result = new List<PaymentParkingSessionDBModel>();

        foreach (var payment in payments)
        {
            if (parkingSessions.TryGetValue(payment.EntityId, out var parkingSession))
            {
                result.Add(new PaymentParkingSessionDBModel
                {
                    Id = payment.Id,
                    Date = payment.Date,
                    Status = payment.Status,
                    CapturedPrice = payment.CapturedPrice,
                    Commentary = payment.Commentary,
                    EntityId = payment.EntityId,
                    EntityType = payment.EntityType,
                    ProcessedAt = payment.ProcessedAt,
                    CreatedAt = payment.CreatedAt,
                    DeletedAt = payment.DeletedAt,
                    ProcessedById = payment.ProcessedById,
                    UpdatedAt = payment.UpdatedAt,
                    ParkingSession = parkingSession,
                });
            }
        }

        return result;
    }

    async Task<Payment?> IBaseReadRepository<Payment>.GetById(Guid id, CancellationToken cancellationToken)
        => await reader.Read<Payment>()
        .NotDeletedAt()
        .ById(id)
        .Include(x => x.User)
        .FirstOrDefaultAsync(cancellationToken);

    async Task<IReadOnlyCollection<Payment>> IBaseReadRepository<Payment>.GetAll(CancellationToken cancellationToken)
        => await reader.Read<Payment>()
        .NotDeletedAt()
        .Include(x => x.User)
        .OrderByDescending(x => x.Date)
        .ToReadOnlyCollectionAsync(cancellationToken);
}