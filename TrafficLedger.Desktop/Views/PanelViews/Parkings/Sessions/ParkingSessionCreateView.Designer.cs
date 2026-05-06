using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions
{
    partial class ParkingSessionCreateView
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
            primaryLabel2 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            numericUpDownHourlyRate = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.ReadOnlyNumericUpDown();
            primaryLabel1 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            comboBoxTransport = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHourlyRate).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(webView, 0, 4);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 10);
            tableLayoutPanelMain.Controls.Add(primaryLabel2, 0, 3);
            tableLayoutPanelMain.Controls.Add(numericUpDownHourlyRate, 1, 3);
            tableLayoutPanelMain.Controls.Add(primaryLabel1, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxAddress, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelCode, 0, 1);
            tableLayoutPanelMain.Controls.Add(comboBoxTransport, 1, 1);
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
            webView.Location = new Point(3, 195);
            webView.Name = "webView";
            tableLayoutPanelMain.SetRowSpan(webView, 6);
            webView.Size = new Size(815, 282);
            webView.Source = new Uri("https://www.google.com/maps", UriKind.Absolute);
            webView.TabIndex = 26;
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
            // primaryLabel2
            // 
            primaryLabel2.Anchor = AnchorStyles.Right;
            primaryLabel2.AutoSize = true;
            primaryLabel2.Font = new Font("Segoe UI", 9.75F);
            primaryLabel2.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel2.Location = new Point(195, 159);
            primaryLabel2.Margin = new Padding(4, 0, 4, 0);
            primaryLabel2.Name = "primaryLabel2";
            primaryLabel2.Size = new Size(211, 17);
            primaryLabel2.TabIndex = 23;
            primaryLabel2.Text = "Стоимость стоянки в час (в руб.): ";
            // 
            // numericUpDownHourlyRate
            // 
            numericUpDownHourlyRate.Anchor = AnchorStyles.Left;
            numericUpDownHourlyRate.BackColor = Color.GhostWhite;
            numericUpDownHourlyRate.BorderStyle = BorderStyle.None;
            numericUpDownHourlyRate.Enabled = false;
            numericUpDownHourlyRate.Font = new Font("Consolas", 9.75F);
            numericUpDownHourlyRate.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownHourlyRate.Location = new Point(413, 158);
            numericUpDownHourlyRate.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownHourlyRate.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownHourlyRate.Name = "numericUpDownHourlyRate";
            numericUpDownHourlyRate.ReadOnly = true;
            numericUpDownHourlyRate.Size = new Size(288, 19);
            numericUpDownHourlyRate.TabIndex = 24;
            numericUpDownHourlyRate.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // primaryLabel1
            // 
            primaryLabel1.Anchor = AnchorStyles.Right;
            primaryLabel1.AutoSize = true;
            primaryLabel1.Font = new Font("Segoe UI", 9.75F);
            primaryLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel1.Location = new Point(355, 111);
            primaryLabel1.Margin = new Padding(4, 0, 4, 0);
            primaryLabel1.Name = "primaryLabel1";
            primaryLabel1.Size = new Size(51, 17);
            primaryLabel1.TabIndex = 21;
            primaryLabel1.Text = "Адрес: ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.BackColor = Color.GhostWhite;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Consolas", 9.75F);
            textBoxAddress.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxAddress.Location = new Point(413, 112);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(405, 16);
            textBoxAddress.TabIndex = 25;
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 9.75F);
            labelCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelCode.Location = new Point(296, 63);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(110, 17);
            labelCode.TabIndex = 6;
            labelCode.Text = "Код транспорта: ";
            // 
            // comboBoxTransport
            // 
            comboBoxTransport.Anchor = AnchorStyles.Left;
            comboBoxTransport.BackColor = Color.White;
            comboBoxTransport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTransport.Font = new Font("Segoe UI", 9.75F);
            comboBoxTransport.ForeColor = Color.FromArgb(0, 0, 0);
            comboBoxTransport.FormattingEnabled = true;
            comboBoxTransport.Location = new Point(413, 59);
            comboBoxTransport.Name = "comboBoxTransport";
            comboBoxTransport.Size = new Size(288, 25);
            comboBoxTransport.TabIndex = 27;
            comboBoxTransport.SelectedIndexChanged += comboBoxTransport_SelectedIndexChanged;
            // 
            // ParkingSessionCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "ParkingSessionCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHourlyRate).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelCode;
        private CommonButton buttonSave;
        private Components.Labels.PrimaryLabel primaryLabel1;
        private Components.Labels.PrimaryLabel primaryLabel2;
        private Components.Controls.NumericUpDowns.ReadOnlyNumericUpDown numericUpDownHourlyRate;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxAddress;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Components.Controls.TextBoxes.DefaultComboBox comboBoxTransport;
    }
}
