using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Requests
{
    partial class RequestView
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
            buttonDriverLicenses = new CommonButton();
            buttonTransports = new CommonButton();
            buttonPayments = new CommonButton();
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
            tableLayoutPanelMain.Controls.Add(buttonPayments, 0, 4);
            tableLayoutPanelMain.Controls.Add(buttonTransports, 0, 3);
            tableLayoutPanelMain.Controls.Add(buttonDriverLicenses, 0, 2);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 7;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonDriverLicenses
            // 
            buttonDriverLicenses.Anchor = AnchorStyles.None;
            buttonDriverLicenses.BackColor = Color.BlueViolet;
            buttonDriverLicenses.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDriverLicenses.FlatStyle = FlatStyle.Flat;
            buttonDriverLicenses.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDriverLicenses.ForeColor = Color.AntiqueWhite;
            buttonDriverLicenses.Location = new Point(219, 179);
            buttonDriverLicenses.Margin = new Padding(4, 3, 4, 3);
            buttonDriverLicenses.Name = "buttonDriverLicenses";
            buttonDriverLicenses.Padding = new Padding(9, 5, 9, 5);
            buttonDriverLicenses.Size = new Size(382, 52);
            buttonDriverLicenses.TabIndex = 1;
            buttonDriverLicenses.Text = "Данные водительских удостоверений";
            buttonDriverLicenses.UseVisualStyleBackColor = false;
            buttonDriverLicenses.Click += buttonDriverLicenses_Click;
            // 
            // buttonTransports
            // 
            buttonTransports.Anchor = AnchorStyles.None;
            buttonTransports.BackColor = Color.BlueViolet;
            buttonTransports.FlatAppearance.BorderColor = Color.DarkGray;
            buttonTransports.FlatStyle = FlatStyle.Flat;
            buttonTransports.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonTransports.ForeColor = Color.AntiqueWhite;
            buttonTransports.Location = new Point(219, 261);
            buttonTransports.Margin = new Padding(4, 3, 4, 3);
            buttonTransports.Name = "buttonTransports";
            buttonTransports.Padding = new Padding(9, 5, 9, 5);
            buttonTransports.Size = new Size(382, 51);
            buttonTransports.TabIndex = 2;
            buttonTransports.Text = "Данные автомобилей";
            buttonTransports.UseVisualStyleBackColor = false;
            buttonTransports.Click += buttonTransports_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.Anchor = AnchorStyles.None;
            buttonPayments.BackColor = Color.BlueViolet;
            buttonPayments.FlatAppearance.BorderColor = Color.DarkGray;
            buttonPayments.FlatStyle = FlatStyle.Flat;
            buttonPayments.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonPayments.ForeColor = Color.AntiqueWhite;
            buttonPayments.Location = new Point(219, 343);
            buttonPayments.Margin = new Padding(4, 3, 4, 3);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Padding = new Padding(9, 5, 9, 5);
            buttonPayments.Size = new Size(382, 51);
            buttonPayments.TabIndex = 7;
            buttonPayments.Text = "Данные чеков";
            buttonPayments.UseVisualStyleBackColor = false;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // RequestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "RequestView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonDriverLicenses;
        private CommonButton buttonTransports;
        private CommonButton buttonPayments;
    }
}
