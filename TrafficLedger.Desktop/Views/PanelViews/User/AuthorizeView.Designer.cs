using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    partial class AuthorizeView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            labelLogin = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxLogin = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelPassword = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxPassword = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            buttonLogin = new CommonButton();
            buttonRegister = new CommonButton();
            roleDebugButton = new CommonButton();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanel1);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00062F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00063F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.00063F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.99813F));
            tableLayoutPanel1.Controls.Add(labelLogin, 1, 1);
            tableLayoutPanel1.Controls.Add(textBoxLogin, 2, 1);
            tableLayoutPanel1.Controls.Add(labelPassword, 1, 2);
            tableLayoutPanel1.Controls.Add(textBoxPassword, 2, 2);
            tableLayoutPanel1.Controls.Add(buttonLogin, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonRegister, 1, 4);
            tableLayoutPanel1.Controls.Add(roleDebugButton, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.28571F));
            tableLayoutPanel1.Size = new Size(821, 576);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9.75F);
            labelLogin.ForeColor = Color.FromArgb(0, 0, 0);
            labelLogin.Location = new Point(360, 135);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(47, 17);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Логин:";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left;
            textBoxLogin.BackColor = Color.White;
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI", 9.75F);
            textBoxLogin.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxLogin.Location = new Point(413, 131);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(199, 25);
            textBoxLogin.TabIndex = 9;
            // 
            // labelPassword
            // 
            labelPassword.Anchor = AnchorStyles.Right;
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F);
            labelPassword.ForeColor = Color.FromArgb(0, 0, 0);
            labelPassword.Location = new Point(350, 231);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(57, 17);
            labelPassword.TabIndex = 8;
            labelPassword.Text = "Пароль:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Left;
            textBoxPassword.BackColor = Color.White;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 9.75F);
            textBoxPassword.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxPassword.Location = new Point(413, 227);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(199, 25);
            textBoxPassword.TabIndex = 10;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.BackColor = Color.BlueViolet;
            tableLayoutPanel1.SetColumnSpan(buttonLogin, 2);
            buttonLogin.FlatAppearance.BorderColor = Color.DarkGray;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.AntiqueWhite;
            buttonLogin.Location = new Point(211, 306);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Padding = new Padding(8, 4, 8, 4);
            buttonLogin.Size = new Size(398, 60);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Войти";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Anchor = AnchorStyles.Top;
            buttonRegister.BackColor = Color.BlueViolet;
            tableLayoutPanel1.SetColumnSpan(buttonRegister, 2);
            buttonRegister.FlatAppearance.BorderColor = Color.DarkGray;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.AntiqueWhite;
            buttonRegister.Location = new Point(228, 387);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Padding = new Padding(8, 4, 8, 4);
            buttonRegister.Size = new Size(363, 38);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Нет аккаунта? Зарегестируйтесь";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // roleDebugButton
            // 
            roleDebugButton.Anchor = AnchorStyles.Top;
            roleDebugButton.BackColor = Color.Red;
            tableLayoutPanel1.SetColumnSpan(roleDebugButton, 2);
            roleDebugButton.FlatAppearance.BorderColor = Color.DarkGray;
            roleDebugButton.FlatStyle = FlatStyle.Flat;
            roleDebugButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            roleDebugButton.ForeColor = Color.AntiqueWhite;
            roleDebugButton.Location = new Point(266, 483);
            roleDebugButton.Name = "roleDebugButton";
            roleDebugButton.Padding = new Padding(8, 4, 8, 4);
            roleDebugButton.Size = new Size(287, 35);
            roleDebugButton.TabIndex = 11;
            roleDebugButton.Text = "DEBUG: Сменить роль";
            roleDebugButton.UseVisualStyleBackColor = false;
            roleDebugButton.Click += roleDebugButton_Click;
            // 
            // AuthorizeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "AuthorizeView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Components.Labels.PrimaryLabel labelLogin;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxLogin;
        private Components.Labels.PrimaryLabel labelPassword;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxPassword;
        private CommonButton buttonLogin;
        private CommonButton buttonRegister;
        private CommonButton roleDebugButton;
    }
}
