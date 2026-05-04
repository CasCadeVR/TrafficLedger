using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;
using TrafficLedger.Desktop.Contracts.Views.PanelViews;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    partial class DriverCreateView
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
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriverCreateView));
            tableLayoutPanelMain = new TableLayoutPanel();
            buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            labelUniqueId = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxUniqueId = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelBirthPlace = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxBirthPlace = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelBirthDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            dateTimePickerBirthDate = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
            labelFullName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxFullName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            driverPhoto = new TrafficLedger.Desktop.Components.Controls.PictureBoxes.FunctionalPictureBox();
            pictureOpenFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)driverPhoto).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 6);
            tableLayoutPanelMain.Controls.Add(labelUniqueId, 0, 5);
            tableLayoutPanelMain.Controls.Add(textBoxUniqueId, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelBirthPlace, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxBirthPlace, 1, 4);
            tableLayoutPanelMain.Controls.Add(labelBirthDate, 0, 3);
            tableLayoutPanelMain.Controls.Add(dateTimePickerBirthDate, 1, 3);
            tableLayoutPanelMain.Controls.Add(labelFullName, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxFullName, 1, 2);
            tableLayoutPanelMain.Controls.Add(driverPhoto, 0, 0);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 7;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
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
            buttonSave.Location = new Point(208, 503);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 60);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelUniqueId
            // 
            labelUniqueId.Anchor = AnchorStyles.Right;
            labelUniqueId.AutoSize = true;
            labelUniqueId.Font = new Font("Segoe UI", 9.75F);
            labelUniqueId.ForeColor = Color.FromArgb(0, 0, 0);
            labelUniqueId.Location = new Point(230, 440);
            labelUniqueId.Margin = new Padding(4, 0, 4, 0);
            labelUniqueId.Name = "labelUniqueId";
            labelUniqueId.Size = new Size(176, 17);
            labelUniqueId.TabIndex = 6;
            labelUniqueId.Text = "Уникальный идентификатор:";
            // 
            // textBoxUniqueId
            // 
            textBoxUniqueId.Anchor = AnchorStyles.Left;
            textBoxUniqueId.BackColor = Color.GhostWhite;
            textBoxUniqueId.BorderStyle = BorderStyle.None;
            textBoxUniqueId.Font = new Font("Segoe UI", 9.75F);
            textBoxUniqueId.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxUniqueId.Location = new Point(414, 439);
            textBoxUniqueId.Margin = new Padding(4, 3, 4, 3);
            textBoxUniqueId.Name = "textBoxUniqueId";
            textBoxUniqueId.ReadOnly = true;
            textBoxUniqueId.Size = new Size(287, 18);
            textBoxUniqueId.TabIndex = 7;
            // 
            // labelBirthPlace
            // 
            labelBirthPlace.Anchor = AnchorStyles.Right;
            labelBirthPlace.AutoSize = true;
            labelBirthPlace.Font = new Font("Segoe UI", 9.75F);
            labelBirthPlace.ForeColor = Color.FromArgb(0, 0, 0);
            labelBirthPlace.Location = new Point(293, 357);
            labelBirthPlace.Margin = new Padding(4, 0, 4, 0);
            labelBirthPlace.Name = "labelBirthPlace";
            labelBirthPlace.Size = new Size(113, 17);
            labelBirthPlace.TabIndex = 3;
            labelBirthPlace.Text = "Место рождения:";
            // 
            // textBoxBirthPlace
            // 
            textBoxBirthPlace.Anchor = AnchorStyles.Left;
            textBoxBirthPlace.BackColor = Color.White;
            textBoxBirthPlace.BorderStyle = BorderStyle.FixedSingle;
            textBoxBirthPlace.Font = new Font("Segoe UI", 9.75F);
            textBoxBirthPlace.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxBirthPlace.Location = new Point(414, 353);
            textBoxBirthPlace.Margin = new Padding(4, 3, 4, 3);
            textBoxBirthPlace.Name = "textBoxBirthPlace";
            textBoxBirthPlace.Size = new Size(287, 25);
            textBoxBirthPlace.TabIndex = 4;
            // 
            // labelBirthDate
            // 
            labelBirthDate.Anchor = AnchorStyles.Right;
            labelBirthDate.AutoSize = true;
            labelBirthDate.Font = new Font("Segoe UI", 9.75F);
            labelBirthDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelBirthDate.Location = new Point(303, 274);
            labelBirthDate.Margin = new Padding(4, 0, 4, 0);
            labelBirthDate.Name = "labelBirthDate";
            labelBirthDate.Size = new Size(103, 17);
            labelBirthDate.TabIndex = 2;
            labelBirthDate.Text = "Дата рождения:";
            // 
            // dateTimePickerBirthDate
            // 
            dateTimePickerBirthDate.Anchor = AnchorStyles.Left;
            dateTimePickerBirthDate.BackColor = Color.White;
            dateTimePickerBirthDate.Font = new Font("Segoe UI", 9.75F);
            dateTimePickerBirthDate.ForeColor = Color.FromArgb(0, 0, 0);
            dateTimePickerBirthDate.Location = new Point(414, 270);
            dateTimePickerBirthDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            dateTimePickerBirthDate.Size = new Size(286, 25);
            dateTimePickerBirthDate.TabIndex = 5;
            dateTimePickerBirthDate.Tag = "";
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 9.75F);
            labelFullName.ForeColor = Color.FromArgb(0, 0, 0);
            labelFullName.Location = new Point(366, 191);
            labelFullName.Margin = new Padding(4, 0, 4, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(40, 17);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "ФИО:";
            // 
            // textBoxFullName
            // 
            textBoxFullName.Anchor = AnchorStyles.Left;
            textBoxFullName.BackColor = Color.White;
            textBoxFullName.BorderStyle = BorderStyle.FixedSingle;
            textBoxFullName.Font = new Font("Segoe UI", 9.75F);
            textBoxFullName.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxFullName.Location = new Point(414, 187);
            textBoxFullName.Margin = new Padding(4, 3, 4, 3);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(287, 25);
            textBoxFullName.TabIndex = 1;
            // 
            // driverPhoto
            // 
            driverPhoto.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            driverPhoto.BorderStyle = BorderStyle.FixedSingle;
            tableLayoutPanelMain.SetColumnSpan(driverPhoto, 2);
            //driverPhoto.Image = (Image)resources.GetObject("driverPhoto.Image");
            driverPhoto.Location = new Point(331, 3);
            driverPhoto.MaximumSize = new Size(158, 158);
            driverPhoto.Name = "driverPhoto";
            tableLayoutPanelMain.SetRowSpan(driverPhoto, 2);
            driverPhoto.Size = new Size(158, 152);
            driverPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            driverPhoto.TabIndex = 9;
            driverPhoto.TabStop = false;
            // 
            // pictureOpenFileDialog
            // 
            pictureOpenFileDialog.FileName = "pictureOpenFileDialog";
            // 
            // DriverCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "DriverCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)driverPhoto).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelFullName;
        private Components.Labels.PrimaryLabel labelBirthDate;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxFullName;
        private Components.Labels.PrimaryLabel labelBirthPlace;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxBirthPlace;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker dateTimePickerBirthDate;
        private Components.Labels.PrimaryLabel labelUniqueId;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxUniqueId;
        private CommonButton buttonSave;
        private OpenFileDialog pictureOpenFileDialog;
        private Components.Controls.PictureBoxes.FunctionalPictureBox driverPhoto;
    }
}
