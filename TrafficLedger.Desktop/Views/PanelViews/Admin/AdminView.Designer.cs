using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    partial class AdminView
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
            buttonParkings = new CommonButton();
            buttonDrivers = new CommonButton();
            buttonUsers = new CommonButton();
            buttonTransports = new CommonButton();
            buttonFines = new CommonButton();
            buttonPayments = new CommonButton();
            buttonViolations = new CommonButton();
            buttonStatistics = new CommonButton();
            buttonRequests = new CommonButton();
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
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.Controls.Add(buttonStatistics, 0, 9);
            tableLayoutPanelMain.Controls.Add(buttonRequests, 0, 8);
            tableLayoutPanelMain.Controls.Add(buttonParkings, 0, 7);
            tableLayoutPanelMain.Controls.Add(buttonViolations, 0, 6);
            tableLayoutPanelMain.Controls.Add(buttonPayments, 0, 5);
            tableLayoutPanelMain.Controls.Add(buttonFines, 0, 4);
            tableLayoutPanelMain.Controls.Add(buttonTransports, 0, 3);
            tableLayoutPanelMain.Controls.Add(buttonDrivers, 0, 2);
            tableLayoutPanelMain.Controls.Add(buttonUsers, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 11;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonParkings
            // 
            buttonParkings.Anchor = AnchorStyles.None;
            buttonParkings.BackColor = Color.BlueViolet;
            buttonParkings.FlatAppearance.BorderColor = Color.DarkGray;
            buttonParkings.FlatStyle = FlatStyle.Flat;
            buttonParkings.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonParkings.ForeColor = Color.AntiqueWhite;
            buttonParkings.Location = new Point(219, 363);
            buttonParkings.Margin = new Padding(4, 3, 4, 3);
            buttonParkings.Name = "buttonParkings";
            buttonParkings.Padding = new Padding(9, 5, 9, 5);
            buttonParkings.Size = new Size(382, 42);
            buttonParkings.TabIndex = 10;
            buttonParkings.Text = "Данные парковок";
            buttonParkings.UseVisualStyleBackColor = false;
            buttonParkings.Click += buttonParkings_Click;
            // 
            // buttonDrivers
            // 
            buttonDrivers.Anchor = AnchorStyles.None;
            buttonDrivers.BackColor = Color.BlueViolet;
            buttonDrivers.FlatAppearance.BorderColor = Color.DarkGray;
            buttonDrivers.FlatStyle = FlatStyle.Flat;
            buttonDrivers.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonDrivers.ForeColor = Color.AntiqueWhite;
            buttonDrivers.Location = new Point(219, 123);
            buttonDrivers.Margin = new Padding(4, 3, 4, 3);
            buttonDrivers.Name = "buttonDrivers";
            buttonDrivers.Padding = new Padding(9, 5, 9, 5);
            buttonDrivers.Size = new Size(382, 42);
            buttonDrivers.TabIndex = 1;
            buttonDrivers.Text = "Данные водителей";
            buttonDrivers.UseVisualStyleBackColor = false;
            buttonDrivers.Click += buttonDrivers_Click;
            // 
            // buttonUsers
            // 
            buttonUsers.Anchor = AnchorStyles.None;
            buttonUsers.BackColor = Color.BlueViolet;
            buttonUsers.FlatAppearance.BorderColor = Color.DarkGray;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonUsers.ForeColor = Color.AntiqueWhite;
            buttonUsers.Location = new Point(219, 75);
            buttonUsers.Margin = new Padding(4, 3, 4, 3);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Padding = new Padding(9, 5, 9, 5);
            buttonUsers.Size = new Size(382, 42);
            buttonUsers.TabIndex = 6;
            buttonUsers.Text = "Данные пользователей";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // buttonTransports
            // 
            buttonTransports.Anchor = AnchorStyles.None;
            buttonTransports.BackColor = Color.BlueViolet;
            buttonTransports.FlatAppearance.BorderColor = Color.DarkGray;
            buttonTransports.FlatStyle = FlatStyle.Flat;
            buttonTransports.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonTransports.ForeColor = Color.AntiqueWhite;
            buttonTransports.Location = new Point(219, 171);
            buttonTransports.Margin = new Padding(4, 3, 4, 3);
            buttonTransports.Name = "buttonTransports";
            buttonTransports.Padding = new Padding(9, 5, 9, 5);
            buttonTransports.Size = new Size(382, 42);
            buttonTransports.TabIndex = 2;
            buttonTransports.Text = "Данные автомобилей";
            buttonTransports.UseVisualStyleBackColor = false;
            buttonTransports.Click += buttonTransports_Click;
            // 
            // buttonFines
            // 
            buttonFines.Anchor = AnchorStyles.None;
            buttonFines.BackColor = Color.BlueViolet;
            buttonFines.FlatAppearance.BorderColor = Color.DarkGray;
            buttonFines.FlatStyle = FlatStyle.Flat;
            buttonFines.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonFines.ForeColor = Color.AntiqueWhite;
            buttonFines.Location = new Point(219, 219);
            buttonFines.Margin = new Padding(4, 3, 4, 3);
            buttonFines.Name = "buttonFines";
            buttonFines.Padding = new Padding(9, 5, 9, 5);
            buttonFines.Size = new Size(382, 42);
            buttonFines.TabIndex = 3;
            buttonFines.Text = "Данные штрафов";
            buttonFines.UseVisualStyleBackColor = false;
            buttonFines.Click += buttonFines_Click;
            // 
            // buttonPayments
            // 
            buttonPayments.Anchor = AnchorStyles.None;
            buttonPayments.BackColor = Color.BlueViolet;
            buttonPayments.FlatAppearance.BorderColor = Color.DarkGray;
            buttonPayments.FlatStyle = FlatStyle.Flat;
            buttonPayments.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonPayments.ForeColor = Color.AntiqueWhite;
            buttonPayments.Location = new Point(219, 267);
            buttonPayments.Margin = new Padding(4, 3, 4, 3);
            buttonPayments.Name = "buttonPayments";
            buttonPayments.Padding = new Padding(9, 5, 9, 5);
            buttonPayments.Size = new Size(382, 42);
            buttonPayments.TabIndex = 7;
            buttonPayments.Text = "Данные чеков";
            buttonPayments.UseVisualStyleBackColor = false;
            buttonPayments.Click += buttonPayments_Click;
            // 
            // buttonViolations
            // 
            buttonViolations.Anchor = AnchorStyles.None;
            buttonViolations.BackColor = Color.BlueViolet;
            buttonViolations.FlatAppearance.BorderColor = Color.DarkGray;
            buttonViolations.FlatStyle = FlatStyle.Flat;
            buttonViolations.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonViolations.ForeColor = Color.AntiqueWhite;
            buttonViolations.Location = new Point(219, 315);
            buttonViolations.Margin = new Padding(4, 3, 4, 3);
            buttonViolations.Name = "buttonViolations";
            buttonViolations.Padding = new Padding(9, 5, 9, 5);
            buttonViolations.Size = new Size(382, 42);
            buttonViolations.TabIndex = 5;
            buttonViolations.Text = "Кодекс нарушений";
            buttonViolations.UseVisualStyleBackColor = false;
            buttonViolations.Click += buttonViolations_Click;
            // 
            // buttonStatistics
            // 
            buttonStatistics.Anchor = AnchorStyles.None;
            buttonStatistics.BackColor = Color.BlueViolet;
            buttonStatistics.FlatAppearance.BorderColor = Color.DarkGray;
            buttonStatistics.FlatStyle = FlatStyle.Flat;
            buttonStatistics.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonStatistics.ForeColor = Color.AntiqueWhite;
            buttonStatistics.Location = new Point(219, 459);
            buttonStatistics.Margin = new Padding(4, 3, 4, 3);
            buttonStatistics.Name = "buttonStatistics";
            buttonStatistics.Padding = new Padding(9, 5, 9, 5);
            buttonStatistics.Size = new Size(382, 42);
            buttonStatistics.TabIndex = 8;
            buttonStatistics.Text = "Просмотр статистики";
            buttonStatistics.UseVisualStyleBackColor = false;
            buttonStatistics.Click += buttonStatistics_Click;
            // 
            // buttonRequests
            // 
            buttonRequests.Anchor = AnchorStyles.None;
            buttonRequests.BackColor = Color.BlueViolet;
            buttonRequests.FlatAppearance.BorderColor = Color.DarkGray;
            buttonRequests.FlatStyle = FlatStyle.Flat;
            buttonRequests.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonRequests.ForeColor = Color.AntiqueWhite;
            buttonRequests.Location = new Point(219, 411);
            buttonRequests.Margin = new Padding(4, 3, 4, 3);
            buttonRequests.Name = "buttonRequests";
            buttonRequests.Padding = new Padding(9, 5, 9, 5);
            buttonRequests.Size = new Size(382, 42);
            buttonRequests.TabIndex = 9;
            buttonRequests.Text = "Просмотр заявок";
            buttonRequests.UseVisualStyleBackColor = false;
            buttonRequests.Click += buttonRequests_Click;
            // 
            // AdminView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "AdminView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonDrivers;
        private CommonButton buttonFines;
        private CommonButton buttonTransports;
        private CommonButton buttonUsers;
        private CommonButton buttonViolations;
        private CommonButton buttonPayments;
        private CommonButton buttonStatistics;
        private CommonButton buttonRequests;
        private CommonButton buttonParkings;
    }
}
