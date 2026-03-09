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

    async Task<DriverLicense?> IDriverLicenseReadRepository.GetByDriverId(Guid driverId, CancellationToken cancellationToken)
    {
        var license = await reader.Read<DriverLicense>()
            .NotDeletedAt()
            .Where(x => x.DriverId == driverId)
            .Include(x => x.Driver)
            .Include(x => x.LicenseCategories).ThenInclude(x => x.TransportCategory)
            .FirstOrDefaultAsync(cancellationToken);

        if (license != null)
        {
            var activeCategories = await reader.Read<LicenseCategory>()
                .NotDeletedAt()
                .Where(o => o.DriverLicenseId == license!.Id)
                .Include(o => o.TransportCategory)
                .ToListAsync(cancellationToken);

            license.LicenseCategories = activeCategories;
        }

        return license;
    }

    Task<bool> IDriverLicenseReadRepository.IsLicenseNumberExists(string licenseNumber, CancellationToken cancellationToken)
         => reader.Read<DriverLicense>()
       .NotDeletedAt()
       .AnyAsync(x => x.LicenseNumber.ToLower() == licenseNumber.ToLower(), cancellationToken);

    async Task<DriverLicense?> IBaseReadRepository<DriverLicense>.GetById(Guid id, CancellationToken cancellationToken)
    {
        var license = await reader.Read<DriverLicense>()
            .NotDeletedAt()
            .ById(id)
            .Include(x => x.Driver)
            .Include(x => x.LicenseCategories).ThenInclude(x => x.TransportCategory)
            .FirstOrDefaultAsync(cancellationToken);

        if (license != null)
        {
            var activeCategories = await reader.Read<LicenseCategory>()
                .NotDeletedAt()
                .Where(o => o.DriverLicenseId == license!.Id)
                .Include(o => o.TransportCategory)
                .ToListAsync(cancellationToken);

            license.LicenseCategories = activeCategories;
        }

        return license;
    }

    async Task<IReadOnlyCollection<DriverLicense>> IBaseReadRepository<DriverLicense>.GetAll(CancellationToken cancellationToken)
    {
        var licenses = await reader.Read<DriverLicense>()
        .NotDeletedAt()
        .Include(x => x.Driver)
        .OrderByDescending(x => x.DateOfIssue)
        .ToReadOnlyCollectionAsync(cancellationToken);

        foreach (var license in licenses)
        {
            if (license != null)
            {
                var activeCategories = await reader.Read<LicenseCategory>()
                    .NotDeletedAt()
                    .Where(o => o.DriverLicenseId == license!.Id)
                    .Include(o => o.TransportCategory)
                    .ToListAsync(cancellationToken);

                license.LicenseCategories = activeCategories;
            }
        }

        return licenses;
    }
}