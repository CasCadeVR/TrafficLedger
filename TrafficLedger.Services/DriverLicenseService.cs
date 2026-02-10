using TrafficLedger.Common.Core;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services
{
    public class DriverLicenseService : IDriverLicenseService
    {
        private readonly IDriverLicenseReadRepository driverLicenseReadRepository;
        private readonly IDriverLicenseWriteRepository driverLicenseWriteRepository;
        private readonly IDriverReadRepository driverReadRepository;
        private readonly ITransportCategoryReadRepository transportCategoryReadRepository;
        private readonly ILicenseCategoryWriteRepository licenseCategoryWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverLicenseService(IDriverLicenseReadRepository driverLicenseReadRepository,
            IDriverLicenseWriteRepository driverLicenseWriteRepository,
            IDriverReadRepository driverReadRepository,
            ITransportCategoryReadRepository transportCategoryReadRepository,
            ILicenseCategoryWriteRepository licenseCategoryWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.driverLicenseReadRepository = driverLicenseReadRepository;
            this.driverLicenseWriteRepository = driverLicenseWriteRepository;
            this.driverReadRepository = driverReadRepository;
            this.transportCategoryReadRepository = transportCategoryReadRepository;
            this.licenseCategoryWriteRepository = licenseCategoryWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<DriverLicense> IDriverLicenseService.GetByDriverId(Guid driverId, CancellationToken cancellationToken)
        {
            var driver = await driverReadRepository.GetById(driverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {driverId}"));

            var result = await driverLicenseReadRepository.GetByDriverId(driver!.Id, cancellationToken);

            return result!;
        }

        async Task<DriverLicense> IBaseService<DriverLicense, DriverLicenseCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<DriverLicense>> IBaseService<DriverLicense, DriverLicenseCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await driverLicenseReadRepository.GetAll(cancellationToken);
        }

        async Task<DriverLicense> IBaseService<DriverLicense, DriverLicenseCreateModel>.Create(DriverLicenseCreateModel model, CancellationToken cancellationToken)
        {
            await driverLicenseReadRepository.IsLicenseNumberExists(model.LicenseNumber.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Водительское удостоверение с номером {model.LicenseNumber} уже существует"));

            await driverReadRepository.GetById(model.DriverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {model.DriverId}"));

            await ValidateMissingCategories(model, cancellationToken);

            var driverLicense = new DriverLicense
            {
                LicenseNumber = model.LicenseNumber.Trim(),
                DateOfIssue = model.DateOfIssue,
                IssuedBy = model.IssuedBy.Trim(),
                Residence = model.Residence.Trim(),
                DriverId = model.DriverId,
            };

            var modelCategories = model.LicenseCategories.Select(x =>
                new LicenseCategory()
                {
                    Date = x.Date,
                    TransportCategoryId = x.TransportCategoryId,
                    DriverLicenseId = driverLicense.Id,
                }).ToList();

            foreach (var ownership in modelCategories)
            {
                licenseCategoryWriteRepository.Add(ownership);
            }

            driverLicenseWriteRepository.Add(driverLicense);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return driverLicense;
        }

        async Task<DriverLicense> IBaseService<DriverLicense, DriverLicenseCreateModel>.Update(Guid id, DriverLicenseCreateModel model, CancellationToken cancellationToken)
        {
            var existingDriverLicense = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            var modelLicenseNumber = model.LicenseNumber.ToLower();

            if (modelLicenseNumber != existingDriverLicense!.LicenseNumber.ToLower())
            {
                await driverLicenseReadRepository.IsLicenseNumberExists(model.LicenseNumber.ToLower(), cancellationToken)
                   .AndThrowIfTrue(() => new InvalidOperationException($"Водительское удостоверение с номером {model.LicenseNumber} уже существует"));
            }

            await driverReadRepository.GetById(model.DriverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {model.DriverId}"));

            var modelCategories = model.LicenseCategories.Select(x =>
                new LicenseCategory()
                {
                    Date = x.Date,
                    TransportCategoryId = x.TransportCategoryId,
                    DriverLicenseId = existingDriverLicense.Id,
                }).ToList();

            existingDriverLicense.LicenseNumber = model.LicenseNumber.Trim();
            existingDriverLicense.DateOfIssue = model.DateOfIssue;
            existingDriverLicense.IssuedBy = model.IssuedBy.Trim();
            existingDriverLicense.Residence = model.Residence.Trim();
            existingDriverLicense.DriverId = model.DriverId;

            var existingLicenseCategories = existingDriverLicense.LicenseCategories;
            var existingLicenseCategoriesDictionary = existingLicenseCategories.ToDictionary(x => x.DriverLicenseId);

            foreach (var licenseCategory in modelCategories)
            {
                if (existingLicenseCategoriesDictionary.TryGetValue(licenseCategory.DriverLicenseId, out var foundLicenseCategory))
                {
                    foundLicenseCategory.Date = licenseCategory.Date;
                    foundLicenseCategory.DriverLicenseId = licenseCategory.DriverLicenseId;
                    licenseCategoryWriteRepository.Update(foundLicenseCategory);
                }
                else
                {
                    licenseCategory.DriverLicenseId = existingDriverLicense.Id;
                    licenseCategoryWriteRepository.Add(licenseCategory);
                }
            }

            var licenseCategoriesIdsToDelete = existingLicenseCategories.Select(x => x.DriverLicenseId)
                .Except(modelCategories.Select(x => x.DriverLicenseId)).ToList();

            foreach (var licenseCategoryId in licenseCategoriesIdsToDelete)
            {
                if (existingLicenseCategoriesDictionary.TryGetValue(licenseCategoryId, out var foundLicenseCategory))
                {
                    licenseCategoryWriteRepository.Delete(foundLicenseCategory);
                }
            }

            driverLicenseWriteRepository.Update(existingDriverLicense);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return existingDriverLicense;
        }

        async Task IBaseService<DriverLicense, DriverLicenseCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var existingDriverLicense = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            driverLicenseWriteRepository.Delete(existingDriverLicense!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        private async Task ValidateMissingCategories(DriverLicenseCreateModel model, CancellationToken cancellationToken)
        {
            var modelCategoriesIds = model.LicenseCategories.Select(x => x.TransportCategoryId).ToList();

            var existingCategories = await transportCategoryReadRepository.GetByIds(modelCategoriesIds, cancellationToken);

            var categoryIdsInDatabase = existingCategories.Select(x => x.Id);

            var missingIds = modelCategoriesIds.Except(categoryIdsInDatabase).ToList();

            if (missingIds.Count > 0)
            {
                throw new InvalidOperationException($"Не удалось найти категории транспортов с идентификаторами: {string.Join(", ", missingIds)}");
            }
        }
    }
}