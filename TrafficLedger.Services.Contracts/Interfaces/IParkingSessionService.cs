using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="ParkingSession"/>
/// </summary>
public interface IParkingSessionService : IBaseService<ParkingSession, ParkingSessionCreateModel>
{
    /// <summary>
    /// Получает список <see cref="ParkingSession"/> по идентификатору транспорта
    /// </summary>
    Task<IReadOnlyCollection<ParkingSession>> GetAllByTransportId(Guid transportId, CancellationToken cancellationToken);
}
