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

        async Task<IReadOnlyCollection<Payment>> IPaymentService.GetAllByUserId(Guid userId, CancellationToken cancellationToken)
        {
            await userReadRepository.GetById(userId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {userId}"));

            return await paymentReadRepository.GetAllByUserId(userId, cancellationToken);
        }

        async Task<Payment> IBaseService<Payment, PaymentRequest>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            return result!;
        }

        async Task<IReadOnlyCollection<Payment>> IBaseService<Payment, PaymentRequest>.GetAll(CancellationToken cancellationToken)
        {
            return await paymentReadRepository.GetAll(cancellationToken);
        }

        async Task IPaymentService.ApprovePayment(Guid paymentId, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(paymentId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {paymentId}"));

            payment!.Status = Status.Finished;

            paymentWriteRepository.Update(payment);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task IPaymentService.RejectPayment(Guid paymentId, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(paymentId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {paymentId}"));

            var fine = await fineReadRepository.GetById(payment!.FineId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {payment.FineId} не существует"));

            fine!.Status = Status.InProgress;
            fineWriteRepository.Update(fine);

            await unitOfWork.SaveChangesAsync(cancellationToken);
        }

        async Task<Payment> IBaseService<Payment, PaymentRequest>.Create(PaymentRequest model, CancellationToken cancellationToken)
        {
            var fine = await fineReadRepository.GetById(model.FineId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {model.FineId} не существует"));

            var user = await userReadRepository.GetById(model.UserId, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var payment = new Payment
            {
                Date = model.Date,
                Status = model.Status,
                FineId = model.FineId,
                UserId = model.UserId,
            };

            paymentWriteRepository.Add(payment);

            fine!.Status = Status.Finished;
            fineWriteRepository.Update(fine);

            await unitOfWork.SaveChangesAsync(cancellationToken);

            return payment;
        }

        async Task<Payment> IBaseService<Payment, PaymentRequest>.Update(Guid id, PaymentRequest model, CancellationToken cancellationToken)
        {
            await fineReadRepository.GetById(model.FineId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Штраф с id {model.FineId} не существует"));

            await userReadRepository.GetById(model.UserId, cancellationToken)
               .OrThrowIfNull(() => new InvalidOperationException($"Пользователь с id {model.UserId} не существует"));

            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            payment!.Date = model.Date;
            payment.Status = model.Status;
            payment.FineId = model.FineId;
            payment.UserId = model.UserId;

            paymentWriteRepository.Update(payment);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return payment;
        }

        async Task IBaseService<Payment, PaymentRequest>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var payment = await paymentReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти чек с идентификатором {id}"));

            paymentWriteRepository.Delete(payment!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}