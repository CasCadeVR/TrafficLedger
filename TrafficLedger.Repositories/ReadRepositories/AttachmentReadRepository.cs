using Microsoft.EntityFrameworkCore;
using TrafficLedger.Common.Repositories;
using TrafficLedger.Common.Repositories.Contracts;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IReadRepositories;

namespace TrafficLedger.Repositories.ReadRepositories;

/// <inheritdoc cref="IAttachmentReadRepository"/>
public class AttachmentReadRepository : IAttachmentReadRepository
{
    private readonly IReader reader;

    public AttachmentReadRepository(IReader reader)
    {
        this.reader = reader;
    }

    Task<Attachment?> IAttachmentReadRepository.GetByIdAndEntityId(Guid id, Guid entityId, string entityType, CancellationToken cancellationToken)
         => reader.Read<Attachment>()
        .NotDeletedAt()
        .ById(id)
        .ByEntityId(entityId)
        .ByEntityType(entityType)
        .FirstOrDefaultAsync(cancellationToken);

    Task<IReadOnlyCollection<Attachment>> IMultiTypedReadRepository<Attachment>.GetAllByEntityId(Guid entityId, string entityType, CancellationToken cancellationToken)
        => reader.Read<Attachment>()
        .NotDeletedAt()
        .ByEntityId(entityId)
        .ByEntityType(entityType)
        .OrderByDescending(x => x.CreatedAt)
        .ToReadOnlyCollectionAsync(cancellationToken);
}