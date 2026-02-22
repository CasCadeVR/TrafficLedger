using TrafficLedger.Common.Services.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Services.Contracts.Interfaces;

/// <summary>
/// Сервис по работе с <see cref="Violation"/>
/// </summary>
public interface IViolationService : IBaseService<Violation, ViolationCreateModel> { }
