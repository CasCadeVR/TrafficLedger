using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews.Admin.Drivers
{
    partial class OwnershipCreateView
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
            labelTransportCode = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            buttonSave = new CommonButton();
            textBoxTransportCode = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            labelDateTitle = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            dateTimePickerDate = new TrafficLedger.Desktop.Components.Controls.DateTimePickers.DefaultDateTimePicker();
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
            tableLayoutPanelMain.Controls.Add(buttonSave, 0, 6);
            tableLayoutPanelMain.Controls.Add(labelDateTitle, 0, 5);
            tableLayoutPanelMain.Controls.Add(dateTimePickerDate, 1, 5);
            tableLayoutPanelMain.Controls.Add(labelTransportCode, 0, 4);
            tableLayoutPanelMain.Controls.Add(textBoxTransportCode, 1, 4);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 10;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 49.9925F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0075F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelTransportCode
            // 
            labelTransportCode.Anchor = AnchorStyles.Right;
            labelTransportCode.AutoSize = true;
            labelTransportCode.Font = new Font("Segoe UI", 9.75F);
            labelTransportCode.ForeColor = Color.FromArgb(0, 0, 0);
            labelTransportCode.Location = new Point(292, 254);
            labelTransportCode.Margin = new Padding(4, 0, 4, 0);
            labelTransportCode.Name = "labelTransportCode";
            labelTransportCode.Size = new Size(114, 17);
            labelTransportCode.TabIndex = 6;
            labelTransportCode.Text = "Код транспорта:  ";
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
            buttonSave.Location = new Point(256, 338);
            buttonSave.Margin = new Padding(4, 3, 4, 3);
            buttonSave.Name = "buttonSave";
            buttonSave.Padding = new Padding(9, 5, 9, 5);
            buttonSave.Size = new Size(309, 42);
            buttonSave.TabIndex = 8;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxTransportCode
            // 
            textBoxTransportCode.Anchor = AnchorStyles.Left;
            textBoxTransportCode.BackColor = Color.White;
            textBoxTransportCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxTransportCode.Font = new Font("Segoe UI", 9.75F);
            textBoxTransportCode.ForeColor = Color.FromArgb(0, 0, 0);
            textBoxTransportCode.Location = new Point(414, 250);
            textBoxTransportCode.Margin = new Padding(4, 3, 4, 3);
            textBoxTransportCode.Name = "textBoxTransportCode";
            textBoxTransportCode.Size = new Size(287, 25);
            textBoxTransportCode.TabIndex = 10;
            // 
            // labelDateTitle
            // 
            labelDateTitle.Anchor = AnchorStyles.Right;
            labelDateTitle.AutoSize = true;
            labelDateTitle.Font = new Font("Segoe UI", 9.75F);
            labelDateTitle.ForeColor = Color.FromArgb(0, 0, 0);
            labelDateTitle.Location = new Point(155, 302);
            labelDateTitle.Margin = new Padding(4, 0, 4, 0);
            labelDateTitle.Name = "labelDateTitle";
            labelDateTitle.Size = new Size(251, 17);
            labelDateTitle.TabIndex = 19;
            labelDateTitle.Text = "Дата подписания договора о владении: ";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Anchor = AnchorStyles.Left;
            dateTimePickerDate.BackColor = Color.White;
            dateTimePickerDate.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerDate.Font = new Font("Segoe UI", 9.75F);
            dateTimePickerDate.ForeColor = Color.FromArgb(0, 0, 0);
            dateTimePickerDate.Format = DateTimePickerFormat.Custom;
            dateTimePickerDate.Location = new Point(414, 298);
            dateTimePickerDate.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(286, 25);
            dateTimePickerDate.TabIndex = 20;
            dateTimePickerDate.Tag = "";
            // 
            // OwnershipCreateView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "OwnershipCreateView";
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
        private Components.Labels.PrimaryLabel labelTransportCode;
        private CommonButton buttonSave;
        private Components.Controls.TextBoxes.DefaultTextBox textBoxTransportCode;
        private Components.Labels.PrimaryLabel labelDateTitle;
        private Components.Controls.DateTimePickers.DefaultDateTimePicker dateTimePickerDate;
    }
}
