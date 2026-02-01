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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.buttonFines = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonTransports = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonDrivers = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonUsers = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonViolations = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonPayments = new TrafficLedger.Desktop.Components.CommonButton();
            this.buttonStatistics = new TrafficLedger.Desktop.Components.CommonButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanelMain);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.buttonDrivers, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.buttonUsers, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonTransports, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.buttonFines, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.buttonPayments, 0, 4);
            this.tableLayoutPanelMain.Controls.Add(this.buttonViolations, 0, 5);
            this.tableLayoutPanelMain.Controls.Add(this.buttonStatistics, 0, 6);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 7;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonFines
            // 
            this.buttonFines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonFines.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonFines.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFines.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonFines.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonFines.Location = new System.Drawing.Point(188, 226);
            this.buttonFines.Name = "buttonFines";
            this.buttonFines.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonFines.Size = new System.Drawing.Size(327, 44);
            this.buttonFines.TabIndex = 3;
            this.buttonFines.Text = "Данные штрафов";
            this.buttonFines.UseVisualStyleBackColor = false;
            this.buttonFines.Click += new System.EventHandler(this.buttonFines_Click);
            // 
            // buttonTransports
            // 
            this.buttonTransports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTransports.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonTransports.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonTransports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransports.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonTransports.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonTransports.Location = new System.Drawing.Point(188, 155);
            this.buttonTransports.Name = "buttonTransports";
            this.buttonTransports.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonTransports.Size = new System.Drawing.Size(327, 44);
            this.buttonTransports.TabIndex = 2;
            this.buttonTransports.Text = "Данные автомобилей";
            this.buttonTransports.UseVisualStyleBackColor = false;
            this.buttonTransports.Click += new System.EventHandler(this.buttonTransports_Click);
            // 
            // buttonDrivers
            // 
            this.buttonDrivers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDrivers.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonDrivers.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrivers.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonDrivers.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonDrivers.Location = new System.Drawing.Point(188, 84);
            this.buttonDrivers.Name = "buttonDrivers";
            this.buttonDrivers.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonDrivers.Size = new System.Drawing.Size(327, 45);
            this.buttonDrivers.TabIndex = 1;
            this.buttonDrivers.Text = "Данные водителей";
            this.buttonDrivers.UseVisualStyleBackColor = false;
            this.buttonDrivers.Click += new System.EventHandler(this.buttonDrivers_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonUsers.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonUsers.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonUsers.Location = new System.Drawing.Point(188, 13);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonUsers.Size = new System.Drawing.Size(327, 44);
            this.buttonUsers.TabIndex = 6;
            this.buttonUsers.Text = "Данные пользователей";
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonViolations
            // 
            this.buttonViolations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonViolations.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonViolations.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonViolations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViolations.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonViolations.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonViolations.Location = new System.Drawing.Point(188, 368);
            this.buttonViolations.Name = "buttonViolations";
            this.buttonViolations.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonViolations.Size = new System.Drawing.Size(327, 44);
            this.buttonViolations.TabIndex = 5;
            this.buttonViolations.Text = "Кодекс нарушений";
            this.buttonViolations.UseVisualStyleBackColor = false;
            this.buttonViolations.Click += new System.EventHandler(this.buttonViolations_Click);
            // 
            // buttonPayments
            // 
            this.buttonPayments.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonPayments.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonPayments.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPayments.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonPayments.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonPayments.Location = new System.Drawing.Point(188, 297);
            this.buttonPayments.Name = "buttonPayments";
            this.buttonPayments.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonPayments.Size = new System.Drawing.Size(327, 44);
            this.buttonPayments.TabIndex = 7;
            this.buttonPayments.Text = "Данные чеков";
            this.buttonPayments.UseVisualStyleBackColor = false;
            this.buttonPayments.Click += new System.EventHandler(this.buttonPayments_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStatistics.BackColor = System.Drawing.Color.BlueViolet;
            this.buttonStatistics.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonStatistics.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.buttonStatistics.Location = new System.Drawing.Point(188, 441);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonStatistics.Size = new System.Drawing.Size(327, 44);
            this.buttonStatistics.TabIndex = 8;
            this.buttonStatistics.Text = "Просмотр отчётов";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AdminView";
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.CommonButton buttonDrivers;
        private Components.CommonButton buttonFines;
        private Components.CommonButton buttonTransports;
        private Components.CommonButton buttonUsers;
        private Components.CommonButton buttonViolations;
        private Components.CommonButton buttonPayments;
        private Components.CommonButton buttonStatistics;
    }
}
