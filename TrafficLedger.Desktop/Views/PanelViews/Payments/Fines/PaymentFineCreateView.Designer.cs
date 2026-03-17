using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Payments
{
    partial class PaymentFineCreateView
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
            labelFineDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxAddress = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxTransportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelTransportCodeTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonSave = new CommonButton();
            labelDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxFinePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            textBoxFineDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            statusLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxStatus = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
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
            tableLayoutPanelMain.Controls.Add(labelFineDescriptionTitle, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxAddress, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelAddressTitle, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxTransportCode, 1, 0);
            tableLayoutPanelMain.Controls.Add(labelTransportCodeTitle, 0, 0);
            tableLayoutPanelMain.Controls.Add(labelDate, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxDate, 1, 1);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 11);
            tableLayoutPanelMain.Controls.Add(labelDescription, 0, 7);
            tableLayoutPanelMain.Controls.Add(textBoxDescription, 1, 7);
            tableLayoutPanelMain.Controls.Add(labelCode, 0, 6);
            tableLayoutPanelMain.Controls.Add(textBoxCode, 1, 6);
            tableLayoutPanelMain.Controls.Add(labelName, 0, 5);
            tableLayoutPanelMain.Controls.Add(textBoxName, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelFinePrice, 0, 3);
            tableLayoutPanelMain.Controls.Add(textBoxFinePrice, 1, 3);
            tableLayoutPanelMain.Controls.Add(textBoxFineDescription, 1, 4);
            tableLayoutPanelMain.Controls.Add(statusLabel, 0, 10);
            tableLayoutPanelMain.Controls.Add(textBoxStatus, 1, 10);
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
            // labelFineDescriptionTitle
            // 
            labelFineDescriptionTitle.Anchor = AnchorStyles.Right;
            labelFineDescriptionTitle.AutoSize = true;
            labelFineDescriptionTitle.Font = new Font("Segoe UI", 9.75F);
            labelFineDescriptionTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelFineDescriptionTitle.Location = new Point(316, 203);
            labelFineDescriptionTitle.Margin = new Padding(4, 0, 4, 0);
            labelFineDescriptionTitle.Name = "labelFineDescriptionTitle";
            labelFineDescriptionTitle.Size = new Size(90, 17);
            labelFineDescriptionTitle.TabIndex = 34;
            labelFineDescriptionTitle.Text = "Примечание: ";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Anchor = AnchorStyles.Left;
            textBoxAddress.BackColor = Color.GhostWhite;
            textBoxAddress.BorderStyle = BorderStyle.None;
            textBoxAddress.Font = new Font("Consolas", 9.75F);
            textBoxAddress.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxAddress.Location = new Point(414, 109);
            textBoxAddress.Margin = new Padding(4, 3, 4, 3);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.ReadOnly = true;
            textBoxAddress.Size = new Size(287, 16);
            textBoxAddress.TabIndex = 32;
            textBoxAddress.Text = ". . .";
            // 
            // labelAddressTitle
            // 
            labelAddressTitle.Anchor = AnchorStyles.Right;
            labelAddressTitle.AutoSize = true;
            labelAddressTitle.Font = new Font("Segoe UI", 9.75F);
            labelAddressTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddressTitle.Location = new Point(284, 109);
            labelAddressTitle.Margin = new Padding(4, 0, 4, 0);
            labelAddressTitle.Name = "labelAddressTitle";
            labelAddressTitle.Size = new Size(122, 17);
            labelAddressTitle.TabIndex = 31;
            labelAddressTitle.Text = "Адрес нарушения: ";
            // 
            // textBoxTransportCode
            // 
            textBoxTransportCode.Anchor = AnchorStyles.Left;
            textBoxTransportCode.BackColor = Color.GhostWhite;
            textBoxTransportCode.BorderStyle = BorderStyle.None;
            textBoxTransportCode.Font = new Font("Consolas", 9.75F);
            textBoxTransportCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxTransportCode.Location = new Point(414, 15);
            textBoxTransportCode.Margin = new Padding(4, 3, 4, 3);
            textBoxTransportCode.Name = "textBoxTransportCode";
            textBoxTransportCode.ReadOnly = true;
            textBoxTransportCode.Size = new Size(287, 16);
            textBoxTransportCode.TabIndex = 30;
            textBoxTransportCode.Text = ". . .";
            // 
            // labelTransportCodeTitle
            // 
            labelTransportCodeTitle.Anchor = AnchorStyles.Right;
            labelTransportCodeTitle.AutoSize = true;
            labelTransportCodeTitle.Font = new Font("Segoe UI", 9.75F);
            labelTransportCodeTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelTransportCodeTitle.Location = new Point(296, 15);
            labelTransportCodeTitle.Margin = new Padding(4, 0, 4, 0);
            labelTransportCodeTitle.Name = "labelTransportCodeTitle";
            labelTransportCodeTitle.Size = new Size(110, 17);
            labelTransportCodeTitle.TabIndex = 29;
            labelTransportCodeTitle.Text = "Номер машины: ";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Segoe UI", 9.75F);
            labelDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelDate.Location = new Point(292, 62);
            labelDate.Margin = new Padding(4, 0, 4, 0);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(114, 17);
            labelDate.TabIndex = 6;
            labelDate.Text = "Дата нарушения: ";
            // 
            // textBoxDate
            // 
            textBoxDate.Anchor = AnchorStyles.Left;
            textBoxDate.BackColor = Color.GhostWhite;
            textBoxDate.BorderStyle = BorderStyle.None;
            textBoxDate.Font = new Font("Consolas", 9.75F);
            textBoxDate.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxDate.Location = new Point(414, 62);
            textBoxDate.Margin = new Padding(4, 3, 4, 3);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.ReadOnly = true;
            textBoxDate.Size = new Size(287, 16);
            textBoxDate.TabIndex = 27;
            textBoxDate.Text = ". . .";
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
            buttonSave.Text = "Оплатить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9.75F);
            labelDescription.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescription.Location = new Point(333, 344);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(73, 17);
            labelDescription.TabIndex = 15;
            labelDescription.Text = "Описание: ";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDescription.BackColor = Color.GhostWhite;
            textBoxDescription.BorderStyle = BorderStyle.None;
            textBoxDescription.Font = new Font("Consolas", 9.75F);
            textBoxDescription.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxDescription.Location = new Point(414, 332);
            textBoxDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ReadOnly = true;
            tableLayoutPanelMain.SetRowSpan(textBoxDescription, 3);
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(403, 138);
            textBoxDescription.TabIndex = 26;
            textBoxDescription.Text = ". . .";
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 9.75F);
            labelCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelCode.Location = new Point(297, 297);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(109, 17);
            labelCode.TabIndex = 23;
            labelCode.Text = "Код нарушения: ";
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Left;
            textBoxCode.BackColor = Color.GhostWhite;
            textBoxCode.BorderStyle = BorderStyle.None;
            textBoxCode.Font = new Font("Consolas", 9.75F);
            textBoxCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxCode.Location = new Point(414, 297);
            textBoxCode.Margin = new Padding(4, 3, 4, 3);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ReadOnly = true;
            textBoxCode.Size = new Size(287, 16);
            textBoxCode.TabIndex = 24;
            textBoxCode.Text = ". . .";
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F);
            labelName.ForeColor = Color.FromArgb(0, 0, 0);
            labelName.Location = new Point(322, 250);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(84, 17);
            labelName.TabIndex = 13;
            labelName.Text = "Нарушение: ";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.BackColor = Color.GhostWhite;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Consolas", 9.75F);
            textBoxName.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxName.Location = new Point(414, 250);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.ReadOnly = true;
            textBoxName.Size = new Size(287, 16);
            textBoxName.TabIndex = 28;
            textBoxName.Text = ". . .";
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
            // textBoxFinePrice
            // 
            textBoxFinePrice.Anchor = AnchorStyles.Left;
            textBoxFinePrice.BackColor = Color.GhostWhite;
            textBoxFinePrice.BorderStyle = BorderStyle.None;
            textBoxFinePrice.Font = new Font("Consolas", 9.75F);
            textBoxFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxFinePrice.Location = new Point(414, 156);
            textBoxFinePrice.Margin = new Padding(4, 3, 4, 3);
            textBoxFinePrice.Name = "textBoxFinePrice";
            textBoxFinePrice.ReadOnly = true;
            textBoxFinePrice.Size = new Size(287, 16);
            textBoxFinePrice.TabIndex = 25;
            textBoxFinePrice.Text = ". . .";
            // 
            // textBoxFineDescription
            // 
            textBoxFineDescription.Anchor = AnchorStyles.Left;
            textBoxFineDescription.BackColor = Color.GhostWhite;
            textBoxFineDescription.BorderStyle = BorderStyle.None;
            textBoxFineDescription.Font = new Font("Consolas", 9.75F);
            textBoxFineDescription.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxFineDescription.Location = new Point(414, 203);
            textBoxFineDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxFineDescription.Name = "textBoxFineDescription";
            textBoxFineDescription.ReadOnly = true;
            textBoxFineDescription.Size = new Size(287, 16);
            textBoxFineDescription.TabIndex = 33;
            textBoxFineDescription.Text = ". . .";
            // 
            // statusLabel
            // 
            statusLabel.Anchor = AnchorStyles.Right;
            statusLabel.AutoSize = true;
            statusLabel.Font = new Font("Segoe UI", 9.75F);
            statusLabel.ForeColor = Color.FromArgb(0, 0, 0);
            statusLabel.Location = new Point(354, 488);
            statusLabel.Margin = new Padding(4, 0, 4, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 17);
            statusLabel.TabIndex = 35;
            statusLabel.Text = "Статус: ";
            // 
            // textBoxStatus
            // 
            textBoxStatus.Anchor = AnchorStyles.Left;
            textBoxStatus.BackColor = Color.GhostWhite;
            textBoxStatus.BorderStyle = BorderStyle.None;
            textBoxStatus.Font = new Font("Consolas", 9.75F);
            textBoxStatus.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxStatus.Location = new Point(414, 489);
            textBoxStatus.Margin = new Padding(4, 3, 4, 3);
            textBoxStatus.Name = "textBoxStatus";
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Size = new Size(287, 16);
            textBoxStatus.TabIndex = 36;
            textBoxStatus.Text = ". . .";
            // 
            // PaymentCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "PaymentCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);

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
        private Components.Labels.PrimaryLabel statusLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxStatus;
    }
}
