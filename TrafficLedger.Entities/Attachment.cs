using TrafficLedger.Entities.Contracts;
using TrafficLedger.Entities.Generics;

namespace TrafficLedger.Entities
{
    /// <summary>
    /// Хранение фото и других мультимедийных данных для любых сущностей
    /// </summary>
    public class Attachment : MultiTypedDataBaseEntity
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// Вид контента (фото, документ и т.д.)
        /// </summary>
        public string ContentType { get; set; } = string.Empty;

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string? StoragePath { get; set; }
    }
}
