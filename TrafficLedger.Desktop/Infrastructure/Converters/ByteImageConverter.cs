namespace TrafficLedger.Desktop.Infrastructure.Converters
{
    /// <summary>
    /// Преобразователь изображений
    /// </summary>
    public static class ByteImageConverter
    {
        /// <summary>
        /// Изображение в массив байтов
        /// </summary>
        public static byte[] ImageToByteArray(Image image, string format)
        {
            using var ms = new MemoryStream();
            System.Drawing.Imaging.ImageFormat imgFormat = format.ToLowerInvariant() switch
            {
                "jpg" or "jpeg" => System.Drawing.Imaging.ImageFormat.Jpeg,
                "png" => System.Drawing.Imaging.ImageFormat.Png,
                "bmp" => System.Drawing.Imaging.ImageFormat.Bmp,
                "gif" => System.Drawing.Imaging.ImageFormat.Gif,
                _ => System.Drawing.Imaging.ImageFormat.Jpeg
            };

            image.Save(ms, imgFormat);
            return ms.ToArray();
        }

        /// <summary>
        /// Массив байтов в изображение
        /// </summary>
        public static Image ByteArrayToImage(byte[] bytes)
        {
            using var ms = new MemoryStream(bytes);
            return Image.FromStream(ms);
        }
    }
}
