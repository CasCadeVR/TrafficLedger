using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class PaymentParkingSessionCard
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
            transportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelFinePriceTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            finePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelPaymentDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            paymentDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            transportCodeTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelStatusTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            status = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            address = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelStartDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            startDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelEndDate = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            endDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonApprove = new CommonButton();
            buttonReject = new CommonButton();
            buttonDelete = new CommonButton();
            toolTip = new ToolTip(components);
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28653F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28653F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28653F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2851F));
            tableLayoutPanel1.Controls.Add(transportCode, 5, 0);
            tableLayoutPanel1.Controls.Add(labelFinePriceTitle, 0, 5);
            tableLayoutPanel1.Controls.Add(finePrice, 1, 5);
            tableLayoutPanel1.Controls.Add(labelPaymentDate, 0, 1);
            tableLayoutPanel1.Controls.Add(paymentDate, 1, 1);
            tableLayoutPanel1.Controls.Add(transportCodeTitle, 4, 0);
            tableLayoutPanel1.Controls.Add(labelStatusTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(status, 1, 0);
            tableLayoutPanel1.Controls.Add(labelAddressTitle, 0, 2);
            tableLayoutPanel1.Controls.Add(address, 1, 2);
            tableLayoutPanel1.Controls.Add(labelStartDate, 0, 3);
            tableLayoutPanel1.Controls.Add(startDate, 1, 3);
            tableLayoutPanel1.Controls.Add(labelEndDate, 0, 4);
            tableLayoutPanel1.Controls.Add(endDate, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonApprove, 5, 3);
            tableLayoutPanel1.Controls.Add(buttonReject, 5, 4);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(666, 251);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // transportCode
            // 
            transportCode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            transportCode.BackColor = Color.GhostWhite;
            transportCode.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(transportCode, 2);
            transportCode.Font = new Font("Consolas", 9.75F);
            transportCode.ForeColor = Color.FromArgb(0, 0, 0);
            transportCode.Location = new Point(478, 12);
            transportCode.Name = "transportCode";
            transportCode.ReadOnly = true;
            transportCode.Size = new Size(185, 16);
            transportCode.TabIndex = 26;
            transportCode.Text = "Загрузка...";
            // 
            // labelFinePriceTitle
            // 
            labelFinePriceTitle.Anchor = AnchorStyles.Right;
            labelFinePriceTitle.AutoSize = true;
            labelFinePriceTitle.Font = new Font("Segoe UI", 9.75F);
            labelFinePriceTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelFinePriceTitle.Location = new Point(5, 219);
            labelFinePriceTitle.Name = "labelFinePriceTitle";
            labelFinePriceTitle.Size = new Size(87, 17);
            labelFinePriceTitle.TabIndex = 13;
            labelFinePriceTitle.Text = "Сумма (руб.): ";
            // 
            // finePrice
            // 
            finePrice.Anchor = AnchorStyles.Left;
            finePrice.BackColor = Color.GhostWhite;
            finePrice.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(finePrice, 2);
            finePrice.Font = new Font("Consolas", 9.75F);
            finePrice.ForeColor = Color.FromArgb(0, 0, 0);
            finePrice.Location = new Point(98, 216);
            finePrice.Name = "finePrice";
            finePrice.ReadOnly = true;
            finePrice.Size = new Size(100, 16);
            finePrice.TabIndex = 17;
            finePrice.Text = "Загрузка...";
            // 
            // labelPaymentDate
            // 
            labelPaymentDate.Anchor = AnchorStyles.Right;
            labelPaymentDate.AutoSize = true;
            labelPaymentDate.Font = new Font("Segoe UI", 9.75F);
            labelPaymentDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelPaymentDate.Location = new Point(6, 53);
            labelPaymentDate.Name = "labelPaymentDate";
            labelPaymentDate.Size = new Size(86, 17);
            labelPaymentDate.TabIndex = 27;
            labelPaymentDate.Text = "Дата оплаты: ";
            // 
            // paymentDate
            // 
            paymentDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            paymentDate.BackColor = Color.GhostWhite;
            paymentDate.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(paymentDate, 2);
            paymentDate.Font = new Font("Consolas", 9.75F);
            paymentDate.ForeColor = Color.FromArgb(0, 0, 0);
            paymentDate.Location = new Point(98, 53);
            paymentDate.Name = "paymentDate";
            paymentDate.ReadOnly = true;
            paymentDate.Size = new Size(184, 16);
            paymentDate.TabIndex = 28;
            paymentDate.Text = "Загрузка...";
            // 
            // transportCodeTitle
            // 
            transportCodeTitle.Anchor = AnchorStyles.Right;
            transportCodeTitle.AutoSize = true;
            transportCodeTitle.Font = new Font("Segoe UI", 9.75F);
            transportCodeTitle.ForeColor = Color.FromArgb(0, 0, 0);
            transportCodeTitle.Location = new Point(389, 3);
            transportCodeTitle.Name = "transportCodeTitle";
            transportCodeTitle.Size = new Size(83, 34);
            transportCodeTitle.TabIndex = 25;
            transportCodeTitle.Text = "Код транспорта: ";
            // 
            // labelStatusTitle
            // 
            labelStatusTitle.Anchor = AnchorStyles.Right;
            labelStatusTitle.AutoSize = true;
            labelStatusTitle.Font = new Font("Segoe UI", 9.75F);
            labelStatusTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelStatusTitle.Location = new Point(40, 12);
            labelStatusTitle.Name = "labelStatusTitle";
            labelStatusTitle.Size = new Size(52, 17);
            labelStatusTitle.TabIndex = 29;
            labelStatusTitle.Text = "Статус: ";
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Left;
            status.BackColor = Color.GhostWhite;
            status.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(status, 2);
            status.Font = new Font("Consolas", 9.75F);
            status.ForeColor = Color.FromArgb(0, 0, 0);
            status.Location = new Point(98, 9);
            status.Name = "status";
            status.ReadOnly = true;
            status.Size = new Size(100, 16);
            status.TabIndex = 30;
            status.Text = "Загрузка...";
            // 
            // labelAddressTitle
            // 
            labelAddressTitle.Anchor = AnchorStyles.Right;
            labelAddressTitle.AutoSize = true;
            labelAddressTitle.Font = new Font("Segoe UI", 9.75F);
            labelAddressTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddressTitle.Location = new Point(41, 94);
            labelAddressTitle.Name = "labelAddressTitle";
            labelAddressTitle.Size = new Size(51, 17);
            labelAddressTitle.TabIndex = 12;
            labelAddressTitle.Text = "Адрес: ";
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Left;
            address.BackColor = Color.GhostWhite;
            address.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(address, 3);
            address.Font = new Font("Consolas", 9.75F);
            address.ForeColor = Color.FromArgb(0, 0, 0);
            address.Location = new Point(98, 94);
            address.Name = "address";
            address.ReadOnly = true;
            address.ScrollBars = ScrollBars.Vertical;
            address.Size = new Size(279, 16);
            address.TabIndex = 16;
            address.Text = "Загрузка...";
            // 
            // labelStartDate
            // 
            labelStartDate.Anchor = AnchorStyles.Right;
            labelStartDate.AutoSize = true;
            labelStartDate.Font = new Font("Segoe UI", 9.75F);
            labelStartDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelStartDate.Location = new Point(35, 126);
            labelStartDate.Name = "labelStartDate";
            labelStartDate.Size = new Size(57, 34);
            labelStartDate.TabIndex = 33;
            labelStartDate.Text = "Время начала: ";
            // 
            // startDate
            // 
            startDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            startDate.BackColor = Color.GhostWhite;
            startDate.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(startDate, 2);
            startDate.Font = new Font("Consolas", 9.75F);
            startDate.ForeColor = Color.FromArgb(0, 0, 0);
            startDate.Location = new Point(98, 135);
            startDate.Name = "startDate";
            startDate.ReadOnly = true;
            startDate.Size = new Size(184, 16);
            startDate.TabIndex = 35;
            startDate.Text = "Загрузка...";
            // 
            // labelEndDate
            // 
            labelEndDate.Anchor = AnchorStyles.Right;
            labelEndDate.AutoSize = true;
            labelEndDate.Font = new Font("Segoe UI", 9.75F);
            labelEndDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelEndDate.Location = new Point(13, 167);
            labelEndDate.Name = "labelEndDate";
            labelEndDate.Size = new Size(79, 34);
            labelEndDate.TabIndex = 34;
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
            endDate.Location = new Point(98, 176);
            endDate.Name = "endDate";
            endDate.ReadOnly = true;
            endDate.Size = new Size(184, 16);
            endDate.TabIndex = 36;
            endDate.Text = "Загрузка...";
            // 
            // buttonApprove
            // 
            buttonApprove.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonApprove, 2);
            buttonApprove.FlatAppearance.BorderColor = Color.DarkGray;
            buttonApprove.FlatStyle = FlatStyle.Flat;
            buttonApprove.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonApprove.ForeColor = Color.White;
            buttonApprove.Location = new Point(478, 126);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Padding = new Padding(8, 4, 8, 4);
            buttonApprove.Size = new Size(185, 35);
            buttonApprove.TabIndex = 20;
            buttonApprove.Text = "Одобрить";
            buttonApprove.UseVisualStyleBackColor = false;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // buttonReject
            // 
            buttonReject.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonReject, 2);
            buttonReject.FlatAppearance.BorderColor = Color.DarkGray;
            buttonReject.FlatStyle = FlatStyle.Flat;
            buttonReject.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonReject.ForeColor = Color.White;
            buttonReject.Location = new Point(478, 167);
            buttonReject.Name = "buttonReject";
            buttonReject.Padding = new Padding(8, 4, 8, 4);
            buttonReject.Size = new Size(185, 35);
            buttonReject.TabIndex = 24;
            buttonReject.Text = "Отклонить";
            buttonReject.UseVisualStyleBackColor = false;
            buttonReject.Click += buttonReject_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonDelete, 2);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(478, 208);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            buttonDelete.Size = new Size(185, 40);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // PaymentParkingSessionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PaymentParkingSessionCard";
            Size = new Size(666, 251);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelAddressTitle;
        private Labels.PrimaryLabel labelFinePriceTitle;
        private Controls.TextBoxes.ReadOnlyTextBox address;
        private Controls.TextBoxes.ReadOnlyTextBox finePrice;
        private CommonButton buttonApprove;
        private CommonButton buttonDelete;
        private CommonButton buttonReject;
        private Controls.TextBoxes.ReadOnlyTextBox transportCode;
        private Labels.PrimaryLabel transportCodeTitle;
        private Controls.TextBoxes.ReadOnlyTextBox paymentDate;
        private Labels.PrimaryLabel labelPaymentDate;
        private Labels.PrimaryLabel labelStatusTitle;
        private Controls.TextBoxes.ReadOnlyTextBox status;
        private Labels.PrimaryLabel labelEndDate;
        private Controls.TextBoxes.ReadOnlyTextBox endDate;
        private Labels.PrimaryLabel labelStartDate;
        private Controls.TextBoxes.ReadOnlyTextBox startDate;
    }
}
