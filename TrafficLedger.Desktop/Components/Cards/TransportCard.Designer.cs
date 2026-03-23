using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class TransportCard
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
            labelNumberTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelBrandTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelModelTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelCategoryTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            number = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            brand = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            model = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            category = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonListFines = new CommonButton();
            primaryLabel1 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            status = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            buttonEdit = new CommonButton();
            buttonDelete = new CommonButton();
            buttonAddFine = new CommonButton();
            toolTip = new ToolTip(components);
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
            tableLayoutPanel1.Controls.Add(labelNumberTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelBrandTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(labelModelTitle, 0, 2);
            tableLayoutPanel1.Controls.Add(labelCategoryTitle, 0, 3);
            tableLayoutPanel1.Controls.Add(number, 1, 0);
            tableLayoutPanel1.Controls.Add(brand, 1, 1);
            tableLayoutPanel1.Controls.Add(model, 1, 2);
            tableLayoutPanel1.Controls.Add(category, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonListFines, 5, 5);
            tableLayoutPanel1.Controls.Add(primaryLabel1, 0, 4);
            tableLayoutPanel1.Controls.Add(status, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonEdit, 5, 4);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 2);
            tableLayoutPanel1.Controls.Add(buttonAddFine, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6655579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6655579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6655579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6655579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6688881F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6688881F));
            tableLayoutPanel1.Size = new Size(666, 283);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNumberTitle
            // 
            labelNumberTitle.Anchor = AnchorStyles.Right;
            labelNumberTitle.AutoSize = true;
            labelNumberTitle.Font = new Font("Segoe UI", 9.75F);
            labelNumberTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNumberTitle.Location = new Point(36, 15);
            labelNumberTitle.Name = "labelNumberTitle";
            labelNumberTitle.Size = new Size(56, 17);
            labelNumberTitle.TabIndex = 10;
            labelNumberTitle.Text = "Номер: ";
            // 
            // labelBrandTitle
            // 
            labelBrandTitle.Anchor = AnchorStyles.Right;
            labelBrandTitle.AutoSize = true;
            labelBrandTitle.Font = new Font("Segoe UI", 9.75F);
            labelBrandTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelBrandTitle.Location = new Point(37, 62);
            labelBrandTitle.Name = "labelBrandTitle";
            labelBrandTitle.Size = new Size(55, 17);
            labelBrandTitle.TabIndex = 11;
            labelBrandTitle.Text = "Марка: ";
            // 
            // labelModelTitle
            // 
            labelModelTitle.Anchor = AnchorStyles.Right;
            labelModelTitle.AutoSize = true;
            labelModelTitle.Font = new Font("Segoe UI", 9.75F);
            labelModelTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelModelTitle.Location = new Point(29, 109);
            labelModelTitle.Name = "labelModelTitle";
            labelModelTitle.Size = new Size(63, 17);
            labelModelTitle.TabIndex = 12;
            labelModelTitle.Text = "Модель: ";
            // 
            // labelCategoryTitle
            // 
            labelCategoryTitle.Anchor = AnchorStyles.Right;
            labelCategoryTitle.AutoSize = true;
            labelCategoryTitle.Font = new Font("Segoe UI", 9.75F);
            labelCategoryTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelCategoryTitle.Location = new Point(15, 156);
            labelCategoryTitle.Name = "labelCategoryTitle";
            labelCategoryTitle.Size = new Size(77, 17);
            labelCategoryTitle.TabIndex = 13;
            labelCategoryTitle.Text = "Категория: ";
            // 
            // number
            // 
            number.Anchor = AnchorStyles.Left;
            number.BackColor = Color.GhostWhite;
            number.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(number, 2);
            number.Font = new Font("Consolas", 9.75F);
            number.ForeColor = Color.FromArgb(0, 0, 0);
            number.Location = new Point(98, 12);
            number.Name = "number";
            number.ReadOnly = true;
            number.Size = new Size(100, 16);
            number.TabIndex = 14;
            number.Text = "Загрузка...";
            // 
            // brand
            // 
            brand.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            brand.BackColor = Color.GhostWhite;
            brand.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(brand, 2);
            brand.Font = new Font("Consolas", 9.75F);
            brand.ForeColor = Color.FromArgb(0, 0, 0);
            brand.Location = new Point(98, 62);
            brand.Name = "brand";
            brand.ReadOnly = true;
            brand.Size = new Size(184, 16);
            brand.TabIndex = 15;
            brand.Text = "Загрузка...";
            // 
            // model
            // 
            model.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            model.BackColor = Color.GhostWhite;
            model.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(model, 2);
            model.Font = new Font("Consolas", 9.75F);
            model.ForeColor = Color.FromArgb(0, 0, 0);
            model.Location = new Point(98, 109);
            model.Name = "model";
            model.ReadOnly = true;
            model.Size = new Size(184, 16);
            model.TabIndex = 16;
            model.Text = "Загрузка...";
            // 
            // category
            // 
            category.Anchor = AnchorStyles.Left;
            category.BackColor = Color.GhostWhite;
            category.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(category, 2);
            category.Font = new Font("Consolas", 9.75F);
            category.ForeColor = Color.FromArgb(0, 0, 0);
            category.Location = new Point(98, 153);
            category.Name = "category";
            category.ReadOnly = true;
            category.Size = new Size(100, 16);
            category.TabIndex = 17;
            category.Text = "Загрузка...";
            // 
            // buttonListFines
            // 
            buttonListFines.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonListFines, 2);
            buttonListFines.Dock = DockStyle.Fill;
            buttonListFines.FlatAppearance.BorderColor = Color.DarkGray;
            buttonListFines.FlatStyle = FlatStyle.Flat;
            buttonListFines.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonListFines.ForeColor = Color.White;
            buttonListFines.Location = new Point(478, 238);
            buttonListFines.Name = "buttonListFines";
            buttonListFines.Padding = new Padding(8, 4, 8, 4);
            buttonListFines.Size = new Size(185, 42);
            buttonListFines.TabIndex = 19;
            buttonListFines.Text = "Посмотреть штрафы";
            buttonListFines.UseVisualStyleBackColor = false;
            buttonListFines.Click += buttonListFines_Click;
            // 
            // primaryLabel1
            // 
            primaryLabel1.Anchor = AnchorStyles.Right;
            primaryLabel1.AutoSize = true;
            primaryLabel1.Font = new Font("Segoe UI", 9.75F);
            primaryLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel1.Location = new Point(36, 203);
            primaryLabel1.Name = "primaryLabel1";
            primaryLabel1.Size = new Size(56, 17);
            primaryLabel1.TabIndex = 22;
            primaryLabel1.Text = "Статус:  ";
            // 
            // status
            // 
            status.Anchor = AnchorStyles.Left;
            status.BackColor = Color.GhostWhite;
            status.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(status, 2);
            status.Font = new Font("Consolas", 9.75F);
            status.ForeColor = Color.FromArgb(0, 0, 0);
            status.Location = new Point(98, 200);
            status.Name = "status";
            status.ReadOnly = true;
            status.Size = new Size(100, 16);
            status.TabIndex = 23;
            status.Text = "Загрузка...";
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonEdit, 2);
            buttonEdit.FlatAppearance.BorderColor = Color.DarkGray;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(478, 191);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(8, 4, 8, 4);
            buttonEdit.Size = new Size(185, 41);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonDelete, 2);
            buttonDelete.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDelete.FlatStyle = FlatStyle.Flat;
            buttonDelete.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDelete.ForeColor = Color.White;
            buttonDelete.Location = new Point(478, 97);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Padding = new Padding(8, 4, 8, 4);
            buttonDelete.Size = new Size(185, 41);
            buttonDelete.TabIndex = 21;
            buttonDelete.Text = "Удалить";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAddFine
            // 
            buttonAddFine.BackColor = Color.Green;
            tableLayoutPanel1.SetColumnSpan(buttonAddFine, 2);
            buttonAddFine.FlatAppearance.BorderColor = Color.DarkGray;
            buttonAddFine.FlatStyle = FlatStyle.Flat;
            buttonAddFine.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonAddFine.ForeColor = Color.White;
            buttonAddFine.Location = new Point(478, 144);
            buttonAddFine.Name = "buttonAddFine";
            buttonAddFine.Padding = new Padding(8, 4, 8, 4);
            buttonAddFine.Size = new Size(185, 41);
            buttonAddFine.TabIndex = 18;
            buttonAddFine.Text = "Добавить штраф";
            buttonAddFine.UseVisualStyleBackColor = false;
            buttonAddFine.Click += buttonAddFine_Click;
            // 
            // TransportCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "TransportCard";
            Size = new Size(666, 283);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelNumberTitle;
        private Labels.PrimaryLabel labelBrandTitle;
        private Labels.PrimaryLabel labelModelTitle;
        private Labels.PrimaryLabel labelCategoryTitle;
        private Controls.TextBoxes.ReadOnlyTextBox number;
        private Controls.TextBoxes.ReadOnlyTextBox brand;
        private Controls.TextBoxes.ReadOnlyTextBox model;
        private Controls.TextBoxes.ReadOnlyTextBox category;
        private CommonButton buttonAddFine;
        private CommonButton buttonListFines;
        private CommonButton buttonEdit;
        private CommonButton buttonDelete;
        private Labels.PrimaryLabel primaryLabel1;
        private Controls.TextBoxes.ReadOnlyTextBox status;
    }
}
