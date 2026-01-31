using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IViolationReadRepository"/>
public class ViolationReadRepository : IViolationReadRepository
{
    private readonly IReader reader;

    public ViolationReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<bool> IViolationReadRepository.IsViolationCodeExists(string code, CancellationToken cancellationToken)
        => reader.Read<Violation>()
       .NotDeletedAt()
       .AnyAsync(x => x.ViolationCode.ToLower() == code.ToLower(), cancellationToken);

    Task<Violation?> IBaseReadRepository<Violation>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<Violation>()
        .NotDeletedAt()
        .ById(id)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<Violation>> IBaseReadRepository<Violation>.GetAll(CancellationToken cancellationToken)
        => reader.Read<Violation>()
        .NotDeletedAt()
        .OrderBy(x => x.ViolationCode)
        .ToReadOnlyCollectionAsync(cancellationToken);
}