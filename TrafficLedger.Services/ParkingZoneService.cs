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
    public class ParkingZoneService : IParkingZoneService
    {
        private readonly IParkingZoneReadRepository parkingZoneReadRepository;
        private readonly IParkingZoneWriteRepository parkingZoneWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public ParkingZoneService(IParkingZoneReadRepository parkingZoneReadRepository,
            IParkingZoneWriteRepository parkingZoneWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.parkingZoneReadRepository = parkingZoneReadRepository;
            this.parkingZoneWriteRepository = parkingZoneWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<ParkingZone> IBaseService<ParkingZone, ParkingZoneCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await parkingZoneReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти парковочное место с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<ParkingZone>> IBaseService<ParkingZone, ParkingZoneCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await parkingZoneReadRepository.GetAll(cancellationToken);
        }

        async Task<ParkingZone> IBaseService<ParkingZone, ParkingZoneCreateModel>.Create(ParkingZoneCreateModel model, CancellationToken cancellationToken)
        {
            if (model.Address == null && model.GeometryWkt == null)
            {
                throw new InvalidOperationException($"Парковочное место должно содержать либо адрес, либо координаты WKT");
            }

            if (model.Address != null)
            {
                await parkingZoneReadRepository.IsAddressExists(model.Address.ToLower(), cancellationToken)
                    .AndThrowIfTrue(() => new InvalidOperationException($"Парковочное место с адресом {model.Address} уже существует"));
            }

            var entity = new ParkingZone
            {
                Address = model.Address,
                GeometryWkt = model.GeometryWkt,
                HourlyRate = model.HourlyRate,
                IsActive = model.IsActive,
            };

            parkingZoneWriteRepository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return entity;
        }

        async Task<ParkingZone> IBaseService<ParkingZone, ParkingZoneCreateModel>.Update(Guid id, ParkingZoneCreateModel model, CancellationToken cancellationToken)
        {
            var existing = await parkingZoneReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти парковочное место с идентификатором {id}"));

            existing!.Address = model.Address;
            existing.GeometryWkt = model.GeometryWkt;
            existing.HourlyRate = model.HourlyRate;
            existing.IsActive = model.IsActive;

            parkingZoneWriteRepository.Update(existing);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return existing;
        }

        async Task IBaseService<ParkingZone, ParkingZoneCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var entity = await parkingZoneReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти парковочное место с идентификатором {id}"));

            parkingZoneWriteRepository.Delete(entity!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}