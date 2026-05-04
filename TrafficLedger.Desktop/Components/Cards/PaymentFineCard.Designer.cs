using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class PaymentFineCard
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
            transportCode = new Controls.TextBoxes.ReadOnlyTextBox();
            labelAddressTitle = new Labels.PrimaryLabel();
            labelFinePriceTitle = new Labels.PrimaryLabel();
            finePrice = new Controls.TextBoxes.ReadOnlyTextBox();
            labelNameTitle = new Labels.PrimaryLabel();
            violationName = new Controls.TextBoxes.ReadOnlyTextBox();
            labelNumberTitle = new Labels.PrimaryLabel();
            code = new Controls.TextBoxes.ReadOnlyTextBox();
            labelDateTitle = new Labels.PrimaryLabel();
            fineDate = new Controls.TextBoxes.ReadOnlyTextBox();
            labelPaymentDate = new Labels.PrimaryLabel();
            paymentDate = new Controls.TextBoxes.ReadOnlyTextBox();
            transportCodeTitle = new Labels.PrimaryLabel();
            labelStatusTitle = new Labels.PrimaryLabel();
            status = new Controls.TextBoxes.ReadOnlyTextBox();
            address = new Controls.TextBoxes.ReadOnlyTextBox();
            labelDescriptionTitle = new Labels.PrimaryLabel();
            description = new Controls.TextBoxes.ReadOnlyTextBox();
            buttonDelete = new CommonButton();
            buttonReject = new CommonButton();
            buttonApprove = new CommonButton();
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
            tableLayoutPanel1.Controls.Add(labelAddressTitle, 0, 6);
            tableLayoutPanel1.Controls.Add(labelFinePriceTitle, 0, 5);
            tableLayoutPanel1.Controls.Add(finePrice, 1, 5);
            tableLayoutPanel1.Controls.Add(labelNameTitle, 0, 4);
            tableLayoutPanel1.Controls.Add(violationName, 1, 4);
            tableLayoutPanel1.Controls.Add(labelNumberTitle, 0, 3);
            tableLayoutPanel1.Controls.Add(code, 1, 3);
            tableLayoutPanel1.Controls.Add(labelDateTitle, 0, 2);
            tableLayoutPanel1.Controls.Add(fineDate, 1, 2);
            tableLayoutPanel1.Controls.Add(labelPaymentDate, 0, 1);
            tableLayoutPanel1.Controls.Add(paymentDate, 1, 1);
            tableLayoutPanel1.Controls.Add(transportCodeTitle, 4, 0);
            tableLayoutPanel1.Controls.Add(labelStatusTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(status, 1, 0);
            tableLayoutPanel1.Controls.Add(address, 1, 6);
            tableLayoutPanel1.Controls.Add(labelDescriptionTitle, 0, 7);
            tableLayoutPanel1.Controls.Add(description, 1, 7);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 8);
            tableLayoutPanel1.Controls.Add(buttonReject, 5, 7);
            tableLayoutPanel1.Controls.Add(buttonApprove, 5, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.10974F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11197F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11403F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11111F));
            tableLayoutPanel1.Size = new Size(666, 344);
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
            transportCode.Location = new Point(478, 11);
            transportCode.Name = "transportCode";
            transportCode.ReadOnly = true;
            transportCode.Size = new Size(185, 16);
            transportCode.TabIndex = 26;
            transportCode.Text = "Загрузка...";
            // 
            // labelAddressTitle
            // 
            labelAddressTitle.Anchor = AnchorStyles.Right;
            labelAddressTitle.AutoSize = true;
            labelAddressTitle.Font = new Font("Segoe UI", 9.75F);
            labelAddressTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddressTitle.Location = new Point(41, 238);
            labelAddressTitle.Name = "labelAddressTitle";
            labelAddressTitle.Size = new Size(51, 17);
            labelAddressTitle.TabIndex = 12;
            labelAddressTitle.Text = "Адрес: ";
            // 
            // labelFinePriceTitle
            // 
            labelFinePriceTitle.Anchor = AnchorStyles.Right;
            labelFinePriceTitle.AutoSize = true;
            labelFinePriceTitle.Font = new Font("Segoe UI", 9.75F);
            labelFinePriceTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelFinePriceTitle.Location = new Point(38, 192);
            labelFinePriceTitle.Name = "labelFinePriceTitle";
            labelFinePriceTitle.Size = new Size(54, 34);
            labelFinePriceTitle.TabIndex = 13;
            labelFinePriceTitle.Text = "Штраф (руб.): ";
            // 
            // finePrice
            // 
            finePrice.Anchor = AnchorStyles.Left;
            finePrice.BackColor = Color.GhostWhite;
            finePrice.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(finePrice, 2);
            finePrice.Font = new Font("Consolas", 9.75F);
            finePrice.ForeColor = Color.FromArgb(0, 0, 0);
            finePrice.Location = new Point(98, 197);
            finePrice.Name = "finePrice";
            finePrice.ReadOnly = true;
            finePrice.Size = new Size(100, 16);
            finePrice.TabIndex = 17;
            finePrice.Text = "Загрузка...";
            // 
            // labelNameTitle
            // 
            labelNameTitle.Anchor = AnchorStyles.Right;
            labelNameTitle.AutoSize = true;
            labelNameTitle.Font = new Font("Segoe UI", 9.75F);
            labelNameTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNameTitle.Location = new Point(9, 154);
            labelNameTitle.Name = "labelNameTitle";
            labelNameTitle.Size = new Size(83, 34);
            labelNameTitle.TabIndex = 11;
            labelNameTitle.Text = "Наименование: ";
            // 
            // violationName
            // 
            violationName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            violationName.BackColor = Color.GhostWhite;
            violationName.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(violationName, 4);
            violationName.Font = new Font("Consolas", 9.75F);
            violationName.ForeColor = Color.FromArgb(0, 0, 0);
            violationName.Location = new Point(98, 163);
            violationName.Name = "violationName";
            violationName.ReadOnly = true;
            violationName.Size = new Size(374, 16);
            violationName.TabIndex = 15;
            violationName.Text = "Загрузка...";
            // 
            // labelNumberTitle
            // 
            labelNumberTitle.Anchor = AnchorStyles.Right;
            labelNumberTitle.AutoSize = true;
            labelNumberTitle.Font = new Font("Segoe UI", 9.75F);
            labelNumberTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNumberTitle.Location = new Point(36, 124);
            labelNumberTitle.Name = "labelNumberTitle";
            labelNumberTitle.Size = new Size(56, 17);
            labelNumberTitle.TabIndex = 10;
            labelNumberTitle.Text = "Номер: ";
            // 
            // code
            // 
            code.Anchor = AnchorStyles.Left;
            code.BackColor = Color.GhostWhite;
            code.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(code, 2);
            code.Font = new Font("Consolas", 9.75F);
            code.ForeColor = Color.FromArgb(0, 0, 0);
            code.Location = new Point(98, 121);
            code.Name = "code";
            code.ReadOnly = true;
            code.Size = new Size(100, 16);
            code.TabIndex = 14;
            code.Text = "Загрузка...";
            // 
            // labelDateTitle
            // 
            labelDateTitle.Anchor = AnchorStyles.Right;
            labelDateTitle.AutoSize = true;
            labelDateTitle.Font = new Font("Segoe UI", 9.75F);
            labelDateTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDateTitle.Location = new Point(14, 78);
            labelDateTitle.Name = "labelDateTitle";
            labelDateTitle.Size = new Size(78, 34);
            labelDateTitle.TabIndex = 22;
            labelDateTitle.Text = "Дата получения: ";
            // 
            // fineDate
            // 
            fineDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fineDate.BackColor = Color.GhostWhite;
            fineDate.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(fineDate, 2);
            fineDate.Font = new Font("Consolas", 9.75F);
            fineDate.ForeColor = Color.FromArgb(0, 0, 0);
            fineDate.Location = new Point(98, 87);
            fineDate.Name = "fineDate";
            fineDate.ReadOnly = true;
            fineDate.Size = new Size(184, 16);
            fineDate.TabIndex = 23;
            fineDate.Text = "Загрузка...";
            // 
            // labelPaymentDate
            // 
            labelPaymentDate.Anchor = AnchorStyles.Right;
            labelPaymentDate.AutoSize = true;
            labelPaymentDate.Font = new Font("Segoe UI", 9.75F);
            labelPaymentDate.ForeColor = Color.FromArgb(0, 0, 0);
            labelPaymentDate.Location = new Point(6, 48);
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
            paymentDate.Location = new Point(98, 49);
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
            transportCodeTitle.Location = new Point(389, 2);
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
            labelStatusTitle.Location = new Point(40, 10);
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
            status.Location = new Point(98, 7);
            status.Name = "status";
            status.ReadOnly = true;
            status.Size = new Size(100, 16);
            status.TabIndex = 30;
            status.Text = "Загрузка...";
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Left;
            address.BackColor = Color.GhostWhite;
            address.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(address, 3);
            address.Font = new Font("Consolas", 9.75F);
            address.ForeColor = Color.FromArgb(0, 0, 0);
            address.Location = new Point(98, 239);
            address.Name = "address";
            address.ReadOnly = true;
            address.ScrollBars = ScrollBars.Vertical;
            address.Size = new Size(279, 16);
            address.TabIndex = 16;
            address.Text = "Загрузка...";
            // 
            // labelDescriptionTitle
            // 
            labelDescriptionTitle.Anchor = AnchorStyles.Right;
            labelDescriptionTitle.AutoSize = true;
            labelDescriptionTitle.Font = new Font("Segoe UI", 9.75F);
            labelDescriptionTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescriptionTitle.Location = new Point(6, 276);
            labelDescriptionTitle.Name = "labelDescriptionTitle";
            labelDescriptionTitle.Size = new Size(86, 17);
            labelDescriptionTitle.TabIndex = 31;
            labelDescriptionTitle.Text = "Примечание: ";
            // 
            // description
            // 
            description.Anchor = AnchorStyles.Left;
            description.BackColor = Color.GhostWhite;
            description.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(description, 3);
            description.Font = new Font("Consolas", 9.75F);
            description.ForeColor = Color.FromArgb(0, 0, 0);
            description.Location = new Point(98, 277);
            description.Name = "description";
            description.ReadOnly = true;
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(279, 16);
            description.TabIndex = 32;
            description.Text = "Загрузка...";
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonDelete, 2);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(478, 307);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            buttonDelete.Size = new Size(185, 34);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonReject
            // 
            buttonReject.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonReject, 2);
            buttonReject.FlatAppearance.BorderColor = Color.DarkGray;
            buttonReject.FlatStyle = FlatStyle.Flat;
            buttonReject.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonReject.ForeColor = Color.White;
            buttonReject.Location = new Point(478, 269);
            buttonReject.Name = "buttonReject";
            buttonReject.Padding = new Padding(8, 4, 8, 4);
            buttonReject.Size = new Size(185, 32);
            buttonReject.TabIndex = 24;
            buttonReject.Text = "Отклонить";
            buttonReject.UseVisualStyleBackColor = false;
            buttonReject.Click += buttonReject_Click;
            // 
            // buttonApprove
            // 
            buttonApprove.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonApprove, 2);
            buttonApprove.FlatAppearance.BorderColor = Color.DarkGray;
            buttonApprove.FlatStyle = FlatStyle.Flat;
            buttonApprove.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonApprove.ForeColor = Color.White;
            buttonApprove.Location = new Point(478, 231);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Padding = new Padding(8, 4, 8, 4);
            buttonApprove.Size = new Size(185, 32);
            buttonApprove.TabIndex = 20;
            buttonApprove.Text = "Одобрить";
            buttonApprove.UseVisualStyleBackColor = false;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // PaymentFineCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "PaymentFineCard";
            Size = new Size(666, 344);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelNumberTitle;
        private Labels.PrimaryLabel labelNameTitle;
        private Labels.PrimaryLabel labelAddressTitle;
        private Labels.PrimaryLabel labelFinePriceTitle;
        private Controls.TextBoxes.ReadOnlyTextBox code;
        private Controls.TextBoxes.ReadOnlyTextBox violationName;
        private Controls.TextBoxes.ReadOnlyTextBox address;
        private Controls.TextBoxes.ReadOnlyTextBox finePrice;
        private CommonButton buttonApprove;
        private CommonButton buttonDelete;
        private Controls.TextBoxes.ReadOnlyTextBox fineDate;
        private Labels.PrimaryLabel labelDateTitle;
        private CommonButton buttonReject;
        private Controls.TextBoxes.ReadOnlyTextBox transportCode;
        private Labels.PrimaryLabel transportCodeTitle;
        private Controls.TextBoxes.ReadOnlyTextBox paymentDate;
        private Labels.PrimaryLabel labelPaymentDate;
        private Labels.PrimaryLabel labelStatusTitle;
        private Controls.TextBoxes.ReadOnlyTextBox status;
        private Labels.PrimaryLabel labelDescriptionTitle;
        private Controls.TextBoxes.ReadOnlyTextBox description;
    }
}
