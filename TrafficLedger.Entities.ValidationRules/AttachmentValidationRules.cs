namespace TrafficLedger.Entities.ValidationRules;

/// <summary>
/// Правила для валидации <see cref="Attachment"/>
/// </summary>
public static class AttachmentValidationRules
{
    /// <summary>
    /// Минимальная длина <see cref="Attachment.FileName"/>
    /// </summary>
    public const int FileNameMinLength = 1;

    /// <summary>
    /// Максимальная длина <see cref="Attachment.FileName"/>
    /// </summary>
    public const int FileNameMaxLength = 255;
    
    /// <summary>
    /// Минимальная длина <see cref="Attachment.ContentType"/>
    /// </summary>
    public const int ContentTypeMinLength = 3;

    /// <summary>
    /// Максимальная длина <see cref="Attachment.ContentType"/>
    /// </summary>
    public const int ContentTypeMaxLength = 255;

    /// <summary>
    /// Максимальный размер <see cref="Attachment.Content"/>
    /// </summary>
    public const long ContentMaxSize = 5 * 1024 * 1024;
}