using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class ParkingSessionCard
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelEndDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            endDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelTransportCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            transportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelStartDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelAddress = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            address = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            startDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonPay = new CommonButton();
            buttonDelete = new CommonButton();
            buttonAbout = new CommonButton();
            labelStatusTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            status = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            toolTip = new ToolTip(components);
            labelCapturedPrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            capturedPrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2865305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2865305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2865305F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851009F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851009F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851009F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851009F));
            tableLayoutPanel1.Controls.Add(labelEndDate, 0, 3);
            tableLayoutPanel1.Controls.Add(endDate, 1, 3);
            tableLayoutPanel1.Controls.Add(labelTransportCode, 0, 0);
            tableLayoutPanel1.Controls.Add(transportCode, 1, 0);
            tableLayoutPanel1.Controls.Add(labelStartDate, 0, 2);
            tableLayoutPanel1.Controls.Add(labelAddress, 0, 1);
            tableLayoutPanel1.Controls.Add(address, 1, 1);
            tableLayoutPanel1.Controls.Add(startDate, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonPay, 5, 5);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 3);
            tableLayoutPanel1.Controls.Add(buttonAbout, 5, 4);
            tableLayoutPanel1.Controls.Add(labelStatusTitle, 4, 0);
            tableLayoutPanel1.Controls.Add(status, 5, 0);
            tableLayoutPanel1.Controls.Add(labelCapturedPrice, 0, 4);
            tableLayoutPanel1.Controls.Add(capturedPrice, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2844915F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2844915F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2844915F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2844915F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2873459F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2873459F));
            tableLayoutPanel1.Size = new Size(666, 274);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEndDate
            // 
            labelEndDate.Anchor = AnchorStyles.Right;
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 9.75F);
            labelEndDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelEndDate.Location = new Point(13, 140);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(79, 34);
            labelEndDate.TabIndex = 11;
            labelEndDate.Text = "Время окончания: ";
            // 
            // endDate
            // 
            endDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            endDate.BackColor = Color.GhostWhite;
            endDate.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(endDate, 2);
            endDate.Font = new Font("Consolas", 9.75F);
            endDate.ForeColor = Color.FromArgb(0, 0, 0);
            endDate.Location = new Point(98, 149);
            endDate.Name = "endDate";
            endDate.ReadOnly = true;
            endDate.Size = new Size(184, 16);
            endDate.TabIndex = 15;
            endDate.Text = "Загрузка...";
            // 
            // labelTransportCode
            // 
            labelTransportCode.Anchor = AnchorStyles.Right;
            labelTransportCode.AutoSize = true;
            labelTransportCode.Font = new Font("Segoe UI", 9.75F);
            labelTransportCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelTransportCode.Location = new Point(9, 5);
            labelTransportCode.Name = "labelTransportCode";
            labelTransportCode.Size = new Size(83, 34);
            labelTransportCode.TabIndex = 13;
            labelTransportCode.Text = "Номер транспорта: ";
            // 
            // transportCode
            // 
            transportCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            transportCode.BackColor = Color.GhostWhite;
            transportCode.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(transportCode, 2);
            transportCode.Font = new Font("Consolas", 9.75F);
            transportCode.ForeColor = Color.FromArgb(0, 0, 0);
            transportCode.Location = new Point(98, 14);
            transportCode.Name = "transportCode";
            transportCode.ReadOnly = true;
            transportCode.Size = new Size(184, 16);
            transportCode.TabIndex = 17;
            transportCode.Text = "Загрузка...";
            // 
            // labelStartDate
            // 
            labelStartDate.Anchor = AnchorStyles.Right;
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI", 9.75F);
            labelStartDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelStartDate.Location = new Point(35, 95);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(57, 34);
            labelStartDate.TabIndex = 10;
            labelStartDate.Text = "Время начала: ";
            // 
            // labelAddress
            // 
            labelAddress.Anchor = AnchorStyles.Right;
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 9.75F);
            labelAddress.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddress.Location = new Point(41, 59);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(51, 17);
            labelAddress.TabIndex = 12;
            labelAddress.Text = "Адрес: ";
            // 
            // address
            // 
            address.BackColor = Color.GhostWhite;
            address.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(address, 3);
            address.Dock = DockStyle.Fill;
            address.Font = new Font("Consolas", 9.75F);
            address.ForeColor = Color.FromArgb(0, 0, 0);
            address.Location = new Point(98, 48);
            address.Multiline = true;
            address.Name = "address";
            address.ReadOnly = true;
            address.Size = new Size(279, 39);
            address.TabIndex = 16;
            address.Text = "Загрузка...";
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            startDate.BackColor = Color.GhostWhite;
            startDate.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(startDate, 2);
            startDate.Font = new Font("Consolas", 9.75F);
            startDate.ForeColor = Color.FromArgb(0, 0, 0);
            startDate.Location = new Point(98, 104);
            startDate.Name = "startDate";
            startDate.ReadOnly = true;
            startDate.Size = new Size(184, 16);
            startDate.TabIndex = 14;
            startDate.Text = "Загрузка...";
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonPay, 2);
            buttonPay.Dock = DockStyle.Fill;
            buttonPay.FlatAppearance.BorderColor = Color.DarkGray;
            buttonPay.FlatStyle = FlatStyle.Flat;
            buttonPay.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonPay.ForeColor = Color.White;
            buttonPay.Location = new Point(478, 228);
            buttonPay.Name = "buttonPay";
            buttonPay.Padding = new Padding(8, 4, 8, 4);
            buttonPay.Size = new Size(185, 43);
            buttonPay.TabIndex = 19;
            buttonPay.Text = "Оплатить";
            buttonPay.UseVisualStyleBackColor = false;
            buttonPay.Click += buttonPay_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonDelete, 2);
            buttonDelete.Dock = DockStyle.Fill;
            buttonDelete.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(478, 138);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            buttonDelete.Size = new Size(185, 39);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonAbout, 2);
            buttonAbout.Dock = DockStyle.Fill;
            buttonAbout.FlatAppearance.BorderColor = Color.DarkGray;
            buttonAbout.FlatStyle = FlatStyle.Flat;
            buttonAbout.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonAbout.ForeColor = Color.White;
            buttonAbout.Location = new Point(478, 183);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new Padding(8, 4, 8, 4);
            buttonAbout.Size = new Size(185, 39);
            buttonAbout.TabIndex = 20;
            buttonAbout.Text = "Подробнее";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // labelStatusTitle
            // 
            labelStatusTitle.Anchor = AnchorStyles.Right;
            labelStatusTitle.AutoSize = true;
            labelStatusTitle.Font = new Font("Segoe UI", 9.75F);
            labelStatusTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelStatusTitle.Location = new Point(420, 14);
            labelStatusTitle.Name = "labelStatusTitle";
            labelStatusTitle.Size = new Size(52, 17);
            labelStatusTitle.TabIndex = 22;
            labelStatusTitle.Text = "Статус: ";
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            status.BackColor = Color.GhostWhite;
            status.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(status, 2);
            status.Font = new Font("Consolas", 9.75F);
            status.ForeColor = Color.FromArgb(0, 0, 0);
            status.Location = new Point(478, 14);
            status.Name = "status";
            status.ReadOnly = true;
            status.Size = new Size(185, 16);
            status.TabIndex = 23;
            status.Text = "Загрузка...";
            // 
            // labelCapturedPrice
            // 
            labelCapturedPrice.Anchor = AnchorStyles.Right;
            labelCapturedPrice.AutoSize = true;
            labelCapturedPrice.Font = new Font("Segoe UI", 9.75F);
            labelCapturedPrice.ForeColor = Color.FromArgb(0, 0, 0);
            labelCapturedPrice.Location = new Point(17, 194);
            labelCapturedPrice.Name = "labelCapturedPrice";
            labelCapturedPrice.Size = new Size(75, 17);
            labelCapturedPrice.TabIndex = 24;
            labelCapturedPrice.Text = "Оплачено: ";
            // 
            // capturedPrice
            // 
            capturedPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            capturedPrice.BackColor = Color.GhostWhite;
            capturedPrice.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(capturedPrice, 2);
            capturedPrice.Font = new Font("Consolas", 9.75F);
            capturedPrice.ForeColor = Color.FromArgb(0, 0, 0);
            capturedPrice.Location = new Point(98, 194);
            capturedPrice.Name = "capturedPrice";
            capturedPrice.ReadOnly = true;
            capturedPrice.Size = new Size(184, 16);
            capturedPrice.TabIndex = 25;
            capturedPrice.Text = "Загрузка...";
            // 
            // ParkingSessionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ParkingSessionCard";
            Size = new Size(666, 274);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelStartDate;
        private Labels.PrimaryLabel labelEndDate;
        private Labels.PrimaryLabel labelAddress;
        private Labels.PrimaryLabel labelTransportCode;
        private Controls.TextBoxes.ReadOnlyTextBox startDate;
        private Controls.TextBoxes.ReadOnlyTextBox endDate;
        private Controls.TextBoxes.ReadOnlyTextBox address;
        private Controls.TextBoxes.ReadOnlyTextBox transportCode;
        private CommonButton buttonPay;
        private CommonButton buttonAbout;
        private CommonButton buttonDelete;
        private Labels.PrimaryLabel labelStatusTitle;
        private Controls.TextBoxes.ReadOnlyTextBox status;
        private Labels.PrimaryLabel labelCapturedPrice;
        private Controls.TextBoxes.ReadOnlyTextBox capturedPrice;
    }
}
