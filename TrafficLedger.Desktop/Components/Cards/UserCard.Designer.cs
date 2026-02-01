namespace TrafficLedger.Desktop.Components.Cards
{
    partial class UserCard
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
            this.labelLoginTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelRoleTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.login = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.role = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            this.buttonEdit = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonDeleteUser = new TrafficLedger.Desktop.Components.CommonButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
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
            this.tableLayoutPanel1.Controls.Add(this.labelLoginTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRoleTitle, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.login, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.role, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonEdit, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDeleteUser, 4, 3);
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
            // labelLoginTitle
            // 
            this.labelLoginTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelLoginTitle.AutoSize = true;
            this.labelLoginTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelLoginTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelLoginTitle.Location = new System.Drawing.Point(57, 16);
            this.labelLoginTitle.Name = "labelLoginTitle";
            this.labelLoginTitle.Size = new System.Drawing.Size(51, 17);
            this.labelLoginTitle.TabIndex = 8;
            this.labelLoginTitle.Text = "Логин: ";
            // 
            // labelRoleTitle
            // 
            this.labelRoleTitle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelRoleTitle.AutoSize = true;
            this.labelRoleTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelRoleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelRoleTitle.Location = new System.Drawing.Point(64, 65);
            this.labelRoleTitle.Name = "labelRoleTitle";
            this.labelRoleTitle.Size = new System.Drawing.Size(44, 17);
            this.labelRoleTitle.TabIndex = 9;
            this.labelRoleTitle.Text = "Роль: ";
            // 
            // login
            // 
            this.login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.login.BackColor = System.Drawing.Color.GhostWhite;
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.login, 2);
            this.login.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login.Location = new System.Drawing.Point(114, 13);
            this.login.Name = "login";
            this.login.ReadOnly = true;
            this.login.Size = new System.Drawing.Size(100, 16);
            this.login.TabIndex = 10;
            this.login.Text = "Загрузка...";
            // 
            // role
            // 
            this.role.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.role.BackColor = System.Drawing.Color.GhostWhite;
            this.role.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.role, 2);
            this.role.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.role.Location = new System.Drawing.Point(114, 62);
            this.role.Name = "role";
            this.role.ReadOnly = true;
            this.role.Size = new System.Drawing.Size(100, 16);
            this.role.TabIndex = 11;
            this.role.Text = "Загрузка...";
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
            this.buttonEdit.Text = "Поменять роль";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UserCard";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolTip toolTip;
        private Labels.PrimaryLabel labelLoginTitle;
        private Labels.PrimaryLabel labelRoleTitle;
        private Controls.TextBoxes.ReadOnlyTextBox login;
        private Controls.TextBoxes.ReadOnlyTextBox role;
        private CommonButton buttonEdit;
        private CommonButton buttonDeleteUser;
    }
}
