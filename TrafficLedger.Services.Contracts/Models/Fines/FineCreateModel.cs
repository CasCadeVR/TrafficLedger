using System.ComponentModel.DataAnnotations;
using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities;
using TrafficLedger.Entities.Enums;

namespace TrafficLedger.Services.Contracts.Models.Fines;

/// <summary>
/// Модель запроса штрафа
/// </summary>
public class FineCreateModel
{
    /// <summary>
    /// Дата получения штрафа
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Адрес, по которому произошло нарушение
    /// </summary>
    [Required(ErrorMessage = "Это поле обязательно")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Примечание
    /// </summary>
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Сумма штрафа
    /// </summary>
    public decimal Price { get; set; }

    /// <summary>
    /// Статус штрафа
    /// </summary>
    public SessionStatus Status { get; set; }

    /// <summary>
    /// Фотки с места происшествия
    /// </summary>
    public ICollection<AttachmentCreateModel> Attachments { get; set; } = null!;

    /// <summary>
    /// Идентификатор <see cref="Violation"/>
    /// </summary>
    public Guid ViolationId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="Transport"/>
    /// </summary>
    public Guid TransportId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }
}
