using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Violations
{
    partial class ViolationView
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
            buttonAdd = new CommonButton();
            buttonList = new CommonButton();
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
            tableLayoutPanelMain.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanelMain.Controls.Add(buttonList, 0, 1);
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
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom;
            buttonAdd.BackColor = Color.BlueViolet;
            buttonAdd.FlatAppearance.BorderColor = Color.DarkGray;
            buttonAdd.FlatStyle = FlatStyle.Flat;
            buttonAdd.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonAdd.ForeColor = Color.AntiqueWhite;
            buttonAdd.Location = new Point(227, 243);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Padding = new Padding(9, 5, 9, 5);
            buttonAdd.Size = new Size(366, 42);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "Добавить новое нарушение";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonList
            // 
            buttonList.Anchor = AnchorStyles.Top;
            buttonList.BackColor = Color.BlueViolet;
            buttonList.FlatAppearance.BorderColor = Color.DarkGray;
            buttonList.FlatStyle = FlatStyle.Flat;
            buttonList.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            buttonList.ForeColor = Color.AntiqueWhite;
            buttonList.Location = new Point(226, 291);
            buttonList.Margin = new Padding(4, 3, 4, 3);
            buttonList.Name = "buttonList";
            buttonList.Padding = new Padding(9, 5, 9, 5);
            buttonList.Size = new Size(368, 42);
            buttonList.TabIndex = 2;
            buttonList.Text = "Список нарушений";
            buttonList.UseVisualStyleBackColor = false;
            buttonList.Click += buttonList_Click;
            // 
            // ViolationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "ViolationView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private CommonButton buttonAdd;
        private CommonButton buttonList;
    }
}
