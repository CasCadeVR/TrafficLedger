using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="ITransportCategoryReadRepository"/>
public class TransportCategoryReadRepository : ITransportCategoryReadRepository
{
    private readonly IReader reader;

    public TransportCategoryReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<bool> ITransportCategoryReadRepository.IsNameExists(string name, CancellationToken cancellationToken)
        => reader.Read<TransportCategory>()
       .NotDeletedAt()
       .AnyAsync(x => x.CategoryName.ToLower() == name.ToLower(), cancellationToken);

    Task<IReadOnlyCollection<TransportCategory>> ITransportCategoryReadRepository.GetByIds(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken)
       => reader.Read<TransportCategory>()
        .NotDeletedAt()
        .ByIds(ids)
        .OrderBy(x => x.CategoryName)
        .ToReadOnlyCollectionAsync(cancellationToken);

    Task<TransportCategory?> IBaseReadRepository<TransportCategory>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<TransportCategory>()
        .NotDeletedAt()
        .ById(id)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<TransportCategory>> IBaseReadRepository<TransportCategory>.GetAll(CancellationToken cancellationToken)
        => reader.Read<TransportCategory>()
        .NotDeletedAt()
        .OrderBy(x => x.CategoryName)
        .ToReadOnlyCollectionAsync(cancellationToken);
}