using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class ParkingZoneCard
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
            labelAddressTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelHourlyRateTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelModelTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            address = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            hourlyRate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            active = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonChoose = new CommonButton();
            buttonDelete = new CommonButton();
            buttonEdit = new CommonButton();
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
            tableLayoutPanel1.Controls.Add(labelAddressTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelHourlyRateTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(labelModelTitle, 0, 2);
            tableLayoutPanel1.Controls.Add(address, 1, 0);
            tableLayoutPanel1.Controls.Add(hourlyRate, 1, 1);
            tableLayoutPanel1.Controls.Add(active, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonChoose, 5, 3);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 2);
            tableLayoutPanel1.Controls.Add(buttonEdit, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 18F));
            tableLayoutPanel1.Size = new Size(666, 173);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelAddressTitle
            // 
            labelAddressTitle.Anchor = AnchorStyles.Right;
            labelAddressTitle.AutoSize = true;
            labelAddressTitle.Font = new Font("Segoe UI", 9.75F);
            labelAddressTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelAddressTitle.Location = new Point(41, 13);
            labelAddressTitle.Name = "labelAddressTitle";
            labelAddressTitle.Size = new Size(51, 17);
            labelAddressTitle.TabIndex = 10;
            labelAddressTitle.Text = "Адрес: ";
            // 
            // labelHourlyRateTitle
            // 
            labelHourlyRateTitle.Anchor = AnchorStyles.Right;
            labelHourlyRateTitle.AutoSize = true;
            labelHourlyRateTitle.Font = new Font("Segoe UI", 9.75F);
            labelHourlyRateTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelHourlyRateTitle.Location = new Point(5, 56);
            labelHourlyRateTitle.Name = "labelHourlyRateTitle";
            labelHourlyRateTitle.Size = new Size(87, 17);
            labelHourlyRateTitle.TabIndex = 11;
            labelHourlyRateTitle.Text = "Цена за час: ";
            // 
            // labelModelTitle
            // 
            labelModelTitle.Anchor = AnchorStyles.Right;
            labelModelTitle.AutoSize = true;
            labelModelTitle.Font = new Font("Segoe UI", 9.75F);
            labelModelTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelModelTitle.Location = new Point(30, 99);
            labelModelTitle.Name = "labelModelTitle";
            labelModelTitle.Size = new Size(62, 17);
            labelModelTitle.TabIndex = 12;
            labelModelTitle.Text = "Активен: ";
            // 
            // address
            // 
            address.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            address.BackColor = Color.GhostWhite;
            address.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(address, 4);
            address.Font = new Font("Consolas", 9.75F);
            address.ForeColor = Color.FromArgb(0, 0, 0);
            address.Location = new Point(98, 10);
            address.Name = "address";
            address.ReadOnly = true;
            address.Size = new Size(374, 16);
            address.TabIndex = 14;
            address.Text = "Загрузка...";
            // 
            // hourlyRate
            // 
            hourlyRate.Anchor = AnchorStyles.Left;
            hourlyRate.BackColor = Color.GhostWhite;
            hourlyRate.BorderStyle = BorderStyle.None;
            hourlyRate.Font = new Font("Consolas", 9.75F);
            hourlyRate.ForeColor = Color.FromArgb(0, 0, 0);
            hourlyRate.Location = new Point(98, 56);
            hourlyRate.Name = "hourlyRate";
            hourlyRate.ReadOnly = true;
            hourlyRate.Size = new Size(89, 16);
            hourlyRate.TabIndex = 15;
            hourlyRate.Text = "Загрузка...";
            // 
            // active
            // 
            active.Anchor = AnchorStyles.Left;
            active.BackColor = Color.GhostWhite;
            active.BorderStyle = BorderStyle.None;
            active.Font = new Font("Consolas", 9.75F);
            active.ForeColor = Color.FromArgb(0, 0, 0);
            active.Location = new Point(98, 99);
            active.Name = "active";
            active.ReadOnly = true;
            active.Size = new Size(89, 16);
            active.TabIndex = 16;
            active.Text = "Загрузка...";
            // 
            // buttonChoose
            // 
            buttonChoose.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonChoose, 2);
            buttonChoose.Dock = DockStyle.Fill;
            buttonChoose.FlatAppearance.BorderColor = Color.DarkGray;
            buttonChoose.FlatStyle = FlatStyle.Flat;
            buttonChoose.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonChoose.ForeColor = Color.White;
            buttonChoose.Location = new Point(478, 132);
            buttonChoose.Name = "buttonChoose";
            buttonChoose.Padding = new Padding(8, 4, 8, 4);
            buttonChoose.Size = new Size(185, 38);
            buttonChoose.TabIndex = 19;
            buttonChoose.Text = "Выбрать";
            buttonChoose.UseVisualStyleBackColor = false;
            buttonChoose.Click += buttonChoose_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonDelete, 2);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(478, 89);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            buttonDelete.Size = new Size(185, 37);
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
            buttonEdit.Location = new Point(478, 46);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(8, 4, 8, 4);
            buttonEdit.Size = new Size(185, 37);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // ParkingZoneCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ParkingZoneCard";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelAddressTitle;
        private Labels.PrimaryLabel labelHourlyRateTitle;
        private Labels.PrimaryLabel labelModelTitle;
        private Labels.PrimaryLabel labelCategoryTitle;
        private Controls.TextBoxes.ReadOnlyTextBox address;
        private Controls.TextBoxes.ReadOnlyTextBox hourlyRate;
        private Controls.TextBoxes.ReadOnlyTextBox active;
        private Controls.TextBoxes.ReadOnlyTextBox category;
        private CommonButton buttonChoose;
        private CommonButton buttonEdit;
        private CommonButton buttonDelete;
    }
}
