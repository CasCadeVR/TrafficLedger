using TrafficLedger.Desktop.Infrastructure.Converters;
using TrafficLedger.Desktop.Infrastructure.Services;
using TrafficLedger.Desktop.Components.Controls.ContextMenuStrips;
using TrafficLedger.Desktop.Views.Views;
using TrafficLedger.Services.Contracts.Models;
using TrafficLedger.Desktop.Contracts;

namespace TrafficLedger.Desktop.Components.Controls.PictureBoxes
{
    /// <summary>
    /// Функциональный PictureBox с поддержкой загрузки и хранения изображения как byte[]
    /// </summary>
    public class FunctionalPictureBox : PictureBox
    {
        private readonly Image placeholderImage;
        private readonly string unrecognizedPhotoName = "Неизвестное фото";
        private string? imageFormat;
        private CommonButton? deleteButton;
        private AttachmentCreateModel attachment = new();

        /// <summary>
        /// Текущее изображение в виде массива байтов (null, если не загружено)
        /// </summary>
        public byte[]? ImageBytes => attachment.Content;

        /// <summary>
        /// Формат изображения (расширение без точки), например "png"
        /// </summary>
        public string? ImageFormat => imageFormat;

        /// <summary>
        /// Имя файла изображения
        /// </summary>
        public string ImageName => attachment.FileName ?? unrecognizedPhotoName;

        /// <summary>
        /// Событие по смене картинки
        /// </summary>
        public event EventHandler<AttachmentCreateModel>? ImageChanged;

        /// <summary>
        /// Событие по нажатию кнопку удаления
        /// </summary>
        public event Action<FunctionalPictureBox>? DeleteRequested;

        public FunctionalPictureBox(bool asReadonly = false)
        {
            var pictureBoxContextMenuStrip = new PictureBoxContextMenuStrip();
            pictureBoxContextMenuStrip.OnItemClick += OnPictureBoxClick;
            pictureBoxContextMenuStrip.Opening += PictureBoxContextMenuStrip_Opening;

            placeholderImage = ImageResources.placeholder;
            this.Image = placeholderImage;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
            this.ContextMenuStrip = pictureBoxContextMenuStrip;

            if (!asReadonly)
            {
                this.DoubleClick += OnPictureBoxDoubleClick;

                AddRemoveButton();
                DeleteRequested += (_) => ResetToPlaceholder();
            }
        }

        private void AddRemoveButton()
        {
            if (deleteButton != null || DesignMode) return;

            deleteButton = new CommonButton
            {
                Text = "×",
                Size = new Size(24, 24),
                Location = new Point(this.Width - 26, 2)
            };

            deleteButton.Font = FontScheme.Caption;
            deleteButton.BackColor = Color.Red;
            deleteButton.ForeColor = Color.White;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.Click += (s, e) => DeleteRequested?.Invoke(this);

            this.Controls.Add(deleteButton);
            this.Controls.SetChildIndex(deleteButton, 0);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if (deleteButton != null)
            {
                deleteButton.Location = new Point(this.Width - 26, 2);
            }
        }

        private void PictureBoxContextMenuStrip_Opening(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            if (attachment.Content == null || attachment.Content.Length == 0)
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
                attachment.FileName = result.FileName;
                attachment.Content = ByteImageConverter.ImageToByteArray(Image, imageFormat);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке изображения:\n{ex.Message}", "Ошибка",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                Image = null!;
                attachment.Content = null;
                attachment.FileName = string.Empty;
                imageFormat = null;
            }
            finally
            {
                result.Image.Dispose();
                ImageChanged?.Invoke(this, new AttachmentCreateModel()
                {
                    FileName = ImageName,
                    Content = attachment.Content,
                    ContentType = nameof(Image),
                });
            }
        }

        /// <summary>
        /// Сброс подписчиков на событие <see cref="FunctionalPictureBox.ImageChanged"/>
        /// </summary>
        public void ResetImageBindings()
        {
            ImageChanged = null;
        }

        /// <summary>
        /// Сбросить к placeholder-изображению
        /// </summary>
        public void ResetToPlaceholder()
        {
            ImageChanged?.Invoke(this, null!);
            this.Image = placeholderImage;
            attachment.Content = null!;
            imageFormat = null;
            attachment.FileName = null!;
        }

        /// <summary>
        /// Установить изображение из byte[]
        /// </summary>
        public void SetImageFromAttachment(AttachmentCreateModel givenAttachment)
        {
            if (givenAttachment.Content == null || givenAttachment.Content.Length == 0)
            {
                ResetToPlaceholder();
                return;
            }

            try
            {
                attachment = givenAttachment;
                using var ms = new MemoryStream(givenAttachment.Content);
                var image = Image.FromStream(ms);
                this.Image = new Bitmap(image);
                attachment.Content = givenAttachment.Content;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить изображение из данных:\n{ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                this.Image = null;
                attachment.Content = null;
                attachment.FileName = string.Empty;
                imageFormat = null;
            }
        }
    }
}
