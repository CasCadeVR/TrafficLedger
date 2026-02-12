using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
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
        private readonly IUnitOfWork unitOfWork;

        public FineService(IFineReadRepository fineReadRepository,
            IFineWriteRepository fineWriteRepository,
            ITransportReadRepository transportReadRepository,
            IViolationReadRepository violationReadRepository,
            IUnitOfWork unitOfWork)
        {
            this.fineReadRepository = fineReadRepository;
            this.fineWriteRepository = fineWriteRepository;
            this.transportReadRepository = transportReadRepository;
            this.violationReadRepository = violationReadRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<IReadOnlyCollection<Fine>> IFineService.GetAllByTransportId(Guid transportId, CancellationToken cancellationToken)
        {
            await transportReadRepository.GetById(transportId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {transportId}"));

            return await fineReadRepository.GetAllByTransportId(transportId, cancellationToken);
        }

        async Task<Fine> IBaseService<Fine, FineCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await fineReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти штраф с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<Fine>> IBaseService<Fine, FineCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await fineReadRepository.GetAll(cancellationToken);
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

            fineWriteRepository.Add(fine);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return fine;
        }

        async Task<Fine> IBaseService<Fine, FineCreateModel>.Update(Guid id, FineCreateModel model, CancellationToken cancellationToken)
        {
            var fine = await fineReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти штраф с идентификатором {id}"));

            var transport = await transportReadRepository.GetById(model.TransportId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Транспорт с id {model.TransportId} не существует"));

            var violation = await violationReadRepository.GetById(model.ViolationId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Нарушение с id {model.ViolationId} не существует"));

            fine!.Date = model.Date;
            fine.Status = model.Status;
            fine.Address = model.Address;
            fine.Description = model.Description;
            fine.TransportId = model.TransportId;
            fine.ViolationId = model.ViolationId;

            fineWriteRepository.Update(fine);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return fine;
        }

        async Task IBaseService<Fine, FineCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var fine = await fineReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти штраф с идентификатором {id}"));

            fine!.Status = RequestStatus.Rejected;

            fineWriteRepository.Delete(fine);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}