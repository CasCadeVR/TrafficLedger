using TrafficLedger.Entities.Contracts;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность штрафа
/// </summary>
public class Fine : DataBaseEntity
{
    /// <summary>
    /// Дата получения штрафа
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Статус обработки
    /// </summary>
    public RequestStatus Status { get; set; }

    /// <summary>
    /// Адрес, по которому произошло нарушение
    /// </summary>
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Примечание
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор <see cref="Violation"/>
    /// </summary>
    public Guid ViolationId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Violation"/>
    /// </summary>
    public Violation Violation { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }

    /// <summary>
    /// Навигационное свойство <see cref="Transport"/>
    /// </summary>
    public Transport Transport { get; set; } = null!;

    /// <summary>
    /// Идентификатор отправителя запроса (User)
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Навигационное свойтво <see cref="User"/>-отправителя
    /// </summary>
    public virtual User? User { get; set; }

    /// <summary>
    /// Навигационное свойство списка <see cref="Attachment"/>
    /// </summary>
    public ICollection<Attachment> Attachments { get; set; } = null!;
}