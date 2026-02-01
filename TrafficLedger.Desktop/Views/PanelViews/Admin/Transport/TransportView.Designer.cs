namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    partial class TransportView
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonAddTransport = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonListTransport = new TrafficLedger.Desktop.Components.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelMain);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonAddTransport, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonListTransport, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonAddTransport
            // 
            this.buttonAddTransport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAddTransport.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonAddTransport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTransport.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonAddTransport.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonAddTransport.Location = new System.Drawing.Point(195, 202);
            this.buttonAddTransport.Name = "buttonAddTransport";
            this.buttonAddTransport.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonAddTransport.Size = new System.Drawing.Size(314, 45);
            this.buttonAddTransport.TabIndex = 0;
            this.buttonAddTransport.Text = "Добавить транспорт";
            this.buttonAddTransport.UseVisualStyleBackColor = false;
            this.buttonAddTransport.Click += new System.EventHandler(this.buttonAddTransport_Click);
            // 
            // buttonListTransport
            // 
            this.buttonListTransport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonListTransport.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonListTransport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonListTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListTransport.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonListTransport.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonListTransport.Location = new System.Drawing.Point(194, 253);
            this.buttonListTransport.Name = "buttonListTransport";
            this.buttonListTransport.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonListTransport.Size = new System.Drawing.Size(315, 45);
            this.buttonListTransport.TabIndex = 2;
            this.buttonListTransport.Text = "Список транспортов";
            this.buttonListTransport.UseVisualStyleBackColor = false;
            this.buttonListTransport.Click += new System.EventHandler(this.buttonListTransport_Click);
            // 
            // TransportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "TransportView";
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.CommonButton buttonAddTransport;
        private Components.CommonButton buttonListTransport;
    }
}
