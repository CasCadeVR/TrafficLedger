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
    public class ParkingSessionService : IParkingSessionService
    {
        private readonly IParkingSessionReadRepository parkingSessionReadRepository;
        private readonly IParkingSessionWriteRepository parkingSessionWriteRepository;
        private readonly ITransportReadRepository transportReadRepository;
        private readonly IUserReadRepository userReadRepository;
        private readonly IDriverReadRepository driverReadRepository;
        private readonly IParkingZoneReadRepository parkingZoneReadRepository;
        private readonly IUnitOfWork unitOfWork;

        public ParkingSessionService(IParkingSessionReadRepository parkingSessionReadRepository,
            IParkingSessionWriteRepository parkingSessionWriteRepository,
            ITransportReadRepository transportReadRepository,
            IUserReadRepository userReadRepository,
            IDriverReadRepository driverReadRepository,
            IParkingZoneReadRepository parkingZoneReadRepository,
            IUnitOfWork unitOfWork)
        {
            this.parkingSessionReadRepository = parkingSessionReadRepository;
            this.parkingSessionWriteRepository = parkingSessionWriteRepository;
            this.transportReadRepository = transportReadRepository;
            this.userReadRepository = userReadRepository;
            this.driverReadRepository = driverReadRepository;
            this.parkingZoneReadRepository = parkingZoneReadRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<IReadOnlyCollection<ParkingSession>> IParkingSessionService.GetAllByTransportId(Guid transportId, CancellationToken cancellationToken)
        {
            await transportReadRepository.GetById(transportId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти транспорт с идентификатором {transportId}"));

            return await parkingSessionReadRepository.GetAllByTransportId(transportId, cancellationToken);
        }

        async Task<IReadOnlyCollection<ParkingSession>> IParkingSessionService.GetAllByUserId(Guid userId, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(userId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {userId}"));

            return await parkingSessionReadRepository.GetAllByUserId(userId, cancellationToken);
        }

        async Task<ParkingSession> IBaseService<ParkingSession, ParkingSessionCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await parkingSessionReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти парковочное место с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<ParkingSession>> IBaseService<ParkingSession, ParkingSessionCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await parkingSessionReadRepository.GetAll(cancellationToken);
        }

        async Task<ParkingSession> IBaseService<ParkingSession, ParkingSessionCreateModel>.Create(ParkingSessionCreateModel model, CancellationToken cancellationToken)
        {
            var existingDriver = await driverReadRepository.GetByUserId(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Вам нужно сперва заполнить данные водителя"));

            var existingTransport = await transportReadRepository.GetById(model.TransportId, cancellationToken)
              .OrThrowIfNull(() => new InvalidOperationException($"Транспорт с id {model.TransportId} не существует"));

            if (!await transportReadRepository.IsDriverOwnsTransport(existingDriver!.Id, existingTransport!.Id, cancellationToken))
            {
                throw new InvalidOperationException("Вы не владеете этим транспортом, либо ваш запрос ещё не подтверждён");
            }

            await userReadRepository.GetById(model.UserId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var parkingZone = await parkingZoneReadRepository.GetById(model.ParkingZoneId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Парковочное место с id {model.ParkingZoneId} не существует"));

            var entity = new ParkingSession
            {
                StartTime = model.StartTime,
                EndTime = model.EndTime,
                Status = model.Status,
                CapturedTotalCost = model.EndTime != null ? parkingZone!.HourlyRate * model.EndTime.Value.Hour : default,
                UserId = model.UserId,
                TransportId = existingTransport!.Id,
                ParkingZoneId = model.ParkingZoneId,
            };

            parkingSessionWriteRepository.Add(entity);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return entity;
        }

        async Task<ParkingSession> IBaseService<ParkingSession, ParkingSessionCreateModel>.Update(Guid id, ParkingSessionCreateModel model, CancellationToken cancellationToken)
        {
            var existing = await parkingSessionReadRepository.GetById(id, cancellationToken)
             .OrThrowIfNull(() => new InvalidOperationException($"Парковочная сессия с id {id} не существует"));

            var existingDriver = await driverReadRepository.GetByUserId(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Вам нужно сперва заполнить данные водителя"));

            var existingTransport = await transportReadRepository.GetById(model.TransportId, cancellationToken)
              .OrThrowIfNull(() => new InvalidOperationException($"Транспорт с id {model.TransportId} не существует"));

            if (!await transportReadRepository.IsDriverOwnsTransport(existingDriver!.Id, existingTransport!.Id, cancellationToken))
            {
                throw new InvalidOperationException($"Вы не владеете этим транспортом");
            }

            await userReadRepository.GetById(model.UserId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var parkingZone = await parkingZoneReadRepository.GetById(model.ParkingZoneId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Парковочное место с id {model.ParkingZoneId} не существует"));

            existing!.StartTime = model.StartTime;
            existing!.EndTime = model.EndTime;
            existing.TransportId = existingTransport.Id;
            existing.CapturedTotalCost = model.EndTime != null ? parkingZone!.HourlyRate * model.EndTime.Value.Hour : default;
            existing.ParkingZoneId = model.ParkingZoneId;

            parkingSessionWriteRepository.Update(existing);
            await unitOfWork.SaveChangesAsync(cancellationToken);
            return existing;
        }

        async Task IBaseService<ParkingSession, ParkingSessionCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var entity = await parkingSessionReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти парковочное место с идентификатором {id}"));

            parkingSessionWriteRepository.Delete(entity!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}