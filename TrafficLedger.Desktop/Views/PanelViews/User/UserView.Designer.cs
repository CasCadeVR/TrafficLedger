using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    partial class UserView
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
            this.buttonLogout = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonDriver = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonDriverLicense = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonListUserPayments = new TrafficLedger.Desktop.Components.CommonButton();
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
            this.tableLayoutPanelMain.Controls.Add(this.buttonDriver, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonDriverLicense, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonListUserPayments, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonLogout, 0, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.75298F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.82113F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.82113F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.60477F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonLogout.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonLogout.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonLogout.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonLogout.Location = new System.Drawing.Point(194, 324);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonLogout.Size = new System.Drawing.Size(315, 45);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Выйти из аккаунта";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonDriver
            // 
            this.buttonDriver.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDriver.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDriver.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriver.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDriver.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDriver.Location = new System.Drawing.Point(195, 125);
            this.buttonDriver.Name = "buttonDriver";
            this.buttonDriver.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonDriver.Size = new System.Drawing.Size(314, 45);
            this.buttonDriver.TabIndex = 0;
            this.buttonDriver.Text = "Данные водителя";
            this.buttonDriver.UseVisualStyleBackColor = false;
            this.buttonDriver.Click += new System.EventHandler(this.buttonDriver_Click);
            // 
            // buttonDriverLicense
            // 
            this.buttonDriverLicense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDriverLicense.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDriverLicense.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDriverLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDriverLicense.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDriverLicense.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDriverLicense.Location = new System.Drawing.Point(194, 187);
            this.buttonDriverLicense.Name = "buttonDriverLicense";
            this.buttonDriverLicense.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonDriverLicense.Size = new System.Drawing.Size(315, 45);
            this.buttonDriverLicense.TabIndex = 1;
            this.buttonDriverLicense.Text = "Данные водительского удостоверения";
            this.buttonDriverLicense.UseVisualStyleBackColor = false;
            this.buttonDriverLicense.Click += new System.EventHandler(this.buttonDriverLicense_Click);
            // 
            // buttonListUserPayments
            // 
            this.buttonListUserPayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListUserPayments.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonListUserPayments.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonListUserPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListUserPayments.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonListUserPayments.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonListUserPayments.Location = new System.Drawing.Point(194, 261);
            this.buttonListUserPayments.Name = "buttonListUserPayments";
            this.buttonListUserPayments.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonListUserPayments.Size = new System.Drawing.Size(315, 45);
            this.buttonListUserPayments.TabIndex = 3;
            this.buttonListUserPayments.Text = "Оплаченные штрафы";
            this.buttonListUserPayments.UseVisualStyleBackColor = false;
            this.buttonListUserPayments.Click += new System.EventHandler(this.buttonListUserPayments_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "UserView";
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonDriverLicense;
        private CommonButton buttonDriver;
        private CommonButton buttonLogout;
        private CommonButton buttonListUserPayments;
    }
}
