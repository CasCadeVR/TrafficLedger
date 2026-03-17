using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Parkings.Sessions
{
    partial class ParkingSessionView
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
            buttonParkingZones = new CommonButton();
            buttonListUserSessions = new CommonButton();
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
            tableLayoutPanelMain.Controls.Add(buttonParkingZones, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonListUserSessions, 0, 1);
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
            // buttonParkingZones
            // 
            buttonParkingZones.Anchor = AnchorStyles.Bottom;
            buttonParkingZones.BackColor = Color.BlueViolet;
            buttonParkingZones.FlatAppearance.BorderColor = Color.DarkGray;
            buttonParkingZones.FlatStyle = FlatStyle.Flat;
            buttonParkingZones.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonParkingZones.ForeColor = Color.AntiqueWhite;
            buttonParkingZones.Location = new Point(227, 233);
            buttonParkingZones.Margin = new Padding(4, 3, 4, 3);
            buttonParkingZones.Name = "buttonParkingZones";
            buttonParkingZones.Padding = new Padding(9, 5, 9, 5);
            buttonParkingZones.Size = new Size(366, 52);
            buttonParkingZones.TabIndex = 0;
            buttonParkingZones.Text = "Начать парковочную сессию";
            buttonParkingZones.UseVisualStyleBackColor = false;
            buttonParkingZones.Click += buttonParkingZones_Click;
            // 
            // buttonListUserSessions
            // 
            buttonListUserSessions.Anchor = AnchorStyles.Top;
            buttonListUserSessions.BackColor = Color.BlueViolet;
            buttonListUserSessions.FlatAppearance.BorderColor = Color.DarkGray;
            buttonListUserSessions.FlatStyle = FlatStyle.Flat;
            buttonListUserSessions.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonListUserSessions.ForeColor = Color.AntiqueWhite;
            buttonListUserSessions.Location = new Point(226, 291);
            buttonListUserSessions.Margin = new Padding(4, 3, 4, 3);
            buttonListUserSessions.Name = "buttonListUserSessions";
            buttonListUserSessions.Padding = new Padding(9, 5, 9, 5);
            buttonListUserSessions.Size = new Size(368, 52);
            buttonListUserSessions.TabIndex = 2;
            buttonListUserSessions.Text = "Текущие сессии";
            buttonListUserSessions.UseVisualStyleBackColor = false;
            buttonListUserSessions.Click += buttonListUserSessions_Click;
            // 
            // ParkingView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "ParkingView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonParkingZones;
        private CommonButton buttonListUserSessions;
    }
}
