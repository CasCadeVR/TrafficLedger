using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Users
{
    partial class UserCreateView
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
            tableLayoutPanelMain = new TableLayoutPanel();
            buttonSave = new CommonButton();
            labelLogin = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxLogin = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            labelFullName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            comboBoxRole = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(tableLayoutPanelMain);
            // 
            // tableLayoutPanelMain
            // 
            tableLayoutPanelMain.ColumnCount = 2;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Controls.Add(labelLogin, 0, 1);
            tableLayoutPanelMain.Controls.Add(labelFullName, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxLogin, 1, 1);
            tableLayoutPanelMain.Controls.Add(comboBoxRole, 1, 2);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 3);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 5;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.BackColor = Color.Green;
            tableLayoutPanelMain.SetColumnSpan(buttonSave, 2);
            buttonSave.FlatAppearance.BorderColor = Color.DarkGray;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonSave.ForeColor = Color.White;
            buttonSave.Location = new Point(208, 315);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 42);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 9.75F);
            labelLogin.ForeColor = Color.FromArgb(0, 0, 0);
            labelLogin.Location = new Point(355, 231);
            labelLogin.Margin = new Padding(4, 0, 4, 0);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(51, 17);
            labelLogin.TabIndex = 6;
            labelLogin.Text = "Логин: ";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left;
            textBoxLogin.BackColor = Color.GhostWhite;
            textBoxLogin.BorderStyle = BorderStyle.None;
            textBoxLogin.Font = new Font("Segoe UI", 9.75F);
            textBoxLogin.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxLogin.Location = new Point(414, 231);
            textBoxLogin.Margin = new Padding(4, 3, 4, 3);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.ReadOnly = true;
            textBoxLogin.Size = new Size(287, 18);
            textBoxLogin.TabIndex = 7;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = AnchorStyles.Right;
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 9.75F);
            labelFullName.ForeColor = Color.FromArgb(0, 0, 0);
            labelFullName.Location = new Point(362, 279);
            labelFullName.Margin = new Padding(4, 0, 4, 0);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(44, 17);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "Роль: ";
            // 
            // comboBoxRole
            // 
            comboBoxRole.Anchor = AnchorStyles.Left;
            comboBoxRole.BackColor = Color.White;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 9.75F);
            comboBoxRole.ForeColor = Color.FromArgb(0, 0, 0);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Location = new Point(414, 275);
            comboBoxRole.Margin = new Padding(4, 3, 4, 3);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(286, 25);
            comboBoxRole.TabIndex = 9;
            // 
            // UserCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "UserCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelFullName;
        private Components.Labels.PrimaryLabel labelLogin;
        private Components.Controls.TextBoxes.ReadOnlyTextBox textBoxLogin;
        private CommonButton buttonSave;
        private Components.Controls.TextBoxes.DefaultComboBox comboBoxRole;
    }
}
