using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class TransportRequestCard
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
            toolTip = new ToolTip(components);
            buttonAbout = new CommonButton();
            category = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            model = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            brand = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            number = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelCategoryTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelModelTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelBrandTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelNumberTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonReject = new CommonButton();
            buttonApprove = new CommonButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            buttonAbout.Location = new Point(478, 132);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new Padding(8, 4, 8, 4);
            buttonAbout.Size = new Size(185, 38);
            buttonAbout.TabIndex = 19;
            buttonAbout.Text = "Подробнее";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // category
            // 
            category.Anchor = AnchorStyles.Left;
            category.BackColor = Color.GhostWhite;
            category.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(category, 2);
            category.Font = new Font("Consolas", 9.75F);
            category.ForeColor = Color.FromArgb(0, 0, 0);
            category.Location = new Point(98, 139);
            category.Name = "category";
            category.ReadOnly = true;
            category.Size = new Size(100, 16);
            category.TabIndex = 17;
            category.Text = "Загрузка...";
            // 
            // model
            // 
            model.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            model.BackColor = Color.GhostWhite;
            model.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(model, 2);
            model.Font = new Font("Consolas", 9.75F);
            model.ForeColor = Color.FromArgb(0, 0, 0);
            model.Location = new Point(98, 99);
            model.Name = "model";
            model.ReadOnly = true;
            model.Size = new Size(184, 16);
            model.TabIndex = 16;
            model.Text = "Загрузка...";
            // 
            // brand
            // 
            brand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            brand.BackColor = Color.GhostWhite;
            brand.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(brand, 2);
            brand.Font = new Font("Consolas", 9.75F);
            brand.ForeColor = Color.FromArgb(0, 0, 0);
            brand.Location = new Point(98, 56);
            brand.Name = "brand";
            brand.ReadOnly = true;
            brand.Size = new Size(184, 16);
            brand.TabIndex = 15;
            brand.Text = "Загрузка...";
            // 
            // number
            // 
            number.Anchor = AnchorStyles.Left;
            number.BackColor = Color.GhostWhite;
            number.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(number, 2);
            number.Font = new Font("Consolas", 9.75F);
            number.ForeColor = Color.FromArgb(0, 0, 0);
            number.Location = new Point(98, 10);
            number.Name = "number";
            number.ReadOnly = true;
            number.Size = new Size(100, 16);
            number.TabIndex = 14;
            number.Text = "Загрузка...";
            // 
            // labelCategoryTitle
            // 
            labelCategoryTitle.Anchor = AnchorStyles.Right;
            labelCategoryTitle.AutoSize = true;
            labelCategoryTitle.Font = new Font("Segoe UI", 9.75F);
            labelCategoryTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelCategoryTitle.Location = new Point(15, 142);
            labelCategoryTitle.Name = "labelCategoryTitle";
            labelCategoryTitle.Size = new Size(77, 17);
            labelCategoryTitle.TabIndex = 13;
            labelCategoryTitle.Text = "Категория: ";
            // 
            // labelModelTitle
            // 
            labelModelTitle.Anchor = AnchorStyles.Right;
            labelModelTitle.AutoSize = true;
            labelModelTitle.Font = new Font("Segoe UI", 9.75F);
            labelModelTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelModelTitle.Location = new Point(29, 99);
            labelModelTitle.Name = "labelModelTitle";
            labelModelTitle.Size = new Size(63, 17);
            labelModelTitle.TabIndex = 12;
            labelModelTitle.Text = "Модель: ";
            // 
            // labelBrandTitle
            // 
            labelBrandTitle.Anchor = AnchorStyles.Right;
            labelBrandTitle.AutoSize = true;
            labelBrandTitle.Font = new Font("Segoe UI", 9.75F);
            labelBrandTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelBrandTitle.Location = new Point(37, 56);
            labelBrandTitle.Name = "labelBrandTitle";
            labelBrandTitle.Size = new Size(55, 17);
            labelBrandTitle.TabIndex = 11;
            labelBrandTitle.Text = "Марка: ";
            // 
            // labelNumberTitle
            // 
            labelNumberTitle.Anchor = AnchorStyles.Right;
            labelNumberTitle.AutoSize = true;
            labelNumberTitle.Font = new Font("Segoe UI", 9.75F);
            labelNumberTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNumberTitle.Location = new Point(36, 13);
            labelNumberTitle.Name = "labelNumberTitle";
            labelNumberTitle.Size = new Size(56, 17);
            labelNumberTitle.TabIndex = 10;
            labelNumberTitle.Text = "Номер: ";
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
            tableLayoutPanel1.Controls.Add(labelNumberTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelBrandTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(labelModelTitle, 0, 2);
            tableLayoutPanel1.Controls.Add(labelCategoryTitle, 0, 3);
            tableLayoutPanel1.Controls.Add(number, 1, 0);
            tableLayoutPanel1.Controls.Add(brand, 1, 1);
            tableLayoutPanel1.Controls.Add(model, 1, 2);
            tableLayoutPanel1.Controls.Add(category, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonAbout, 5, 3);
            tableLayoutPanel1.Controls.Add(buttonReject, 5, 2);
            tableLayoutPanel1.Controls.Add(buttonApprove, 5, 1);
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
            // buttonReject
            // 
            buttonReject.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonReject, 2);
            buttonReject.Dock = DockStyle.Fill;
            buttonReject.FlatAppearance.BorderColor = Color.DarkGray;
            buttonReject.FlatStyle = FlatStyle.Flat;
            buttonReject.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonReject.ForeColor = Color.White;
            buttonReject.Location = new Point(478, 89);
            buttonReject.Name = "buttonReject";
            buttonReject.Padding = new Padding(8, 4, 8, 4);
            buttonReject.Size = new Size(185, 37);
            buttonReject.TabIndex = 28;
            buttonReject.Text = "Отклонить";
            buttonReject.UseVisualStyleBackColor = false;
            buttonReject.Click += buttonReject_Click;
            // 
            // buttonApprove
            // 
            buttonApprove.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonApprove, 2);
            buttonApprove.Dock = DockStyle.Fill;
            buttonApprove.FlatAppearance.BorderColor = Color.DarkGray;
            buttonApprove.FlatStyle = FlatStyle.Flat;
            buttonApprove.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonApprove.ForeColor = Color.White;
            buttonApprove.Location = new Point(478, 46);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Padding = new Padding(8, 4, 8, 4);
            buttonApprove.Size = new Size(185, 37);
            buttonApprove.TabIndex = 27;
            buttonApprove.Text = "Одобрить";
            buttonApprove.UseVisualStyleBackColor = false;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // TransportRequestCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "TransportRequestCard";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private CommonButton buttonAbout;
        private TableLayoutPanel tableLayoutPanel1;
        private Labels.PrimaryLabel labelNumberTitle;
        private Labels.PrimaryLabel labelBrandTitle;
        private Labels.PrimaryLabel labelModelTitle;
        private Labels.PrimaryLabel labelCategoryTitle;
        private Controls.TextBoxes.ReadOnlyTextBox number;
        private Controls.TextBoxes.ReadOnlyTextBox brand;
        private Controls.TextBoxes.ReadOnlyTextBox model;
        private Controls.TextBoxes.ReadOnlyTextBox category;
        private CommonButton buttonReject;
        private CommonButton buttonApprove;
    }
}
