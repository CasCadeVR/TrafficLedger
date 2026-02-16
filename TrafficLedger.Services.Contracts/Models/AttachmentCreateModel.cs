namespace TrafficLedger.Services.Contracts.Models;

/// <summary>
/// Модель запроса вложения
/// </summary>
public class AttachmentCreateModel
{
    /// <summary>
    /// Идентификатор сущности
    /// </summary>
    public Guid EntityId { get; set; }

    /// <summary>
    /// Тип сущности
    /// </summary>
    public string EntityType { get; set; } = string.Empty;

    /// <summary>
    /// Имя файла
    /// </summary>
    public string FileName { get; set; } = string.Empty;

    /// <summary>
    /// Вид контента (фото, документ и т.д.)
    /// </summary>
    public string ContentType { get; set; } = string.Empty;

    /// <summary>
    /// Побитовый контент
    /// </summary>
    public byte[]? Content { get; set; }
}
