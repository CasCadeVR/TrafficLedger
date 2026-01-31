using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IUserReadRepository"/>
public class UserReadRepository : IUserReadRepository
{
    private readonly IReader reader;

    public UserReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<User?> IUserReadRepository.GetByLogin(string login, CancellationToken cancellationToken)
        => reader.Read<User>()
       .NotDeletedAt()
       .Where(x => x.Login.ToLower() == login.ToLower())
       .FirstOrDefaultAsync(cancellationToken);

    Task<bool> IUserReadRepository.IsLoginExists(string login, CancellationToken cancellationToken)
        => reader.Read<User>()
       .AnyAsync(x => x.Login.ToLower() == login.ToLower(), cancellationToken);

    Task<User?> IBaseReadRepository<User>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<User>()
        .NotDeletedAt()
        .ById(id)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<User>> IBaseReadRepository<User>.GetAll(CancellationToken cancellationToken)
        => reader.Read<User>()
        .NotDeletedAt()
        .OrderBy(x => x.Login)
        .ToReadOnlyCollectionAsync(cancellationToken);
}