using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Violation"/>
/// </summary>
public interface IViolationReadRepository : IBaseReadRepository<Violation>
{
    /// <summary>
    /// Существует ли уже такой код нарушения
    /// </summary>
    Task<bool> IsViolationCodeExists(string сode, CancellationToken cancellationToken);
}
