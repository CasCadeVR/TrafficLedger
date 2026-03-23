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
            tableLayoutPanelMain = new TableLayoutPanel();
            buttonDriver = new CommonButton();
            buttonDriverLicense = new CommonButton();
            buttonListUserPayments = new CommonButton();
            buttonLogout = new CommonButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanelMain);
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(buttonLogout, 0, 4);
            tableLayoutPanelMain.Controls.Add(buttonListUserPayments, 0, 3);
            tableLayoutPanelMain.Controls.Add(buttonDriverLicense, 0, 2);
            tableLayoutPanelMain.Controls.Add(buttonDriver, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 6;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonDriver
            // 
            buttonDriver.Anchor = AnchorStyles.None;
            buttonDriver.BackColor = Color.BlueViolet;
            buttonDriver.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDriver.FlatStyle = FlatStyle.Flat;
            buttonDriver.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDriver.ForeColor = Color.AntiqueWhite;
            buttonDriver.Location = new Point(227, 118);
            buttonDriver.Margin = new Padding(4, 3, 4, 3);
            buttonDriver.Name = "buttonDriver";
            buttonDriver.Padding = new Padding(9, 5, 9, 5);
            buttonDriver.Size = new Size(366, 52);
            buttonDriver.TabIndex = 0;
            buttonDriver.Text = "Данные водителя";
            buttonDriver.UseVisualStyleBackColor = false;
            buttonDriver.Click += buttonDriver_Click;
            // 
            // buttonDriverLicense
            // 
            buttonDriverLicense.Anchor = AnchorStyles.None;
            buttonDriverLicense.BackColor = Color.BlueViolet;
            buttonDriverLicense.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDriverLicense.FlatStyle = FlatStyle.Flat;
            buttonDriverLicense.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDriverLicense.ForeColor = Color.AntiqueWhite;
            buttonDriverLicense.Location = new Point(226, 214);
            buttonDriverLicense.Margin = new Padding(4, 3, 4, 3);
            buttonDriverLicense.Name = "buttonDriverLicense";
            buttonDriverLicense.Padding = new Padding(9, 5, 9, 5);
            buttonDriverLicense.Size = new Size(368, 52);
            buttonDriverLicense.TabIndex = 1;
            buttonDriverLicense.Text = "Данные водительского удостоверения";
            buttonDriverLicense.UseVisualStyleBackColor = false;
            buttonDriverLicense.Click += buttonDriverLicense_Click;
            // 
            // buttonListUserPayments
            // 
            buttonListUserPayments.Anchor = AnchorStyles.None;
            buttonListUserPayments.BackColor = Color.BlueViolet;
            buttonListUserPayments.FlatAppearance.BorderColor = Color.DarkGray;
            buttonListUserPayments.FlatStyle = FlatStyle.Flat;
            buttonListUserPayments.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonListUserPayments.ForeColor = Color.AntiqueWhite;
            buttonListUserPayments.Location = new Point(226, 310);
            buttonListUserPayments.Margin = new Padding(4, 3, 4, 3);
            buttonListUserPayments.Name = "buttonListUserPayments";
            buttonListUserPayments.Padding = new Padding(9, 5, 9, 5);
            buttonListUserPayments.Size = new Size(368, 52);
            buttonListUserPayments.TabIndex = 3;
            buttonListUserPayments.Text = "Оплаченные штрафы";
            buttonListUserPayments.UseVisualStyleBackColor = false;
            buttonListUserPayments.Click += buttonListUserPayments_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.Anchor = AnchorStyles.None;
            buttonLogout.BackColor = Color.BlueViolet;
            buttonLogout.FlatAppearance.BorderColor = Color.DarkGray;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLogout.ForeColor = Color.AntiqueWhite;
            buttonLogout.Location = new Point(226, 406);
            buttonLogout.Margin = new Padding(4, 3, 4, 3);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Padding = new Padding(9, 5, 9, 5);
            buttonLogout.Size = new Size(368, 52);
            buttonLogout.TabIndex = 2;
            buttonLogout.Text = "Выйти из аккаунта";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "UserView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonDriverLicense;
        private CommonButton buttonDriver;
        private CommonButton buttonLogout;
        private CommonButton buttonListUserPayments;
    }
}
