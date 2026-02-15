using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Entities;

namespace TrafficLedger.Repositories.Contracts.IReadRepositories;

/// <summary>
/// Репозиторий чтения для <see cref="Attachment"/>
/// </summary>
public interface IAttachmentReadRepository : IMultiTypedReadRepository<Attachment>
{
    /// <summary>
    /// Получает <see cref="Attachment"/> по идентификатору сущности и id
    /// </summary>
    Task<Attachment?> GetByIdAndEntityId(Guid id, Guid entityId, string entityType, CancellationToken cancellationToken);
}
