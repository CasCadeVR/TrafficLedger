namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Payments
{
    partial class PaymentListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainerPanel = new System.Windows.Forms.SplitContainer();
            this.readOnlyTextBox1 = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.searchBar = new TrafficLedger.Desktop.Components.Controls.SearchBars.SearchBar();
            this.tableLayoutPanelWithActive = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxShowUnactive = new TrafficLedger.Desktop.Components.Controls.CheckBoxes.DefaultCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPanel)).BeginInit();
            this.splitContainerPanel.Panel1.SuspendLayout();
            this.splitContainerPanel.Panel2.SuspendLayout();
            this.splitContainerPanel.SuspendLayout();
            this.tableLayoutPanelWithActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.splitContainerPanel);
            this.splitContainer.Size = new System.Drawing.Size(600, 600);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(3, 39);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(594, 418);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // splitContainerPanel
            // 
            this.splitContainerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerPanel.IsSplitterFixed = true;
            this.splitContainerPanel.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPanel.Name = "splitContainerPanel";
            this.splitContainerPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerPanel.Panel1
            // 
            this.splitContainerPanel.Panel1.Controls.Add(this.readOnlyTextBox1);
            this.splitContainerPanel.Panel1.Controls.Add(this.searchBar);
            // 
            // splitContainerPanel.Panel2
            // 
            this.splitContainerPanel.Panel2.Controls.Add(this.tableLayoutPanelWithActive);
            this.splitContainerPanel.Size = new System.Drawing.Size(600, 500);
            this.splitContainerPanel.SplitterDistance = 36;
            this.splitContainerPanel.TabIndex = 1;
            // 
            // readOnlyTextBox1
            // 
            this.readOnlyTextBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.readOnlyTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readOnlyTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.readOnlyTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.readOnlyTextBox1.Location = new System.Drawing.Point(456, 58);
            this.readOnlyTextBox1.Name = "readOnlyTextBox1";
            this.readOnlyTextBox1.ReadOnly = true;
            this.readOnlyTextBox1.Size = new System.Drawing.Size(8, 16);
            this.readOnlyTextBox1.TabIndex = 1;
            // 
            // searchBar
            // 
            this.searchBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBar.Location = new System.Drawing.Point(0, 0);
            this.searchBar.Margin = new System.Windows.Forms.Padding(0);
            this.searchBar.Name = "searchBar";
            this.searchBar.Size = new System.Drawing.Size(600, 36);
            this.searchBar.TabIndex = 0;
            // 
            // tableLayoutPanelWithActive
            // 
            this.tableLayoutPanelWithActive.ColumnCount = 1;
            this.tableLayoutPanelWithActive.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelWithActive.Controls.Add(this.flowLayoutPanel, 0, 1);
            this.tableLayoutPanelWithActive.Controls.Add(this.checkBoxShowUnactive, 0, 0);
            this.tableLayoutPanelWithActive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelWithActive.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelWithActive.Name = "tableLayoutPanelWithActive";
            this.tableLayoutPanelWithActive.RowCount = 2;
            this.tableLayoutPanelWithActive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8F));
            this.tableLayoutPanelWithActive.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92F));
            this.tableLayoutPanelWithActive.Size = new System.Drawing.Size(600, 460);
            this.tableLayoutPanelWithActive.TabIndex = 2;
            // 
            // checkBoxShowUnactive
            // 
            this.checkBoxShowUnactive.BackColor = System.Drawing.Color.White;
            this.checkBoxShowUnactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxShowUnactive.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.checkBoxShowUnactive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.checkBoxShowUnactive.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShowUnactive.Name = "checkBoxShowUnactive";
            this.checkBoxShowUnactive.Size = new System.Drawing.Size(594, 30);
            this.checkBoxShowUnactive.TabIndex = 1;
            this.checkBoxShowUnactive.Text = "Показать одобренные чеки";
            this.checkBoxShowUnactive.UseVisualStyleBackColor = false;
            this.checkBoxShowUnactive.CheckedChanged += new System.EventHandler(this.checkBoxShowUnactive_CheckedChanged);
            // 
            // PaymentListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PaymentListView";
            this.Size = new System.Drawing.Size(600, 600);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.splitContainerPanel.Panel1.ResumeLayout(false);
            this.splitContainerPanel.Panel1.PerformLayout();
            this.splitContainerPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPanel)).EndInit();
            this.splitContainerPanel.ResumeLayout(false);
            this.tableLayoutPanelWithActive.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainerPanel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox readOnlyTextBox1;
        private Components.Controls.SearchBars.SearchBar searchBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWithActive;
        private Components.Controls.CheckBoxes.DefaultCheckBox checkBoxShowUnactive;
    }
}
