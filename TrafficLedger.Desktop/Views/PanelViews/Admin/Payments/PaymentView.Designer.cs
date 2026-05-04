using TrafficLedger.Desktop.Components;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Requests
{
    partial class PaymentView
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
            buttonPaymentsFines = new CommonButton();
            buttonPaymentsParkingSessions = new CommonButton();
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
            tableLayoutPanelMain.Controls.Add(buttonPaymentsFines, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonPaymentsParkingSessions, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // buttonPaymentsFines
            // 
            buttonPaymentsFines.Anchor = AnchorStyles.Bottom;
            buttonPaymentsFines.BackColor = Color.BlueViolet;
            buttonPaymentsFines.FlatAppearance.BorderColor = Color.DarkGray;
            buttonPaymentsFines.FlatStyle = FlatStyle.Flat;
            buttonPaymentsFines.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonPaymentsFines.ForeColor = Color.AntiqueWhite;
            buttonPaymentsFines.Location = new Point(219, 243);
            buttonPaymentsFines.Margin = new Padding(4, 3, 4, 3);
            buttonPaymentsFines.Name = "buttonPaymentsFines";
            buttonPaymentsFines.Padding = new Padding(9, 5, 9, 5);
            buttonPaymentsFines.Size = new Size(382, 42);
            buttonPaymentsFines.TabIndex = 7;
            buttonPaymentsFines.Text = "Данные чеков штрафов";
            buttonPaymentsFines.UseVisualStyleBackColor = false;
            buttonPaymentsFines.Click += buttonPaymentsFines_Click;
            // 
            // buttonPaymentsParkingSessions
            // 
            buttonPaymentsParkingSessions.Anchor = AnchorStyles.Top;
            buttonPaymentsParkingSessions.BackColor = Color.BlueViolet;
            buttonPaymentsParkingSessions.FlatAppearance.BorderColor = Color.DarkGray;
            buttonPaymentsParkingSessions.FlatStyle = FlatStyle.Flat;
            buttonPaymentsParkingSessions.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonPaymentsParkingSessions.ForeColor = Color.AntiqueWhite;
            buttonPaymentsParkingSessions.Location = new Point(219, 291);
            buttonPaymentsParkingSessions.Margin = new Padding(4, 3, 4, 3);
            buttonPaymentsParkingSessions.Name = "buttonPaymentsParkingSessions";
            buttonPaymentsParkingSessions.Padding = new Padding(9, 5, 9, 5);
            buttonPaymentsParkingSessions.Size = new Size(382, 42);
            buttonPaymentsParkingSessions.TabIndex = 8;
            buttonPaymentsParkingSessions.Text = "Данные чеков парковок";
            buttonPaymentsParkingSessions.UseVisualStyleBackColor = false;
            buttonPaymentsParkingSessions.Click += buttonPaymentsParkingSessions_Click;
            // 
            // PaymentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "PaymentView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonPaymentsFines;
        private CommonButton buttonPaymentsParkingSessions;
    }
}
