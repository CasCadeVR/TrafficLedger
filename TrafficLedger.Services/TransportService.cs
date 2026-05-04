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
    public class TransportService : ITransportService
    {
        private readonly ITransportReadRepository transportReadRepository;
        private readonly ITransportWriteRepository transportWriteRepository;
        private readonly ITransportCategoryReadRepository transportCategoryReadRepository;
        private readonly IUserReadRepository userReadRepository;
        private readonly IOwnershipWriteRepository ownershipWriteRepository;
        private readonly IDriverReadRepository driverReadRepository;
        private readonly IDriverLicenseReadRepository driverLicenseReadRepository;
        private readonly IAttachmentReadRepository attachmentReadRepository;
        private readonly IAttachmentWriteRepository attachmentWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public TransportService(ITransportReadRepository transportReadRepository,
            ITransportWriteRepository transportWriteRepository,
            ITransportCategoryReadRepository transportCategoryReadRepository,
            IUserReadRepository userReadRepository,
            IOwnershipWriteRepository ownershipWriteRepository,
            IDriverReadRepository driverReadRepository,
            IDriverLicenseReadRepository driverLicenseReadRepository,
            IAttachmentReadRepository attachmentReadRepository,
            IAttachmentWriteRepository attachmentWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.transportReadRepository = transportReadRepository;
            this.transportWriteRepository = transportWriteRepository;
            this.transportCategoryReadRepository = transportCategoryReadRepository;
            this.userReadRepository = userReadRepository;
            this.ownershipWriteRepository = ownershipWriteRepository;
            this.driverReadRepository = driverReadRepository;
            this.driverLicenseReadRepository = driverLicenseReadRepository;
            this.attachmentReadRepository = attachmentReadRepository;
            this.attachmentWriteRepository = attachmentWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<IReadOnlyCollection<Transport>> ITransportService.GetAllByDriverId(Guid driverId, CancellationToken cancellationToken)
        {
            await driverReadRepository.GetById(driverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Вам нужно сперва заполнить данные водителя"));

            var existingList = await transportReadRepository.GetAllByDriverId(driverId, cancellationToken);

            foreach (var entity in existingList)
            {
                var foundAttachments = await attachmentReadRepository.GetAllByEntityId(entity.Id, EntityTypes.TransportType, cancellationToken);
                entity.Attachments = foundAttachments.ToList();
            }

            return existingList;
        }

        async Task<Transport> ITransportService.GetByTransportCode(string transportCode, CancellationToken cancellationToken)
        {
            var result = await transportReadRepository.GetByTransportCode(transportCode, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с кодом {transportCode}"));

            var foundAttachments = await attachmentReadRepository.GetAllByEntityId(result!.Id, EntityTypes.TransportType, cancellationToken);
            result.Attachments = foundAttachments.ToList();

            return result!;
        }

        async Task<Transport> IBaseService<Transport, TransportCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await transportReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            var foundAttachments = await attachmentReadRepository.GetAllByEntityId(result!.Id, EntityTypes.TransportType, cancellationToken);
            result.Attachments = foundAttachments.ToList();

            return result!;
        }

        async Task<IReadOnlyCollection<Transport>> IBaseService<Transport, TransportCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            var existingList = await transportReadRepository.GetAll(cancellationToken);

            foreach (var entity in existingList)
            {
                var foundAttachments = await attachmentReadRepository.GetAllByEntityId(entity.Id, EntityTypes.TransportType, cancellationToken);
                entity.Attachments = foundAttachments.ToList();
            }

            return existingList;
        }

        async Task<Transport> IBaseService<Transport, TransportCreateModel>.Create(TransportCreateModel model, CancellationToken cancellationToken)
        {
            var user = await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {model.UserId}"));

            var driver = await driverReadRepository.GetByUserId(user!.Id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException("Сперва заполните данные водителя"));

            var noLicenseErrorMessage = "Сперва заполните данные водительского удостоверения, отправьте заявку и ожидайте подтверждения";

            var license = await driverLicenseReadRepository.GetByDriverId(driver!.Id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException(noLicenseErrorMessage));

            await transportReadRepository.IsCodeExists(model.TransportCode.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Транспорт с кодом {model.TransportCode} уже существует"));

            var category = await transportCategoryReadRepository.GetById(model.TransportCategoryId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Категория транспорта с id {model.TransportCategoryId} не существует"));

            if (!license!.LicenseCategories.Select(x => x.TransportCategory.CategoryName).Contains(category!.CategoryName) && license.Status == RequestStatus.Approved)
            {
                throw new InvalidOperationException(noLicenseErrorMessage);
            }

            await ValidateMissingDrivers(model, cancellationToken);

            var transport = new Transport
            {
                TransportCode = model.TransportCode.Trim(),
                Brand = model.Brand.Trim(),
                MileAge = model.MileAge,
                Model = model.Model.Trim(),
                Region = model.Region.Trim(),
                Year = model.Year,
                Status = RequestStatus.Pending,
                UserId = model.UserId,
                TransportCategoryId = category!.Id,
            };

            if (user!.Role == Role.Admin)
            {
                transport.Status = RequestStatus.Approved;
            }

            var modelOwnerships = model.Ownerships.Select(x =>
                new Ownership()
                {
                    Date = x.Date,
                    TransportId = transport.Id,
                    DriverId = x.DriverId,
                }).ToList();

            foreach (var ownership in modelOwnerships)
            {
                ownershipWriteRepository.Add(ownership);
            }

            var modelAttachments = model.Attachments.Select(x =>
                new Attachment()
                {
                    EntityId = transport.Id,
                    EntityType = EntityTypes.TransportType,
                    FileName = x.FileName,
                    ContentType = x.ContentType,
                    Content = x.Content,
                }).ToList();

            foreach (var attachment in modelAttachments)
            {
                attachmentWriteRepository.Add(attachment);
            }

            transportWriteRepository.Add(transport);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return transport;
        }

        async Task<Transport> IBaseService<Transport, TransportCreateModel>.Update(Guid id, TransportCreateModel model, CancellationToken cancellationToken)
        {
            var existingTransport = await transportReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            await transportCategoryReadRepository.GetById(model.TransportCategoryId, cancellationToken)
              .OrThrowIfNull(() => new InvalidOperationException($"Категория транспорта с id {model.TransportCategoryId} не существует"));

            await ValidateMissingDrivers(model, cancellationToken);

            existingTransport!.TransportCode = model.TransportCode.Trim();
            existingTransport.Brand = model.Brand.Trim();
            existingTransport.MileAge = model.MileAge;
            existingTransport.Model = model.Model.Trim();
            existingTransport.Region = model.Region.Trim();
            existingTransport.Year = model.Year;
            existingTransport.Status = RequestStatus.Pending;
            existingTransport.UserId = model.UserId;
            existingTransport.TransportCategoryId = model.TransportCategoryId;

            var existingOwnerships = existingTransport.Ownerships;
            var existingOwnershipsDictionary = existingOwnerships.ToDictionary(x => x.DriverId);

            var modelOwnerships = model.Ownerships.Select(x =>
               new Ownership()
               {
                   Date = x.Date,
                   TransportId = existingTransport!.Id,
                   DriverId = x.DriverId,
               }).ToList();

            foreach (var ownership in modelOwnerships)
            {
                if (existingOwnershipsDictionary.TryGetValue(ownership.DriverId, out var foundOwnership))
                {
                    foundOwnership.Date = ownership.Date;
                    foundOwnership.DriverId = ownership.DriverId;
                    foundOwnership.TransportId = ownership.TransportId;
                    ownershipWriteRepository.Update(foundOwnership);
                }
                else
                {
                    ownership.DriverId = existingTransport.Id;
                    ownershipWriteRepository.Add(ownership);
                }
            }

            var ownershipsIdsToDelete = existingOwnerships.Select(x => x.DriverId).Except(modelOwnerships.Select(x => x.DriverId)).ToList();

            foreach (var ownershipId in ownershipsIdsToDelete)
            {
                if (existingOwnershipsDictionary.TryGetValue(ownershipId, out var foundOwnership))
                {
                    ownershipWriteRepository.Delete(foundOwnership);
                }
            }

            var modelAttachments = model.Attachments.Select(x =>
               new Attachment()
               {
                   EntityId = existingTransport!.Id,
                   EntityType = EntityTypes.TransportType,
                   FileName = x.FileName,
                   ContentType = x.ContentType,
                   Content = x.Content,
               }).ToList();

            var foundAttachments = await attachmentReadRepository.GetAllByEntityId(existingTransport!.Id, EntityTypes.TransportType, cancellationToken);
            existingTransport.Attachments = foundAttachments.ToList();

            var existingAttachments = existingTransport.Attachments;
            var existingAttachmentsDictionary = existingAttachments.ToDictionary(x => x.FileName);

            foreach (var attachment in modelAttachments)
            {
                if (existingAttachmentsDictionary.TryGetValue(attachment.FileName, out var foundAttachment))
                {
                    foundAttachment.EntityId = existingTransport.Id;
                    foundAttachment.EntityType = EntityTypes.TransportType;
                    foundAttachment.FileName = attachment.FileName;
                    foundAttachment.Content = attachment.Content;
                    foundAttachment.ContentType = attachment.ContentType;

                    attachmentWriteRepository.Update(foundAttachment);
                }
                else
                {
                    attachmentWriteRepository.Add(attachment);
                }
            }

            var attachmentsFileNamesToDelete = existingAttachments.Select(x => x.FileName)
                .Except(modelAttachments.Select(x => x.FileName)).ToList();

            foreach (var attachmentFileName in attachmentsFileNamesToDelete)
            {
                if (existingAttachmentsDictionary.TryGetValue(attachmentFileName, out var foundAttachment))
                {
                    attachmentWriteRepository.Delete(foundAttachment);
                }
            }

            transportWriteRepository.Update(existingTransport);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return existingTransport;
        }

        async Task IBaseService<Transport, TransportCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var existingTransport = await transportReadRepository.GetById(id, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            var existingOwnerships = existingTransport!.Ownerships;

            foreach (var existingOwnership in existingOwnerships)
            {
                ownershipWriteRepository.Delete(existingOwnership);
            }

            var previousAttachments = await attachmentReadRepository.GetAllByEntityId(id, EntityTypes.TransportType, cancellationToken);

            foreach (var existingAttachment in previousAttachments)
            {
                attachmentWriteRepository.Delete(existingAttachment);
            }

            transportWriteRepository.Delete(existingTransport);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IRequestedService<Transport, TransportCreateModel>.Approve(Guid id, Guid processedById, CancellationToken cancellationToken)
        {
            var transport = await transportReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            await userReadRepository.GetById(processedById, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя одобряющего с идентификатором {processedById}"));

            transport!.Status = RequestStatus.Approved;
            transport.ProcessedById = processedById;
            transport.ProcessedAt = DateTime.Now;

            transportWriteRepository.Update(transport);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IRequestedService<Transport, TransportCreateModel>.Reject(Guid id, Guid processedById, string commentary, CancellationToken cancellationToken)
        {
            var transport = await transportReadRepository.GetById(id, cancellationToken)
                 .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            await userReadRepository.GetById(processedById, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя одобряющего с идентификатором {processedById}"));

            transport!.Status = RequestStatus.Rejected;
            transport.ProcessedById = processedById;
            transport.Commentary = commentary;
            transport.ProcessedAt = DateTime.Now;

            transportWriteRepository.Update(transport);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        private async Task ValidateMissingDrivers(TransportCreateModel model, CancellationToken cancellationToken)
        {
            var modelDriverIds = model.Ownerships.Select(x => x.DriverId).ToList();

            var existingDrivers = await driverReadRepository.GetByIds(modelDriverIds, cancellationToken);

            var driverIdsInDatabase = existingDrivers.Select(x => x.Id);

            var missingIds = modelDriverIds.Except(driverIdsInDatabase).ToList();

            if (missingIds.Count > 0)
            {
                throw new InvalidOperationException($"Не удалось найти водителей с идентификаторами: {string.Join(", ", missingIds)}");
            }
        }
    }
}