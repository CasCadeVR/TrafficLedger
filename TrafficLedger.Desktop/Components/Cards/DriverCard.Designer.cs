using System.Windows.Forms;
using TrafficLedger.Desktop.Components;

namespace TrafficLedger.Desktop.Components.Cards
{
    partial class DriverCard
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
            this.labelFullNameTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelBirthDateTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.fullName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.birthDate = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonDeleteUser = new TrafficLedger.Desktop.Components.CommonButton();
            this.labelBirthPlaceTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelUniqueIdTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.birthPlace = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.uniqueId = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonEdit = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonConnectTransport = new TrafficLedger.Desktop.Components.CommonButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonConnectDriverLicense = new TrafficLedger.Desktop.Components.CommonButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28653F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.2851F));
            this.tableLayoutPanel1.Controls.Add(this.labelFullNameTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelBirthDateTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fullName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.birthDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteUser, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBirthPlaceTitle, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelUniqueIdTitle, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.birthPlace, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.uniqueId, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonConnectTransport, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonConnectDriverLicense, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(666, 196);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelFullNameTitle
            // 
            this.labelFullNameTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFullNameTitle.AutoSize = true;
            this.labelFullNameTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFullNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFullNameTitle.Location = new System.Drawing.Point(64, 16);
            this.labelFullNameTitle.Name = "labelFullNameTitle";
            this.labelFullNameTitle.Size = new System.Drawing.Size(44, 17);
            this.labelFullNameTitle.TabIndex = 8;
            this.labelFullNameTitle.Text = "ФИО: ";
            // 
            // labelBirthDateTitle
            // 
            this.labelBirthDateTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBirthDateTitle.AutoSize = true;
            this.labelBirthDateTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelBirthDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBirthDateTitle.Location = new System.Drawing.Point(5, 65);
            this.labelBirthDateTitle.Name = "labelBirthDateTitle";
            this.labelBirthDateTitle.Size = new System.Drawing.Size(103, 17);
            this.labelBirthDateTitle.TabIndex = 9;
            this.labelBirthDateTitle.Text = "Дата рождения: ";
            // 
            // fullName
            // 
            this.fullName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.fullName.BackColor = System.Drawing.Color.GhostWhite;
            this.fullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.fullName, 2);
            this.fullName.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fullName.Location = new System.Drawing.Point(114, 16);
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            this.fullName.Size = new System.Drawing.Size(216, 16);
            this.fullName.TabIndex = 10;
            this.fullName.Text = "Загрузка...";
            // 
            // birthDate
            // 
            this.birthDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.birthDate.BackColor = System.Drawing.Color.GhostWhite;
            this.birthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.birthDate, 2);
            this.birthDate.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.birthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.birthDate.Location = new System.Drawing.Point(114, 65);
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            this.birthDate.Size = new System.Drawing.Size(216, 16);
            this.birthDate.TabIndex = 11;
            this.birthDate.Text = "Загрузка...";
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonDeleteUser, 2);
            this.buttonDeleteUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteUser.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDeleteUser.ForeColor = System.Drawing.Color.White;
            this.buttonDeleteUser.Location = new System.Drawing.Point(446, 150);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonDeleteUser.Size = new System.Drawing.Size(217, 43);
            this.buttonDeleteUser.TabIndex = 13;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = false;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // labelBirthPlaceTitle
            // 
            this.labelBirthPlaceTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelBirthPlaceTitle.AutoSize = true;
            this.labelBirthPlaceTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelBirthPlaceTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelBirthPlaceTitle.Location = new System.Drawing.Point(33, 105);
            this.labelBirthPlaceTitle.Name = "labelBirthPlaceTitle";
            this.labelBirthPlaceTitle.Size = new System.Drawing.Size(75, 34);
            this.labelBirthPlaceTitle.TabIndex = 14;
            this.labelBirthPlaceTitle.Text = "Место рождения: ";
            // 
            // labelUniqueIdTitle
            // 
            this.labelUniqueIdTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelUniqueIdTitle.AutoSize = true;
            this.labelUniqueIdTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelUniqueIdTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUniqueIdTitle.Location = new System.Drawing.Point(3, 154);
            this.labelUniqueIdTitle.Name = "labelUniqueIdTitle";
            this.labelUniqueIdTitle.Size = new System.Drawing.Size(105, 34);
            this.labelUniqueIdTitle.TabIndex = 15;
            this.labelUniqueIdTitle.Text = "Уникальный идентификатор: ";
            // 
            // birthPlace
            // 
            this.birthPlace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.birthPlace.BackColor = System.Drawing.Color.GhostWhite;
            this.birthPlace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.birthPlace, 2);
            this.birthPlace.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.birthPlace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.birthPlace.Location = new System.Drawing.Point(114, 114);
            this.birthPlace.Name = "birthPlace";
            this.birthPlace.ReadOnly = true;
            this.birthPlace.Size = new System.Drawing.Size(216, 16);
            this.birthPlace.TabIndex = 16;
            this.birthPlace.Text = "Загрузка...";
            // 
            // uniqueId
            // 
            this.uniqueId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uniqueId.BackColor = System.Drawing.Color.GhostWhite;
            this.uniqueId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.uniqueId, 2);
            this.uniqueId.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.uniqueId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uniqueId.Location = new System.Drawing.Point(114, 163);
            this.uniqueId.Name = "uniqueId";
            this.uniqueId.ReadOnly = true;
            this.uniqueId.Size = new System.Drawing.Size(216, 16);
            this.uniqueId.TabIndex = 17;
            this.uniqueId.Text = "Загрузка...";
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
            this.buttonEdit.Location = new System.Drawing.Point(446, 101);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonEdit.Size = new System.Drawing.Size(217, 43);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonConnectTransport
            // 
            this.buttonConnectTransport.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonConnectTransport, 2);
            this.buttonConnectTransport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConnectTransport.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConnectTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectTransport.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonConnectTransport.ForeColor = System.Drawing.Color.White;
            this.buttonConnectTransport.Location = new System.Drawing.Point(446, 52);
            this.buttonConnectTransport.Name = "buttonConnectTransport";
            this.buttonConnectTransport.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonConnectTransport.Size = new System.Drawing.Size(217, 43);
            this.buttonConnectTransport.TabIndex = 18;
            this.buttonConnectTransport.Text = "Привязка транспорта";
            this.buttonConnectTransport.UseVisualStyleBackColor = false;
            this.buttonConnectTransport.Click += new System.EventHandler(this.buttonConnectTransport_Click);
            // 
            // buttonConnectDriverLicense
            // 
            this.buttonConnectDriverLicense.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonConnectDriverLicense, 2);
            this.buttonConnectDriverLicense.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConnectDriverLicense.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonConnectDriverLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnectDriverLicense.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonConnectDriverLicense.ForeColor = System.Drawing.Color.White;
            this.buttonConnectDriverLicense.Location = new System.Drawing.Point(446, 3);
            this.buttonConnectDriverLicense.Name = "buttonConnectDriverLicense";
            this.buttonConnectDriverLicense.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonConnectDriverLicense.Size = new System.Drawing.Size(217, 43);
            this.buttonConnectDriverLicense.TabIndex = 19;
            this.buttonConnectDriverLicense.Text = "Удостоверение";
            this.buttonConnectDriverLicense.UseVisualStyleBackColor = false;
            this.buttonConnectDriverLicense.Click += new System.EventHandler(this.buttonConnectDriverLicense_Click);
            // 
            // DriverCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DriverCard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelFullNameTitle;
        private Labels.PrimaryLabel labelBirthDateTitle;
        private Controls.TextBoxes.ReadOnlyTextBox fullName;
        private Controls.TextBoxes.ReadOnlyTextBox birthDate;
        private CommonButton buttonEdit;
        private CommonButton buttonDeleteUser;
        private Labels.PrimaryLabel labelBirthPlaceTitle;
        private Labels.PrimaryLabel labelUniqueIdTitle;
        private Controls.TextBoxes.ReadOnlyTextBox birthPlace;
        private Controls.TextBoxes.ReadOnlyTextBox uniqueId;
        private CommonButton buttonConnectTransport;
        private CommonButton buttonConnectDriverLicense;
    }
}
