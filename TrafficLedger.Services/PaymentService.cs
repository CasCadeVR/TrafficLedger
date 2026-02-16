using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;
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
        private readonly IUserReadRepository userReadRepository;
        private readonly IFineReadRepository fineReadRepository;
        private readonly IUnitOfWork unitOfWork;

        public PaymentService(IPaymentReadRepository paymentReadRepository,
            IPaymentWriteRepository paymentWriteRepository,
            IFineWriteRepository fineWriteRepository,
            IUserReadRepository userReadRepository,
            IFineReadRepository fineReadRepository,
            IUnitOfWork unitOfWork)
        {
            this.paymentReadRepository = paymentReadRepository;
            this.paymentWriteRepository = paymentWriteRepository;
            this.fineWriteRepository = fineWriteRepository;
            this.userReadRepository = userReadRepository;
            this.fineReadRepository = fineReadRepository;
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

        async Task IPaymentService.ApprovePayment(Guid paymentId, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(paymentId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {paymentId}"));

            payment!.Status = RequestStatus.Approved;

            paymentWriteRepository.Update(payment);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IPaymentService.RejectPayment(Guid paymentId, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(paymentId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {paymentId}"));

            var fine = await fineReadRepository.GetById(payment!.EntityId, cancellationToken);
            var parkingSession = await fineReadRepository.GetById(payment!.EntityId, cancellationToken);

            if (fine != null)
            {
                fine!.Status = RequestStatus.Rejected;
                fineWriteRepository.Update(fine);
            } 
            else if (parkingSession != null)
            {
                fine!.Status = RequestStatus.Rejected;
                fineWriteRepository.Update(fine);
            } 
            else
            {
                throw new InvalidOperationException($"Штраф с id {payment.EntityId} не существует");
            }

            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task<Payment> IBaseService<Payment, PaymentCreateModel>.Create(PaymentCreateModel model, CancellationToken cancellationToken)
        {
            var fine = await fineReadRepository.GetById(model.EntityId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {model.EntityId} не существует"));

            var user = await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var payment = new Payment
            {
                Date = model.Date,
                Status = model.Status,
                EntityId = model.EntityId,
                UserId = model.UserId,
            };

            paymentWriteRepository.Add(payment);

            fine!.Status = RequestStatus.Approved;
            fineWriteRepository.Update(fine);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return payment;
        }

        async Task<Payment> IBaseService<Payment, PaymentCreateModel>.Update(Guid id, PaymentCreateModel model, CancellationToken cancellationToken)
        {
            await fineReadRepository.GetById(model.EntityId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {model.EntityId} не существует"));

            await userReadRepository.GetById(model.UserId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            payment!.Date = model.Date;
            payment.Status = model.Status;
            payment.EntityId = model.EntityId;
            payment.UserId = model.UserId;

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