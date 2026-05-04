namespace TrafficLedger.Desktop.Components
{
    partial class MenuButton
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            pictureBox = new PictureBox();
            title = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(pictureBox, 0, 0);
            tableLayoutPanel.Controls.Add(title, 0, 1);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 2;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 67.89474F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 32.1052628F));
            tableLayoutPanel.Size = new Size(175, 190);
            tableLayoutPanel.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(6, 6);
            pictureBox.Margin = new Padding(6);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(163, 117);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Dock = DockStyle.Top;
            title.Font = new Font("Segoe UI", 9.75F);
            title.ForeColor = Color.FromArgb(0, 0, 0);
            title.Location = new Point(0, 129);
            title.Margin = new Padding(0);
            title.Name = "title";
            title.Size = new Size(175, 17);
            title.TabIndex = 1;
            title.Text = "Title here...";
            title.TextAlign = ContentAlignment.TopCenter;
            // 
            // MenuButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Cursor = Cursors.Hand;
            Margin = new Padding(0, 0, 0, 5);
            Name = "MenuButton";
            Size = new Size(175, 190);
            Click += MenuButton_Click;
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private Labels.PrimaryLabel title;
    }
}
