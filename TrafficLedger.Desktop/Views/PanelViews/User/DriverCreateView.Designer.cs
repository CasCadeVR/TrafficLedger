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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelUniqueId = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelBirthDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelFullName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxFullName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.labelBirthPlace = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxBirthPlace = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.dateTimePickerBirthDate = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
            this.textBoxUniqueId = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
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
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.labelUniqueId, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelBirthDate, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelFullName, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxFullName, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelBirthPlace, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxBirthPlace, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerBirthDate, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxUniqueId, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 0, 6);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 7;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelUniqueId
            // 
            this.labelUniqueId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUniqueId.AutoSize = true;
            this.labelUniqueId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelUniqueId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUniqueId.Location = new System.Drawing.Point(173, 240);
            this.labelUniqueId.Name = "labelUniqueId";
            this.labelUniqueId.Size = new System.Drawing.Size(176, 17);
            this.labelUniqueId.TabIndex = 6;
            this.labelUniqueId.Text = "Уникальный идентификатор:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBirthDate.Location = new System.Drawing.Point(246, 98);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(103, 17);
            this.labelBirthDate.TabIndex = 2;
            this.labelBirthDate.Text = "Дата рождения:";
            // 
            // labelFullName
            // 
            this.labelFullName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFullName.Location = new System.Drawing.Point(309, 27);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(40, 17);
            this.labelFullName.TabIndex = 0;
            this.labelFullName.Text = "ФИО:";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFullName.BackColor = System.Drawing.Color.White;
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxFullName.Location = new System.Drawing.Point(355, 23);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(246, 25);
            this.textBoxFullName.TabIndex = 1;
            // 
            // labelBirthPlace
            // 
            this.labelBirthPlace.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBirthPlace.AutoSize = true;
            this.labelBirthPlace.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelBirthPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBirthPlace.Location = new System.Drawing.Point(236, 169);
            this.labelBirthPlace.Name = "labelBirthPlace";
            this.labelBirthPlace.Size = new System.Drawing.Size(113, 17);
            this.labelBirthPlace.TabIndex = 3;
            this.labelBirthPlace.Text = "Место рождения:";
            // 
            // textBoxBirthPlace
            // 
            this.textBoxBirthPlace.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxBirthPlace.BackColor = System.Drawing.Color.White;
            this.textBoxBirthPlace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBirthPlace.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxBirthPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxBirthPlace.Location = new System.Drawing.Point(355, 165);
            this.textBoxBirthPlace.Name = "textBoxBirthPlace";
            this.textBoxBirthPlace.Size = new System.Drawing.Size(246, 25);
            this.textBoxBirthPlace.TabIndex = 4;
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerBirthDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerBirthDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePickerBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(355, 94);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(246, 25);
            this.dateTimePickerBirthDate.TabIndex = 5;
            this.dateTimePickerBirthDate.Tag = "";
            // 
            // textBoxUniqueId
            // 
            this.textBoxUniqueId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUniqueId.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxUniqueId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUniqueId.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxUniqueId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxUniqueId.Location = new System.Drawing.Point(355, 239);
            this.textBoxUniqueId.Name = "textBoxUniqueId";
            this.textBoxUniqueId.ReadOnly = true;
            this.textBoxUniqueId.Size = new System.Drawing.Size(246, 18);
            this.textBoxUniqueId.TabIndex = 7;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanelMain.SetColumnSpan(this.buttonSave, 2);
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(179, 437);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonSave.Size = new System.Drawing.Size(346, 52);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // DriverCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DriverCreateView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);

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
        private Components.CommonButton buttonSave;
    }
}
