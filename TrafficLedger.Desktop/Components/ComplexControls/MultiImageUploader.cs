using TrafficLedger.Desktop.Components.Controls.PictureBoxes;
using TrafficLedger.Services.Contracts.Models;

namespace TrafficLedger.Desktop.Components.ComplexControls
{
    public partial class MultiImageUploader : FlowLayoutPanel
    {
        private readonly List<AttachmentCreateModel> attachments = [];
        private readonly Button addButton;

        /// <summary>
        /// Событие по смене картинки
        /// </summary>
        public event EventHandler<List<AttachmentCreateModel>>? ImagesChanged;

        private int PictureBoxSize => Height - Padding.Top;

        public MultiImageUploader()
        {
            WrapContents = true;
            AutoScroll = true;
            FlowDirection = FlowDirection.LeftToRight;
            Padding = new Padding(5);
            BackColor = SystemColors.Control;

            addButton = new CommonButton
            {
                Text = "+ Добавить фото",
                Size = new Size(Height - Padding.Top, Height - Padding.Top),
            };
            addButton.Click += AddButton_Click;

            Controls.Add(addButton);
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            var pictureBox = CreateNewPictureBox(asReadonly: false);
            Controls.Add(pictureBox);
            Controls.SetChildIndex(pictureBox, this.Controls.GetChildIndex(addButton));
        }

        private FunctionalPictureBox CreateNewPictureBox(bool asReadonly)
        {
            var box = new FunctionalPictureBox(asReadonly)
            {
                Size = new Size(PictureBoxSize, PictureBoxSize),
                Margin = new Padding(5)
            };
            box.ImageChanged += (sender, e) =>
            {
                if (e == null)
                {
                    attachments.RemoveAll(x => x.FileName == box.ImageName);
                } 
                else 
                {
                    attachments.Add(e);
                }

                ImagesChanged?.Invoke(sender, attachments);
            };

            box.DeleteRequested += OnPictureBoxDeleteRequested;
            return box;
        }

        private void OnPictureBoxDeleteRequested(FunctionalPictureBox box)
        {
            attachments.RemoveAll(x => x.FileName == box.ImageName);
            Controls.Remove(box);
            ImagesChanged?.Invoke(this, attachments);
            box.Dispose();
        }

        /// <summary>
        /// Загрузить изображения из массивов байтов
        /// </summary>
        public void SetImagesFromAttachments(IEnumerable<AttachmentCreateModel> givenAttachments, bool asReadonlyImages = false)
        {
            foreach (var attachment in givenAttachments)
            {
                var box = CreateNewPictureBox(asReadonlyImages);
                box.SetImageFromAttachment(attachment);
                Controls.Add(box);
                Controls.SetChildIndex(box, Controls.GetChildIndex(addButton));
                attachments.Add(attachment);
            }
        }

        /// <summary>
        /// Очистить все изображения
        /// </summary>
        public void Clear()
        {
            var pictureBoxes = this.Controls.OfType<FunctionalPictureBox>().ToArray();

            foreach (var box in pictureBoxes)
            {
                OnPictureBoxDeleteRequested(box);
            }

            attachments.Clear();
        }

        /// <summary>
        /// Убрать кнопку добавления
        /// </summary>
        public void HideAddButton()
        {
            addButton.Visible = false;
        }

        /// <summary>
        /// Сброс подписчиков всех картинок на событие <see cref="FunctionalPictureBox.ImageChanged"/>
        /// </summary>
        public void ResetImageBindings()
        {
            var pictureBoxes = this.Controls.OfType<FunctionalPictureBox>().ToArray();

            foreach (var box in pictureBoxes)
            {
                box.ResetImageBindings();
            }

            ImagesChanged = null;
        }
    }
}
