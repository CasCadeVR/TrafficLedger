namespace TrafficLedger.Desktop
{
    partial class MainView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            splitContainer = new SplitContainer();
            flowLayoutPanelButtons = new FlowLayoutPanel();
            mainContentPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.FixedPanel = FixedPanel.Panel1;
            splitContainer.IsSplitterFixed = true;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Margin = new Padding(0);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(flowLayoutPanelButtons);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(mainContentPanel);
            splitContainer.Size = new Size(809, 861);
            splitContainer.SplitterDistance = 112;
            splitContainer.TabIndex = 0;
            // 
            // flowLayoutPanelButtons
            // 
            flowLayoutPanelButtons.AutoScroll = true;
            flowLayoutPanelButtons.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanelButtons.Dock = DockStyle.Fill;
            flowLayoutPanelButtons.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelButtons.Location = new Point(0, 0);
            flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            flowLayoutPanelButtons.Size = new Size(112, 861);
            flowLayoutPanelButtons.TabIndex = 0;
            flowLayoutPanelButtons.WrapContents = false;
            // 
            // mainContentPanel
            // 
            mainContentPanel.Dock = DockStyle.Fill;
            mainContentPanel.Location = new Point(0, 0);
            mainContentPanel.Name = "mainContentPanel";
            mainContentPanel.Size = new Size(693, 861);
            mainContentPanel.TabIndex = 0;
            // 
            // MainView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 861);
            Controls.Add(splitContainer);
            Margin = new Padding(5, 4, 5, 4);
            MinimumSize = new Size(825, 900);
            Name = "MainView";
            Text = "TrafficLedger";
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Panel mainContentPanel;
    }
}

