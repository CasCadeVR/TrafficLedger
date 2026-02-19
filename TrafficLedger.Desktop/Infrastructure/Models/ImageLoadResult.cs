namespace TrafficLedger.Desktop.Infrastructure.Models
{
    /// <summary>
    /// Результат скачивания фото
    /// </summary>
    public record ImageLoadResult(Image Image, string Format, string FileName);
}
