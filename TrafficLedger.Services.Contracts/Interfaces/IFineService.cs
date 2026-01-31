using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="Fine"/>
/// </summary>
public interface IFineService : IBaseService<Fine, FineRequest>
{
    /// <summary>
    /// Получает список <see cref="Fine"/> по идентификатору транспорта
    /// </summary>
    Task<IReadOnlyCollection<Fine>> GetAllByTransportId(Guid transportId, CancellationToken cancellationToken);
}