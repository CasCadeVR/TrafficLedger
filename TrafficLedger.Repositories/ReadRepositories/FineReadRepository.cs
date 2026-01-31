using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IFineReadRepository"/>
public class FineReadRepository : IFineReadRepository
{
    private readonly IReader reader;

    public FineReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<IReadOnlyCollection<Fine>> IFineReadRepository.GetAllByTransportId(Guid transportId, CancellationToken cancellationToken)
        => reader.Read<Fine>()
        .NotDeletedAt()
        .Where(x => x.TransportId == transportId)
        .Include(x => x.Transport)
        .Include(x => x.Violation)
        .OrderByDescending(x => x.Date)
        .ToReadOnlyCollectionAsync(cancellationToken);

    Task<Fine?> IBaseReadRepository<Fine>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<Fine>()
        .NotDeletedAt()
        .ById(id)
        .Include(x => x.Transport)
        .Include(x => x.Violation)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<Fine>> IBaseReadRepository<Fine>.GetAll(CancellationToken cancellationToken)
        => reader.Read<Fine>()
        .NotDeletedAt()
        .Include(x => x.Transport)
        .Include(x => x.Violation)
        .OrderByDescending(x => x.Date)
        .ToReadOnlyCollectionAsync(cancellationToken);
}