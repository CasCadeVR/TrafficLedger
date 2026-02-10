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
    public class TransportService : ITransportService
    {
        private readonly ITransportReadRepository transportReadRepository;
        private readonly ITransportWriteRepository transportWriteRepository;
        private readonly ITransportCategoryReadRepository transportCategoryReadRepository;
        private readonly IOwnershipWriteRepository ownershipWriteRepository;
        private readonly IDriverReadRepository driverReadRepository;
        private readonly IUnitOfWork unitOfWork;

        public TransportService(ITransportReadRepository transportReadRepository,
            ITransportWriteRepository transportWriteRepository,
            ITransportCategoryReadRepository transportCategoryReadRepository,
            IOwnershipWriteRepository ownershipWriteRepository,
            IDriverReadRepository driverReadRepository,
            IUnitOfWork unitOfWork)
        {
            this.transportReadRepository = transportReadRepository;
            this.transportWriteRepository = transportWriteRepository;
            this.transportCategoryReadRepository = transportCategoryReadRepository;
            this.ownershipWriteRepository = ownershipWriteRepository;
            this.driverReadRepository = driverReadRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<IReadOnlyCollection<Transport>> ITransportService.GetAllByDriverId(Guid driverId, CancellationToken cancellationToken)
        {
            await driverReadRepository.GetById(driverId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти водителя с идентификатором {driverId}"));

            return await transportReadRepository.GetAllByDriverId(driverId, cancellationToken);
        }

        async Task<Transport> ITransportService.GetByTransportCode(string transportCode, CancellationToken cancellationToken)
        {
            var result = await transportReadRepository.GetByTransportCode(transportCode, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с кодом {transportCode}"));

            return result!;
        }

        async Task<Transport> IBaseService<Transport, TransportCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await transportReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<Transport>> IBaseService<Transport, TransportCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await transportReadRepository.GetAll(cancellationToken);
        }

        async Task<Transport> IBaseService<Transport, TransportCreateModel>.Create(TransportCreateModel model, CancellationToken cancellationToken)
        {
            await transportReadRepository.IsCodeExists(model.TransportCode.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Транспорт с кодом {model.TransportCode} уже существует"));

            var category = await transportCategoryReadRepository.GetById(model.TransportCategoryId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Категория транспорта с id {model.TransportCategoryId} не существует"));

            await ValidateMissingDrivers(model, cancellationToken);

            var transport = new Transport
            {
                TransportCode = model.TransportCode.Trim(),
                Brand = model.Brand.Trim(),
                MileAge = model.MileAge,
                Model = model.Model.Trim(),
                Region = model.Region.Trim(),
                Year = model.Year,
                TransportCategoryId = category!.Id,
            };

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

            transportWriteRepository.Add(transport);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return transport;
        }

        async Task<Transport> IBaseService<Transport, TransportCreateModel>.Update(Guid id, TransportCreateModel model, CancellationToken cancellationToken)
        {
            var existingTransport = await transportReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {id}"));

            var existingCategory = await transportCategoryReadRepository.GetById(model.TransportCategoryId, cancellationToken)
              .OrThrowIfNull(() => new InvalidOperationException($"Категория транспорта с id {model.TransportCategoryId} не существует"));

            await ValidateMissingDrivers(model, cancellationToken);

            var modelOwnerships = model.Ownerships.Select(x =>
                new Ownership()
                {
                    Date = x.Date,
                    TransportId = existingTransport!.Id,
                    DriverId = x.DriverId,
                }).ToList();

            existingTransport!.TransportCode = model.TransportCode.Trim();
            existingTransport.Brand = model.Brand.Trim();
            existingTransport.MileAge = model.MileAge;
            existingTransport.Model = model.Model.Trim();
            existingTransport.Region = model.Region.Trim();
            existingTransport.Year = model.Year;
            existingTransport.TransportCategoryId = model.TransportCategoryId;
            existingTransport.TransportCategory = existingCategory!;

            var existingOwnerships = existingTransport.Ownerships;
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
                    ownership.DriverId = existingTransport.Id;
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

            transportWriteRepository.Delete(existingTransport);
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