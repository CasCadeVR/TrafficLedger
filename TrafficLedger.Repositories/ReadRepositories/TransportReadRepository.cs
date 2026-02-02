using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="ITransportReadRepository"/>
public class TransportReadRepository : ITransportReadRepository
{
    private readonly IReader reader;

    public TransportReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<bool> ITransportReadRepository.IsCodeExists(string code, CancellationToken cancellationToken)
        => reader.Read<Transport>()
       .NotDeletedAt()
       .AnyAsync(x => x.TransportCode.ToLower() == code.ToLower(), cancellationToken);

    async Task<IReadOnlyCollection<Transport>> ITransportReadRepository.GetByIds(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken)
    {
        var transports = await reader.Read<Transport>()
            .NotDeletedAt()
            .ByIds(ids)
            .Include(x => x.TransportCategory)
            .Include(x => x.Ownerships)
            .OrderBy(x => x.TransportCode)
            .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var transport in transports)
        {
            if (transport != null)
            {
                var activeOwnerships = await reader.Read<Ownership>()
                    .Where(o => o.TransportId == transport.Id && o.DeletedAt == null)
                    .Include(o => o.Driver)
                    .ToListAsync(cancellationToken);

                transport.Ownerships = activeOwnerships;
            }
        }

        return transports;
    }

    async Task<IReadOnlyCollection<Transport>> ITransportReadRepository.GetAllByDriverId(Guid driverId, CancellationToken cancellationToken)
    {
        var transports = await reader.Read<Transport>()
            .Include(t => t.TransportCategory)
            .Include(t => t.Ownerships)
            .Where(t => t.Ownerships.Any(o => o.DriverId == driverId && o.DeletedAt == null))
            .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var transport in transports)
        {
            if (transport != null)
            {
                var activeOwnerships = await reader.Read<Ownership>()
                    .Include(o => o.Driver)
                    .Where(o => o.TransportId == transport.Id && o.DeletedAt == null)
                    .ToListAsync(cancellationToken);

                transport.Ownerships = activeOwnerships;
            }
        }

        return transports;
    }

    async Task<Transport?> ITransportReadRepository.GetByTransportCode(string transportCode, CancellationToken cancellationToken)
    {
        var transport = await reader.Read<Transport>()
            .NotDeletedAt()
            .Where(x => x.TransportCode == transportCode)
            .Include(x => x.TransportCategory)
            .FirstOrDefaultAsync(cancellationToken);

        if (transport != null)
        {
            var activeOwnerships = await reader.Read<Ownership>()
                .Where(o => o.TransportId == transport.Id && o.DeletedAt == null)
                .Include(o => o.Driver)
                .ToListAsync(cancellationToken);

            transport.Ownerships = activeOwnerships;
        }

        return transport;
    }

    async Task<Transport?> IBaseReadRepository<Transport>.GetById(Guid id, CancellationToken cancellationToken)
    {
        var transport = await reader.Read<Transport>()
            .NotDeletedAt()
            .ById(id)
            .Include(x => x.TransportCategory)
            .FirstOrDefaultAsync(cancellationToken);

        if (transport != null)
        {
            var activeOwnerships = await reader.Read<Ownership>()
                .Where(o => o.TransportId == transport.Id && o.DeletedAt == null)
                .Include(o => o.Driver)
                .ToListAsync(cancellationToken);

            transport.Ownerships = activeOwnerships;
        }

        return transport;
    }

    async Task<IReadOnlyCollection<Transport>> IBaseReadRepository<Transport>.GetAll(CancellationToken cancellationToken)
    {
        var transports = await reader.Read<Transport>()
            .NotDeletedAt()
            .Include(x => x.TransportCategory)
            .OrderBy(x => x.TransportCode)
            .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var transport in transports)
        {
            if (transport != null)
            {
                var activeOwnerships = await reader.Read<Ownership>()
                    .Where(o => o.TransportId == transport.Id && o.DeletedAt == null)
                    .Include(o => o.Driver)
                    .ToListAsync(cancellationToken);

                transport.Ownerships = activeOwnerships;
            }
        }

        return transports;
    }
}