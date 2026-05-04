using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    partial class TransportCreateView
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
            multiImageUploader = new TrafficLedger.Desktop.Components.ComplexControls.MultiImageUploader();
            labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelRegion = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxRegion = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelYear = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelBrand = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxBrand = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelModel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxModel = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelMileAge = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            numericUpDownMileAge = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            labelFullName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            comboBoxCategory = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultComboBox();
            labelCategoryDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxCategoryDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            textBoxCode = new TrafficLedger.Desktop.Components.Controls.MaskedTextBoxes.DefaultMaskedTextBox();
            textBoxYear = new TrafficLedger.Desktop.Components.Controls.MaskedTextBoxes.DefaultMaskedTextBox();
            buttonSave = new CommonButton();
            labelStatus = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxStatus = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelOwnershipDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            ownershipCheckBox = new TrafficLedger.Desktop.Components.Controls.CheckBoxes.DefaultCheckBox();
            ownershipDateTimePicker = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
            secondaryLabel1 = new TrafficLedger.Desktop.Components.Labels.SecondaryLabel();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMileAge).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanelMain);
            splitContainer.Size = new Size(821, 816);
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(multiImageUploader, 0, 12);
            tableLayoutPanelMain.Controls.Add(labelCode, 0, 1);
            tableLayoutPanelMain.Controls.Add(labelRegion, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxRegion, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelYear, 0, 3);
            tableLayoutPanelMain.Controls.Add(labelBrand, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxBrand, 1, 4);
            tableLayoutPanelMain.Controls.Add(labelModel, 0, 5);
            tableLayoutPanelMain.Controls.Add(textBoxModel, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelMileAge, 0, 6);
            tableLayoutPanelMain.Controls.Add(numericUpDownMileAge, 1, 6);
            tableLayoutPanelMain.Controls.Add(labelFullName, 0, 7);
            tableLayoutPanelMain.Controls.Add(comboBoxCategory, 1, 7);
            tableLayoutPanelMain.Controls.Add(labelCategoryDescription, 0, 8);
            tableLayoutPanelMain.Controls.Add(textBoxCategoryDescription, 1, 8);
            tableLayoutPanelMain.Controls.Add(textBoxCode, 1, 1);
            tableLayoutPanelMain.Controls.Add(textBoxYear, 1, 3);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 15);
            tableLayoutPanelMain.Controls.Add(labelStatus, 0, 11);
            tableLayoutPanelMain.Controls.Add(textBoxStatus, 1, 11);
            tableLayoutPanelMain.Controls.Add(labelOwnershipDate, 0, 10);
            tableLayoutPanelMain.Controls.Add(ownershipCheckBox, 0, 9);
            tableLayoutPanelMain.Controls.Add(ownershipDateTimePicker, 1, 10);
            tableLayoutPanelMain.Controls.Add(secondaryLabel1, 1, 9);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 17;
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
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 700);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // multiImageUploader
            // 
            multiImageUploader.AutoScroll = true;
            multiImageUploader.BackColor = SystemColors.Control;
            tableLayoutPanelMain.SetColumnSpan(multiImageUploader, 2);
            multiImageUploader.Dock = DockStyle.Fill;
            multiImageUploader.Location = new Point(3, 521);
            multiImageUploader.Name = "multiImageUploader";
            multiImageUploader.Padding = new Padding(5);
            tableLayoutPanelMain.SetRowSpan(multiImageUploader, 3);
            multiImageUploader.Size = new Size(815, 138);
            multiImageUploader.TabIndex = 23;
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 9.75F);
            labelCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelCode.Location = new Point(244, 5);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(162, 17);
            labelCode.TabIndex = 6;
            labelCode.Text = "Регистрационный номер: ";
            // 
            // labelRegion
            // 
            labelRegion.Anchor = AnchorStyles.Right;
            labelRegion.AutoSize = true;
            labelRegion.Font = new Font("Segoe UI", 9.75F);
            labelRegion.ForeColor = Color.FromArgb(0, 0, 0);
            labelRegion.Location = new Point(265, 53);
            labelRegion.Margin = new Padding(4, 0, 4, 0);
            labelRegion.Name = "labelRegion";
            labelRegion.Size = new Size(141, 17);
            labelRegion.TabIndex = 13;
            labelRegion.Text = "Регион изготовления: ";
            // 
            // textBoxRegion
            // 
            textBoxRegion.Anchor = AnchorStyles.Left;
            textBoxRegion.BackColor = Color.White;
            textBoxRegion.BorderStyle = BorderStyle.FixedSingle;
            textBoxRegion.Font = new Font("Segoe UI", 9.75F);
            textBoxRegion.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxRegion.Location = new Point(414, 49);
            textBoxRegion.Margin = new Padding(4, 3, 4, 3);
            textBoxRegion.Name = "textBoxRegion";
            textBoxRegion.Size = new Size(287, 25);
            textBoxRegion.TabIndex = 14;
            // 
            // labelYear
            // 
            labelYear.Anchor = AnchorStyles.Right;
            labelYear.AutoSize = true;
            labelYear.Font = new Font("Segoe UI", 9.75F);
            labelYear.ForeColor = Color.FromArgb(0, 0, 0);
            labelYear.Location = new Point(285, 101);
            labelYear.Margin = new Padding(4, 0, 4, 0);
            labelYear.Name = "labelYear";
            labelYear.Size = new Size(121, 17);
            labelYear.TabIndex = 15;
            labelYear.Text = "Год изготовления: ";
            // 
            // labelBrand
            // 
            labelBrand.Anchor = AnchorStyles.Right;
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 9.75F);
            labelBrand.ForeColor = Color.FromArgb(0, 0, 0);
            labelBrand.Location = new Point(351, 149);
            labelBrand.Margin = new Padding(4, 0, 4, 0);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(55, 17);
            labelBrand.TabIndex = 11;
            labelBrand.Text = "Марка: ";
            // 
            // textBoxBrand
            // 
            textBoxBrand.Anchor = AnchorStyles.Left;
            textBoxBrand.BackColor = Color.White;
            textBoxBrand.BorderStyle = BorderStyle.FixedSingle;
            textBoxBrand.Font = new Font("Segoe UI", 9.75F);
            textBoxBrand.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxBrand.Location = new Point(414, 145);
            textBoxBrand.Margin = new Padding(4, 3, 4, 3);
            textBoxBrand.Name = "textBoxBrand";
            textBoxBrand.Size = new Size(287, 25);
            textBoxBrand.TabIndex = 12;
            // 
            // labelModel
            // 
            labelModel.Anchor = AnchorStyles.Right;
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 9.75F);
            labelModel.ForeColor = Color.FromArgb(0, 0, 0);
            labelModel.Location = new Point(343, 197);
            labelModel.Margin = new Padding(4, 0, 4, 0);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(63, 17);
            labelModel.TabIndex = 17;
            labelModel.Text = "Модель: ";
            // 
            // textBoxModel
            // 
            textBoxModel.Anchor = AnchorStyles.Left;
            textBoxModel.BackColor = Color.White;
            textBoxModel.BorderStyle = BorderStyle.FixedSingle;
            textBoxModel.Font = new Font("Segoe UI", 9.75F);
            textBoxModel.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxModel.Location = new Point(414, 193);
            textBoxModel.Margin = new Padding(4, 3, 4, 3);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(287, 25);
            textBoxModel.TabIndex = 18;
            // 
            // labelMileAge
            // 
            labelMileAge.Anchor = AnchorStyles.Right;
            labelMileAge.AutoSize = true;
            labelMileAge.Font = new Font("Segoe UI", 9.75F);
            labelMileAge.ForeColor = Color.FromArgb(0, 0, 0);
            labelMileAge.Location = new Point(305, 245);
            labelMileAge.Margin = new Padding(4, 0, 4, 0);
            labelMileAge.Name = "labelMileAge";
            labelMileAge.Size = new Size(101, 17);
            labelMileAge.TabIndex = 19;
            labelMileAge.Text = "Пробег (в км.): ";
            // 
            // numericUpDownMileAge
            // 
            numericUpDownMileAge.Anchor = AnchorStyles.Left;
            numericUpDownMileAge.BackColor = Color.White;
            numericUpDownMileAge.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMileAge.Font = new Font("Segoe UI", 9.75F);
            numericUpDownMileAge.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownMileAge.Location = new Point(414, 241);
            numericUpDownMileAge.Margin = new Padding(4, 3, 4, 3);
            numericUpDownMileAge.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMileAge.Name = "numericUpDownMileAge";
            numericUpDownMileAge.Size = new Size(287, 25);
            numericUpDownMileAge.TabIndex = 20;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 9.75F);
            labelFullName.ForeColor = Color.FromArgb(0, 0, 0);
            labelFullName.Location = new Point(329, 293);
            labelFullName.Margin = new Padding(4, 0, 4, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(77, 17);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "Категория: ";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Anchor = AnchorStyles.Left;
            comboBoxCategory.BackColor = Color.White;
            comboBoxCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCategory.Font = new Font("Segoe UI", 9.75F);
            comboBoxCategory.ForeColor = Color.FromArgb(0, 0, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(414, 289);
            comboBoxCategory.Margin = new Padding(4, 3, 4, 3);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(286, 25);
            comboBoxCategory.TabIndex = 9;
            // 
            // labelCategoryDescription
            // 
            labelCategoryDescription.Anchor = AnchorStyles.Right;
            labelCategoryDescription.AutoSize = true;
            labelCategoryDescription.Font = new Font("Segoe UI", 9.75F);
            labelCategoryDescription.ForeColor = Color.FromArgb(0, 0, 0);
            labelCategoryDescription.Location = new Point(269, 341);
            labelCategoryDescription.Margin = new Padding(4, 0, 4, 0);
            labelCategoryDescription.Name = "labelCategoryDescription";
            labelCategoryDescription.Size = new Size(137, 17);
            labelCategoryDescription.TabIndex = 21;
            labelCategoryDescription.Text = "Описание категории: ";
            // 
            // textBoxCategoryDescription
            // 
            textBoxCategoryDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            textBoxCategoryDescription.BackColor = Color.GhostWhite;
            textBoxCategoryDescription.BorderStyle = BorderStyle.None;
            textBoxCategoryDescription.Font = new Font("Consolas", 9.75F);
            textBoxCategoryDescription.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxCategoryDescription.Location = new Point(414, 329);
            textBoxCategoryDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxCategoryDescription.Multiline = true;
            textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            textBoxCategoryDescription.ReadOnly = true;
            textBoxCategoryDescription.ScrollBars = ScrollBars.Vertical;
            textBoxCategoryDescription.Size = new Size(403, 42);
            textBoxCategoryDescription.TabIndex = 22;
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Left;
            textBoxCode.BackColor = Color.White;
            textBoxCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxCode.Font = new Font("Segoe UI", 9.75F);
            textBoxCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxCode.Location = new Point(413, 1);
            textBoxCode.Mask = ">AAAAAAAAA";
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(287, 25);
            textBoxCode.TabIndex = 28;
            // 
            // textBoxYear
            // 
            textBoxYear.Anchor = AnchorStyles.Left;
            textBoxYear.BackColor = Color.White;
            textBoxYear.BorderStyle = BorderStyle.FixedSingle;
            textBoxYear.Font = new Font("Segoe UI", 9.75F);
            textBoxYear.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxYear.Location = new Point(413, 97);
            textBoxYear.Mask = "0000";
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(288, 25);
            textBoxYear.TabIndex = 29;
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
            buttonSave.Location = new Point(208, 667);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 38);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.Right;
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9.75F);
            labelStatus.ForeColor = Color.FromArgb(0, 0, 0);
            labelStatus.Location = new Point(310, 485);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(96, 17);
            labelStatus.TabIndex = 24;
            labelStatus.Text = "Статус заявки: ";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Left;
            textBoxStatus.BackColor = Color.GhostWhite;
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Consolas", 9.75F);
            textBoxStatus.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxStatus.Location = new Point(413, 486);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(288, 16);
            textBoxStatus.TabIndex = 25;
            // 
            // labelOwnershipDate
            // 
            labelOwnershipDate.Anchor = AnchorStyles.Right;
            labelOwnershipDate.AutoSize = true;
            labelOwnershipDate.Font = new Font("Segoe UI", 9.75F);
            labelOwnershipDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelOwnershipDate.Location = new Point(155, 437);
            labelOwnershipDate.Margin = new Padding(4, 0, 4, 0);
            labelOwnershipDate.Name = "labelOwnershipDate";
            labelOwnershipDate.Size = new Size(251, 17);
            labelOwnershipDate.TabIndex = 26;
            labelOwnershipDate.Text = "Дата подписания договора о владении: ";
            // 
            // ownershipCheckBox
            // 
            ownershipCheckBox.Anchor = AnchorStyles.Right;
            ownershipCheckBox.BackColor = Color.White;
            ownershipCheckBox.Font = new Font("Segoe UI", 9.75F);
            ownershipCheckBox.ForeColor = Color.FromArgb(0, 0, 0);
            ownershipCheckBox.Location = new Point(303, 386);
            ownershipCheckBox.Name = "ownershipCheckBox";
            ownershipCheckBox.Size = new Size(104, 24);
            ownershipCheckBox.TabIndex = 30;
            ownershipCheckBox.Text = "Я - владелец";
            ownershipCheckBox.UseVisualStyleBackColor = false;
            ownershipCheckBox.CheckedChanged += ownershipCheckBox_CheckedChanged;
            // 
            // ownershipDateTimePicker
            // 
            ownershipDateTimePicker.Anchor = AnchorStyles.Left;
            ownershipDateTimePicker.BackColor = Color.White;
            ownershipDateTimePicker.Font = new Font("Segoe UI", 9.75F);
            ownershipDateTimePicker.ForeColor = Color.FromArgb(0, 0, 0);
            ownershipDateTimePicker.Location = new Point(413, 433);
            ownershipDateTimePicker.Name = "ownershipDateTimePicker";
            ownershipDateTimePicker.Size = new Size(288, 25);
            ownershipDateTimePicker.TabIndex = 27;
            // 
            // secondaryLabel1
            // 
            secondaryLabel1.Anchor = AnchorStyles.Left;
            secondaryLabel1.AutoSize = true;
            secondaryLabel1.Font = new Font("Segoe UI", 8.25F);
            secondaryLabel1.ForeColor = Color.FromArgb(102, 102, 102);
            secondaryLabel1.Location = new Point(413, 385);
            secondaryLabel1.Name = "secondaryLabel1";
            secondaryLabel1.Size = new Size(385, 26);
            secondaryLabel1.TabIndex = 31;
            secondaryLabel1.Text = "Если вы указываете, что вы- владелец транспорта, нужно прикрепить договор о владении транспортом";
            secondaryLabel1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TransportCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "TransportCreateView";
            Size = new Size(821, 816);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMileAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelFullName;
        private Components.Labels.PrimaryLabel labelCode;
        private CommonButton buttonSave;
        private Components.Controls.TextBoxes.DefaultComboBox comboBoxCategory;
        private Components.Labels.PrimaryLabel labelRegion;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxBrand;
        private Components.Labels.PrimaryLabel labelBrand;
        private Components.Labels.PrimaryLabel labelYear;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxRegion;
        private Components.Labels.PrimaryLabel labelModel;
        private Components.Labels.PrimaryLabel labelMileAge;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxModel;
        private Components.Controls.NumericUpDowns.DefaultNumericUpDown numericUpDownMileAge;
        private Components.Labels.PrimaryLabel labelCategoryDescription;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxCategoryDescription;
        private Components.ComplexControls.MultiImageUploader multiImageUploader;
        private Components.Labels.PrimaryLabel labelStatus;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxStatus;
        private Components.Labels.PrimaryLabel labelOwnershipDate;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker ownershipDateTimePicker;
        private Components.Controls.MaskedTextBoxes.DefaultMaskedTextBox textBoxCode;
        private Components.Controls.MaskedTextBoxes.DefaultMaskedTextBox textBoxYear;
        private Components.Controls.CheckBoxes.DefaultCheckBox ownershipCheckBox;
        private Components.Labels.SecondaryLabel secondaryLabel1;
    }
}
