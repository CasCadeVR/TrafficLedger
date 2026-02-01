namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers
{
    partial class OwnershipCreateView
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
            this.labelTransportCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            this.textBoxTransportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.labelDateTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.dateTimePickerDate = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
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
            this.tableLayoutPanelMain.Controls.Add(this.labelTransportCode, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxTransportCode, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelDateTitle, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerDate, 1, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 10;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelTransportCode
            // 
            this.labelTransportCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTransportCode.AutoSize = true;
            this.labelTransportCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelTransportCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTransportCode.Location = new System.Drawing.Point(235, 16);
            this.labelTransportCode.Name = "labelTransportCode";
            this.labelTransportCode.Size = new System.Drawing.Size(114, 17);
            this.labelTransportCode.TabIndex = 6;
            this.labelTransportCode.Text = "Код транспорта:  ";
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
            this.buttonSave.Location = new System.Drawing.Point(179, 450);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonSave.Size = new System.Drawing.Size(346, 43);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxTransportCode
            // 
            this.textBoxTransportCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTransportCode.BackColor = System.Drawing.Color.White;
            this.textBoxTransportCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTransportCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxTransportCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxTransportCode.Location = new System.Drawing.Point(355, 12);
            this.textBoxTransportCode.Name = "textBoxTransportCode";
            this.textBoxTransportCode.Size = new System.Drawing.Size(246, 25);
            this.textBoxTransportCode.TabIndex = 10;
            // 
            // labelDateTitle
            // 
            this.labelDateTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDateTitle.AutoSize = true;
            this.labelDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDateTitle.Location = new System.Drawing.Point(98, 65);
            this.labelDateTitle.Name = "labelDateTitle";
            this.labelDateTitle.Size = new System.Drawing.Size(251, 17);
            this.labelDateTitle.TabIndex = 19;
            this.labelDateTitle.Text = "Дата подписания договора о владении: ";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePickerDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePickerDate.Location = new System.Drawing.Point(355, 61);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(246, 25);
            this.dateTimePickerDate.TabIndex = 20;
            this.dateTimePickerDate.Tag = "";
            // 
            // OwnershipCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "OwnershipCreateView";
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
        private Components.Labels.PrimaryLabel labelTransportCode;
        private Components.CommonButton buttonSave;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxTransportCode;
        private Components.Labels.PrimaryLabel labelDateTitle;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker dateTimePickerDate;
    }
}
