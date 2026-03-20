using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services
{
    public class ViolationService : IViolationService
    {
        private readonly IViolationReadRepository violationReadRepository;
        private readonly IViolationWriteRepository violationWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public ViolationService(IViolationReadRepository violationReadRepository,
            IViolationWriteRepository violationWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.violationReadRepository = violationReadRepository;
            this.violationWriteRepository = violationWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<Violation> IBaseService<Violation, ViolationCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await violationReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти нарушение с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<Violation>> IBaseService<Violation, ViolationCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await violationReadRepository.GetAll(cancellationToken);
        }

        async Task<Violation> IBaseService<Violation, ViolationCreateModel>.Create(ViolationCreateModel model, CancellationToken cancellationToken)
        {
            await violationReadRepository.IsViolationCodeExists(model.Name.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Нарушение с кодом {model.ViolationCode} уже существует"));

            var violation = new Violation
            {
                ViolationCode = model.ViolationCode.Trim(),
                Name = model.Name.Trim(),
                Description = model.Description,
                MinFinePrice = model.MinFinePrice,
                MaxFinePrice = model.MaxFinePrice,
            };

            violationWriteRepository.Add(violation);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return violation;
        }

        async Task<Violation> IBaseService<Violation, ViolationCreateModel>.Update(Guid id, ViolationCreateModel model, CancellationToken cancellationToken)
        {
            var violation = await violationReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти нарушение с идентификатором {id}"));

            violation!.ViolationCode = model.ViolationCode.Trim();
            violation.Name = model.Name.Trim();
            violation.Description = model.Description;
            violation.MinFinePrice = model.MinFinePrice;
            violation.MaxFinePrice = model.MaxFinePrice;

            violationWriteRepository.Update(violation);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return violation;
        }

        async Task IBaseService<Violation, ViolationCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var violation = await violationReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти нарушение с идентификатором {id}"));

            violationWriteRepository.Delete(violation!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}