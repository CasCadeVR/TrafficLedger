namespace TrafficLedger.Desktop.Components.Cards
{
    partial class ViolationCard
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
            this.labelNameTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.code = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.violationName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonDelete = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonEdit = new TrafficLedger.Desktop.Components.CommonButton();
            this.labelDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.description = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.labelFinePriceTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.finePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
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
            this.tableLayoutPanel1.Controls.Add(this.labelNameTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.code, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.violationName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptionTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.description, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelFinePriceTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.finePrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 5, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66556F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 280);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNumberTitle
            // 
            this.labelNumberTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNumberTitle.AutoSize = true;
            this.labelNumberTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelNumberTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNumberTitle.Location = new System.Drawing.Point(36, 14);
            this.labelNumberTitle.Name = "labelNumberTitle";
            this.labelNumberTitle.Size = new System.Drawing.Size(56, 17);
            this.labelNumberTitle.TabIndex = 10;
            this.labelNumberTitle.Text = "Номер: ";
            // 
            // labelNameTitle
            // 
            this.labelNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelNameTitle.AutoSize = true;
            this.labelNameTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNameTitle.Location = new System.Drawing.Point(9, 52);
            this.labelNameTitle.Name = "labelNameTitle";
            this.labelNameTitle.Size = new System.Drawing.Size(83, 34);
            this.labelNameTitle.TabIndex = 11;
            this.labelNameTitle.Text = "Наименование: ";
            // 
            // code
            // 
            this.code.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.code.BackColor = System.Drawing.Color.GhostWhite;
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.code, 2);
            this.code.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.code.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.code.Location = new System.Drawing.Point(98, 11);
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Size = new System.Drawing.Size(100, 16);
            this.code.TabIndex = 14;
            this.code.Text = "Загрузка...";
            // 
            // violationName
            // 
            this.violationName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.violationName.BackColor = System.Drawing.Color.GhostWhite;
            this.violationName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.violationName, 4);
            this.violationName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.violationName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.violationName.Location = new System.Drawing.Point(98, 61);
            this.violationName.Name = "violationName";
            this.violationName.ReadOnly = true;
            this.violationName.Size = new System.Drawing.Size(374, 16);
            this.violationName.TabIndex = 15;
            this.violationName.Text = "Загрузка...";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonDelete, 2);
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.ForeColor = System.Drawing.Color.White;
            this.buttonDelete.Location = new System.Drawing.Point(478, 233);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonDelete.Size = new System.Drawing.Size(185, 44);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonEdit, 2);
            this.buttonEdit.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(478, 187);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonEdit.Size = new System.Drawing.Size(185, 40);
            this.buttonEdit.TabIndex = 20;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelDescriptionTitle
            // 
            this.labelDescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDescriptionTitle.AutoSize = true;
            this.labelDescriptionTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDescriptionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescriptionTitle.Location = new System.Drawing.Point(19, 152);
            this.labelDescriptionTitle.Name = "labelDescriptionTitle";
            this.labelDescriptionTitle.Size = new System.Drawing.Size(73, 17);
            this.labelDescriptionTitle.TabIndex = 12;
            this.labelDescriptionTitle.Text = "Описание: ";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.GhostWhite;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.description, 3);
            this.description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.description.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.description.Location = new System.Drawing.Point(98, 141);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.description, 3);
            this.description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.description.Size = new System.Drawing.Size(279, 136);
            this.description.TabIndex = 16;
            this.description.Text = "Загрузка...";
            // 
            // labelFinePriceTitle
            // 
            this.labelFinePriceTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFinePriceTitle.AutoSize = true;
            this.labelFinePriceTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFinePriceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFinePriceTitle.Location = new System.Drawing.Point(38, 98);
            this.labelFinePriceTitle.Name = "labelFinePriceTitle";
            this.labelFinePriceTitle.Size = new System.Drawing.Size(54, 34);
            this.labelFinePriceTitle.TabIndex = 13;
            this.labelFinePriceTitle.Text = "Штраф (руб.): ";
            // 
            // finePrice
            // 
            this.finePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.finePrice.BackColor = System.Drawing.Color.GhostWhite;
            this.finePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.finePrice, 2);
            this.finePrice.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.finePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.finePrice.Location = new System.Drawing.Point(98, 103);
            this.finePrice.Name = "finePrice";
            this.finePrice.ReadOnly = true;
            this.finePrice.Size = new System.Drawing.Size(100, 16);
            this.finePrice.TabIndex = 17;
            this.finePrice.Text = "Загрузка...";
            // 
            // ViolationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViolationCard";
            this.Size = new System.Drawing.Size(666, 280);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
