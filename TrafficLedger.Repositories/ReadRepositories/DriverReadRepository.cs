using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IDriverReadRepository"/>
public class DriverReadRepository : IDriverReadRepository
{
    private readonly IReader reader;

    public DriverReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    /// <summary>
    /// Получает <see cref="Driver"/> по идентификатору пользователя
    /// </summary>
    async Task<Driver?> IDriverReadRepository.GetByUserId(Guid userId, CancellationToken cancellationToken)
    {
        var driver = await reader.Read<Driver>()
            .NotDeletedAt()
            .Where(x => x.UserId == userId)
            .Include(x => x.User)
            .FirstOrDefaultAsync(cancellationToken);

        if (driver != null)
        {
            var activeOwnerships = await reader.Read<Ownership>()
                .Where(o => o.DriverId == driver.Id && o.DeletedAt == null)
                .Include(o => o.Transport)
                .ToListAsync(cancellationToken);

            driver.Ownerships = activeOwnerships;
        }

        return driver;
    }

    async Task<IReadOnlyCollection<Driver>> IDriverReadRepository.GetByIds(IReadOnlyCollection<Guid> ids, CancellationToken cancellationToken)
    {
        var drivers = await reader.Read<Driver>()
            .NotDeletedAt()
            .ByIds(ids)
            .Include(x => x.User)
            .OrderByDescending(x => x.UniqueId)
            .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var driver in drivers)
        {
            if (driver != null)
            {
                var activeOwnerships = await reader.Read<Ownership>()
                    .NotDeletedAt()
                    .Where(o => o.DriverId == driver.Id)
                    .Include(o => o.Transport)
                    .ToListAsync(cancellationToken);

                driver.Ownerships = activeOwnerships;
            }
        }

        return drivers;
    }

    async Task<Driver?> IBaseReadRepository<Driver>.GetById(Guid id, CancellationToken cancellationToken)
    {
        var driver = await reader.Read<Driver>()
            .NotDeletedAt()
            .ById(id)
            .Include(x => x.User)
            .FirstOrDefaultAsync(cancellationToken);

        if (driver != null)
        {
            var activeOwnerships = await reader.Read<Ownership>()
                .NotDeletedAt()
                .Where(o => o.DriverId == driver.Id)
                .Include(o => o.Transport)
                .ToListAsync(cancellationToken);

            driver.Ownerships = activeOwnerships;
        }

        return driver;
    }

    async Task<IReadOnlyCollection<Driver>> IBaseReadRepository<Driver>.GetAll(CancellationToken cancellationToken)
    {
        var drivers = await reader.Read<Driver>()
            .NotDeletedAt()
            .Include(x => x.User)
            .OrderByDescending(x => x.UniqueId)
            .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var driver in drivers)
        {
            if (driver != null)
            {
                var activeOwnerships = await reader.Read<Ownership>()
                    .NotDeletedAt()
                    .Where(o => o.DriverId == driver.Id)
                    .Include(o => o.Transport)
                    .ToListAsync(cancellationToken);

                driver.Ownerships = activeOwnerships;
            }
        }

        return drivers;
    }
}