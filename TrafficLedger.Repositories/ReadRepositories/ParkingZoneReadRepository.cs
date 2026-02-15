using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IParkingZoneReadRepository"/>
public class ParkingZoneReadRepository : IParkingZoneReadRepository
{
    private readonly IReader reader;

    public ParkingZoneReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<bool> IParkingZoneReadRepository.IsAddressExists(string address, CancellationToken cancellationToken)
        => reader.Read<Fine>()
        .NotDeletedAt()
        .Where(x => x.Address == address)
        .AnyAsync(cancellationToken);

    Task<ParkingZone?> IBaseReadRepository<ParkingZone>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<ParkingZone>()
        .NotDeletedAt()
        .ById(id)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<ParkingZone>> IBaseReadRepository<ParkingZone>.GetAll(CancellationToken cancellationToken)
        => reader.Read<ParkingZone>()
        .NotDeletedAt()
        .OrderByDescending(x => x.Address)
        .ToReadOnlyCollectionAsync(cancellationToken);
}