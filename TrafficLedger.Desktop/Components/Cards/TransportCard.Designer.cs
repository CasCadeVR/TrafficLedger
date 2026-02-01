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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNumberTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelBrandTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelModelTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelCategoryTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.number = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.brand = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.model = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.category = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonListFines = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonEdit = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonAddFine = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonDelete = new TrafficLedger.Desktop.Components.CommonButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.Controls.Add(this.labelNumberTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBrandTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelModelTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCategoryTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.number, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.brand, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.model, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.category, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonListFines, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddFine, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNumberTitle
            // 
            this.labelNumberTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNumberTitle.AutoSize = true;
            this.labelNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelNumberTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumberTitle.Location = new System.Drawing.Point(36, 16);
            this.labelNumberTitle.Name = "labelNumberTitle";
            this.labelNumberTitle.Size = new System.Drawing.Size(56, 17);
            this.labelNumberTitle.TabIndex = 10;
            this.labelNumberTitle.Text = "Номер: ";
            // 
            // labelBrandTitle
            // 
            this.labelBrandTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBrandTitle.AutoSize = true;
            this.labelBrandTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelBrandTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBrandTitle.Location = new System.Drawing.Point(37, 65);
            this.labelBrandTitle.Name = "labelBrandTitle";
            this.labelBrandTitle.Size = new System.Drawing.Size(55, 17);
            this.labelBrandTitle.TabIndex = 11;
            this.labelBrandTitle.Text = "Марка: ";
            // 
            // labelModelTitle
            // 
            this.labelModelTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelModelTitle.AutoSize = true;
            this.labelModelTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelModelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelModelTitle.Location = new System.Drawing.Point(29, 114);
            this.labelModelTitle.Name = "labelModelTitle";
            this.labelModelTitle.Size = new System.Drawing.Size(63, 17);
            this.labelModelTitle.TabIndex = 12;
            this.labelModelTitle.Text = "Модель: ";
            // 
            // labelCategoryTitle
            // 
            this.labelCategoryTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCategoryTitle.AutoSize = true;
            this.labelCategoryTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCategoryTitle.Location = new System.Drawing.Point(15, 163);
            this.labelCategoryTitle.Name = "labelCategoryTitle";
            this.labelCategoryTitle.Size = new System.Drawing.Size(77, 17);
            this.labelCategoryTitle.TabIndex = 13;
            this.labelCategoryTitle.Text = "Категория: ";
            // 
            // number
            // 
            this.number.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.number.BackColor = System.Drawing.Color.GhostWhite;
            this.number.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.number, 2);
            this.number.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.number.Location = new System.Drawing.Point(98, 13);
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Size = new System.Drawing.Size(100, 16);
            this.number.TabIndex = 14;
            this.number.Text = "Загрузка...";
            // 
            // brand
            // 
            this.brand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.brand.BackColor = System.Drawing.Color.GhostWhite;
            this.brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.brand, 2);
            this.brand.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.brand.Location = new System.Drawing.Point(98, 65);
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Size = new System.Drawing.Size(184, 16);
            this.brand.TabIndex = 15;
            this.brand.Text = "Загрузка...";
            // 
            // model
            // 
            this.model.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.model.BackColor = System.Drawing.Color.GhostWhite;
            this.model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.model, 2);
            this.model.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.model.Location = new System.Drawing.Point(98, 114);
            this.model.Name = "model";
            this.model.ReadOnly = true;
            this.model.Size = new System.Drawing.Size(184, 16);
            this.model.TabIndex = 16;
            this.model.Text = "Загрузка...";
            // 
            // category
            // 
            this.category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.category.BackColor = System.Drawing.Color.GhostWhite;
            this.category.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.category, 2);
            this.category.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.category.Location = new System.Drawing.Point(98, 160);
            this.category.Name = "category";
            this.category.ReadOnly = true;
            this.category.Size = new System.Drawing.Size(100, 16);
            this.category.TabIndex = 17;
            this.category.Text = "Загрузка...";
            // 
            // buttonListFines
            // 
            this.buttonListFines.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonListFines, 2);
            this.buttonListFines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonListFines.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonListFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListFines.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonListFines.ForeColor = System.Drawing.Color.White;
            this.buttonListFines.Location = new System.Drawing.Point(478, 150);
            this.buttonListFines.Name = "buttonListFines";
            this.buttonListFines.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonListFines.Size = new System.Drawing.Size(185, 43);
            this.buttonListFines.TabIndex = 19;
            this.buttonListFines.Text = "Посмотреть штрафы";
            this.buttonListFines.UseVisualStyleBackColor = false;
            this.buttonListFines.Click += new System.EventHandler(this.buttonListFines_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonEdit, 2);
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(478, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonEdit.Size = new System.Drawing.Size(185, 43);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddFine
            // 
            this.buttonAddFine.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonAddFine, 2);
            this.buttonAddFine.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonAddFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFine.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonAddFine.ForeColor = System.Drawing.Color.White;
            this.buttonAddFine.Location = new System.Drawing.Point(478, 101);
            this.buttonAddFine.Name = "buttonAddFine";
            this.buttonAddFine.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonAddFine.Size = new System.Drawing.Size(185, 43);
            this.buttonAddFine.TabIndex = 18;
            this.buttonAddFine.Text = "Добавить штраф";
            this.buttonAddFine.UseVisualStyleBackColor = false;
            this.buttonAddFine.Click += new System.EventHandler(this.buttonAddFine_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonDelete, 2);
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(478, 52);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonDelete.Size = new System.Drawing.Size(185, 43);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // TransportCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TransportCard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
