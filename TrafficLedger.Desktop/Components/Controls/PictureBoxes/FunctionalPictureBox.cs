using TrafficLedger.Desktop.Infrastructure.Converters;
using TrafficLedger.Desktop.Infrastructure.Services;
using TrafficLedger.Desktop.Components.Controls.ContextMenuStrips;
using TrafficLedger.Desktop.Views.Views;
using System.Diagnostics;

namespace TrafficLedger.Desktop.Components.Controls.PictureBoxes
{
    /// <summary>
    /// Функциональный PictureBox с поддержкой загрузки и хранения изображения как byte[]
    /// </summary>
    public class FunctionalPictureBox : PictureBox
    {
        private readonly Image placeholderImage;
        private readonly string unrecognizedPhotoName = "Неизвестное фото";
        private byte[]? imageBytes;
        private string? imageFormat;
        private string? imageName;

        /// <summary>
        /// Текущее изображение в виде массива байтов (null, если не загружено)
        /// </summary>
        public byte[]? ImageBytes => imageBytes;

        /// <summary>
        /// Формат изображения (расширение без точки), например "png"
        /// </summary>
        public string? ImageFormat => imageFormat;

        /// <summary>
        /// Имя файла изображения
        /// </summary>
        public string ImageName => imageName ?? unrecognizedPhotoName;

        /// <summary>
        /// Событие по смене картинки
        /// </summary>
        public event EventHandler? ImageChanged;

        public FunctionalPictureBox()
        {
            var pictureBoxContextMenuStrip = new PictureBoxContextMenuStrip();
            pictureBoxContextMenuStrip.OnItemClick += OnPictureBoxClick;
            pictureBoxContextMenuStrip.Opening += PictureBoxContextMenuStrip_Opening;

            placeholderImage = ImageResources.PlaceHolder;
            this.Image = placeholderImage;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
            this.ContextMenuStrip = pictureBoxContextMenuStrip;
            this.DoubleClick += OnPictureBoxDoubleClick;
        }

        private void PictureBoxContextMenuStrip_Opening(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (imageBytes == null || imageBytes.Length == 0)
            {
                e.Cancel = true;
            }
        }

        private void OnPictureBoxClick()
        {
            var attachmentView = new AttachmentView(ImageName, this.Image);
            attachmentView.Show();
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
                Image = new Bitmap(result.Image);
                imageFormat = result.Format;
                imageName = result.FileName;
                imageBytes = ByteImageConverter.ImageToByteArray(Image, imageFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения:\n{ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Image = null!;
                imageBytes = null;
                imageName = null;
                imageFormat = null;
            }
            finally
            {
                result.Image.Dispose();
                ImageChanged?.Invoke(this, e);
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
                this.Image = new Bitmap(image);
                imageBytes = bytes;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить изображение из данных:\n{ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Image = null;
                imageBytes = null;
                imageName = null;
                imageFormat = null;
            }
            finally
            {
                ImageChanged?.Invoke(this, null!);
            }
        }
    }
}
