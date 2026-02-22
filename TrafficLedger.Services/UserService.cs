using TrafficLedger.Common.Services;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;
using TrafficLedger.Services.Contracts.Interfaces;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Common.Core.Extensions;
using TrafficLedger.Common.Services.Contracts;

namespace TrafficLedger.Services
{
    public class UserService : IUserService
    {
        private readonly IUserReadRepository userReadRepository;
        private readonly IUserWriteRepository userWriteRepository;
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUserReadRepository userReadRepository,
            IUserWriteRepository userWriteRepository,
            IUnitOfWork unitOfWork)
        {
            this.userReadRepository = userReadRepository;
            this.userWriteRepository = userWriteRepository;
            this.unitOfWork = unitOfWork;
        }

        async Task<User> IBaseService<User, UserCreateModel>.GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await userReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {id}"));

            return result!;
        }

        async Task<User> IUserService.GetByLoginAndPassword(LoginModel model, CancellationToken cancellationToken)
        {
            var message = "Пользователь с указанным логином и паролем не найден";
            var user = await userReadRepository.GetByLogin(model.Login.ToLower(), cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException(message));

            var passwordHash = SecurityHelper.HashPassword32(model.Password, user!.PasswordSalt);

            if (passwordHash != user.PasswordHash)
            {
                throw new InvalidOperationException(message);
            }

            return user;
        }

        async Task<IReadOnlyCollection<User>> IBaseService<User, UserCreateModel>.GetAll(CancellationToken cancellationToken)
        {
            return await userReadRepository.GetAll(cancellationToken);
        }

        async Task<User> IBaseService<User, UserCreateModel>.Create(UserCreateModel model, CancellationToken cancellationToken)
        {
            await userReadRepository.IsLoginExists(model.Login.ToLower(), cancellationToken)
                .AndThrowIfTrue(() => new InvalidOperationException($"Пользователь с логином {model.Login} уже существует"));

            var saltValue = SecurityHelper.GenerateSalt32();
            var passwordHash = SecurityHelper.HashPassword32(model.Password, saltValue);
            var user = new User
            {
                Login = model.Login.Trim(),
                Role = Role.Default,
                PasswordHash = passwordHash,
                PasswordSalt = saltValue,
            };

            userWriteRepository.Add(user);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }

        async Task<User> IBaseService<User, UserCreateModel>.Update(Guid id, UserCreateModel model, CancellationToken cancellationToken)
        {
            var user = await userReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {id}"));

            user!.Login = model.Login.Trim();
            user.Role = model.Role;

            userWriteRepository.Update(user);
            await unitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }

        async Task IBaseService<User, UserCreateModel>.Delete(Guid id, CancellationToken cancellationToken)
        {
            var user = await userReadRepository.GetById(id, cancellationToken)
                .OrThrowIfNull(() => new InvalidOperationException($"Не удалось найти пользователя с идентификатором {id}"));

            userWriteRepository.Delete(user!);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}