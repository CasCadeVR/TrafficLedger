using TrafficLedger.Desktop.Components.Controls.PictureBoxes;

namespace TrafficLedger.Desktop.Components.ComplexControls
{
    public partial class MultiImageUploader : FlowLayoutPanel
    {
        private readonly Button _addButton;
        private int PictureBoxSize => Height - Padding.Top;

        public MultiImageUploader()
        {
            this.WrapContents = true;
            this.AutoScroll = true;
            this.FlowDirection = FlowDirection.LeftToRight;
            this.Padding = new Padding(5);
            this.BackColor = SystemColors.Control;

            _addButton = new CommonButton
            {
                Text = "+ Добавить фото",
                Size = new Size(Height - Padding.Top, Height - Padding.Top),
            };
            _addButton.Click += AddButton_Click;

            this.Controls.Add(_addButton);
        }

        private void AddButton_Click(object? sender, EventArgs e)
        {
            var pictureBox = CreateNewPictureBox();
            this.Controls.Add(pictureBox);
            this.Controls.SetChildIndex(pictureBox, this.Controls.GetChildIndex(_addButton));
        }

        private FunctionalPictureBox CreateNewPictureBox()
        {
            var box = new FunctionalPictureBox
            {
                Size = new Size(PictureBoxSize, PictureBoxSize),
                Margin = new Padding(5)
            };
            box.DeleteRequested += OnPictureBoxDeleteRequested;
            return box;
        }

        private void OnPictureBoxDeleteRequested(FunctionalPictureBox box)
        {
            box.DeleteRequested -= OnPictureBoxDeleteRequested;
            this.Controls.Remove(box);
            box.Dispose();
        }

        /// <summary>
        /// Получить все загруженные изображения как массивы байтов
        /// </summary>
        public List<byte[]> GetImagesAsBytes()
        {
            return this.Controls
                .OfType<FunctionalPictureBox>()
                .Where(p => p.ImageBytes != null)
                .Select(p => p.ImageBytes!)
                .ToList();
        }

        /// <summary>
        /// Загрузить изображения из массивов байтов
        /// </summary>
        public void SetImagesFromBytes(IEnumerable<byte[]> images)
        {
            var pictureBoxes = this.Controls.OfType<FunctionalPictureBox>().ToArray();
            foreach (var box in pictureBoxes)
            {
                box.DeleteRequested -= OnPictureBoxDeleteRequested;
                this.Controls.Remove(box);
                box.Dispose();
            }

            foreach (var bytes in images)
            {
                var box = CreateNewPictureBox();
                box.SetImageFromBytes(bytes);
                this.Controls.Add(box);
                this.Controls.SetChildIndex(box, this.Controls.GetChildIndex(_addButton));
            }
        }

        /// <summary>
        /// Очистить все изображения
        /// </summary>
        public void Clear()
        {
            SetImagesFromBytes([]);
        }
    }
}
