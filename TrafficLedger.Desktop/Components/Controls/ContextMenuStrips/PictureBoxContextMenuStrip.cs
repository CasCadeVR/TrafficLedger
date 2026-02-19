namespace TrafficLedger.Desktop.Components.Controls.ContextMenuStrips
{
    /// <summary>
    /// <see cref="ContextMenuStrip"/> для <see cref="PictureBox"/>
    /// </summary>
    public class PictureBoxContextMenuStrip : ContextMenuStrip
    {
        /// <summary>
        /// Событие по нажатию на <see cref="PictureBoxContextMenuStrip"/>
        /// </summary>
        public Action? OnItemClick {  get; set; } = null;

        /// <summary>
        /// Иницилизирует новый экземпляр <see cref="PictureBoxContextMenuStrip"/>
        /// </summary>
        public PictureBoxContextMenuStrip()
        {
            var showPictureToolStripMenuItem = new ToolStripMenuItem()
            {
                Text = "Посмотреть изображение",
                Size = new Size(180, 22)
            };
            showPictureToolStripMenuItem.Click += PictureBoxContextMenuStrip_Click;
            this.Items.AddRange([showPictureToolStripMenuItem]);
        }

        private void PictureBoxContextMenuStrip_Click(object? sender, EventArgs e)
        {
            OnItemClick?.Invoke();
        }
    }
}
