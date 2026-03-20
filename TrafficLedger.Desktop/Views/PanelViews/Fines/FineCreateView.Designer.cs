using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Fines
{
    partial class FineCreateView
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
            textBoxFineDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            dateTimePickerDate = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
            labelDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            buttonSave = new CommonButton();
            textBoxDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            multiImageUploader = new TrafficLedger.Desktop.Components.ComplexControls.MultiImageUploader();
            labelFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            numericUpDownPrice = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            comboBoxViolation = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
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
            tableLayoutPanelMain.Controls.Add(textBoxFineDescription, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelAddressTitle, 0, 1);
            tableLayoutPanelMain.Controls.Add(labelDate, 0, 0);
            tableLayoutPanelMain.Controls.Add(dateTimePickerDate, 1, 0);
            tableLayoutPanelMain.Controls.Add(labelDescription, 0, 6);
            tableLayoutPanelMain.Controls.Add(labelDescriptionTitle, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxAddress, 1, 1);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 11);
            tableLayoutPanelMain.Controls.Add(textBoxDescription, 1, 6);
            tableLayoutPanelMain.Controls.Add(multiImageUploader, 0, 8);
            tableLayoutPanelMain.Controls.Add(labelFinePrice, 0, 3);
            tableLayoutPanelMain.Controls.Add(numericUpDownPrice, 1, 3);
            tableLayoutPanelMain.Controls.Add(labelCode, 0, 5);
            tableLayoutPanelMain.Controls.Add(labelName, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxCode, 1, 5);
            tableLayoutPanelMain.Controls.Add(comboBoxViolation, 1, 4);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 12;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.332583F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.335084F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.335084F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.335084F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333334F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 8.333334F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // textBoxFineDescription
            // 
            textBoxFineDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxFineDescription.BackColor = Color.White;
            textBoxFineDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxFineDescription.Font = new Font("Segoe UI", 9.75F);
            textBoxFineDescription.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxFineDescription.Location = new Point(414, 105);
            textBoxFineDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxFineDescription.Name = "textBoxFineDescription";
            textBoxFineDescription.Size = new Size(403, 25);
            textBoxFineDescription.TabIndex = 30;
            // 
            // labelAddressTitle
            // 
            labelAddressTitle.Anchor = AnchorStyles.Right;
            labelAddressTitle.AutoSize = true;
            labelAddressTitle.Font = new Font("Segoe UI", 9.75F);
            labelAddressTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddressTitle.Location = new Point(355, 62);
            labelAddressTitle.Margin = new Padding(4, 0, 4, 0);
            labelAddressTitle.Name = "labelAddressTitle";
            labelAddressTitle.Size = new Size(51, 17);
            labelAddressTitle.TabIndex = 27;
            labelAddressTitle.Text = "Адрес: ";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9.75F);
            labelDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelDate.Location = new Point(292, 15);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(114, 17);
            labelDate.TabIndex = 6;
            labelDate.Text = "Дата нарушения: ";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Anchor = AnchorStyles.Left;
            dateTimePickerDate.BackColor = Color.White;
            dateTimePickerDate.Font = new Font("Segoe UI", 9.75F);
            dateTimePickerDate.ForeColor = Color.FromArgb(0, 0, 0);
            dateTimePickerDate.Location = new Point(414, 11);
            dateTimePickerDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(286, 25);
            dateTimePickerDate.TabIndex = 21;
            dateTimePickerDate.Tag = "";
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9.75F);
            labelDescription.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescription.Location = new Point(333, 297);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(73, 17);
            labelDescription.TabIndex = 15;
            labelDescription.Text = "Описание: ";
            // 
            // labelDescriptionTitle
            // 
            labelDescriptionTitle.Anchor = AnchorStyles.Right;
            labelDescriptionTitle.AutoSize = true;
            labelDescriptionTitle.Font = new Font("Segoe UI", 9.75F);
            labelDescriptionTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescriptionTitle.Location = new Point(316, 109);
            labelDescriptionTitle.Margin = new Padding(4, 0, 4, 0);
            labelDescriptionTitle.Name = "labelDescriptionTitle";
            labelDescriptionTitle.Size = new Size(90, 17);
            labelDescriptionTitle.TabIndex = 28;
            labelDescriptionTitle.Text = "Примечание: ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxAddress.BackColor = Color.White;
            textBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            textBoxAddress.Font = new Font("Segoe UI", 9.75F);
            textBoxAddress.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxAddress.Location = new Point(414, 58);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(403, 25);
            textBoxAddress.TabIndex = 29;
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
            buttonSave.Location = new Point(208, 524);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 49);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.BackColor = Color.GhostWhite;
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Font = new Font("Consolas", 9.75F);
            textBoxDescription.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxDescription.Location = new Point(414, 285);
            textBoxDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            tableLayoutPanelMain.SetRowSpan(textBoxDescription, 2);
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(403, 89);
            textBoxDescription.TabIndex = 26;
            textBoxDescription.Text = ". . .";
            // 
            // multiImageUploader
            // 
            multiImageUploader.AutoScroll = true;
            multiImageUploader.BackColor = SystemColors.Control;
            tableLayoutPanelMain.SetColumnSpan(multiImageUploader, 2);
            multiImageUploader.Dock = DockStyle.Fill;
            multiImageUploader.Location = new Point(3, 380);
            multiImageUploader.Name = "multiImageUploader";
            multiImageUploader.Padding = new Padding(5);
            tableLayoutPanelMain.SetRowSpan(multiImageUploader, 3);
            multiImageUploader.Size = new Size(815, 138);
            multiImageUploader.TabIndex = 31;
            // 
            // labelFinePrice
            // 
            labelFinePrice.Anchor = AnchorStyles.Right;
            labelFinePrice.AutoSize = true;
            labelFinePrice.Font = new Font("Segoe UI", 9.75F);
            labelFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            labelFinePrice.Location = new Point(301, 156);
            labelFinePrice.Margin = new Padding(4, 0, 4, 0);
            labelFinePrice.Name = "labelFinePrice";
            labelFinePrice.Size = new Size(105, 17);
            labelFinePrice.TabIndex = 19;
            labelFinePrice.Text = "Сумма штрафа: ";
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownPrice.BackColor = Color.White;
            numericUpDownPrice.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownPrice.Font = new Font("Segoe UI", 9.75F);
            numericUpDownPrice.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownPrice.Location = new Point(413, 152);
            numericUpDownPrice.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(405, 25);
            numericUpDownPrice.TabIndex = 32;
            numericUpDownPrice.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 9.75F);
            labelCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelCode.Location = new Point(297, 250);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(109, 17);
            labelCode.TabIndex = 23;
            labelCode.Text = "Код нарушения: ";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F);
            labelName.ForeColor = Color.FromArgb(0, 0, 0);
            labelName.Location = new Point(322, 203);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 17);
            labelName.TabIndex = 13;
            labelName.Text = "Нарушение: ";
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Left;
            textBoxCode.BackColor = Color.GhostWhite;
            textBoxCode.BorderStyle = BorderStyle.None;
            textBoxCode.Font = new Font("Consolas", 9.75F);
            textBoxCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxCode.Location = new Point(414, 250);
            textBoxCode.Margin = new Padding(4, 3, 4, 3);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ReadOnly = true;
            textBoxCode.Size = new Size(287, 16);
            textBoxCode.TabIndex = 24;
            textBoxCode.Text = ". . .";
            // 
            // comboBoxViolation
            // 
            comboBoxViolation.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxViolation.BackColor = Color.White;
            comboBoxViolation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxViolation.Font = new Font("Segoe UI", 9.75F);
            comboBoxViolation.ForeColor = Color.FromArgb(0, 0, 0);
            comboBoxViolation.FormattingEnabled = true;
            comboBoxViolation.Location = new Point(414, 199);
            comboBoxViolation.Margin = new Padding(4, 3, 4, 3);
            comboBoxViolation.Name = "comboBoxViolation";
            comboBoxViolation.Size = new Size(403, 25);
            comboBoxViolation.TabIndex = 22;
            // 
            // FineCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "FineCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelDate;
        private CommonButton buttonSave;
        private Components.Labels.PrimaryLabel labelName;
        private Components.Labels.PrimaryLabel labelDescription;
        private Components.Labels.PrimaryLabel labelFinePrice;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker dateTimePickerDate;
        private Components.Controls.TextBoxes.DefaultComboBox comboBoxViolation;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxDescription;
        private Components.Labels.PrimaryLabel labelCode;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxCode;
        private Components.Labels.PrimaryLabel labelAddressTitle;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxFineDescription;
        private Components.Labels.PrimaryLabel labelDescriptionTitle;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxAddress;
        private Components.ComplexControls.MultiImageUploader multiImageUploader;
        private Components.Controls.NumericUpDowns.DefaultNumericUpDown numericUpDownPrice;
    }
}
