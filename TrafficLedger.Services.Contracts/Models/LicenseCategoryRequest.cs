using TrafficLedger.Common.Services.Contracts.Extensions;
using TrafficLedger.Entities;

namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса категории для водительсокого удостоверения 
/// </summary>
public class LicenseCategoryRequest
{
    /// <summary>
    /// Дата присуждения определённой категории
    /// </summary>
    [NotFutureDate]
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Идентификатор <see cref="DriverLicense"/>
    /// </summary>
    public Guid DriverLicenseId { get; set; }

    /// <summary>
    /// Идентификатор <see cref="TransportCategory"/>
    /// </summary>
    public Guid TransportCategoryId { get; set; }
}
