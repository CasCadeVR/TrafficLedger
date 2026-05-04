using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Transports
{
    partial class TransportUserView
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
            buttonAddTransport = new CommonButton();
            buttonListTransport = new CommonButton();
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
            tableLayoutPanelMain.Controls.Add(buttonAddTransport, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonListTransport, 0, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 2;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 1;
            // 
            // buttonAddTransport
            // 
            buttonAddTransport.Anchor = AnchorStyles.Bottom;
            buttonAddTransport.BackColor = Color.BlueViolet;
            buttonAddTransport.FlatAppearance.BorderColor = Color.DarkGray;
            buttonAddTransport.FlatStyle = FlatStyle.Flat;
            buttonAddTransport.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonAddTransport.ForeColor = Color.AntiqueWhite;
            buttonAddTransport.Location = new Point(227, 243);
            buttonAddTransport.Margin = new Padding(4, 3, 4, 3);
            buttonAddTransport.Name = "buttonAddTransport";
            buttonAddTransport.Padding = new Padding(9, 5, 9, 5);
            buttonAddTransport.Size = new Size(366, 42);
            buttonAddTransport.TabIndex = 0;
            buttonAddTransport.Text = "Привязать транспорт";
            buttonAddTransport.UseVisualStyleBackColor = false;
            buttonAddTransport.Click += buttonAddTransport_Click;
            // 
            // buttonListTransport
            // 
            buttonListTransport.Anchor = AnchorStyles.Top;
            buttonListTransport.BackColor = Color.BlueViolet;
            buttonListTransport.FlatAppearance.BorderColor = Color.DarkGray;
            buttonListTransport.FlatStyle = FlatStyle.Flat;
            buttonListTransport.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonListTransport.ForeColor = Color.AntiqueWhite;
            buttonListTransport.Location = new Point(226, 291);
            buttonListTransport.Margin = new Padding(4, 3, 4, 3);
            buttonListTransport.Name = "buttonListTransport";
            buttonListTransport.Padding = new Padding(9, 5, 9, 5);
            buttonListTransport.Size = new Size(368, 42);
            buttonListTransport.TabIndex = 2;
            buttonListTransport.Text = "Список транспортов";
            buttonListTransport.UseVisualStyleBackColor = false;
            buttonListTransport.Click += buttonListTransport_Click;
            // 
            // TransportUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "TransportUserView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonAddTransport;
        private CommonButton buttonListTransport;
    }
}
