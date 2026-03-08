using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Controls.SearchBars
{
    partial class SearchBar
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
            searchTerm = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            search = new CommonButton();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 44F));
            tableLayoutPanel.Controls.Add(searchTerm, 0, 0);
            tableLayoutPanel.Controls.Add(search, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(700, 42);
            tableLayoutPanel.TabIndex = 2;
            // 
            // searchTerm
            // 
            searchTerm.BackColor = Color.White;
            searchTerm.BorderStyle = BorderStyle.FixedSingle;
            searchTerm.Dock = DockStyle.Fill;
            searchTerm.Font = new Font("Segoe UI", 9.75F);
            searchTerm.ForeColor = Color.FromArgb(0, 0, 0);
            searchTerm.Location = new Point(4, 3);
            searchTerm.Margin = new Padding(4, 3, 4, 3);
            searchTerm.Name = "searchTerm";
            searchTerm.Size = new Size(648, 25);
            searchTerm.TabIndex = 0;
            // 
            // search
            // 
            search.BackColor = Color.Green;
            search.BackgroundImage = ImageResources.Search;
            search.BackgroundImageLayout = ImageLayout.Zoom;
            search.Dock = DockStyle.Right;
            search.FlatAppearance.BorderColor = Color.DarkGray;
            search.FlatStyle = FlatStyle.Flat;
            search.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            search.ForeColor = Color.White;
            search.Location = new Point(660, 3);
            search.Margin = new Padding(4, 3, 4, 3);
            search.Name = "search";
            search.Padding = new Padding(9, 5, 9, 5);
            search.Size = new Size(36, 36);
            search.TabIndex = 1;
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // SearchBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(0);
            Name = "SearchBar";
            Size = new Size(700, 42);
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private CommonButton search;
        public TextBoxes.DefaultTextBox searchTerm;
    }
}
