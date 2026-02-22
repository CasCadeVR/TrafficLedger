using System.Windows.Forms;
using TrafficLedger.Desktop.Components;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class DriverLicenseCard
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
            labelFullNameTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            fullName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelUniqueIdTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            uniqueId = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            primaryLabel1 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            buttonAbout = new CommonButton();
            licenseNumberTextBox = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            primaryLabel2 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            residenseTextBox = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            primaryLabel3 = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            categoryNames = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            toolTip = new ToolTip(components);
            buttonReject = new CommonButton();
            buttonApprove = new CommonButton();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6675F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6675F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6675F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6658325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6658325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6658325F));
            tableLayoutPanel1.Controls.Add(labelFullNameTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(fullName, 1, 0);
            tableLayoutPanel1.Controls.Add(labelUniqueIdTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(uniqueId, 1, 1);
            tableLayoutPanel1.Controls.Add(primaryLabel1, 0, 2);
            tableLayoutPanel1.Controls.Add(buttonAbout, 4, 5);
            tableLayoutPanel1.Controls.Add(licenseNumberTextBox, 1, 2);
            tableLayoutPanel1.Controls.Add(primaryLabel2, 0, 3);
            tableLayoutPanel1.Controls.Add(residenseTextBox, 1, 3);
            tableLayoutPanel1.Controls.Add(primaryLabel3, 0, 4);
            tableLayoutPanel1.Controls.Add(categoryNames, 1, 4);
            tableLayoutPanel1.Controls.Add(buttonApprove, 4, 4);
            tableLayoutPanel1.Controls.Add(buttonReject, 4, 3);
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
            tableLayoutPanel1.Size = new Size(666, 279);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelFullNameTitle
            // 
            labelFullNameTitle.Anchor = AnchorStyles.Right;
            labelFullNameTitle.AutoSize = true;
            labelFullNameTitle.Font = new Font("Segoe UI", 9.75F);
            labelFullNameTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelFullNameTitle.Location = new Point(16, 6);
            labelFullNameTitle.Name = "labelFullNameTitle";
            labelFullNameTitle.Size = new Size(92, 34);
            labelFullNameTitle.TabIndex = 8;
            labelFullNameTitle.Text = "ФИО Отправителя: ";
            // 
            // fullName
            // 
            fullName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            fullName.BackColor = Color.GhostWhite;
            fullName.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(fullName, 2);
            fullName.Font = new Font("Consolas", 9.75F);
            fullName.ForeColor = Color.FromArgb(0, 0, 0);
            fullName.Location = new Point(114, 15);
            fullName.Name = "fullName";
            fullName.ReadOnly = true;
            fullName.Size = new Size(216, 16);
            fullName.TabIndex = 10;
            fullName.Text = "Загрузка...";
            // 
            // labelUniqueIdTitle
            // 
            labelUniqueIdTitle.Anchor = AnchorStyles.Right;
            labelUniqueIdTitle.AutoSize = true;
            labelUniqueIdTitle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelUniqueIdTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelUniqueIdTitle.Location = new Point(13, 46);
            labelUniqueIdTitle.Name = "labelUniqueIdTitle";
            labelUniqueIdTitle.Size = new Size(95, 45);
            labelUniqueIdTitle.TabIndex = 15;
            labelUniqueIdTitle.Text = "Уникальный идентификатор отправителя: ";
            // 
            // uniqueId
            // 
            uniqueId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            uniqueId.BackColor = Color.GhostWhite;
            uniqueId.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(uniqueId, 2);
            uniqueId.Font = new Font("Consolas", 9.75F);
            uniqueId.ForeColor = Color.FromArgb(0, 0, 0);
            uniqueId.Location = new Point(114, 61);
            uniqueId.Name = "uniqueId";
            uniqueId.ReadOnly = true;
            uniqueId.Size = new Size(216, 16);
            uniqueId.TabIndex = 17;
            uniqueId.Text = "Загрузка...";
            // 
            // primaryLabel1
            // 
            primaryLabel1.Anchor = AnchorStyles.Right;
            primaryLabel1.AutoSize = true;
            primaryLabel1.Font = new Font("Segoe UI", 9.75F);
            primaryLabel1.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel1.Location = new Point(45, 98);
            primaryLabel1.Name = "primaryLabel1";
            primaryLabel1.Size = new Size(63, 34);
            primaryLabel1.TabIndex = 18;
            primaryLabel1.Text = "Номер лицензии";
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
            buttonAbout.Location = new Point(446, 233);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Padding = new Padding(8, 4, 8, 4);
            buttonAbout.Size = new Size(217, 43);
            buttonAbout.TabIndex = 13;
            buttonAbout.Text = "Подробнее";
            buttonAbout.UseVisualStyleBackColor = false;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // licenseNumberTextBox
            // 
            licenseNumberTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            licenseNumberTextBox.BackColor = Color.GhostWhite;
            licenseNumberTextBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(licenseNumberTextBox, 2);
            licenseNumberTextBox.Font = new Font("Consolas", 9.75F);
            licenseNumberTextBox.ForeColor = Color.FromArgb(0, 0, 0);
            licenseNumberTextBox.Location = new Point(114, 107);
            licenseNumberTextBox.Name = "licenseNumberTextBox";
            licenseNumberTextBox.ReadOnly = true;
            licenseNumberTextBox.Size = new Size(216, 16);
            licenseNumberTextBox.TabIndex = 19;
            licenseNumberTextBox.Text = "Загрузка...";
            // 
            // primaryLabel2
            // 
            primaryLabel2.Anchor = AnchorStyles.Right;
            primaryLabel2.AutoSize = true;
            primaryLabel2.Font = new Font("Segoe UI", 9.75F);
            primaryLabel2.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel2.Location = new Point(56, 152);
            primaryLabel2.Name = "primaryLabel2";
            primaryLabel2.Size = new Size(52, 17);
            primaryLabel2.TabIndex = 20;
            primaryLabel2.Text = "Город: ";
            // 
            // residenseTextBox
            // 
            residenseTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            residenseTextBox.BackColor = Color.GhostWhite;
            residenseTextBox.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(residenseTextBox, 2);
            residenseTextBox.Font = new Font("Consolas", 9.75F);
            residenseTextBox.ForeColor = Color.FromArgb(0, 0, 0);
            residenseTextBox.Location = new Point(114, 153);
            residenseTextBox.Name = "residenseTextBox";
            residenseTextBox.ReadOnly = true;
            residenseTextBox.Size = new Size(216, 16);
            residenseTextBox.TabIndex = 21;
            residenseTextBox.Text = "Загрузка...";
            // 
            // primaryLabel3
            // 
            primaryLabel3.Anchor = AnchorStyles.Right;
            primaryLabel3.AutoSize = true;
            primaryLabel3.Font = new Font("Segoe UI", 9.75F);
            primaryLabel3.ForeColor = Color.FromArgb(0, 0, 0);
            primaryLabel3.Location = new Point(31, 198);
            primaryLabel3.Name = "primaryLabel3";
            primaryLabel3.Size = new Size(77, 17);
            primaryLabel3.TabIndex = 22;
            primaryLabel3.Text = "Категории: ";
            // 
            // categoryNames
            // 
            categoryNames.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            categoryNames.BackColor = Color.GhostWhite;
            categoryNames.BorderStyle = BorderStyle.None;
            tableLayoutPanel1.SetColumnSpan(categoryNames, 2);
            categoryNames.Font = new Font("Consolas", 9.75F);
            categoryNames.ForeColor = Color.FromArgb(0, 0, 0);
            categoryNames.Location = new Point(114, 199);
            categoryNames.Name = "categoryNames";
            categoryNames.ReadOnly = true;
            categoryNames.Size = new Size(216, 16);
            categoryNames.TabIndex = 23;
            categoryNames.Text = "Загрузка...";
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
            buttonReject.Location = new Point(446, 141);
            buttonReject.Name = "buttonReject";
            buttonReject.Padding = new Padding(8, 4, 8, 4);
            buttonReject.Size = new Size(217, 40);
            buttonReject.TabIndex = 26;
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
            buttonApprove.Location = new Point(446, 187);
            buttonApprove.Name = "buttonApprove";
            buttonApprove.Padding = new Padding(8, 4, 8, 4);
            buttonApprove.Size = new Size(217, 40);
            buttonApprove.TabIndex = 25;
            buttonApprove.Text = "Одобрить";
            buttonApprove.UseVisualStyleBackColor = false;
            buttonApprove.Click += buttonApprove_Click;
            // 
            // DriverLicenseCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DriverLicenseCard";
            Size = new Size(666, 279);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelFullNameTitle;
        private Labels.PrimaryLabel labelBirthDateTitle;
        private Controls.TextBoxes.ReadOnlyTextBox fullName;
        private Controls.TextBoxes.ReadOnlyTextBox birthDate;
        private CommonButton buttonEdit;
        private CommonButton buttonAbout;
        private Labels.PrimaryLabel labelBirthPlaceTitle;
        private Labels.PrimaryLabel labelUniqueIdTitle;
        private Controls.TextBoxes.ReadOnlyTextBox birthPlace;
        private Controls.TextBoxes.ReadOnlyTextBox uniqueId;
        private Labels.PrimaryLabel primaryLabel1;
        private CommonButton buttonConnectTransport;
        private CommonButton buttonConnectDriverLicense;
        private Controls.TextBoxes.ReadOnlyTextBox licenseNumberTextBox;
        private Labels.PrimaryLabel primaryLabel2;
        private Controls.TextBoxes.ReadOnlyTextBox residenseTextBox;
        private Labels.PrimaryLabel primaryLabel3;
        private Controls.TextBoxes.ReadOnlyTextBox categoryNames;
        private CommonButton buttonApprove;
        private CommonButton buttonReject;
    }
}
