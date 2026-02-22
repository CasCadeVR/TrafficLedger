using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Violations
{
    partial class ViolationCreateView
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
            this.textBoxName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.buttonSave = new TrafficLedger.Desktop.Components.CommonButton();
            this.textBoxCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            this.labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.labelFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            this.numericUpDownFinePrice = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            this.textBoxDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinePrice)).BeginInit();
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
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelCode, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.buttonSave, 0, 9);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxCode, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.labelDescription, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelFinePrice, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.numericUpDownFinePrice, 1, 2);
            this.tableLayoutPanelMain.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 10;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.9991F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0021F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(704, 500);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxName.Location = new System.Drawing.Point(355, 61);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(246, 25);
            this.textBoxName.TabIndex = 14;
            // 
            // labelCode
            // 
            this.labelCode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelCode.AutoSize = true;
            this.labelCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelCode.Location = new System.Drawing.Point(240, 16);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(109, 17);
            this.labelCode.TabIndex = 6;
            this.labelCode.Text = "Код нарушения: ";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSave.BackColor = System.Drawing.Color.Green;
            this.tableLayoutPanelMain.SetColumnSpan(this.buttonSave, 2);
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(179, 450);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Padding = new System.Windows.Forms.Padding(8, 4, 8, 4);
            this.buttonSave.Size = new System.Drawing.Size(346, 43);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCode.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxCode.Location = new System.Drawing.Point(355, 12);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(246, 25);
            this.textBoxCode.TabIndex = 10;
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelName.Location = new System.Drawing.Point(245, 65);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 17);
            this.labelName.TabIndex = 13;
            this.labelName.Text = "Наименование: ";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelDescription.Location = new System.Drawing.Point(276, 163);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(73, 17);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Описание: ";
            // 
            // labelFinePrice
            // 
            this.labelFinePrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFinePrice.AutoSize = true;
            this.labelFinePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelFinePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelFinePrice.Location = new System.Drawing.Point(244, 114);
            this.labelFinePrice.Name = "labelFinePrice";
            this.labelFinePrice.Size = new System.Drawing.Size(105, 17);
            this.labelFinePrice.TabIndex = 19;
            this.labelFinePrice.Text = "Сумма штрафа: ";
            // 
            // numericUpDownFinePrice
            // 
            this.numericUpDownFinePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numericUpDownFinePrice.BackColor = System.Drawing.Color.White;
            this.numericUpDownFinePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownFinePrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.numericUpDownFinePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numericUpDownFinePrice.Location = new System.Drawing.Point(355, 110);
            this.numericUpDownFinePrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownFinePrice.Name = "numericUpDownFinePrice";
            this.numericUpDownFinePrice.Size = new System.Drawing.Size(246, 25);
            this.numericUpDownFinePrice.TabIndex = 20;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BackColor = System.Drawing.Color.White;
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBoxDescription.Location = new System.Drawing.Point(355, 150);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.tableLayoutPanelMain.SetRowSpan(this.textBoxDescription, 3);
            this.textBoxDescription.Size = new System.Drawing.Size(346, 141);
            this.textBoxDescription.TabIndex = 16;
            // 
            // ViolationCreateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ViolationCreateView";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFinePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel labelCode;
        private CommonButton buttonSave;
        private Components.Labels.PrimaryLabel labelName;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxCode;
        private Components.Labels.PrimaryLabel labelDescription;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxName;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxDescription;
        private Components.Labels.PrimaryLabel labelFinePrice;
        private Components.Controls.NumericUpDowns.DefaultNumericUpDown numericUpDownFinePrice;
    }
}
