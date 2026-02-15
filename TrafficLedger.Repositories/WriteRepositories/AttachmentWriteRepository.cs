using TrafficLedger.Common.Repositories;
using TrafficLedger.Context.Contracts;
using TrafficLedger.Entities;
using TrafficLedger.Repositories.Contracts.IWriteRepositories;

namespace TrafficLedger.Repositories.WriteRepositories;

/// <summary>
/// <inheritdoc cref="IAttachmentWriteRepository"/>
/// </summary>
/// <remarks>
/// Инициализирует новый экземпляр <see cref="AttachmentWriteRepository"/>
/// </remarks>
public class AttachmentWriteRepository(IWriter writer)
    : BaseWriteRepository<Attachment>(writer), IAttachmentWriteRepository { }