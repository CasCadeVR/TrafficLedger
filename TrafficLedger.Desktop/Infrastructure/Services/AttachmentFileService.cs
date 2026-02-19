using TrafficLedger.Desktop.Infrastructure.Models;

namespace TrafficLedger.Desktop.Infrastructure.Services
{
    /// <summary>
    /// Файловый сервис по работе с вложениями
    /// </summary>
    public static class AttachmentFileService
    {
        /// <summary>
        /// Получить изображение из файла
        /// </summary>
        public static ImageLoadResult? LoadImageWithFormat()
        {
            using var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                var image = Image.FromFile(filePath);
                string format = Path.GetExtension(filePath).TrimStart('.').ToLowerInvariant();
                return new ImageLoadResult(image, format, openFileDialog.SafeFileName);
            }

            return null;
        }
    }
}
