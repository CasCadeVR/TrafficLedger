namespace TrafficLedger.Desktop.Views.PanelViews
{
    partial class DriverLicenseCreateView
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverLicenseCreateView));
            tableLayoutPanelMain = new TableLayoutPanel();
            labelStatus = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxStatus = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            listBoxCategories = new ListBox();
            labelCategories = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelResidence = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxResidence = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelBirthPlace = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxIssuedBy = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelBirthDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            dateTimePickerDateOfIssue = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
            labelFullName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            licensePhoto = new TrafficLedger.Desktop.Components.Controls.PictureBoxes.FunctionalPictureBox();
            buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            textBoxLicenseNumber = new TrafficLedger.Desktop.Components.Controls.MaskedTextBoxes.DefaultMaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)licensePhoto).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanelMain);
            splitContainer.Size = new Size(821, 693);
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(labelStatus, 0, 9);
            tableLayoutPanelMain.Controls.Add(textBoxStatus, 1, 9);
            tableLayoutPanelMain.Controls.Add(listBoxCategories, 1, 7);
            tableLayoutPanelMain.Controls.Add(labelCategories, 0, 7);
            tableLayoutPanelMain.Controls.Add(labelResidence, 0, 6);
            tableLayoutPanelMain.Controls.Add(textBoxResidence, 1, 6);
            tableLayoutPanelMain.Controls.Add(labelBirthPlace, 0, 5);
            tableLayoutPanelMain.Controls.Add(textBoxIssuedBy, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelBirthDate, 0, 4);
            tableLayoutPanelMain.Controls.Add(dateTimePickerDateOfIssue, 1, 4);
            tableLayoutPanelMain.Controls.Add(labelFullName, 0, 3);
            tableLayoutPanelMain.Controls.Add(licensePhoto, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 10);
            tableLayoutPanelMain.Controls.Add(textBoxLicenseNumber, 1, 3);
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
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Size = new Size(821, 577);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelStatus
            // 
            labelStatus.Anchor = AnchorStyles.Right;
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9.75F);
            labelStatus.ForeColor = Color.FromArgb(0, 0, 0);
            labelStatus.Location = new Point(310, 447);
            labelStatus.Margin = new Padding(4, 0, 4, 0);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(96, 17);
            labelStatus.TabIndex = 14;
            labelStatus.Text = "Статус заявки: ";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Left;
            textBoxStatus.BackColor = Color.GhostWhite;
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Consolas", 9.75F);
            textBoxStatus.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxStatus.Location = new Point(413, 448);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(288, 16);
            textBoxStatus.TabIndex = 15;
            // 
            // listBoxCategories
            // 
            listBoxCategories.Anchor = AnchorStyles.Left;
            listBoxCategories.FormattingEnabled = true;
            listBoxCategories.ItemHeight = 15;
            listBoxCategories.Location = new Point(414, 344);
            listBoxCategories.Margin = new Padding(4, 3, 4, 3);
            listBoxCategories.Name = "listBoxCategories";
            tableLayoutPanelMain.SetRowSpan(listBoxCategories, 2);
            listBoxCategories.SelectionMode = SelectionMode.MultiSimple;
            listBoxCategories.Size = new Size(286, 79);
            listBoxCategories.TabIndex = 12;
            listBoxCategories.SelectedIndexChanged += listBoxCategories_SelectedIndexChanged;
            // 
            // labelCategories
            // 
            labelCategories.Anchor = AnchorStyles.Right;
            labelCategories.AutoSize = true;
            labelCategories.Font = new Font("Segoe UI", 9.75F);
            labelCategories.ForeColor = Color.FromArgb(0, 0, 0);
            labelCategories.Location = new Point(329, 351);
            labelCategories.Margin = new Padding(4, 0, 4, 0);
            labelCategories.Name = "labelCategories";
            labelCategories.Size = new Size(77, 17);
            labelCategories.TabIndex = 11;
            labelCategories.Text = "Категории: ";
            // 
            // labelResidence
            // 
            labelResidence.Anchor = AnchorStyles.Right;
            labelResidence.AutoSize = true;
            labelResidence.Font = new Font("Segoe UI", 9.75F);
            labelResidence.ForeColor = Color.FromArgb(0, 0, 0);
            labelResidence.Location = new Point(305, 303);
            labelResidence.Margin = new Padding(4, 0, 4, 0);
            labelResidence.Name = "labelResidence";
            labelResidence.Size = new Size(101, 17);
            labelResidence.TabIndex = 9;
            labelResidence.Text = "Место выдачи: ";
            // 
            // textBoxResidence
            // 
            textBoxResidence.Anchor = AnchorStyles.Left;
            textBoxResidence.BackColor = Color.White;
            textBoxResidence.BorderStyle = BorderStyle.FixedSingle;
            textBoxResidence.Font = new Font("Segoe UI", 9.75F);
            textBoxResidence.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxResidence.Location = new Point(414, 299);
            textBoxResidence.Margin = new Padding(4, 3, 4, 3);
            textBoxResidence.Name = "textBoxResidence";
            textBoxResidence.Size = new Size(287, 25);
            textBoxResidence.TabIndex = 10;
            // 
            // labelBirthPlace
            // 
            labelBirthPlace.Anchor = AnchorStyles.Right;
            labelBirthPlace.AutoSize = true;
            labelBirthPlace.Font = new Font("Segoe UI", 9.75F);
            labelBirthPlace.ForeColor = Color.FromArgb(0, 0, 0);
            labelBirthPlace.Location = new Point(318, 255);
            labelBirthPlace.Margin = new Padding(4, 0, 4, 0);
            labelBirthPlace.Name = "labelBirthPlace";
            labelBirthPlace.Size = new Size(88, 17);
            labelBirthPlace.TabIndex = 3;
            labelBirthPlace.Text = "Кем выдано: ";
            // 
            // textBoxIssuedBy
            // 
            textBoxIssuedBy.Anchor = AnchorStyles.Left;
            textBoxIssuedBy.BackColor = Color.White;
            textBoxIssuedBy.BorderStyle = BorderStyle.FixedSingle;
            textBoxIssuedBy.Font = new Font("Segoe UI", 9.75F);
            textBoxIssuedBy.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxIssuedBy.Location = new Point(414, 251);
            textBoxIssuedBy.Margin = new Padding(4, 3, 4, 3);
            textBoxIssuedBy.Name = "textBoxIssuedBy";
            textBoxIssuedBy.Size = new Size(287, 25);
            textBoxIssuedBy.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            labelBirthDate.Anchor = AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI", 9.75F);
            labelBirthDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelBirthDate.Location = new Point(315, 207);
            labelBirthDate.Margin = new Padding(4, 0, 4, 0);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(91, 17);
            labelBirthDate.TabIndex = 2;
            labelBirthDate.Text = "Дата выдачи: ";
            // 
            // dateTimePickerDateOfIssue
            // 
            dateTimePickerDateOfIssue.Anchor = AnchorStyles.Left;
            dateTimePickerDateOfIssue.BackColor = Color.White;
            dateTimePickerDateOfIssue.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerDateOfIssue.Font = new Font("Segoe UI", 9.75F);
            dateTimePickerDateOfIssue.ForeColor = Color.FromArgb(0, 0, 0);
            dateTimePickerDateOfIssue.Format = DateTimePickerFormat.Custom;
            dateTimePickerDateOfIssue.Location = new Point(414, 203);
            dateTimePickerDateOfIssue.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDateOfIssue.Name = "dateTimePickerDateOfIssue";
            dateTimePickerDateOfIssue.Size = new Size(286, 25);
            dateTimePickerDateOfIssue.TabIndex = 5;
            dateTimePickerDateOfIssue.Tag = "";
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 9.75F);
            labelFullName.ForeColor = Color.FromArgb(0, 0, 0);
            labelFullName.Location = new Point(256, 159);
            labelFullName.Margin = new Padding(4, 0, 4, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(150, 17);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "Номер удостоверения: ";
            // 
            // licensePhoto
            // 
            licensePhoto.Anchor = AnchorStyles.Bottom;
            licensePhoto.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanelMain.SetColumnSpan(licensePhoto, 2);
            //licensePhoto.Image = (Image)resources.GetObject("licensePhoto.Image");
            licensePhoto.Location = new Point(345, 3);
            licensePhoto.Name = "licensePhoto";
            tableLayoutPanelMain.SetRowSpan(licensePhoto, 3);
            licensePhoto.Size = new Size(131, 135);
            licensePhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            licensePhoto.TabIndex = 16;
            licensePhoto.TabStop = false;
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
            buttonSave.Text = "Отправить заявку";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxLicenseNumber
            // 
            textBoxLicenseNumber.Anchor = AnchorStyles.Left;
            textBoxLicenseNumber.BackColor = Color.White;
            textBoxLicenseNumber.BorderStyle = BorderStyle.FixedSingle;
            textBoxLicenseNumber.Font = new Font("Segoe UI", 9.75F);
            textBoxLicenseNumber.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxLicenseNumber.Location = new Point(413, 155);
            textBoxLicenseNumber.Mask = "00 00 000000";
            textBoxLicenseNumber.Name = "textBoxLicenseNumber";
            textBoxLicenseNumber.Size = new Size(288, 25);
            textBoxLicenseNumber.TabIndex = 17;
            // 
            // DriverLicenseCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "DriverLicenseCreateView";
            Size = new Size(821, 693);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)licensePhoto).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelFullName;
        private Components.Labels.PrimaryLabel labelBirthDate;
        private Components.Labels.PrimaryLabel labelBirthPlace;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxIssuedBy;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker dateTimePickerDateOfIssue;
        private Components.CommonButton buttonSave;
        private Components.Labels.PrimaryLabel labelResidence;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxResidence;
        private Components.Labels.PrimaryLabel labelCategories;
        private System.Windows.Forms.ListBox listBoxCategories;
        private Components.Labels.PrimaryLabel labelStatus;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxStatus;
        private Components.Controls.PictureBoxes.FunctionalPictureBox licensePhoto;
        private Components.Controls.MaskedTextBoxes.DefaultMaskedTextBox textBoxLicenseNumber;
    }
}
