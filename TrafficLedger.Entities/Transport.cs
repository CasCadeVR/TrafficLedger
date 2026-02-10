using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities;

/// <summary>
/// Сущность транспорта
/// </summary>
public class Transport : RequestedDataBaseEntity
{
    /// <summary>
    /// Код транспорта
    /// </summary>
    public string TransportCode { get; set; } = string.Empty;

    /// <summary>
    /// Регион изготовления
    /// </summary>
    public string Region { get; set; } = string.Empty;

    /// <summary>
    /// Марка
    /// </summary>
    public string Brand { get; set; } = string.Empty;

    /// <summary>
    /// Год выпуска
    /// </summary>
    public string Year { get; set; } = string.Empty;

    /// <summary>
    /// Модель
    /// </summary>
    public string Model { get; set; } = string.Empty;

    /// <summary>
    /// Пробег
    /// </summary>
    public int MileAge { get; set; }

    /// <summary>
    /// Идентификатор <see cref="TransportCategory"/>
    /// </summary>
    public Guid TransportCategoryId { get; set; }

    /// <summary>
    /// Навигационное свойтво <see cref="TransportCategory"/>
    /// </summary>
    public TransportCategory TransportCategory { get; set; } = null!;

    /// <summary>
    /// Навигационное свойство списка <see cref="Ownership"/>
    /// </summary>
    public ICollection<Ownership> Ownerships { get; set; } = null!;

    /// <summary>
    /// Навигационное свойство списка <see cref="Fine"/>
    /// </summary>
    public ICollection<Fine> Fines { get; set; } = null!;
}