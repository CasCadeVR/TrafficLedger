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
            var pictureBox = CreateNewPictureBox();
            Controls.Add(pictureBox);
            Controls.SetChildIndex(pictureBox, this.Controls.GetChildIndex(addButton));
        }

        private FunctionalPictureBox CreateNewPictureBox()
        {
            var box = new FunctionalPictureBox
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
            Controls.Remove(box);
            box.Dispose();
        }

        /// <summary>
        /// Загрузить изображения из массивов байтов
        /// </summary>
        public void SetImagesFromBytes(IEnumerable<byte[]> images)
        {
            foreach (var bytes in images)
            {
                var box = CreateNewPictureBox();
                box.SetImageFromBytes(bytes);
                Controls.Add(box);
                Controls.SetChildIndex(box, Controls.GetChildIndex(addButton));
            }
        }

        /// <summary>
        /// Очистить все изображения
        /// </summary>
        public void Clear()
        {
            SetImagesFromBytes([]);
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
        }
    }
}
