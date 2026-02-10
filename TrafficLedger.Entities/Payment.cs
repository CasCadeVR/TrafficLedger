using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность оплаты
/// </summary>
public class Payment : RequestedMultiTypedDataBaseEntity
{
    /// <summary>
    /// Дата оплаты
    /// </summary>
    public DateTimeOffset Date { get; set; }

    /// <summary>
    /// Запечатлённая сумма на момент оплаты
    /// </summary>
    public decimal CapturedPrice { get; set; }
}