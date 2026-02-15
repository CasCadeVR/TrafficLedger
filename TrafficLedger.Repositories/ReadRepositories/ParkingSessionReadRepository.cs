using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IParkingSessionReadRepository"/>
public class ParkingSessionReadRepository : IParkingSessionReadRepository
{
    private readonly IReader reader;

    public ParkingSessionReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<IReadOnlyCollection<ParkingSession>> IParkingSessionReadRepository.GetAllByTransportId(Guid transportId, CancellationToken cancellationToken)
        => reader.Read<ParkingSession>()
        .NotDeletedAt()
        .Where(x => x.TransportId == transportId)
        .Include(x => x.Transport)
        .Include(x => x.ParkingZone)
        .Include(x => x.User)
        .ToReadOnlyCollectionAsync(cancellationToken);

    Task<ParkingSession?> IBaseReadRepository<ParkingSession>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<ParkingSession>()
        .NotDeletedAt()
        .ById(id)
        .Include(x => x.Transport)
        .Include(x => x.ParkingZone)
        .Include(x => x.User)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<ParkingSession>> IBaseReadRepository<ParkingSession>.GetAll(CancellationToken cancellationToken)
        => reader.Read<ParkingSession>()
        .NotDeletedAt()
        .Include(x => x.Transport)
        .Include(x => x.ParkingZone)
        .Include(x => x.User)
        .OrderByDescending(x => x.StartTime)
        .ToReadOnlyCollectionAsync(cancellationToken);
}