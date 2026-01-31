using System.ComponentModel.DataAnnotations;
using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса водителя
/// </summary>
public class DriverRequest
{
    /// <summary>
    /// ФИО водителя
    /// </summary>
    [Required(ErrorMessage = "Это поле обязательно")]
    public string FullName { get; set; } = string.Empty;

    /// <summary>
    /// Дата рождения
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset BirthDate { get; set; }

    /// <summary>
    /// Место рождения
    /// </summary>
    public string BirthPlace { get; set; } = string.Empty;

    /// <summary>
    /// Идентификатор <see cref="User"/>
    /// </summary>
    public Guid UserId { get; set; }

    /// <summary>
    /// Объект передачи данных <see cref="OwnershipTransportRequest"/>
    /// </summary>
    public ICollection<OwnershipTransportRequest> Ownerships { get; set; } = null!;
}
