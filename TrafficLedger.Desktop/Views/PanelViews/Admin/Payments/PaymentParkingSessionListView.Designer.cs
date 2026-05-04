namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Payments
{
    partial class PaymentParkingSessionListView
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
            flowLayoutPanel = new FlowLayoutPanel();
            splitContainerPanel = new SplitContainer();
            readOnlyTextBox1 = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            searchBar = new TrafficLedger.Desktop.Components.Controls.SearchBars.SearchBar();
            tableLayoutPanelWithActive = new TableLayoutPanel();
            checkBoxShowApproved = new TrafficLedger.Desktop.Components.Controls.CheckBoxes.DefaultCheckBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerPanel).BeginInit();
            splitContainerPanel.Panel1.SuspendLayout();
            splitContainerPanel.Panel2.SuspendLayout();
            splitContainerPanel.SuspendLayout();
            tableLayoutPanelWithActive.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Margin = new Padding(5, 3, 5, 3);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(splitContainerPanel);
            splitContainer.Size = new Size(700, 692);
            splitContainer.SplitterDistance = 128;
            splitContainer.SplitterWidth = 6;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.Location = new Point(4, 43);
            flowLayoutPanel.Margin = new Padding(4, 3, 4, 3);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(692, 465);
            flowLayoutPanel.TabIndex = 0;
            // 
            // splitContainerPanel
            // 
            splitContainerPanel.Dock = DockStyle.Fill;
            splitContainerPanel.FixedPanel = FixedPanel.Panel1;
            splitContainerPanel.IsSplitterFixed = true;
            splitContainerPanel.Location = new Point(0, 0);
            splitContainerPanel.Margin = new Padding(4, 3, 4, 3);
            splitContainerPanel.Name = "splitContainerPanel";
            splitContainerPanel.Orientation = Orientation.Horizontal;
            // 
            // splitContainerPanel.Panel1
            // 
            splitContainerPanel.Panel1.Controls.Add(readOnlyTextBox1);
            splitContainerPanel.Panel1.Controls.Add(searchBar);
            // 
            // splitContainerPanel.Panel2
            // 
            splitContainerPanel.Panel2.Controls.Add(tableLayoutPanelWithActive);
            splitContainerPanel.Size = new Size(700, 558);
            splitContainerPanel.SplitterDistance = 42;
            splitContainerPanel.SplitterWidth = 5;
            splitContainerPanel.TabIndex = 1;
            // 
            // readOnlyTextBox1
            // 
            readOnlyTextBox1.BackColor = Color.GhostWhite;
            readOnlyTextBox1.BorderStyle = BorderStyle.None;
            readOnlyTextBox1.Font = new Font("Consolas", 9.75F);
            readOnlyTextBox1.ForeColor = Color.FromArgb(0, 0, 0);
            readOnlyTextBox1.Location = new Point(532, 67);
            readOnlyTextBox1.Margin = new Padding(4, 3, 4, 3);
            readOnlyTextBox1.Name = "readOnlyTextBox1";
            readOnlyTextBox1.ReadOnly = true;
            readOnlyTextBox1.Size = new Size(9, 16);
            readOnlyTextBox1.TabIndex = 1;
            // 
            // searchBar
            // 
            searchBar.Cursor = Cursors.Hand;
            searchBar.Dock = DockStyle.Fill;
            searchBar.Location = new Point(0, 0);
            searchBar.Margin = new Padding(0);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(700, 42);
            searchBar.TabIndex = 0;
            // 
            // tableLayoutPanelWithActive
            // 
            tableLayoutPanelWithActive.ColumnCount = 1;
            tableLayoutPanelWithActive.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelWithActive.Controls.Add(flowLayoutPanel, 0, 1);
            tableLayoutPanelWithActive.Controls.Add(checkBoxShowApproved, 0, 0);
            tableLayoutPanelWithActive.Dock = DockStyle.Fill;
            tableLayoutPanelWithActive.Location = new Point(0, 0);
            tableLayoutPanelWithActive.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelWithActive.Name = "tableLayoutPanelWithActive";
            tableLayoutPanelWithActive.RowCount = 2;
            tableLayoutPanelWithActive.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tableLayoutPanelWithActive.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tableLayoutPanelWithActive.Size = new Size(700, 511);
            tableLayoutPanelWithActive.TabIndex = 2;
            // 
            // checkBoxShowApproved
            // 
            checkBoxShowApproved.BackColor = Color.White;
            checkBoxShowApproved.Dock = DockStyle.Fill;
            checkBoxShowApproved.Font = new Font("Segoe UI", 9.75F);
            checkBoxShowApproved.ForeColor = Color.FromArgb(0, 0, 0);
            checkBoxShowApproved.Location = new Point(4, 3);
            checkBoxShowApproved.Margin = new Padding(4, 3, 4, 3);
            checkBoxShowApproved.Name = "checkBoxShowApproved";
            checkBoxShowApproved.Size = new Size(692, 34);
            checkBoxShowApproved.TabIndex = 1;
            checkBoxShowApproved.Text = "Показать одобренные чеки";
            checkBoxShowApproved.UseVisualStyleBackColor = false;
            checkBoxShowApproved.CheckedChanged += checkBoxShowApproved_CheckedChanged;
            // 
            // PaymentFineListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "PaymentFineListView";
            Size = new Size(700, 692);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            splitContainerPanel.Panel1.ResumeLayout(false);
            splitContainerPanel.Panel1.PerformLayout();
            splitContainerPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerPanel).EndInit();
            splitContainerPanel.ResumeLayout(false);
            tableLayoutPanelWithActive.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.SplitContainer splitContainerPanel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox readOnlyTextBox1;
        private Components.Controls.SearchBars.SearchBar searchBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelWithActive;
        private Components.Controls.CheckBoxes.DefaultCheckBox checkBoxShowApproved;
    }
}
