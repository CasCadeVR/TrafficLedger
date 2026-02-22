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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.textBoxFinePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            this.labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.dateTimePickerDate = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
            this.comboBoxViolation = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultComboBox();
            this.labelDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.textBoxFineDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
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
            this.tableLayoutPanelMain.Controls.Add(this.textBoxFineDescription, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelAddressTitle, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelDate, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.dateTimePickerDate, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelDescription, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDescription, 1, 6);
            this.tableLayoutPanelMain.Controls.Add(this.labelFinePrice, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxFinePrice, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelCode, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCode, 1, 4);
            this.tableLayoutPanelMain.Controls.Add(this.labelName, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.comboBoxViolation, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelDescriptionTitle, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxAddress, 1, 1);
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
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescription.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDescription.Location = new System.Drawing.Point(355, 297);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.tableLayoutPanelMain.SetRowSpan(this.textBoxDescription, 3);
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(346, 143);
            this.textBoxDescription.TabIndex = 26;
            this.textBoxDescription.Text = ". . .";
            // 
            // textBoxFinePrice
            // 
            this.textBoxFinePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFinePrice.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxFinePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFinePrice.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxFinePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxFinePrice.Location = new System.Drawing.Point(355, 261);
            this.textBoxFinePrice.Name = "textBoxFinePrice";
            this.textBoxFinePrice.ReadOnly = true;
            this.textBoxFinePrice.Size = new System.Drawing.Size(246, 16);
            this.textBoxFinePrice.TabIndex = 25;
            this.textBoxFinePrice.Text = ". . .";
            // 
            // labelCode
            // 
            this.labelCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCode.Location = new System.Drawing.Point(240, 212);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(109, 17);
            this.labelCode.TabIndex = 23;
            this.labelCode.Text = "Код нарушения: ";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(235, 16);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(114, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата нарушения: ";
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
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(265, 163);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 17);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Нарушение: ";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dateTimePickerDate.BackColor = System.Drawing.Color.White;
            this.dateTimePickerDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePickerDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dateTimePickerDate.Location = new System.Drawing.Point(355, 12);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(246, 25);
            this.dateTimePickerDate.TabIndex = 21;
            this.dateTimePickerDate.Tag = "";
            // 
            // comboBoxViolation
            // 
            this.comboBoxViolation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxViolation.BackColor = System.Drawing.Color.White;
            this.comboBoxViolation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxViolation.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.comboBoxViolation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxViolation.FormattingEnabled = true;
            this.comboBoxViolation.Location = new System.Drawing.Point(355, 159);
            this.comboBoxViolation.Name = "comboBoxViolation";
            this.comboBoxViolation.Size = new System.Drawing.Size(346, 25);
            this.comboBoxViolation.TabIndex = 22;
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.Location = new System.Drawing.Point(276, 310);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(73, 17);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Описание: ";
            // 
            // labelFinePrice
            // 
            this.labelFinePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFinePrice.AutoSize = true;
            this.labelFinePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFinePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFinePrice.Location = new System.Drawing.Point(244, 261);
            this.labelFinePrice.Name = "labelFinePrice";
            this.labelFinePrice.Size = new System.Drawing.Size(105, 17);
            this.labelFinePrice.TabIndex = 19;
            this.labelFinePrice.Text = "Сумма штрафа: ";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCode.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxCode.Location = new System.Drawing.Point(355, 212);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(246, 16);
            this.textBoxCode.TabIndex = 24;
            this.textBoxCode.Text = ". . .";
            // 
            // labelAddressTitle
            // 
            this.labelAddressTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddressTitle.AutoSize = true;
            this.labelAddressTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelAddressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAddressTitle.Location = new System.Drawing.Point(298, 65);
            this.labelAddressTitle.Name = "labelAddressTitle";
            this.labelAddressTitle.Size = new System.Drawing.Size(51, 17);
            this.labelAddressTitle.TabIndex = 27;
            this.labelAddressTitle.Text = "Адрес: ";
            // 
            // labelDescriptionTitle
            // 
            this.labelDescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDescriptionTitle.AutoSize = true;
            this.labelDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescriptionTitle.Location = new System.Drawing.Point(259, 114);
            this.labelDescriptionTitle.Name = "labelDescriptionTitle";
            this.labelDescriptionTitle.Size = new System.Drawing.Size(90, 17);
            this.labelDescriptionTitle.TabIndex = 28;
            this.labelDescriptionTitle.Text = "Примечание: ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.Color.White;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxAddress.Location = new System.Drawing.Point(355, 61);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(346, 25);
            this.textBoxAddress.TabIndex = 29;
            // 
            // textBoxFineDescription
            // 
            this.textBoxFineDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFineDescription.BackColor = System.Drawing.Color.White;
            this.textBoxFineDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFineDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxFineDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxFineDescription.Location = new System.Drawing.Point(355, 110);
            this.textBoxFineDescription.Name = "textBoxFineDescription";
            this.textBoxFineDescription.Size = new System.Drawing.Size(346, 25);
            this.textBoxFineDescription.TabIndex = 30;
            // 
            // FineCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "FineCreateView";
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
        private Components.Labels.PrimaryLabel labelDate;
        private CommonButton buttonSave;
        private Components.Labels.PrimaryLabel labelName;
        private Components.Labels.PrimaryLabel labelDescription;
        private Components.Labels.PrimaryLabel labelFinePrice;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker dateTimePickerDate;
        private Components.Controls.TextBoxes.DefaultComboBox comboBoxViolation;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxDescription;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxFinePrice;
        private Components.Labels.PrimaryLabel labelCode;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxCode;
        private Components.Labels.PrimaryLabel labelAddressTitle;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxFineDescription;
        private Components.Labels.PrimaryLabel labelDescriptionTitle;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxAddress;
    }
}
