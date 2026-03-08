using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="User"/>
/// </summary>
public interface IUserService : IBaseService<User, UserCreateModel>
{
    /// <summary>
    /// Получить пользователя по логину и паролю
    /// </summary>
    Task<User?> GetByLoginAndPassword(LoginModel model, CancellationToken cancellationToken);
}
