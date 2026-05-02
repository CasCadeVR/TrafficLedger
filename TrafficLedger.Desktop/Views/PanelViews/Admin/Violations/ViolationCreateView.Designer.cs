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
            tableLayoutPanelMain = new TableLayoutPanel();
            textBoxDescription = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            buttonSave = new CommonButton();
            labelDescription = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelMaxFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            labelMinFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            numericUpDownMaxFinePrice = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            numericUpDownMinFinePrice = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            defaultRadioButton1 = new TrafficLedger.Desktop.Components.Controls.RadioButtons.DefaultRadioButton();
            labelFinePrice = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            numericUpDownFinePrice = new TrafficLedger.Desktop.Components.Controls.NumericUpDowns.DefaultNumericUpDown();
            radioEndPrice = new TrafficLedger.Desktop.Components.Controls.RadioButtons.DefaultRadioButton();
            labelName = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxName = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            textBoxCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxFinePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinFinePrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinePrice).BeginInit();
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
            tableLayoutPanelMain.Controls.Add(textBoxDescription, 1, 8);
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 10);
            tableLayoutPanelMain.Controls.Add(labelDescription, 0, 8);
            tableLayoutPanelMain.Controls.Add(labelMaxFinePrice, 0, 7);
            tableLayoutPanelMain.Controls.Add(labelMinFinePrice, 0, 6);
            tableLayoutPanelMain.Controls.Add(numericUpDownMaxFinePrice, 1, 7);
            tableLayoutPanelMain.Controls.Add(numericUpDownMinFinePrice, 1, 6);
            tableLayoutPanelMain.Controls.Add(defaultRadioButton1, 0, 5);
            tableLayoutPanelMain.Controls.Add(labelFinePrice, 0, 4);
            tableLayoutPanelMain.Controls.Add(numericUpDownFinePrice, 1, 4);
            tableLayoutPanelMain.Controls.Add(radioEndPrice, 0, 3);
            tableLayoutPanelMain.Controls.Add(labelName, 0, 2);
            tableLayoutPanelMain.Controls.Add(textBoxName, 1, 2);
            tableLayoutPanelMain.Controls.Add(labelCode, 0, 1);
            tableLayoutPanelMain.Controls.Add(textBoxCode, 1, 1);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 12;
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
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            textBoxDescription.BackColor = Color.White;
            textBoxDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Font = new Font("Segoe UI", 9.75F);
            textBoxDescription.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxDescription.Location = new Point(414, 387);
            textBoxDescription.Margin = new Padding(4, 3, 4, 3);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            tableLayoutPanelMain.SetRowSpan(textBoxDescription, 2);
            textBoxDescription.Size = new Size(403, 90);
            textBoxDescription.TabIndex = 16;
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
            buttonSave.Location = new Point(208, 483);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(404, 42);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // labelDescription
            // 
            labelDescription.Anchor = AnchorStyles.Right;
            labelDescription.AutoSize = true;
            labelDescription.Font = new Font("Segoe UI", 9.75F);
            labelDescription.ForeColor = Color.FromArgb(0, 0, 0);
            labelDescription.Location = new Point(333, 399);
            labelDescription.Margin = new Padding(4, 0, 4, 0);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(73, 17);
            labelDescription.TabIndex = 15;
            labelDescription.Text = "Описание: ";
            // 
            // labelMaxFinePrice
            // 
            labelMaxFinePrice.Anchor = AnchorStyles.Right;
            labelMaxFinePrice.AutoSize = true;
            labelMaxFinePrice.Enabled = false;
            labelMaxFinePrice.Font = new Font("Segoe UI", 9.75F);
            labelMaxFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            labelMaxFinePrice.Location = new Point(210, 351);
            labelMaxFinePrice.Margin = new Padding(4, 0, 4, 0);
            labelMaxFinePrice.Name = "labelMaxFinePrice";
            labelMaxFinePrice.Size = new Size(196, 17);
            labelMaxFinePrice.TabIndex = 24;
            labelMaxFinePrice.Text = "Максимальная сумма штрафа: ";
            // 
            // labelMinFinePrice
            // 
            labelMinFinePrice.Anchor = AnchorStyles.Right;
            labelMinFinePrice.AutoSize = true;
            labelMinFinePrice.Enabled = false;
            labelMinFinePrice.Font = new Font("Segoe UI", 9.75F);
            labelMinFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            labelMinFinePrice.Location = new Point(215, 303);
            labelMinFinePrice.Margin = new Padding(4, 0, 4, 0);
            labelMinFinePrice.Name = "labelMinFinePrice";
            labelMinFinePrice.Size = new Size(191, 17);
            labelMinFinePrice.TabIndex = 23;
            labelMinFinePrice.Text = "Минимальная сумма штрафа: ";
            // 
            // numericUpDownMaxFinePrice
            // 
            numericUpDownMaxFinePrice.Anchor = AnchorStyles.Left;
            numericUpDownMaxFinePrice.BackColor = Color.White;
            numericUpDownMaxFinePrice.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMaxFinePrice.Enabled = false;
            numericUpDownMaxFinePrice.Font = new Font("Segoe UI", 9.75F);
            numericUpDownMaxFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownMaxFinePrice.Location = new Point(414, 347);
            numericUpDownMaxFinePrice.Margin = new Padding(4, 3, 4, 3);
            numericUpDownMaxFinePrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMaxFinePrice.Name = "numericUpDownMaxFinePrice";
            numericUpDownMaxFinePrice.Size = new Size(287, 25);
            numericUpDownMaxFinePrice.TabIndex = 26;
            // 
            // numericUpDownMinFinePrice
            // 
            numericUpDownMinFinePrice.Anchor = AnchorStyles.Left;
            numericUpDownMinFinePrice.BackColor = Color.White;
            numericUpDownMinFinePrice.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownMinFinePrice.Enabled = false;
            numericUpDownMinFinePrice.Font = new Font("Segoe UI", 9.75F);
            numericUpDownMinFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownMinFinePrice.Location = new Point(414, 299);
            numericUpDownMinFinePrice.Margin = new Padding(4, 3, 4, 3);
            numericUpDownMinFinePrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownMinFinePrice.Name = "numericUpDownMinFinePrice";
            numericUpDownMinFinePrice.Size = new Size(287, 25);
            numericUpDownMinFinePrice.TabIndex = 25;
            // 
            // defaultRadioButton1
            // 
            defaultRadioButton1.Anchor = AnchorStyles.Right;
            defaultRadioButton1.AutoSize = true;
            defaultRadioButton1.BackColor = Color.White;
            defaultRadioButton1.Font = new Font("Segoe UI", 9.75F);
            defaultRadioButton1.ForeColor = Color.FromArgb(0, 0, 0);
            defaultRadioButton1.Location = new Point(323, 253);
            defaultRadioButton1.Name = "defaultRadioButton1";
            defaultRadioButton1.Size = new Size(84, 21);
            defaultRadioButton1.TabIndex = 22;
            defaultRadioButton1.Text = "Диапазон";
            defaultRadioButton1.UseVisualStyleBackColor = false;
            // 
            // labelFinePrice
            // 
            labelFinePrice.Anchor = AnchorStyles.Right;
            labelFinePrice.AutoSize = true;
            labelFinePrice.Font = new Font("Segoe UI", 9.75F);
            labelFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            labelFinePrice.Location = new Point(301, 207);
            labelFinePrice.Margin = new Padding(4, 0, 4, 0);
            labelFinePrice.Name = "labelFinePrice";
            labelFinePrice.Size = new Size(105, 17);
            labelFinePrice.TabIndex = 19;
            labelFinePrice.Text = "Сумма штрафа: ";
            // 
            // numericUpDownFinePrice
            // 
            numericUpDownFinePrice.Anchor = AnchorStyles.Left;
            numericUpDownFinePrice.BackColor = Color.White;
            numericUpDownFinePrice.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownFinePrice.Font = new Font("Segoe UI", 9.75F);
            numericUpDownFinePrice.ForeColor = Color.FromArgb(0, 0, 0);
            numericUpDownFinePrice.Location = new Point(414, 203);
            numericUpDownFinePrice.Margin = new Padding(4, 3, 4, 3);
            numericUpDownFinePrice.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            numericUpDownFinePrice.Name = "numericUpDownFinePrice";
            numericUpDownFinePrice.Size = new Size(287, 25);
            numericUpDownFinePrice.TabIndex = 20;
            // 
            // radioEndPrice
            // 
            radioEndPrice.Anchor = AnchorStyles.Right;
            radioEndPrice.AutoSize = true;
            radioEndPrice.BackColor = Color.White;
            radioEndPrice.Checked = true;
            radioEndPrice.Font = new Font("Segoe UI", 9.75F);
            radioEndPrice.ForeColor = Color.FromArgb(0, 0, 0);
            radioEndPrice.Location = new Point(282, 157);
            radioEndPrice.Name = "radioEndPrice";
            radioEndPrice.Size = new Size(125, 21);
            radioEndPrice.TabIndex = 21;
            radioEndPrice.TabStop = true;
            radioEndPrice.Text = "Конечная сумма";
            radioEndPrice.UseVisualStyleBackColor = false;
            radioEndPrice.CheckedChanged += radioEndPrice_CheckedChanged;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Right;
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 9.75F);
            labelName.ForeColor = Color.FromArgb(0, 0, 0);
            labelName.Location = new Point(302, 111);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(104, 17);
            labelName.TabIndex = 13;
            labelName.Text = "Наименование: ";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = AnchorStyles.Left;
            textBoxName.BackColor = Color.White;
            textBoxName.BorderStyle = BorderStyle.FixedSingle;
            textBoxName.Font = new Font("Segoe UI", 9.75F);
            textBoxName.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxName.Location = new Point(414, 107);
            textBoxName.Margin = new Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(287, 25);
            textBoxName.TabIndex = 14;
            // 
            // labelCode
            // 
            labelCode.Anchor = AnchorStyles.Right;
            labelCode.AutoSize = true;
            labelCode.Font = new Font("Segoe UI", 9.75F);
            labelCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelCode.Location = new Point(297, 63);
            labelCode.Margin = new Padding(4, 0, 4, 0);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(109, 17);
            labelCode.TabIndex = 6;
            labelCode.Text = "Код нарушения: ";
            // 
            // textBoxCode
            // 
            textBoxCode.Anchor = AnchorStyles.Left;
            textBoxCode.BackColor = Color.White;
            textBoxCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxCode.Font = new Font("Segoe UI", 9.75F);
            textBoxCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxCode.Location = new Point(414, 59);
            textBoxCode.Margin = new Padding(4, 3, 4, 3);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(287, 25);
            textBoxCode.TabIndex = 10;
            // 
            // ViolationCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "ViolationCreateView";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMaxFinePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinFinePrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFinePrice).EndInit();
            ResumeLayout(false);

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
        private Components.Controls.RadioButtons.DefaultRadioButton radioEndPrice;
        private Components.Controls.RadioButtons.DefaultRadioButton defaultRadioButton1;
        private Components.Labels.PrimaryLabel labelMinFinePrice;
        private Components.Labels.PrimaryLabel labelMaxFinePrice;
        private Components.Controls.NumericUpDowns.DefaultNumericUpDown numericUpDownMinFinePrice;
        private Components.Controls.NumericUpDowns.DefaultNumericUpDown numericUpDownMaxFinePrice;
    }
}
