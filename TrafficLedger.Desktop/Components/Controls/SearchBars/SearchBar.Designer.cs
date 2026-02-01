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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.searchTerm = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.search = new TrafficLedger.Desktop.Components.CommonButton();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.66666F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.333333F));
            this.tableLayoutPanel.Controls.Add(this.searchTerm, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.search, 1, 0);
            this.tableLayoutPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(600, 36);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // searchTerm
            // 
            this.searchTerm.BackColor = System.Drawing.Color.White;
            this.searchTerm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTerm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTerm.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.searchTerm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchTerm.Location = new System.Drawing.Point(3, 3);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(549, 25);
            this.searchTerm.TabIndex = 0;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.Green;
            this.search.BackgroundImage = global::TrafficLedger.Desktop.ImageResources.Search;
            this.search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.search.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(558, 3);
            this.search.Name = "search";
            this.search.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.search.Size = new System.Drawing.Size(39, 30);
            this.search.TabIndex = 1;
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(600, 36);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private CommonButton search;
        public TextBoxes.DefaultTextBox searchTerm;
    }
}
