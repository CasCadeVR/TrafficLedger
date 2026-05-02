using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Parkings
{
    partial class ParkingZoneCreateView
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
            buttonSave = new CommonButton();
            linkCheckButton = new CommonButton();
            textBoxLink = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            primaryLabel1 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            checkBoxActive = new TrafficLedger.Desktop.Components.Controls.CheckBoxes.DefaultCheckBox();
            labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            numericUpDownPrice = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
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
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(webView, 0, 6);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 10);
            tableLayoutPanelMain.Controls.Add(linkCheckButton, 1, 5);
            tableLayoutPanelMain.Controls.Add(textBoxLink, 1, 4);
            tableLayoutPanelMain.Controls.Add(primaryLabel1, 0, 4);
            tableLayoutPanelMain.Controls.Add(checkBoxActive, 0, 3);
            tableLayoutPanelMain.Controls.Add(labelName, 0, 2);
            tableLayoutPanelMain.Controls.Add(numericUpDownPrice, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelCode, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxAddress, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 12;
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
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            tableLayoutPanelMain.SetColumnSpan(webView, 2);
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(3, 291);
            webView.Name = "webView";
            tableLayoutPanelMain.SetRowSpan(webView, 4);
            webView.Size = new Size(815, 186);
            webView.Source = new Uri("https://www.google.com/maps", UriKind.Absolute);
            webView.TabIndex = 25;
            webView.ZoomFactor = 1D;
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
            buttonSave.Location = new Point(208, 483);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 42);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // linkCheckButton
            // 
            linkCheckButton.Anchor = AnchorStyles.Top;
            linkCheckButton.BackColor = Color.Green;
            linkCheckButton.FlatAppearance.BorderColor = Color.DarkGray;
            linkCheckButton.FlatStyle = FlatStyle.Flat;
            linkCheckButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            linkCheckButton.ForeColor = Color.White;
            linkCheckButton.Location = new Point(508, 243);
            linkCheckButton.Name = "linkCheckButton";
            linkCheckButton.Padding = new Padding(8, 4, 8, 4);
            linkCheckButton.Size = new Size(214, 38);
            linkCheckButton.TabIndex = 24;
            linkCheckButton.Text = "Проверить ссылку";
            linkCheckButton.UseVisualStyleBackColor = false;
            linkCheckButton.Click += linkCheckButton_Click;
            // 
            // textBoxLink
            // 
            textBoxLink.Anchor = AnchorStyles.Left;
            textBoxLink.BackColor = Color.White;
            textBoxLink.BorderStyle = BorderStyle.FixedSingle;
            textBoxLink.Font = new Font("Segoe UI", 9.75F);
            textBoxLink.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxLink.Location = new Point(414, 203);
            textBoxLink.Margin = new Padding(4, 3, 4, 3);
            textBoxLink.Name = "textBoxLink";
            textBoxLink.Size = new Size(287, 25);
            textBoxLink.TabIndex = 23;
            // 
            // primaryLabel1
            // 
            primaryLabel1.Anchor = AnchorStyles.Right;
            primaryLabel1.AutoSize = true;
            primaryLabel1.Font = new Font("Segoe UI", 9.75F);
            primaryLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel1.Location = new Point(193, 207);
            primaryLabel1.Margin = new Padding(4, 0, 4, 0);
            primaryLabel1.Name = "primaryLabel1";
            primaryLabel1.Size = new Size(213, 17);
            primaryLabel1.TabIndex = 22;
            primaryLabel1.Text = "Ссылка на координаты на картах: ";
            // 
            // checkBoxActive
            // 
            checkBoxActive.Anchor = AnchorStyles.None;
            checkBoxActive.BackColor = Color.White;
            tableLayoutPanelMain.SetColumnSpan(checkBoxActive, 2);
            checkBoxActive.Font = new Font("Segoe UI", 9.75F);
            checkBoxActive.ForeColor = Color.FromArgb(0, 0, 0);
            checkBoxActive.Location = new Point(358, 156);
            checkBoxActive.Name = "checkBoxActive";
            checkBoxActive.Size = new Size(104, 24);
            checkBoxActive.TabIndex = 21;
            checkBoxActive.Text = "Активен";
            checkBoxActive.UseVisualStyleBackColor = false;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F);
            labelName.ForeColor = Color.FromArgb(0, 0, 0);
            labelName.Location = new Point(195, 111);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(211, 17);
            labelName.TabIndex = 13;
            labelName.Text = "Стоимость стоянки в час (в руб.): ";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Anchor = AnchorStyles.Left;
            numericUpDownPrice.BackColor = Color.White;
            numericUpDownPrice.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownPrice.Font = new Font("Segoe UI", 9.75F);
            numericUpDownPrice.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownPrice.Location = new Point(414, 107);
            numericUpDownPrice.Margin = new Padding(4, 3, 4, 3);
            numericUpDownPrice.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(287, 25);
            numericUpDownPrice.TabIndex = 20;
            numericUpDownPrice.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 9.75F);
            labelCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelCode.Location = new Point(355, 63);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(51, 17);
            labelCode.TabIndex = 6;
            labelCode.Text = "Адрес: ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left;
            textBoxAddress.BackColor = Color.White;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Font = new Font("Segoe UI", 9.75F);
            textBoxAddress.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxAddress.Location = new Point(414, 59);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(287, 25);
            textBoxAddress.TabIndex = 10;
            // 
            // ParkingZoneCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "ParkingZoneCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelCode;
        private CommonButton buttonSave;
        private Components.Labels.PrimaryLabel labelName;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxAddress;
        private Components.Controls.NumericUpDowns.DefaultNumericUpDown numericUpDownPrice;
        private Components.Controls.CheckBoxes.DefaultCheckBox checkBoxActive;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxLink;
        private Components.Labels.PrimaryLabel primaryLabel1;
        private CommonButton linkCheckButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
