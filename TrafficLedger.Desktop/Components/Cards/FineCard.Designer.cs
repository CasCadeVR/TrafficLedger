using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class FineCard
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
            transportCodeTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            buttonPay = new CommonButton();
            buttonDelete = new CommonButton();
            buttonEdit = new CommonButton();
            description = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            status = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelStatusTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelDateTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            date = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            primaryLabel1 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            address = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            primaryLabel2 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            fineDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelNumberTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            code = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelNameTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            violationName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelFinePriceTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            finePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
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
            tableLayoutPanel1.Controls.Add(transportCodeTitle, 4, 0);
            tableLayoutPanel1.Controls.Add(buttonPay, 5, 8);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 6);
            tableLayoutPanel1.Controls.Add(buttonEdit, 5, 4);
            tableLayoutPanel1.Controls.Add(description, 1, 6);
            tableLayoutPanel1.Controls.Add(status, 5, 1);
            tableLayoutPanel1.Controls.Add(labelStatusTitle, 4, 1);
            tableLayoutPanel1.Controls.Add(labelDateTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(date, 1, 0);
            tableLayoutPanel1.Controls.Add(primaryLabel1, 0, 1);
            tableLayoutPanel1.Controls.Add(address, 1, 1);
            tableLayoutPanel1.Controls.Add(primaryLabel2, 0, 2);
            tableLayoutPanel1.Controls.Add(fineDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(labelNumberTitle, 0, 3);
            tableLayoutPanel1.Controls.Add(code, 1, 3);
            tableLayoutPanel1.Controls.Add(labelNameTitle, 0, 4);
            tableLayoutPanel1.Controls.Add(violationName, 1, 4);
            tableLayoutPanel1.Controls.Add(labelFinePriceTitle, 0, 5);
            tableLayoutPanel1.Controls.Add(finePrice, 1, 5);
            tableLayoutPanel1.Controls.Add(labelDescriptionTitle, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.998768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.998768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.998768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.998768F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.00077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.00077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.00077F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.00262F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(666, 366);
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
            transportCode.Location = new Point(478, 10);
            transportCode.Name = "transportCode";
            transportCode.ReadOnly = true;
            transportCode.Size = new Size(185, 16);
            transportCode.TabIndex = 26;
            transportCode.Text = "Загрузка...";
            // 
            // transportCodeTitle
            // 
            transportCodeTitle.Anchor = AnchorStyles.Right;
            transportCodeTitle.AutoSize = true;
            transportCodeTitle.Font = new Font("Segoe UI", 9.75F);
            transportCodeTitle.ForeColor = Color.FromArgb(0, 0, 0);
            transportCodeTitle.Location = new Point(389, 1);
            transportCodeTitle.Name = "transportCodeTitle";
            transportCodeTitle.Size = new Size(83, 34);
            transportCodeTitle.TabIndex = 25;
            transportCodeTitle.Text = "Код транспорта: ";
            // 
            // buttonPay
            // 
            buttonPay.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonPay, 2);
            buttonPay.FlatAppearance.BorderColor = Color.DarkGray;
            buttonPay.FlatStyle = FlatStyle.Flat;
            buttonPay.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonPay.ForeColor = Color.White;
            buttonPay.Location = new Point(478, 291);
            buttonPay.Name = "buttonPay";
            buttonPay.Padding = new Padding(8, 4, 8, 4);
            tableLayoutPanel1.SetRowSpan(buttonPay, 2);
            buttonPay.Size = new Size(185, 69);
            buttonPay.TabIndex = 24;
            buttonPay.Text = "Оплатить";
            buttonPay.UseVisualStyleBackColor = false;
            buttonPay.Click += buttonPay_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonDelete, 2);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(478, 219);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            tableLayoutPanel1.SetRowSpan(buttonDelete, 2);
            buttonDelete.Size = new Size(185, 64);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonEdit, 2);
            buttonEdit.FlatAppearance.BorderColor = Color.DarkGray;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(478, 147);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(8, 4, 8, 4);
            tableLayoutPanel1.SetRowSpan(buttonEdit, 2);
            buttonEdit.Size = new Size(185, 64);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // description
            // 
            description.BackColor = Color.GhostWhite;
            description.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(description, 3);
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Consolas", 9.75F);
            description.ForeColor = Color.FromArgb(0, 0, 0);
            description.Location = new Point(98, 219);
            description.Multiline = true;
            description.Name = "description";
            description.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(description, 4);
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(279, 144);
            description.TabIndex = 16;
            description.Text = "Загрузка...";
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Left;
            status.BackColor = Color.GhostWhite;
            status.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(status, 2);
            status.Font = new Font("Consolas", 9.75F);
            status.ForeColor = Color.FromArgb(0, 0, 0);
            status.Location = new Point(478, 42);
            status.Name = "status";
            status.ReadOnly = true;
            status.Size = new Size(100, 16);
            status.TabIndex = 28;
            status.Text = "Загрузка...";
            // 
            // labelStatusTitle
            // 
            labelStatusTitle.Anchor = AnchorStyles.Right;
            labelStatusTitle.AutoSize = true;
            labelStatusTitle.Font = new Font("Segoe UI", 9.75F);
            labelStatusTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelStatusTitle.Location = new Point(420, 45);
            labelStatusTitle.Name = "labelStatusTitle";
            labelStatusTitle.Size = new Size(52, 17);
            labelStatusTitle.TabIndex = 27;
            labelStatusTitle.Text = "Статус: ";
            // 
            // labelDateTitle
            // 
            labelDateTitle.Anchor = AnchorStyles.Right;
            labelDateTitle.AutoSize = true;
            labelDateTitle.Font = new Font("Segoe UI", 9.75F);
            labelDateTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDateTitle.Location = new Point(14, 1);
            labelDateTitle.Name = "labelDateTitle";
            labelDateTitle.Size = new Size(78, 34);
            labelDateTitle.TabIndex = 22;
            labelDateTitle.Text = "Дата получения: ";
            // 
            // date
            // 
            date.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            date.BackColor = Color.GhostWhite;
            date.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(date, 2);
            date.Font = new Font("Consolas", 9.75F);
            date.ForeColor = Color.FromArgb(0, 0, 0);
            date.Location = new Point(98, 10);
            date.Name = "date";
            date.ReadOnly = true;
            date.Size = new Size(184, 16);
            date.TabIndex = 23;
            date.Text = "Загрузка...";
            // 
            // primaryLabel1
            // 
            primaryLabel1.Anchor = AnchorStyles.Right;
            primaryLabel1.AutoSize = true;
            primaryLabel1.Font = new Font("Segoe UI", 9.75F);
            primaryLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel1.Location = new Point(41, 45);
            primaryLabel1.Name = "primaryLabel1";
            primaryLabel1.Size = new Size(51, 17);
            primaryLabel1.TabIndex = 29;
            primaryLabel1.Text = "Адрес: ";
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            address.BackColor = Color.GhostWhite;
            address.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(address, 3);
            address.Font = new Font("Consolas", 9.75F);
            address.ForeColor = Color.FromArgb(0, 0, 0);
            address.Location = new Point(98, 46);
            address.Name = "address";
            address.ReadOnly = true;
            address.Size = new Size(279, 16);
            address.TabIndex = 32;
            address.Text = "Загрузка...";
            // 
            // primaryLabel2
            // 
            primaryLabel2.Anchor = AnchorStyles.Right;
            primaryLabel2.AutoSize = true;
            primaryLabel2.Font = new Font("Segoe UI", 9.75F);
            primaryLabel2.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel2.Location = new Point(6, 81);
            primaryLabel2.Name = "primaryLabel2";
            primaryLabel2.Size = new Size(86, 17);
            primaryLabel2.TabIndex = 30;
            primaryLabel2.Text = "Примечание: ";
            // 
            // fineDescription
            // 
            fineDescription.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fineDescription.BackColor = Color.GhostWhite;
            fineDescription.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(fineDescription, 4);
            fineDescription.Font = new Font("Consolas", 9.75F);
            fineDescription.ForeColor = Color.FromArgb(0, 0, 0);
            fineDescription.Location = new Point(98, 82);
            fineDescription.Name = "fineDescription";
            fineDescription.ReadOnly = true;
            fineDescription.Size = new Size(374, 16);
            fineDescription.TabIndex = 31;
            fineDescription.Text = "Загрузка...";
            // 
            // labelNumberTitle
            // 
            labelNumberTitle.Anchor = AnchorStyles.Right;
            labelNumberTitle.AutoSize = true;
            labelNumberTitle.Font = new Font("Segoe UI", 9.75F);
            labelNumberTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNumberTitle.Location = new Point(36, 117);
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
            code.Location = new Point(98, 114);
            code.Name = "code";
            code.ReadOnly = true;
            code.Size = new Size(100, 16);
            code.TabIndex = 14;
            code.Text = "Загрузка...";
            // 
            // labelNameTitle
            // 
            labelNameTitle.Anchor = AnchorStyles.Right;
            labelNameTitle.AutoSize = true;
            labelNameTitle.Font = new Font("Segoe UI", 9.75F);
            labelNameTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNameTitle.Location = new Point(9, 145);
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
            violationName.Location = new Point(98, 154);
            violationName.Name = "violationName";
            violationName.ReadOnly = true;
            violationName.Size = new Size(374, 16);
            violationName.TabIndex = 15;
            violationName.Text = "Загрузка...";
            // 
            // labelFinePriceTitle
            // 
            labelFinePriceTitle.Anchor = AnchorStyles.Right;
            labelFinePriceTitle.AutoSize = true;
            labelFinePriceTitle.Font = new Font("Segoe UI", 9.75F);
            labelFinePriceTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelFinePriceTitle.Location = new Point(38, 181);
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
            finePrice.Location = new Point(98, 186);
            finePrice.Name = "finePrice";
            finePrice.ReadOnly = true;
            finePrice.Size = new Size(100, 16);
            finePrice.TabIndex = 17;
            finePrice.Text = "Загрузка...";
            // 
            // labelDescriptionTitle
            // 
            labelDescriptionTitle.Anchor = AnchorStyles.Right;
            labelDescriptionTitle.AutoSize = true;
            labelDescriptionTitle.Font = new Font("Segoe UI", 9.75F);
            labelDescriptionTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescriptionTitle.Location = new Point(19, 225);
            labelDescriptionTitle.Name = "labelDescriptionTitle";
            labelDescriptionTitle.Size = new Size(73, 17);
            labelDescriptionTitle.TabIndex = 12;
            labelDescriptionTitle.Text = "Описание: ";
            // 
            // FineCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "FineCard";
            Size = new Size(666, 366);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelNumberTitle;
        private Labels.PrimaryLabel labelNameTitle;
        private Labels.PrimaryLabel labelDescriptionTitle;
        private Labels.PrimaryLabel labelFinePriceTitle;
        private Controls.TextBoxes.ReadOnlyTextBox code;
        private Controls.TextBoxes.ReadOnlyTextBox violationName;
        private Controls.TextBoxes.ReadOnlyTextBox description;
        private Controls.TextBoxes.ReadOnlyTextBox finePrice;
        private CommonButton buttonEdit;
        private CommonButton buttonDelete;
        private Controls.TextBoxes.ReadOnlyTextBox date;
        private Labels.PrimaryLabel labelDateTitle;
        private CommonButton buttonPay;
        private Controls.TextBoxes.ReadOnlyTextBox transportCode;
        private Labels.PrimaryLabel transportCodeTitle;
        private Labels.PrimaryLabel labelStatusTitle;
        private Controls.TextBoxes.ReadOnlyTextBox status;
        private Labels.PrimaryLabel primaryLabel1;
        private Labels.PrimaryLabel primaryLabel2;
        private Controls.TextBoxes.ReadOnlyTextBox fineDescription;
        private Controls.TextBoxes.ReadOnlyTextBox address;
    }
}
