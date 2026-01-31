using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="Driver"/>
/// </summary>
public interface IDriverService : IBaseService<Driver, DriverRequest>
{
    /// <summary>
    /// Получает <see cref="Driver"/> по идентификатору пользователя
    /// </summary>
    Task<Driver> GetByUserId(Guid userId, CancellationToken cancellationToken);
}
