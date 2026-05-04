using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
using TrafficLedger.Entities.Typing;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Repositories.Contracts.Models.Payments;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentReadRepository paymentReadRepository;
        private readonly IPaymentWriteRepository paymentWriteRepository;
        private readonly IFineWriteRepository fineWriteRepository;
        private readonly IFineReadRepository fineReadRepository;
        private readonly IParkingSessionReadRepository parkingSessionReadRepository;
        private readonly IParkingSessionWriteRepository parkingSessionWriteRepository;
        private readonly IUserReadRepository userReadRepository;
        private readonly IUnitOfWork unitOfWork;

        public PaymentService(IPaymentReadRepository paymentReadRepository,
            IPaymentWriteRepository paymentWriteRepository,
            IFineReadRepository fineReadRepository,
            IFineWriteRepository fineWriteRepository,
            IParkingSessionReadRepository parkingSessionReadRepository,
            IParkingSessionWriteRepository parkingSessionWriteRepository,
            IUserReadRepository userReadRepository,
            IUnitOfWork unitOfWork)
        {
            this.paymentReadRepository = paymentReadRepository;
            this.paymentWriteRepository = paymentWriteRepository;
            this.fineWriteRepository = fineWriteRepository;
            this.userReadRepository = userReadRepository;
            this.fineReadRepository = fineReadRepository;
            this.parkingSessionReadRepository = parkingSessionReadRepository;
            this.parkingSessionWriteRepository = parkingSessionWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<IReadOnlyCollection<PaymentFineDBModel>> IPaymentService.GetAllFinesByUserId(Guid userId, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(userId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {userId}"));

            return await paymentReadRepository.GetAllFinesByUserId(userId, cancellationToken);
        }

        async Task<IReadOnlyCollection<PaymentParkingSessionDBModel>> IPaymentService.GetAllParkingSessionsByUserId(Guid userId, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(userId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {userId}"));

            return await paymentReadRepository.GetAllParkingSessionsByUserId(userId, cancellationToken);
        }

        async Task<Payment> IBaseService<Payment, PaymentCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<Payment>> IBaseService<Payment, PaymentCreateModel>.GetAll(CancellationToken cancellationToken)
            => await paymentReadRepository.GetAll(cancellationToken);

        async Task<IReadOnlyCollection<PaymentFineDBModel>> IPaymentService.GetAllFines(CancellationToken cancellationToken)
           => await paymentReadRepository.GetAllFines(cancellationToken);

        async Task<IReadOnlyCollection<PaymentParkingSessionDBModel>> IPaymentService.GetAllParkingSessions(CancellationToken cancellationToken)
           => await paymentReadRepository.GetAllParkingSessions(cancellationToken);

        async Task IRequestedService<Payment, PaymentCreateModel>.Approve(Guid id, Guid processedById, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            await userReadRepository.GetById(processedById, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя одобряющего с идентификатором {processedById}"));

            payment!.Status = RequestStatus.Approved;
            payment.ProcessedById = processedById;
            payment.ProcessedAt = DateTimeOffset.Now;

            if (payment.EntityType == EntityTypes.FineType)
            {
                var fine = await fineReadRepository.GetById(payment.EntityId, cancellationToken)
                   .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {payment.EntityId} не существует"));

                fine!.Status = SessionStatus.Completed;
                fineWriteRepository.Update(fine);
            }

            paymentWriteRepository.Update(payment);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IRequestedService<Payment, PaymentCreateModel>.Reject(Guid id, Guid processedById, string commentary, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                 .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            await userReadRepository.GetById(processedById, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя одобряющего с идентификатором {processedById}"));

            payment!.Status = RequestStatus.Rejected;
            payment.ProcessedById = processedById;
            payment.ProcessedAt = DateTimeOffset.Now;
            payment.Commentary = commentary;

            if (payment.EntityType == EntityTypes.FineType)
            {
                var fine = await fineReadRepository.GetById(payment.EntityId, cancellationToken)
                   .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {payment.EntityId} не существует"));

                fine!.Status = SessionStatus.Active;
                fineWriteRepository.Update(fine);
            }
            else if (payment.EntityType == EntityTypes.ParkingSessionType)
            {
                var session = await parkingSessionReadRepository.GetById(payment.EntityId, cancellationToken)
                    .OrThrowIfNull(() => new InvalidOperationException($"Парковочная сессия с id {payment.EntityId} не существует"));

                session!.Status = SessionStatus.Active;
                session.EndTime = null;
                parkingSessionWriteRepository.Update(session);
            }

            paymentWriteRepository.Update(payment);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task<Payment> IBaseService<Payment, PaymentCreateModel>.Create(PaymentCreateModel model, CancellationToken cancellationToken)
        {
            var user = await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var payment = new Payment();

            if (model.EntityType == EntityTypes.FineType)
            {
                var fine = await fineReadRepository.GetById(model.EntityId, cancellationToken)
                    .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {model.EntityId} не существует"));

                payment = new Payment
                {
                    Date = model.Date,
                    Status = model.Status,
                    EntityId = model.EntityId,
                    UserId = user!.Id,
                    CapturedPrice = fine!.Price,
                    EntityType = EntityTypes.FineType,
                };

                fine.Status = SessionStatus.Completed;
                fineWriteRepository.Update(fine);
            }
            else if (model.EntityType == EntityTypes.ParkingSessionType)
            {
                var session = await parkingSessionReadRepository.GetById(model.EntityId, cancellationToken)
                    .OrThrowIfNull(() => new InvalidOperationException($"Парковочная сессия с id {model.EntityId} не существует"));

                var passedHours = (int)(DateTimeOffset.Now - session!.StartTime).TotalHours + 1;
                var price = passedHours * session.ParkingZone.HourlyRate;

                payment = new Payment
                {
                    Date = model.Date,
                    Status = model.Status,
                    EntityId = model.EntityId,
                    UserId = user!.Id,
                    CapturedPrice = price,
                    EntityType = EntityTypes.ParkingSessionType,
                };

                session.Status = SessionStatus.Completed;
                session.EndTime = DateTimeOffset.Now;
                parkingSessionWriteRepository.Update(session);
            }

            paymentWriteRepository.Add(payment);

            await unitOfWork.SaveChangesAsync(cancellationToken);
            return payment;
        }

        async Task<Payment> IBaseService<Payment, PaymentCreateModel>.Update(Guid id, PaymentCreateModel model, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(model.UserId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            payment!.Date = model.Date;
            payment.Status = model.Status;

            paymentWriteRepository.Update(payment);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return payment;
        }

        async Task IBaseService<Payment, PaymentCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            paymentWriteRepository.Delete(payment!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}