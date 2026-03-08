using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Entities.Typing;
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
        private readonly IUserReadRepository userReadRepository;
        private readonly ILicenseCategoryWriteRepository licenseCategoryWriteRepository;
        private readonly IAttachmentReadRepository attachmentReadRepository;
        private readonly IAttachmentWriteRepository attachmentWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverLicenseService(IDriverLicenseReadRepository driverLicenseReadRepository,
            IDriverLicenseWriteRepository driverLicenseWriteRepository,
            IDriverReadRepository driverReadRepository,
            ITransportCategoryReadRepository transportCategoryReadRepository,
            IUserReadRepository userReadRepository,
            ILicenseCategoryWriteRepository licenseCategoryWriteRepository,
            IAttachmentReadRepository attachmentReadRepository,
            IAttachmentWriteRepository attachmentWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.driverLicenseReadRepository = driverLicenseReadRepository;
            this.driverLicenseWriteRepository = driverLicenseWriteRepository;
            this.driverReadRepository = driverReadRepository;
            this.transportCategoryReadRepository = transportCategoryReadRepository;
            this.userReadRepository = userReadRepository;
            this.licenseCategoryWriteRepository = licenseCategoryWriteRepository;
            this.attachmentReadRepository = attachmentReadRepository;
            this.attachmentWriteRepository = attachmentWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<DriverLicense> IDriverLicenseService.GetByDriverId(Guid driverId, CancellationToken cancellationToken)
        {
            var driver = await driverReadRepository.GetById(driverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Вам нужно сперва заполнить данные водителя"));

            var result = await driverLicenseReadRepository.GetByDriverId(driver!.Id, cancellationToken);

            if (result != null)
            {
                result.Attachment = await attachmentReadRepository.GetByEntityId(result.Id, EntityTypes.DriverLicenseType, cancellationToken);
            }

            return result!;
        }

        async Task<DriverLicense> IBaseService<DriverLicense, DriverLicenseCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            result!.Attachment = await attachmentReadRepository.GetByEntityId(result.Id, EntityTypes.DriverLicenseType, cancellationToken);

            return result!;
        }

        async Task<IReadOnlyCollection<DriverLicense>> IBaseService<DriverLicense, DriverLicenseCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            var existingList = await driverLicenseReadRepository.GetAll(cancellationToken);

            foreach (var entity in existingList)
            {
                entity.Attachment = await attachmentReadRepository.GetByEntityId(entity.Id, EntityTypes.DriverLicenseType, cancellationToken);
            }

            return existingList;
        }

        async Task<DriverLicense> IBaseService<DriverLicense, DriverLicenseCreateModel>.Create(DriverLicenseCreateModel model, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {model.UserId}"));

            await driverLicenseReadRepository.IsLicenseNumberExists(model.LicenseNumber.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Водительское удостоверение с номером {model.LicenseNumber} уже существует"));

            await driverReadRepository.GetById(model.DriverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Вам нужно сперва заполнить данные водителя"));

            await ValidateMissingCategories(model, cancellationToken);

            var driverLicense = new DriverLicense
            {
                LicenseNumber = model.LicenseNumber.Trim(),
                DateOfIssue = model.DateOfIssue,
                IssuedBy = model.IssuedBy.Trim(),
                Residence = model.Residence.Trim(),
                Status = RequestStatus.Pending,
                UserId = model.UserId,
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

            if (model.Attachment != null)
            {
                var attachment = new Attachment()
                {
                    EntityId = driverLicense.Id,
                    EntityType = EntityTypes.DriverLicenseType,
                    FileName = model.Attachment.FileName,
                    ContentType = model.Attachment.ContentType,
                    Content = model.Attachment.Content,
                };

                driverLicense.AttachmentId = attachment.Id;
                attachmentWriteRepository.Add(attachment);
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

            await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {model.UserId}"));

            await driverReadRepository.GetById(model.DriverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {model.DriverId}, Вам нужно сперва заполнить данные водителя"));

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
            existingDriverLicense.Status = RequestStatus.Pending;
            existingDriverLicense.UserId = model.UserId;
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

            var previousAttachment = await attachmentReadRepository.GetByEntityId(id, EntityTypes.DriverLicenseType, cancellationToken);

            if (previousAttachment != null)
            {
                if (model.Attachment == null)
                {
                    attachmentWriteRepository.Delete(previousAttachment);
                }
                else
                {
                    previousAttachment.EntityId = existingDriverLicense.Id;
                    previousAttachment.EntityType = EntityTypes.DriverLicenseType;
                    previousAttachment.FileName = model.Attachment!.FileName;
                    previousAttachment.Content = model.Attachment!.Content;
                    previousAttachment.ContentType = model.Attachment!.ContentType;

                    attachmentWriteRepository.Update(previousAttachment);
                }
            }
            else if (model.Attachment != null)
            {
                var attachment = new Attachment()
                {
                    EntityId = existingDriverLicense!.Id,
                    EntityType = EntityTypes.DriverLicenseType,
                    FileName = model.Attachment!.FileName,
                    ContentType = model.Attachment.ContentType,
                    Content = model.Attachment.Content,
                };

                existingDriverLicense.AttachmentId = attachment.Id;
                attachmentWriteRepository.Add(attachment);
            }

            driverLicenseWriteRepository.Update(existingDriverLicense);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return existingDriverLicense;
        }

        async Task IBaseService<DriverLicense, DriverLicenseCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var existingDriverLicense = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            var previousAttachment = await attachmentReadRepository.GetByEntityId(id, EntityTypes.DriverType, cancellationToken);

            if (previousAttachment != null)
            {
                attachmentWriteRepository.Delete(previousAttachment);
            }

            driverLicenseWriteRepository.Delete(existingDriverLicense!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IRequestedService<DriverLicense, DriverLicenseCreateModel>.Approve(Guid id, Guid processedById, CancellationToken cancellationToken)
        {
            var existingDriverLicense = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            await userReadRepository.GetById(processedById, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя одобряющего с идентификатором {processedById}"));

            existingDriverLicense!.Status = RequestStatus.Approved;
            existingDriverLicense.ProcessedById = processedById;
            existingDriverLicense.ProcessedAt = DateTime.Now;

            driverLicenseWriteRepository.Update(existingDriverLicense);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IRequestedService<DriverLicense, DriverLicenseCreateModel>.Reject(Guid id, Guid processedById, string commentary, CancellationToken cancellationToken)
        {
            var existingDriverLicense = await driverLicenseReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водительское удостоверение с идентификатором {id}"));

            await userReadRepository.GetById(processedById, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя одобряющего с идентификатором {processedById}"));

            existingDriverLicense!.Status = RequestStatus.Rejected;
            existingDriverLicense.ProcessedById = processedById;
            existingDriverLicense.ProcessedAt = DateTime.Now;
            existingDriverLicense.Commentary = commentary;

            driverLicenseWriteRepository.Update(existingDriverLicense);
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