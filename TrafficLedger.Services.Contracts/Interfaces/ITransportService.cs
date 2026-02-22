using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="Transport"/>
/// </summary>
public interface ITransportService : IRequestedService<Transport, TransportCreateModel>
{
    /// <summary>
    /// Получить все транспорты водителя с идентификатором
    /// </summary>
    Task<IReadOnlyCollection<Transport>> GetAllByDriverId(Guid driverId, CancellationToken cancellationToken);

    /// <summary>
    /// Получить транспорт по его коду
    /// </summary>
    Task<Transport> GetByTransportCode(string transportCode, CancellationToken cancellationToken);
}
