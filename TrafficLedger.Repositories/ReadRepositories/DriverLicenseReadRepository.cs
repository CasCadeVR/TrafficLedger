using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IDriverLicenseReadRepository"/>
public class DriverLicenseReadRepository : IDriverLicenseReadRepository
{
    private readonly IReader reader;

    public DriverLicenseReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<DriverLicense?> IDriverLicenseReadRepository.GetByDriverId(Guid driverId, CancellationToken cancellationToken)
        => reader.Read<DriverLicense>()
        .NotDeletedAt()
        .Where(x => x.DriverId == driverId)
        .Include(x => x.Driver)
        .Include(x => x.LicenseCategories)
        .FirstOrDefaultAsync(cancellationToken);

    Task<bool> IDriverLicenseReadRepository.IsLicenseNumberExists(string licenseNumber, CancellationToken cancellationToken)
         => reader.Read<DriverLicense>()
       .NotDeletedAt()
       .AnyAsync(x => x.LicenseNumber.ToLower() == licenseNumber.ToLower(), cancellationToken);

    Task<DriverLicense?> IBaseReadRepository<DriverLicense>.GetById(Guid id, CancellationToken cancellationToken)
         => reader.Read<DriverLicense>()
        .NotDeletedAt()
        .ById(id)
        .Include(x => x.Driver)
        .Include(x => x.LicenseCategories)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<DriverLicense>> IBaseReadRepository<DriverLicense>.GetAll(CancellationToken cancellationToken)
        => reader.Read<DriverLicense>()
        .NotDeletedAt()
        .Include(x => x.Driver)
        .Include(x => x.LicenseCategories)
        .OrderByDescending(x => x.DateOfIssue)
        .ToReadOnlyCollectionAsync(cancellationToken);
}