using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Typing;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverReadRepository driverReadRepository;
        private readonly IDriverWriteRepository driverWriteRepository;
        private readonly IOwnershipWriteRepository ownershipWriteRepository;
        private readonly ITransportReadRepository transportReadRepository;
        private readonly IUserReadRepository userReadRepository;
        private readonly IAttachmentReadRepository attachmentReadRepository;
        private readonly IAttachmentWriteRepository attachmentWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public DriverService(IDriverReadRepository driverReadRepository,
            IDriverWriteRepository driverWriteRepository,
            IOwnershipWriteRepository ownershipWriteRepository,
            ITransportReadRepository transportReadRepository,
            IUserReadRepository userReadRepository,
            IAttachmentReadRepository attachmentReadRepository,
            IAttachmentWriteRepository attachmentWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.driverReadRepository = driverReadRepository;
            this.driverWriteRepository = driverWriteRepository;
            this.ownershipWriteRepository = ownershipWriteRepository;
            this.transportReadRepository = transportReadRepository;
            this.userReadRepository = userReadRepository;
            this.attachmentReadRepository = attachmentReadRepository;
            this.attachmentWriteRepository = attachmentWriteRepository;
            this.unitOfWork = unitOfWork;
        }


        /// <summary>
        /// Получает <see cref="Driver"/> по идентификатору пользователя
        /// </summary>
        async Task<Driver> IDriverService.GetByUserId(Guid userId, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(userId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {userId}"));

            var result = await driverReadRepository.GetByUserId(userId, cancellationToken);

            if (result != null)
            {
                result.Attachment = await attachmentReadRepository.GetByEntityId(result.Id, EntityTypes.DriverType, cancellationToken);
            }

            return result!;
        }

        async Task<Driver> IBaseService<Driver, DriverCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await driverReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {id}"));

            result!.Attachment = await attachmentReadRepository.GetByEntityId(result.Id, EntityTypes.DriverType, cancellationToken);

            return result!;
        }

        async Task<IReadOnlyCollection<Driver>> IBaseService<Driver, DriverCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            var existingList = await driverReadRepository.GetAll(cancellationToken);

            foreach (var entity in existingList)
            {
                entity.Attachment = await attachmentReadRepository.GetByEntityId(entity.Id, EntityTypes.DriverType, cancellationToken);
            }

            return existingList;
        }

        async Task<Driver> IBaseService<Driver, DriverCreateModel>.Create(DriverCreateModel model, CancellationToken cancellationToken)
        {
            var user = await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {model.UserId}"));

            var existingDriver = await driverReadRepository.GetByUserId(model.UserId, cancellationToken);

            if (existingDriver != null)
            {
                throw new InvalidOperationException($"У пользователя с ID {model.UserId} уже есть водитель");
            }

            await ValidateMissingTransport(model, cancellationToken);

            var driver = new Driver
            {
                FullName = model.FullName.Trim(),
                BirthDate = model.BirthDate,
                BirthPlace = model.BirthPlace,
                UserId = model.UserId
            };

            if (model.Attachment != null)
            {
                var attachment = new Attachment()
                {
                    EntityId = driver.Id,
                    EntityType = EntityTypes.DriverType,
                    FileName = model.Attachment.FileName,
                    ContentType = model.Attachment.ContentType,
                    Content = model.Attachment.Content,
                };

                attachmentWriteRepository.Add(attachment);
                await unitOfWork.SaveChangesAsync(cancellationToken);
                var response = await attachmentReadRepository.GetByEntityId(driver.Id, EntityTypes.DriverType, cancellationToken)
                    .OrThrowIfNull(() => new InvalidOperationException($"Не сохранить фотографию для водителя с именем {model.FullName}"));
                
                driver.AttachmentId = response!.Id;
            }

            var modelOwnerships = model.Ownerships.Select(x =>
                new Ownership()
                { 
                    Date = x.Date,
                    TransportId = x.TransportId,
                    DriverId = driver.Id,
                }).ToList();

            foreach (var ownership in modelOwnerships)
            {
                ownershipWriteRepository.Add(ownership);
            }

            driverWriteRepository.Add(driver);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return driver;
        }

        async Task<Driver> IBaseService<Driver, DriverCreateModel>.Update(Guid id, DriverCreateModel model, CancellationToken cancellationToken)
        {
            var existingDriver = await driverReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {id}"));

            var user = await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {model.UserId}"));

            var previousAttachment = await attachmentReadRepository.GetByEntityId(id, EntityTypes.DriverType, cancellationToken);

            if (previousAttachment != null)
            {
                if (model.Attachment == null)
                {
                    attachmentWriteRepository.Delete(previousAttachment);
                } 
                else
                {
                    previousAttachment.EntityId = model.Attachment!.EntityId;
                    previousAttachment.EntityType = model.Attachment!.EntityType;
                    previousAttachment.FileName = model.Attachment!.FileName;
                    previousAttachment.Content = model.Attachment!.Content;
                    previousAttachment.ContentType = model.Attachment!.ContentType;

                    attachmentWriteRepository.Update(previousAttachment);
                }
            }

            await ValidateMissingTransport(model, cancellationToken);

            var modelOwnerships = model.Ownerships.Select(x =>
                new Ownership()
                {
                    Date = x.Date,
                    TransportId = x.TransportId,
                    DriverId = existingDriver!.Id,
                }).ToList();

            existingDriver!.FullName = model.FullName.Trim();
            existingDriver.BirthDate = model.BirthDate;
            existingDriver.BirthPlace = model.BirthPlace;
            existingDriver.UserId = model.UserId;

            var existingOwnerships = existingDriver.Ownerships;
            var existingOwnershipsDictionary = existingOwnerships.ToDictionary(x => x.TransportId);

            foreach (var ownership in modelOwnerships)
            {
                if (existingOwnershipsDictionary.TryGetValue(ownership.TransportId, out var foundOwnership))
                {
                    foundOwnership.Date = ownership.Date;
                    foundOwnership.TransportId = ownership.TransportId;
                    ownershipWriteRepository.Update(foundOwnership);
                }
                else
                {
                    ownership.DriverId = existingDriver.Id;
                    ownershipWriteRepository.Add(ownership);
                }
            }

            var ownershipsIdsToDelete = existingOwnerships.Select(x => x.TransportId).Except(modelOwnerships.Select(x => x.TransportId)).ToList();

            foreach (var ownershipId in ownershipsIdsToDelete)
            {
                if (existingOwnershipsDictionary.TryGetValue(ownershipId, out var foundOwnership))
                {
                    ownershipWriteRepository.Delete(foundOwnership);
                }
            }

            driverWriteRepository.Update(existingDriver);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return existingDriver;
        }

        async Task IBaseService<Driver, DriverCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var existingDriver = await driverReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {id}"));

            var existingOwnerships = existingDriver!.Ownerships;

            foreach (var existingOwnership in existingOwnerships)
            {
                ownershipWriteRepository.Delete(existingOwnership);
            }

            var previousAttachment = await attachmentReadRepository.GetByEntityId(id, EntityTypes.DriverType, cancellationToken);

            if (previousAttachment != null)
            {
                attachmentWriteRepository.Delete(previousAttachment);
            }

            driverWriteRepository.Delete(existingDriver);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        private async Task ValidateMissingTransport(DriverCreateModel model, CancellationToken cancellationToken)
        {
            var modelTransportIds = model.Ownerships.Select(x => x.TransportId).ToList();

            var existingTransports = await transportReadRepository.GetByIds(modelTransportIds, cancellationToken);

            var transportIdsInDatabase = existingTransports.Select(x => x.Id);

            var missingIds = modelTransportIds.Except(transportIdsInDatabase).ToList();

            if (missingIds.Count > 0)
            {
                throw new InvalidOperationException($"Не удалось найти транспорты с идентификаторами: {string.Join(", ", missingIds)}");
            }
        }
    }
}