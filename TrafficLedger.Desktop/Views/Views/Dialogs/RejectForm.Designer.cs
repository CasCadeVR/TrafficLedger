namespace TrafficLedger.Desktop.Views.Views
{
    partial class RejectForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel = new TableLayoutPanel();
            labelCommentary = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            rejectButton = new TrafficLedger.Desktop.Components.CommonButton();
            cancelButton = new TrafficLedger.Desktop.Components.CommonButton();
            commentaryTextBox = new TrafficLedger.Desktop.Components.Controls.TextBoxes.DefaultTextBox();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel.Controls.Add(labelCommentary, 0, 0);
            tableLayoutPanel.Controls.Add(rejectButton, 0, 2);
            tableLayoutPanel.Controls.Add(cancelButton, 1, 2);
            tableLayoutPanel.Controls.Add(commentaryTextBox, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 3;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel.Size = new Size(380, 168);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelCommentary
            // 
            labelCommentary.Anchor = AnchorStyles.Right;
            labelCommentary.AutoSize = true;
            labelCommentary.Font = new Font("Segoe UI", 9.75F);
            labelCommentary.ForeColor = Color.FromArgb(0, 0, 0);
            labelCommentary.Location = new Point(16, 19);
            labelCommentary.Name = "labelCommentary";
            labelCommentary.Size = new Size(171, 17);
            labelCommentary.TabIndex = 9;
            labelCommentary.Text = "Напишите причину отказа: ";
            // 
            // rejectButton
            // 
            rejectButton.BackColor = Color.Green;
            rejectButton.Dock = DockStyle.Fill;
            rejectButton.FlatAppearance.BorderColor = Color.DarkGray;
            rejectButton.FlatStyle = FlatStyle.Flat;
            rejectButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            rejectButton.ForeColor = Color.White;
            rejectButton.Location = new Point(3, 115);
            rejectButton.Name = "rejectButton";
            rejectButton.Padding = new Padding(8, 4, 8, 4);
            rejectButton.Size = new Size(184, 50);
            rejectButton.TabIndex = 0;
            rejectButton.Text = "Отклонить заявку";
            rejectButton.UseVisualStyleBackColor = false;
            rejectButton.Click += rejectButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Green;
            cancelButton.DialogResult = DialogResult.OK;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.FlatAppearance.BorderColor = Color.DarkGray;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(193, 115);
            cancelButton.Name = "cancelButton";
            cancelButton.Padding = new Padding(8, 4, 8, 4);
            cancelButton.Size = new Size(184, 50);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // commentaryTextBox
            // 
            commentaryTextBox.BackColor = Color.White;
            commentaryTextBox.BorderStyle = BorderStyle.FixedSingle;
            commentaryTextBox.Dock = DockStyle.Fill;
            commentaryTextBox.Font = new Font("Segoe UI", 9.75F);
            commentaryTextBox.ForeColor = Color.FromArgb(0, 0, 0);
            commentaryTextBox.Location = new Point(193, 3);
            commentaryTextBox.Multiline = true;
            commentaryTextBox.Name = "commentaryTextBox";
            tableLayoutPanel.SetRowSpan(commentaryTextBox, 2);
            commentaryTextBox.Size = new Size(184, 106);
            commentaryTextBox.TabIndex = 2;
            // 
            // RejectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 168);
            Controls.Add(tableLayoutPanel);
            MaximumSize = new Size(396, 207);
            MinimumSize = new Size(396, 207);
            Name = "RejectForm";
            Text = "Отклонение заявки";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private Components.CommonButton rejectButton;
        private Components.CommonButton cancelButton;
        private Components.Controls.TextBoxes.DefaultTextBox commentaryTextBox;
        private Components.Labels.PrimaryLabel labelCommentary;
    }
}