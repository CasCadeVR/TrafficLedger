using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    partial class PaymentParkingSessionCreateView
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxTransportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelTransportCodeTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonSave = new CommonButton();
            labelSessionPrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxSessionPrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            statusLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxStatus = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanelMain);
            splitContainer.Size = new Size(821, 710);
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(webView, 0, 5);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 12);
            tableLayoutPanelMain.Controls.Add(statusLabel, 0, 11);
            tableLayoutPanelMain.Controls.Add(textBoxStatus, 1, 11);
            tableLayoutPanelMain.Controls.Add(labelSessionPrice, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxSessionPrice, 1, 4);
            tableLayoutPanelMain.Controls.Add(labelAddressTitle, 0, 3);
            tableLayoutPanelMain.Controls.Add(textBoxAddress, 1, 3);
            tableLayoutPanelMain.Controls.Add(labelDate, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxDate, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelTransportCodeTitle, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxTransportCode, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 14;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 594);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            tableLayoutPanelMain.SetColumnSpan(webView, 2);
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(3, 204);
            webView.Name = "webView";
            tableLayoutPanelMain.SetRowSpan(webView, 6);
            webView.Size = new Size(815, 282);
            webView.Source = new Uri("https://www.google.com/maps", UriKind.Absolute);
            webView.TabIndex = 37;
            webView.ZoomFactor = 1D;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left;
            textBoxAddress.BackColor = Color.GhostWhite;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Consolas", 9.75F);
            textBoxAddress.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxAddress.Location = new Point(414, 121);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(287, 16);
            textBoxAddress.TabIndex = 32;
            textBoxAddress.Text = ". . .";
            // 
            // labelAddressTitle
            // 
            labelAddressTitle.Anchor = AnchorStyles.Right;
            labelAddressTitle.AutoSize = true;
            labelAddressTitle.Font = new Font("Segoe UI", 9.75F);
            labelAddressTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddressTitle.Location = new Point(227, 120);
            labelAddressTitle.Margin = new Padding(4, 0, 4, 0);
            labelAddressTitle.Name = "labelAddressTitle";
            labelAddressTitle.Size = new Size(179, 17);
            labelAddressTitle.TabIndex = 31;
            labelAddressTitle.Text = "Адрес парковочного места: ";
            // 
            // textBoxTransportCode
            // 
            textBoxTransportCode.Anchor = AnchorStyles.Left;
            textBoxTransportCode.BackColor = Color.GhostWhite;
            textBoxTransportCode.BorderStyle = BorderStyle.None;
            textBoxTransportCode.Font = new Font("Consolas", 9.75F);
            textBoxTransportCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxTransportCode.Location = new Point(414, 25);
            textBoxTransportCode.Margin = new Padding(4, 3, 4, 3);
            textBoxTransportCode.Name = "textBoxTransportCode";
            textBoxTransportCode.ReadOnly = true;
            textBoxTransportCode.Size = new Size(287, 16);
            textBoxTransportCode.TabIndex = 30;
            textBoxTransportCode.Text = ". . .";
            // 
            // labelTransportCodeTitle
            // 
            labelTransportCodeTitle.Anchor = AnchorStyles.Right;
            labelTransportCodeTitle.AutoSize = true;
            labelTransportCodeTitle.Font = new Font("Segoe UI", 9.75F);
            labelTransportCodeTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelTransportCodeTitle.Location = new Point(296, 24);
            labelTransportCodeTitle.Margin = new Padding(4, 0, 4, 0);
            labelTransportCodeTitle.Name = "labelTransportCodeTitle";
            labelTransportCodeTitle.Size = new Size(110, 17);
            labelTransportCodeTitle.TabIndex = 29;
            labelTransportCodeTitle.Text = "Номер машины: ";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9.75F);
            labelDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelDate.Location = new Point(317, 72);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(89, 17);
            labelDate.TabIndex = 6;
            labelDate.Text = "Дата начала: ";
            // 
            // textBoxDate
            // 
            textBoxDate.Anchor = AnchorStyles.Left;
            textBoxDate.BackColor = Color.GhostWhite;
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Font = new Font("Consolas", 9.75F);
            textBoxDate.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxDate.Location = new Point(414, 73);
            textBoxDate.Margin = new Padding(4, 3, 4, 3);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(287, 16);
            textBoxDate.TabIndex = 27;
            textBoxDate.Text = ". . .";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.BackColor = Color.Green;
            tableLayoutPanelMain.SetColumnSpan(buttonSave, 2);
            buttonSave.FlatAppearance.BorderColor = Color.DarkGray;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(208, 540);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 42);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Оплатить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelSessionPrice
            // 
            labelSessionPrice.Anchor = AnchorStyles.Right;
            labelSessionPrice.AutoSize = true;
            labelSessionPrice.Font = new Font("Segoe UI", 9.75F);
            labelSessionPrice.ForeColor = Color.FromArgb(0, 0, 0);
            labelSessionPrice.Location = new Point(352, 168);
            labelSessionPrice.Margin = new Padding(4, 0, 4, 0);
            labelSessionPrice.Name = "labelSessionPrice";
            labelSessionPrice.Size = new Size(54, 17);
            labelSessionPrice.TabIndex = 19;
            labelSessionPrice.Text = "Сумма: ";
            // 
            // textBoxSessionPrice
            // 
            textBoxSessionPrice.Anchor = AnchorStyles.Left;
            textBoxSessionPrice.BackColor = Color.GhostWhite;
            textBoxSessionPrice.BorderStyle = BorderStyle.None;
            textBoxSessionPrice.Font = new Font("Consolas", 9.75F);
            textBoxSessionPrice.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxSessionPrice.Location = new Point(414, 169);
            textBoxSessionPrice.Margin = new Padding(4, 3, 4, 3);
            textBoxSessionPrice.Name = "textBoxSessionPrice";
            textBoxSessionPrice.ReadOnly = true;
            textBoxSessionPrice.Size = new Size(287, 16);
            textBoxSessionPrice.TabIndex = 25;
            textBoxSessionPrice.Text = ". . .";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 9.75F);
            statusLabel.ForeColor = Color.FromArgb(0, 0, 0);
            statusLabel.Location = new Point(354, 504);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 17);
            statusLabel.TabIndex = 35;
            statusLabel.Text = "Статус: ";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Left;
            textBoxStatus.BackColor = Color.GhostWhite;
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Consolas", 9.75F);
            textBoxStatus.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxStatus.Location = new Point(414, 505);
            textBoxStatus.Margin = new Padding(4, 3, 4, 3);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(287, 16);
            textBoxStatus.TabIndex = 36;
            textBoxStatus.Text = ". . .";
            // 
            // PaymentParkingSessionCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "PaymentParkingSessionCreateView";
            Size = new Size(821, 710);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelDate;
        private CommonButton buttonSave;
        private Components.Labels.PrimaryLabel labelSessionPrice;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxSessionPrice;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxDate;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxTransportCode;
        private Components.Labels.PrimaryLabel labelTransportCodeTitle;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxAddress;
        private Components.Labels.PrimaryLabel labelAddressTitle;
        private Components.Labels.PrimaryLabel statusLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxStatus;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
