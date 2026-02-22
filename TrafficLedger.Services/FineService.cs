using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Entities.Typing;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models.Fines;

namespace TrafficLedger.Services
{
    public class FineService : IFineService
    {
        private readonly IFineReadRepository fineReadRepository;
        private readonly IFineWriteRepository fineWriteRepository;
        private readonly ITransportReadRepository transportReadRepository;
        private readonly IViolationReadRepository violationReadRepository;
        private readonly IAttachmentReadRepository attachmentReadRepository;
        private readonly IAttachmentWriteRepository attachmentWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public FineService(IFineReadRepository fineReadRepository,
            IFineWriteRepository fineWriteRepository,
            ITransportReadRepository transportReadRepository,
            IViolationReadRepository violationReadRepository,
            IAttachmentReadRepository attachmentReadRepository,
            IAttachmentWriteRepository attachmentWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.fineReadRepository = fineReadRepository;
            this.fineWriteRepository = fineWriteRepository;
            this.transportReadRepository = transportReadRepository;
            this.violationReadRepository = violationReadRepository;
            this.attachmentReadRepository = attachmentReadRepository;
            this.attachmentWriteRepository = attachmentWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<IReadOnlyCollection<Fine>> IFineService.GetAllByTransportId(Guid transportId, CancellationToken cancellationToken)
        {
            await transportReadRepository.GetById(transportId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {transportId}"));

            var existingList = await fineReadRepository.GetAllByTransportId(transportId, cancellationToken);

            foreach (var entity in existingList)
            {
                var foundAttachments = await attachmentReadRepository.GetAllByEntityId(entity.Id, EntityTypes.FineType, cancellationToken);
                entity.Attachments = foundAttachments.ToList();
            }

            return existingList;
        }

        async Task<Fine> IBaseService<Fine, FineCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await fineReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти штраф с идентификатором {id}"));

            var foundAttachments = await attachmentReadRepository.GetAllByEntityId(result!.Id, EntityTypes.FineType, cancellationToken);
            result.Attachments = foundAttachments.ToList();

            return result!;
        }

        async Task<IReadOnlyCollection<Fine>> IBaseService<Fine, FineCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            var existingList = await fineReadRepository.GetAll(cancellationToken);

            foreach (var entity in existingList)
            {
                var foundAttachments = await attachmentReadRepository.GetAllByEntityId(entity.Id, EntityTypes.FineType, cancellationToken);
                entity.Attachments = foundAttachments.ToList();
            }

            return existingList;
        }

        async Task<Fine> IBaseService<Fine, FineCreateModel>.Create(FineCreateModel model, CancellationToken cancellationToken)
        {
            await transportReadRepository.GetById(model.TransportId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Транспорт с id {model.TransportId} не существует"));

            await violationReadRepository.GetById(model.ViolationId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Нарушение с id {model.ViolationId} не существует"));

            var fine = new Fine
            {
                Date = model.Date,
                Address = model.Address,
                Description = model.Description,
                Status = RequestStatus.Pending,
                TransportId = model.TransportId,
                ViolationId = model.ViolationId,
            };

            var modelAttachments = model.Attachments.Select(x =>
                new Attachment()
                {
                    EntityId = fine.Id,
                    EntityType = EntityTypes.FineType,
                    FileName = x.FileName,
                    ContentType = x.ContentType,
                    Content = x.Content,
                }).ToList();

            foreach (var attachment in modelAttachments)
            {
                attachmentWriteRepository.Add(attachment);
            }

            fineWriteRepository.Add(fine);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return fine;
        }

        async Task<Fine> IBaseService<Fine, FineCreateModel>.Update(Guid id, FineCreateModel model, CancellationToken cancellationToken)
        {
            var existingFine = await fineReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти штраф с идентификатором {id}"));

            var transport = await transportReadRepository.GetById(model.TransportId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Транспорт с id {model.TransportId} не существует"));

            var violation = await violationReadRepository.GetById(model.ViolationId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Нарушение с id {model.ViolationId} не существует"));

            existingFine!.Date = model.Date;
            existingFine.Status = model.Status;
            existingFine.Address = model.Address;
            existingFine.Description = model.Description;
            existingFine.TransportId = model.TransportId;
            existingFine.ViolationId = model.ViolationId;

            var modelAttachments = model.Attachments.Select(x =>
               new Attachment()
               {
                   EntityId = existingFine!.Id,
                   EntityType = EntityTypes.FineType,
                   FileName = x.FileName,
                   ContentType = x.ContentType,
                   Content = x.Content,
               }).ToList();

            var existingAttachments = existingFine.Attachments;
            var existingAttachmentsDictionary = existingAttachments.ToDictionary(x => x.FileName);

            foreach (var attachment in modelAttachments)
            {
                if (existingAttachmentsDictionary.TryGetValue(attachment.FileName, out var foundAttachment))
                {
                    foundAttachment.EntityId = attachment.EntityId;
                    foundAttachment.EntityType = attachment.EntityType;
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

            var attachmentsFileNamesToDelete = existingAttachments.Select(x => x.FileName).Except(modelAttachments.Select(x => x.FileName)).ToList();

            foreach (var attachmentFileName in attachmentsFileNamesToDelete)
            {
                if (existingAttachmentsDictionary.TryGetValue(attachmentFileName, out var foundAttachment))
                {
                    attachmentWriteRepository.Delete(foundAttachment);
                }
            }

            fineWriteRepository.Update(existingFine);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return existingFine;
        }

        async Task IBaseService<Fine, FineCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var fine = await fineReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти штраф с идентификатором {id}"));

            var previousAttachments = await attachmentReadRepository.GetAllByEntityId(id, EntityTypes.FineType, cancellationToken);

            foreach (var existingAttachment in previousAttachments)
            {
                attachmentWriteRepository.Delete(existingAttachment);
            }

            fineWriteRepository.Delete(fine);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}