using TrafficLedger.Desktop.Components.Controls;

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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelNumberTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelNameTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            code = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            violationName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelDescriptionTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            description = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelFinePriceTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            finePrice = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
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
            tableLayoutPanel1.Controls.Add(labelNumberTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(labelNameTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(code, 1, 0);
            tableLayoutPanel1.Controls.Add(violationName, 1, 1);
            tableLayoutPanel1.Controls.Add(labelDescriptionTitle, 0, 3);
            tableLayoutPanel1.Controls.Add(description, 1, 3);
            tableLayoutPanel1.Controls.Add(labelFinePriceTitle, 0, 2);
            tableLayoutPanel1.Controls.Add(finePrice, 1, 2);
            tableLayoutPanel1.Controls.Add(buttonDelete, 5, 5);
            tableLayoutPanel1.Controls.Add(buttonEdit, 5, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66889F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66889F));
            tableLayoutPanel1.Size = new Size(666, 247);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelNumberTitle
            // 
            labelNumberTitle.Anchor = AnchorStyles.Right;
            labelNumberTitle.AutoSize = true;
            labelNumberTitle.Font = new Font("Segoe UI", 9.75F);
            labelNumberTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNumberTitle.Location = new Point(36, 12);
            labelNumberTitle.Name = "labelNumberTitle";
            labelNumberTitle.Size = new Size(56, 17);
            labelNumberTitle.TabIndex = 10;
            labelNumberTitle.Text = "Номер: ";
            // 
            // labelNameTitle
            // 
            labelNameTitle.Anchor = AnchorStyles.Right;
            labelNameTitle.AutoSize = true;
            labelNameTitle.Font = new Font("Segoe UI", 9.75F);
            labelNameTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelNameTitle.Location = new Point(9, 44);
            labelNameTitle.Name = "labelNameTitle";
            labelNameTitle.Size = new Size(83, 34);
            labelNameTitle.TabIndex = 11;
            labelNameTitle.Text = "Наименование: ";
            // 
            // code
            // 
            code.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            code.BackColor = Color.GhostWhite;
            code.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(code, 2);
            code.Font = new Font("Consolas", 9.75F);
            code.ForeColor = Color.FromArgb(0, 0, 0);
            code.Location = new Point(98, 12);
            code.Name = "code";
            code.ReadOnly = true;
            code.Size = new Size(184, 16);
            code.TabIndex = 14;
            code.Text = "Загрузка...";
            // 
            // violationName
            // 
            violationName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            violationName.BackColor = Color.GhostWhite;
            violationName.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(violationName, 4);
            violationName.Font = new Font("Consolas", 9.75F);
            violationName.ForeColor = Color.FromArgb(0, 0, 0);
            violationName.Location = new Point(98, 53);
            violationName.Name = "violationName";
            violationName.ReadOnly = true;
            violationName.Size = new Size(374, 16);
            violationName.TabIndex = 15;
            violationName.Text = "Загрузка...";
            // 
            // labelDescriptionTitle
            // 
            labelDescriptionTitle.Anchor = AnchorStyles.Right;
            labelDescriptionTitle.AutoSize = true;
            labelDescriptionTitle.Font = new Font("Segoe UI", 9.75F);
            labelDescriptionTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescriptionTitle.Location = new Point(19, 135);
            labelDescriptionTitle.Name = "labelDescriptionTitle";
            labelDescriptionTitle.Size = new Size(73, 17);
            labelDescriptionTitle.TabIndex = 12;
            labelDescriptionTitle.Text = "Описание: ";
            // 
            // description
            // 
            description.BackColor = Color.GhostWhite;
            description.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(description, 3);
            description.Dock = DockStyle.Fill;
            description.Font = new Font("Consolas", 9.75F);
            description.ForeColor = Color.FromArgb(0, 0, 0);
            description.Location = new Point(98, 126);
            description.Multiline = true;
            description.Name = "description";
            description.ReadOnly = true;
            tableLayoutPanel1.SetRowSpan(description, 3);
            description.ScrollBars = ScrollBars.Vertical;
            description.Size = new Size(279, 118);
            description.TabIndex = 16;
            description.Text = "Загрузка...";
            // 
            // labelFinePriceTitle
            // 
            labelFinePriceTitle.Anchor = AnchorStyles.Right;
            labelFinePriceTitle.AutoSize = true;
            labelFinePriceTitle.Font = new Font("Segoe UI", 9.75F);
            labelFinePriceTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelFinePriceTitle.Location = new Point(38, 85);
            labelFinePriceTitle.Name = "labelFinePriceTitle";
            labelFinePriceTitle.Size = new Size(54, 34);
            labelFinePriceTitle.TabIndex = 13;
            labelFinePriceTitle.Text = "Штраф (руб.): ";
            // 
            // finePrice
            // 
            finePrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            finePrice.BackColor = Color.GhostWhite;
            finePrice.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(finePrice, 2);
            finePrice.Font = new Font("Consolas", 9.75F);
            finePrice.ForeColor = Color.FromArgb(0, 0, 0);
            finePrice.Location = new Point(98, 94);
            finePrice.Name = "finePrice";
            finePrice.ReadOnly = true;
            finePrice.Size = new Size(184, 16);
            finePrice.TabIndex = 17;
            finePrice.Text = "Загрузка...";
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
            buttonDelete.Size = new Size(185, 36);
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
            buttonEdit.Location = new Point(478, 167);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Padding = new Padding(8, 4, 8, 4);
            buttonEdit.Size = new Size(185, 35);
            buttonEdit.TabIndex = 20;
            buttonEdit.Text = "Редактировать";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // ViolationCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "ViolationCard";
            Size = new Size(666, 247);
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
    }
}
