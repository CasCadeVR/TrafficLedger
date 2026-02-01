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

        async Task<Violation> IBaseService<Violation, ViolationRequest>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await violationReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти нарушение с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<Violation>> IBaseService<Violation, ViolationRequest>.GetAll(CancellationToken cancellationToken)
        {
            return await violationReadRepository.GetAll(cancellationToken);
        }

        async Task<Violation> IBaseService<Violation, ViolationRequest>.Create(ViolationRequest model, CancellationToken cancellationToken)
        {
            await violationReadRepository.IsViolationCodeExists(model.Name.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Нарушение с кодом {model.ViolationCode} уже существует"));

            var violation = new Violation
            {
                ViolationCode = model.ViolationCode.Trim(),
                Name = model.Name.Trim(),
                Description = model.Description,
                FinePrice = model.FinePrice,
            };

            violationWriteRepository.Add(violation);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return violation;
        }

        async Task<Violation> IBaseService<Violation, ViolationRequest>.Update(Guid id, ViolationRequest model, CancellationToken cancellationToken)
        {
            var violation = await violationReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти нарушение с идентификатором {id}"));

            violation!.ViolationCode = model.ViolationCode.Trim();
            violation.Name = model.Name.Trim();
            violation.Description = model.Description;
            violation.FinePrice = model.FinePrice;

            violationWriteRepository.Update(violation);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return violation;
        }

        async Task IBaseService<Violation, ViolationRequest>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var violation = await violationReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти нарушение с идентификатором {id}"));

            violationWriteRepository.Delete(violation!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}