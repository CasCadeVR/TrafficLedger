using System.Drawing.Imaging;
using TrafficLedger.Desktop.Infrastructure.Converters;
using TrafficLedger.Desktop.Infrastructure.Services;

namespace TrafficLedger.Desktop.Components.Controls.PictureBoxes
{
    /// <summary>
    /// Функциональный PictureBox с поддержкой загрузки и хранения изображения как byte[]
    /// </summary>
    public class FunctionalPictureBox : PictureBox
    {
        private byte[]? imageBytes;
        private string? imageFormat; // например, "png", "jpg"
        private readonly Image placeholderImage;

        /// <summary>
        /// Текущее изображение в виде массива байтов (null, если не загружено)
        /// </summary>
        public byte[]? ImageBytes => imageBytes;

        /// <summary>
        /// Формат изображения (расширение без точки), например "png"
        /// </summary>
        public string? ImageFormat => imageFormat;

        public FunctionalPictureBox()
        {
            placeholderImage = ImageResources.PlaceHolder;
            this.Image = placeholderImage;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
            this.DoubleClick += OnPictureBoxDoubleClick;
        }

        private void OnPictureBoxDoubleClick(object? sender, EventArgs e)
        {
            var result = AttachmentFileService.LoadImageWithFormat();
            if (result == null) {
                ResetToPlaceholder();
                return;
            }

            try
            {
                // Клонируем, чтобы разблокировать файл
                this.Image = new Bitmap(result.Image);
                imageFormat = result.Format;
                imageBytes = ByteImageConverter.ImageToByteArray(this.Image, imageFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения:\n{ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Image = null;
                imageBytes = null;
                imageFormat = null;
            }
            finally
            {
                // Освобождаем исходное изображение из сервиса
                result.Image.Dispose();
            }
        }

        /// <summary>
        /// Сбросить к placeholder-изображению
        /// </summary>
        private void ResetToPlaceholder()
        {
            this.Image = placeholderImage;
            imageBytes = null;
            imageFormat = null;
        }

        /// <summary>
        /// Установить изображение из byte[]
        /// </summary>
        public void SetImageFromBytes(byte[]? bytes)
        {
            if (bytes == null || bytes.Length == 0)
            {
                ResetToPlaceholder();
                return;
            }

            try
            {
                using var ms = new MemoryStream(bytes);
                var image = Image.FromStream(ms);
                this.Image = new Bitmap(image); // копия для безопасности
                imageBytes = bytes; // сохраняем исходные байты
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить изображение из данных:\n{ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Image = null;
                imageBytes = null;
                imageFormat = null;
            }
        }
    }
}
