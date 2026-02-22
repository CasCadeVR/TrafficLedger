using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    partial class PaymentCreateView
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
            this.labelFineDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxTransportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelTransportCodeTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            this.labelDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.textBoxFinePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.textBoxFineDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
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
            this.tableLayoutPanelMain.Controls.Add(this.labelFineDescriptionTitle, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxAddress, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.labelAddressTitle, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxTransportCode, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelTransportCodeTitle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelDate, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDate, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 0, 11);
            this.tableLayoutPanelMain.Controls.Add(this.labelDescription, 0, 7);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDescription, 1, 7);
            this.tableLayoutPanelMain.Controls.Add(this.labelCode, 0, 6);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCode, 1, 6);
            this.tableLayoutPanelMain.Controls.Add(this.labelName, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxName, 1, 5);
            this.tableLayoutPanelMain.Controls.Add(this.labelFinePrice, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxFinePrice, 1, 3);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxFineDescription, 1, 4);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 12;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.332583F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335084F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335084F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.335084F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333334F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelFineDescriptionTitle
            // 
            this.labelFineDescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFineDescriptionTitle.AutoSize = true;
            this.labelFineDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFineDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFineDescriptionTitle.Location = new System.Drawing.Point(259, 176);
            this.labelFineDescriptionTitle.Name = "labelFineDescriptionTitle";
            this.labelFineDescriptionTitle.Size = new System.Drawing.Size(90, 17);
            this.labelFineDescriptionTitle.TabIndex = 34;
            this.labelFineDescriptionTitle.Text = "Примечание: ";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAddress.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAddress.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxAddress.Location = new System.Drawing.Point(355, 94);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.ReadOnly = true;
            this.textBoxAddress.Size = new System.Drawing.Size(246, 16);
            this.textBoxAddress.TabIndex = 32;
            this.textBoxAddress.Text = ". . .";
            // 
            // labelAddressTitle
            // 
            this.labelAddressTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelAddressTitle.AutoSize = true;
            this.labelAddressTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelAddressTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelAddressTitle.Location = new System.Drawing.Point(227, 94);
            this.labelAddressTitle.Name = "labelAddressTitle";
            this.labelAddressTitle.Size = new System.Drawing.Size(122, 17);
            this.labelAddressTitle.TabIndex = 31;
            this.labelAddressTitle.Text = "Адрес нарушения: ";
            // 
            // textBoxTransportCode
            // 
            this.textBoxTransportCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTransportCode.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxTransportCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTransportCode.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxTransportCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxTransportCode.Location = new System.Drawing.Point(355, 12);
            this.textBoxTransportCode.Name = "textBoxTransportCode";
            this.textBoxTransportCode.ReadOnly = true;
            this.textBoxTransportCode.Size = new System.Drawing.Size(246, 16);
            this.textBoxTransportCode.TabIndex = 30;
            this.textBoxTransportCode.Text = ". . .";
            // 
            // labelTransportCodeTitle
            // 
            this.labelTransportCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelTransportCodeTitle.AutoSize = true;
            this.labelTransportCodeTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelTransportCodeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTransportCodeTitle.Location = new System.Drawing.Point(239, 12);
            this.labelTransportCodeTitle.Name = "labelTransportCodeTitle";
            this.labelTransportCodeTitle.Size = new System.Drawing.Size(110, 17);
            this.labelTransportCodeTitle.TabIndex = 29;
            this.labelTransportCodeTitle.Text = "Номер машины: ";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDate.Location = new System.Drawing.Point(235, 53);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(114, 17);
            this.labelDate.TabIndex = 6;
            this.labelDate.Text = "Дата нарушения: ";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxDate.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDate.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDate.Location = new System.Drawing.Point(355, 53);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.ReadOnly = true;
            this.textBoxDate.Size = new System.Drawing.Size(246, 16);
            this.textBoxDate.TabIndex = 27;
            this.textBoxDate.Text = ". . .";
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
            this.buttonSave.Location = new System.Drawing.Point(179, 454);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonSave.Size = new System.Drawing.Size(346, 43);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Оплатить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.Location = new System.Drawing.Point(276, 299);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(73, 17);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Описание: ";
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
            this.textBoxDescription.Location = new System.Drawing.Point(355, 290);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.tableLayoutPanelMain.SetRowSpan(this.textBoxDescription, 3);
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(346, 117);
            this.textBoxDescription.TabIndex = 26;
            this.textBoxDescription.Text = ". . .";
            // 
            // labelCode
            // 
            this.labelCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCode.Location = new System.Drawing.Point(240, 258);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(109, 17);
            this.labelCode.TabIndex = 23;
            this.labelCode.Text = "Код нарушения: ";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCode.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCode.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxCode.Location = new System.Drawing.Point(355, 258);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(246, 16);
            this.textBoxCode.TabIndex = 24;
            this.textBoxCode.Text = ". . .";
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(265, 217);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(84, 17);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Нарушение: ";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxName.Location = new System.Drawing.Point(355, 217);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(246, 16);
            this.textBoxName.TabIndex = 28;
            this.textBoxName.Text = ". . .";
            // 
            // labelFinePrice
            // 
            this.labelFinePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFinePrice.AutoSize = true;
            this.labelFinePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFinePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFinePrice.Location = new System.Drawing.Point(244, 135);
            this.labelFinePrice.Name = "labelFinePrice";
            this.labelFinePrice.Size = new System.Drawing.Size(105, 17);
            this.labelFinePrice.TabIndex = 19;
            this.labelFinePrice.Text = "Сумма штрафа: ";
            // 
            // textBoxFinePrice
            // 
            this.textBoxFinePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFinePrice.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxFinePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFinePrice.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxFinePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxFinePrice.Location = new System.Drawing.Point(355, 135);
            this.textBoxFinePrice.Name = "textBoxFinePrice";
            this.textBoxFinePrice.ReadOnly = true;
            this.textBoxFinePrice.Size = new System.Drawing.Size(246, 16);
            this.textBoxFinePrice.TabIndex = 25;
            this.textBoxFinePrice.Text = ". . .";
            // 
            // textBoxFineDescription
            // 
            this.textBoxFineDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxFineDescription.BackColor = System.Drawing.Color.GhostWhite;
            this.textBoxFineDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFineDescription.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.textBoxFineDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxFineDescription.Location = new System.Drawing.Point(355, 176);
            this.textBoxFineDescription.Name = "textBoxFineDescription";
            this.textBoxFineDescription.ReadOnly = true;
            this.textBoxFineDescription.Size = new System.Drawing.Size(246, 16);
            this.textBoxFineDescription.TabIndex = 33;
            this.textBoxFineDescription.Text = ". . .";
            // 
            // PaymentCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "PaymentCreateView";
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
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxDescription;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxFinePrice;
        private Components.Labels.PrimaryLabel labelCode;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxCode;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxName;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxDate;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxTransportCode;
        private Components.Labels.PrimaryLabel labelTransportCodeTitle;
        private Components.Labels.PrimaryLabel labelFineDescriptionTitle;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxAddress;
        private Components.Labels.PrimaryLabel labelAddressTitle;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxFineDescription;
    }
}
