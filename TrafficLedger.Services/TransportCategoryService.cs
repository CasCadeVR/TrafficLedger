using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services
{
    public class TransportCategoryService : ITransportCategoryService
    {
        private readonly ITransportCategoryReadRepository transportCategoryReadRepository;
        private readonly ITransportCategoryWriteRepository transportCategoryWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public TransportCategoryService(ITransportCategoryReadRepository transportCategoryReadRepository,
            ITransportCategoryWriteRepository transportCategoryWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.transportCategoryReadRepository = transportCategoryReadRepository;
            this.transportCategoryWriteRepository = transportCategoryWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<TransportCategory> IBaseService<TransportCategory, TransportCategoryCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await transportCategoryReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти категорию транспорта с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<TransportCategory>> IBaseService<TransportCategory, TransportCategoryCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await transportCategoryReadRepository.GetAll(cancellationToken);
        }

        async Task<TransportCategory> IBaseService<TransportCategory, TransportCategoryCreateModel>.Create(TransportCategoryCreateModel model, CancellationToken cancellationToken)
        {
            await transportCategoryReadRepository.IsNameExists(model.CategoryName.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Категорию транспорта с кодом {model.CategoryName} уже существует"));

            var category = new TransportCategory
            {
                CategoryName = model.CategoryName.Trim(),
                Description = model.Description,
            };

            transportCategoryWriteRepository.Add(category);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return category;
        }

        async Task<TransportCategory> IBaseService<TransportCategory, TransportCategoryCreateModel>.Update(Guid id, TransportCategoryCreateModel model, CancellationToken cancellationToken)
        {
            var category = await transportCategoryReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти категорию транспорта с идентификатором {id}"));

            category!.CategoryName = model.CategoryName.Trim();
            category.Description = model.Description;

            transportCategoryWriteRepository.Update(category);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return category;
        }

        async Task IBaseService<TransportCategory, TransportCategoryCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var category = await transportCategoryReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти категорию транспорта с идентификатором {id}"));

            transportCategoryWriteRepository.Delete(category!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}