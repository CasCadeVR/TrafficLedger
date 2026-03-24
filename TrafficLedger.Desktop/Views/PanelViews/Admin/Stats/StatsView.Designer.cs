using TrafficLedger.Desktop.Components;
using TrafficLedger.Desktop.Components.Controls;

namespace TrafficLedger.Desktop.Views.PanelViews
{
    partial class StatsView
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
            acceptedRequestsCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            acceptedRequestsCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            rejectedRequestsCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            rejectedRequestsCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            pendingRequestsCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            pendingRequestsCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            heading3Label1 = new TrafficLedger.Desktop.Components.Labels.Heading3Label();
            parikngStatsTitle = new TrafficLedger.Desktop.Components.Labels.Heading3Label();
            fineStatsTitle = new TrafficLedger.Desktop.Components.Labels.Heading3Label();
            parkingTotalSumLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            zoneCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            zoneCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            mostCommonFineLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            mostCommonFine = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            totalFinePaymentSumLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            totalFinePaymentSum = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            payedFinesCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            payedFinesCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            activeFinesCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            activeFinesCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            transportCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            transportCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            licenseCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            licenseCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            driverCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            driverCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            userCountLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            userCount = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            countTitle = new TrafficLedger.Desktop.Components.Labels.Heading3Label();
            mostPopularZoneLabel = new TrafficLedger.Desktop.Components.Labels.PrimaryLabel();
            parkingTotalSum = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            mostPopularZone = new TrafficLedger.Desktop.Components.Controls.TextBoxes.ReadOnlyTextBox();
            exportToExcel = new CommonButton();
            saveFileDialog = new SaveFileDialog();
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
            tableLayoutPanelMain.Controls.Add(acceptedRequestsCountLabel, 0, 18);
            tableLayoutPanelMain.Controls.Add(acceptedRequestsCount, 1, 18);
            tableLayoutPanelMain.Controls.Add(rejectedRequestsCountLabel, 0, 17);
            tableLayoutPanelMain.Controls.Add(rejectedRequestsCount, 1, 17);
            tableLayoutPanelMain.Controls.Add(pendingRequestsCountLabel, 0, 16);
            tableLayoutPanelMain.Controls.Add(pendingRequestsCount, 1, 16);
            tableLayoutPanelMain.Controls.Add(heading3Label1, 0, 15);
            tableLayoutPanelMain.Controls.Add(parikngStatsTitle, 0, 11);
            tableLayoutPanelMain.Controls.Add(fineStatsTitle, 0, 6);
            tableLayoutPanelMain.Controls.Add(parkingTotalSumLabel, 0, 13);
            tableLayoutPanelMain.Controls.Add(zoneCountLabel, 0, 12);
            tableLayoutPanelMain.Controls.Add(zoneCount, 1, 12);
            tableLayoutPanelMain.Controls.Add(mostCommonFineLabel, 0, 10);
            tableLayoutPanelMain.Controls.Add(mostCommonFine, 1, 10);
            tableLayoutPanelMain.Controls.Add(totalFinePaymentSumLabel, 0, 9);
            tableLayoutPanelMain.Controls.Add(totalFinePaymentSum, 1, 9);
            tableLayoutPanelMain.Controls.Add(payedFinesCountLabel, 0, 8);
            tableLayoutPanelMain.Controls.Add(payedFinesCount, 1, 8);
            tableLayoutPanelMain.Controls.Add(activeFinesCountLabel, 0, 7);
            tableLayoutPanelMain.Controls.Add(activeFinesCount, 1, 7);
            tableLayoutPanelMain.Controls.Add(transportCountLabel, 0, 5);
            tableLayoutPanelMain.Controls.Add(transportCount, 1, 5);
            tableLayoutPanelMain.Controls.Add(licenseCountLabel, 0, 4);
            tableLayoutPanelMain.Controls.Add(licenseCount, 1, 4);
            tableLayoutPanelMain.Controls.Add(driverCountLabel, 0, 3);
            tableLayoutPanelMain.Controls.Add(driverCount, 1, 3);
            tableLayoutPanelMain.Controls.Add(userCountLabel, 0, 2);
            tableLayoutPanelMain.Controls.Add(userCount, 1, 2);
            tableLayoutPanelMain.Controls.Add(countTitle, 0, 1);
            tableLayoutPanelMain.Controls.Add(mostPopularZoneLabel, 0, 14);
            tableLayoutPanelMain.Controls.Add(parkingTotalSum, 1, 13);
            tableLayoutPanelMain.Controls.Add(mostPopularZone, 1, 14);
            tableLayoutPanelMain.Controls.Add(exportToExcel, 0, 19);
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Margin = new Padding(4, 3, 4, 3);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.RowCount = 22;
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.546278F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.545824F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.545824F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.545824F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.545824F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.545824F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54429674F));
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelMain.Size = new Size(821, 576);
            tableLayoutPanelMain.TabIndex = 0;
            // 
            // acceptedRequestsCountLabel
            // 
            acceptedRequestsCountLabel.Anchor = AnchorStyles.Right;
            acceptedRequestsCountLabel.AutoSize = true;
            acceptedRequestsCountLabel.Font = new Font("Segoe UI", 9.75F);
            acceptedRequestsCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            acceptedRequestsCountLabel.Location = new Point(75, 472);
            acceptedRequestsCountLabel.Name = "acceptedRequestsCountLabel";
            acceptedRequestsCountLabel.Size = new Size(332, 17);
            acceptedRequestsCountLabel.TabIndex = 35;
            acceptedRequestsCountLabel.Text = "Количество принятых заявок за последнюю неделю: ";
            // 
            // acceptedRequestsCount
            // 
            acceptedRequestsCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            acceptedRequestsCount.BackColor = Color.GhostWhite;
            acceptedRequestsCount.BorderStyle = BorderStyle.None;
            acceptedRequestsCount.Font = new Font("Consolas", 9.75F);
            acceptedRequestsCount.ForeColor = Color.FromArgb(0, 0, 0);
            acceptedRequestsCount.Location = new Point(413, 473);
            acceptedRequestsCount.Name = "acceptedRequestsCount";
            acceptedRequestsCount.ReadOnly = true;
            acceptedRequestsCount.Size = new Size(405, 16);
            acceptedRequestsCount.TabIndex = 36;
            acceptedRequestsCount.Text = "Загрузка . . .";
            // 
            // rejectedRequestsCountLabel
            // 
            rejectedRequestsCountLabel.Anchor = AnchorStyles.Right;
            rejectedRequestsCountLabel.AutoSize = true;
            rejectedRequestsCountLabel.Font = new Font("Segoe UI", 9.75F);
            rejectedRequestsCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            rejectedRequestsCountLabel.Location = new Point(47, 446);
            rejectedRequestsCountLabel.Name = "rejectedRequestsCountLabel";
            rejectedRequestsCountLabel.Size = new Size(360, 17);
            rejectedRequestsCountLabel.TabIndex = 33;
            rejectedRequestsCountLabel.Text = "Количество отклоннённых заявок за последнюю неделю: ";
            // 
            // rejectedRequestsCount
            // 
            rejectedRequestsCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rejectedRequestsCount.BackColor = Color.GhostWhite;
            rejectedRequestsCount.BorderStyle = BorderStyle.None;
            rejectedRequestsCount.Font = new Font("Consolas", 9.75F);
            rejectedRequestsCount.ForeColor = Color.FromArgb(0, 0, 0);
            rejectedRequestsCount.Location = new Point(413, 447);
            rejectedRequestsCount.Name = "rejectedRequestsCount";
            rejectedRequestsCount.ReadOnly = true;
            rejectedRequestsCount.Size = new Size(405, 16);
            rejectedRequestsCount.TabIndex = 34;
            rejectedRequestsCount.Text = "Загрузка . . .";
            // 
            // pendingRequestsCountLabel
            // 
            pendingRequestsCountLabel.Anchor = AnchorStyles.Right;
            pendingRequestsCountLabel.AutoSize = true;
            pendingRequestsCountLabel.Font = new Font("Segoe UI", 9.75F);
            pendingRequestsCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            pendingRequestsCountLabel.Location = new Point(224, 420);
            pendingRequestsCountLabel.Name = "pendingRequestsCountLabel";
            pendingRequestsCountLabel.Size = new Size(183, 17);
            pendingRequestsCountLabel.TabIndex = 31;
            pendingRequestsCountLabel.Text = "Текущее количество заявок: ";
            // 
            // pendingRequestsCount
            // 
            pendingRequestsCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pendingRequestsCount.BackColor = Color.GhostWhite;
            pendingRequestsCount.BorderStyle = BorderStyle.None;
            pendingRequestsCount.Font = new Font("Consolas", 9.75F);
            pendingRequestsCount.ForeColor = Color.FromArgb(0, 0, 0);
            pendingRequestsCount.Location = new Point(413, 421);
            pendingRequestsCount.Name = "pendingRequestsCount";
            pendingRequestsCount.ReadOnly = true;
            pendingRequestsCount.Size = new Size(405, 16);
            pendingRequestsCount.TabIndex = 32;
            pendingRequestsCount.Text = "Загрузка . . .";
            // 
            // heading3Label1
            // 
            heading3Label1.Anchor = AnchorStyles.None;
            heading3Label1.AutoSize = true;
            tableLayoutPanelMain.SetColumnSpan(heading3Label1, 2);
            heading3Label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            heading3Label1.ForeColor = Color.FromArgb(0, 0, 0);
            heading3Label1.Location = new Point(378, 392);
            heading3Label1.Name = "heading3Label1";
            heading3Label1.Size = new Size(65, 21);
            heading3Label1.TabIndex = 30;
            heading3Label1.Text = "Заявки";
            // 
            // parikngStatsTitle
            // 
            parikngStatsTitle.Anchor = AnchorStyles.None;
            parikngStatsTitle.AutoSize = true;
            tableLayoutPanelMain.SetColumnSpan(parikngStatsTitle, 2);
            parikngStatsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            parikngStatsTitle.ForeColor = Color.FromArgb(0, 0, 0);
            parikngStatsTitle.Location = new Point(366, 288);
            parikngStatsTitle.Name = "parikngStatsTitle";
            parikngStatsTitle.Size = new Size(88, 21);
            parikngStatsTitle.TabIndex = 29;
            parikngStatsTitle.Text = "Парковки";
            // 
            // fineStatsTitle
            // 
            fineStatsTitle.Anchor = AnchorStyles.None;
            fineStatsTitle.AutoSize = true;
            tableLayoutPanelMain.SetColumnSpan(fineStatsTitle, 2);
            fineStatsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            fineStatsTitle.ForeColor = Color.FromArgb(0, 0, 0);
            fineStatsTitle.Location = new Point(371, 158);
            fineStatsTitle.Name = "fineStatsTitle";
            fineStatsTitle.Size = new Size(78, 21);
            fineStatsTitle.TabIndex = 28;
            fineStatsTitle.Text = "Штрафы";
            // 
            // parkingTotalSumLabel
            // 
            parkingTotalSumLabel.Anchor = AnchorStyles.Right;
            parkingTotalSumLabel.AutoSize = true;
            parkingTotalSumLabel.Font = new Font("Segoe UI", 9.75F);
            parkingTotalSumLabel.ForeColor = Color.FromArgb(0, 0, 0);
            parkingTotalSumLabel.Location = new Point(109, 342);
            parkingTotalSumLabel.Name = "parkingTotalSumLabel";
            parkingTotalSumLabel.Size = new Size(298, 17);
            parkingTotalSumLabel.TabIndex = 25;
            parkingTotalSumLabel.Text = "Итоговая сумма со всех оплаченных парковок: ";
            // 
            // zoneCountLabel
            // 
            zoneCountLabel.Anchor = AnchorStyles.Right;
            zoneCountLabel.AutoSize = true;
            zoneCountLabel.Font = new Font("Segoe UI", 9.75F);
            zoneCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            zoneCountLabel.Location = new Point(103, 316);
            zoneCountLabel.Name = "zoneCountLabel";
            zoneCountLabel.Size = new Size(304, 17);
            zoneCountLabel.TabIndex = 23;
            zoneCountLabel.Text = "Зарегистрировано парковочных мест в системе: ";
            // 
            // zoneCount
            // 
            zoneCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            zoneCount.BackColor = Color.GhostWhite;
            zoneCount.BorderStyle = BorderStyle.None;
            zoneCount.Font = new Font("Consolas", 9.75F);
            zoneCount.ForeColor = Color.FromArgb(0, 0, 0);
            zoneCount.Location = new Point(413, 317);
            zoneCount.Name = "zoneCount";
            zoneCount.ReadOnly = true;
            zoneCount.Size = new Size(405, 16);
            zoneCount.TabIndex = 24;
            zoneCount.Text = "Загрузка . . .";
            // 
            // mostCommonFineLabel
            // 
            mostCommonFineLabel.Anchor = AnchorStyles.Right;
            mostCommonFineLabel.AutoSize = true;
            mostCommonFineLabel.Font = new Font("Segoe UI", 9.75F);
            mostCommonFineLabel.ForeColor = Color.FromArgb(0, 0, 0);
            mostCommonFineLabel.Location = new Point(183, 264);
            mostCommonFineLabel.Name = "mostCommonFineLabel";
            mostCommonFineLabel.Size = new Size(224, 17);
            mostCommonFineLabel.TabIndex = 19;
            mostCommonFineLabel.Text = "Самый распространнённый штраф: ";
            // 
            // mostCommonFine
            // 
            mostCommonFine.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mostCommonFine.BackColor = Color.GhostWhite;
            mostCommonFine.BorderStyle = BorderStyle.None;
            mostCommonFine.Font = new Font("Consolas", 9.75F);
            mostCommonFine.ForeColor = Color.FromArgb(0, 0, 0);
            mostCommonFine.Location = new Point(413, 265);
            mostCommonFine.Name = "mostCommonFine";
            mostCommonFine.ReadOnly = true;
            mostCommonFine.Size = new Size(405, 16);
            mostCommonFine.TabIndex = 20;
            mostCommonFine.Text = "Загрузка . . .";
            // 
            // totalFinePaymentSumLabel
            // 
            totalFinePaymentSumLabel.Anchor = AnchorStyles.Right;
            totalFinePaymentSumLabel.AutoSize = true;
            totalFinePaymentSumLabel.Font = new Font("Segoe UI", 9.75F);
            totalFinePaymentSumLabel.ForeColor = Color.FromArgb(0, 0, 0);
            totalFinePaymentSumLabel.Location = new Point(111, 238);
            totalFinePaymentSumLabel.Name = "totalFinePaymentSumLabel";
            totalFinePaymentSumLabel.Size = new Size(296, 17);
            totalFinePaymentSumLabel.TabIndex = 17;
            totalFinePaymentSumLabel.Text = "Итоговая сумма со всех оплаченных штрафов: ";
            // 
            // totalFinePaymentSum
            // 
            totalFinePaymentSum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            totalFinePaymentSum.BackColor = Color.GhostWhite;
            totalFinePaymentSum.BorderStyle = BorderStyle.None;
            totalFinePaymentSum.Font = new Font("Consolas", 9.75F);
            totalFinePaymentSum.ForeColor = Color.FromArgb(0, 0, 0);
            totalFinePaymentSum.Location = new Point(413, 239);
            totalFinePaymentSum.Name = "totalFinePaymentSum";
            totalFinePaymentSum.ReadOnly = true;
            totalFinePaymentSum.Size = new Size(405, 16);
            totalFinePaymentSum.TabIndex = 18;
            totalFinePaymentSum.Text = "Загрузка . . .";
            // 
            // payedFinesCountLabel
            // 
            payedFinesCountLabel.Anchor = AnchorStyles.Right;
            payedFinesCountLabel.AutoSize = true;
            payedFinesCountLabel.Font = new Font("Segoe UI", 9.75F);
            payedFinesCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            payedFinesCountLabel.Location = new Point(187, 212);
            payedFinesCountLabel.Name = "payedFinesCountLabel";
            payedFinesCountLabel.Size = new Size(220, 17);
            payedFinesCountLabel.TabIndex = 15;
            payedFinesCountLabel.Text = "Количество оплаченных штрафов: ";
            // 
            // payedFinesCount
            // 
            payedFinesCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            payedFinesCount.BackColor = Color.GhostWhite;
            payedFinesCount.BorderStyle = BorderStyle.None;
            payedFinesCount.Font = new Font("Consolas", 9.75F);
            payedFinesCount.ForeColor = Color.FromArgb(0, 0, 0);
            payedFinesCount.Location = new Point(413, 213);
            payedFinesCount.Name = "payedFinesCount";
            payedFinesCount.ReadOnly = true;
            payedFinesCount.Size = new Size(405, 16);
            payedFinesCount.TabIndex = 16;
            payedFinesCount.Text = "Загрузка . . .";
            // 
            // activeFinesCountLabel
            // 
            activeFinesCountLabel.Anchor = AnchorStyles.Right;
            activeFinesCountLabel.AutoSize = true;
            activeFinesCountLabel.Font = new Font("Segoe UI", 9.75F);
            activeFinesCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            activeFinesCountLabel.Location = new Point(179, 186);
            activeFinesCountLabel.Name = "activeFinesCountLabel";
            activeFinesCountLabel.Size = new Size(228, 17);
            activeFinesCountLabel.TabIndex = 13;
            activeFinesCountLabel.Text = "Количество действующих штрафов: ";
            // 
            // activeFinesCount
            // 
            activeFinesCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            activeFinesCount.BackColor = Color.GhostWhite;
            activeFinesCount.BorderStyle = BorderStyle.None;
            activeFinesCount.Font = new Font("Consolas", 9.75F);
            activeFinesCount.ForeColor = Color.FromArgb(0, 0, 0);
            activeFinesCount.Location = new Point(413, 187);
            activeFinesCount.Name = "activeFinesCount";
            activeFinesCount.ReadOnly = true;
            activeFinesCount.Size = new Size(405, 16);
            activeFinesCount.TabIndex = 14;
            activeFinesCount.Text = "Загрузка . . .";
            // 
            // transportCountLabel
            // 
            transportCountLabel.Anchor = AnchorStyles.Right;
            transportCountLabel.AutoSize = true;
            transportCountLabel.Font = new Font("Segoe UI", 9.75F);
            transportCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            transportCountLabel.Location = new Point(146, 134);
            transportCountLabel.Name = "transportCountLabel";
            transportCountLabel.Size = new Size(261, 17);
            transportCountLabel.TabIndex = 7;
            transportCountLabel.Text = "Зарегистрировано транспорта в системе: ";
            // 
            // transportCount
            // 
            transportCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            transportCount.BackColor = Color.GhostWhite;
            transportCount.BorderStyle = BorderStyle.None;
            transportCount.Font = new Font("Consolas", 9.75F);
            transportCount.ForeColor = Color.FromArgb(0, 0, 0);
            transportCount.Location = new Point(413, 135);
            transportCount.Name = "transportCount";
            transportCount.ReadOnly = true;
            transportCount.Size = new Size(405, 16);
            transportCount.TabIndex = 8;
            transportCount.Text = "Загрузка . . .";
            // 
            // licenseCountLabel
            // 
            licenseCountLabel.Anchor = AnchorStyles.Right;
            licenseCountLabel.AutoSize = true;
            licenseCountLabel.Font = new Font("Segoe UI", 9.75F);
            licenseCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            licenseCountLabel.Location = new Point(200, 108);
            licenseCountLabel.Name = "licenseCountLabel";
            licenseCountLabel.Size = new Size(207, 17);
            licenseCountLabel.TabIndex = 5;
            licenseCountLabel.Text = "Зарегистрировано ВУ в системе: ";
            // 
            // licenseCount
            // 
            licenseCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            licenseCount.BackColor = Color.GhostWhite;
            licenseCount.BorderStyle = BorderStyle.None;
            licenseCount.Font = new Font("Consolas", 9.75F);
            licenseCount.ForeColor = Color.FromArgb(0, 0, 0);
            licenseCount.Location = new Point(413, 109);
            licenseCount.Name = "licenseCount";
            licenseCount.ReadOnly = true;
            licenseCount.Size = new Size(405, 16);
            licenseCount.TabIndex = 6;
            licenseCount.Text = "Загрузка . . .";
            // 
            // driverCountLabel
            // 
            driverCountLabel.Anchor = AnchorStyles.Right;
            driverCountLabel.AutoSize = true;
            driverCountLabel.Font = new Font("Segoe UI", 9.75F);
            driverCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            driverCountLabel.Location = new Point(152, 82);
            driverCountLabel.Name = "driverCountLabel";
            driverCountLabel.Size = new Size(255, 17);
            driverCountLabel.TabIndex = 3;
            driverCountLabel.Text = "Зарегистрировано водителей в системе: ";
            // 
            // driverCount
            // 
            driverCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            driverCount.BackColor = Color.GhostWhite;
            driverCount.BorderStyle = BorderStyle.None;
            driverCount.Font = new Font("Consolas", 9.75F);
            driverCount.ForeColor = Color.FromArgb(0, 0, 0);
            driverCount.Location = new Point(413, 83);
            driverCount.Name = "driverCount";
            driverCount.ReadOnly = true;
            driverCount.Size = new Size(405, 16);
            driverCount.TabIndex = 4;
            driverCount.Text = "Загрузка . . .";
            // 
            // userCountLabel
            // 
            userCountLabel.Anchor = AnchorStyles.Right;
            userCountLabel.AutoSize = true;
            userCountLabel.Font = new Font("Segoe UI", 9.75F);
            userCountLabel.ForeColor = Color.FromArgb(0, 0, 0);
            userCountLabel.Location = new Point(124, 56);
            userCountLabel.Name = "userCountLabel";
            userCountLabel.Size = new Size(283, 17);
            userCountLabel.TabIndex = 1;
            userCountLabel.Text = "Зарегистрировано пользователей в системе: ";
            // 
            // userCount
            // 
            userCount.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            userCount.BackColor = Color.GhostWhite;
            userCount.BorderStyle = BorderStyle.None;
            userCount.Font = new Font("Consolas", 9.75F);
            userCount.ForeColor = Color.FromArgb(0, 0, 0);
            userCount.Location = new Point(413, 57);
            userCount.Name = "userCount";
            userCount.ReadOnly = true;
            userCount.Size = new Size(405, 16);
            userCount.TabIndex = 2;
            userCount.Text = "Загрузка . . .";
            // 
            // countTitle
            // 
            countTitle.Anchor = AnchorStyles.None;
            countTitle.AutoSize = true;
            tableLayoutPanelMain.SetColumnSpan(countTitle, 2);
            countTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            countTitle.ForeColor = Color.FromArgb(0, 0, 0);
            countTitle.Location = new Point(359, 28);
            countTitle.Name = "countTitle";
            countTitle.Size = new Size(103, 21);
            countTitle.TabIndex = 27;
            countTitle.Text = "Количество";
            // 
            // mostPopularZoneLabel
            // 
            mostPopularZoneLabel.Anchor = AnchorStyles.Right;
            mostPopularZoneLabel.AutoSize = true;
            mostPopularZoneLabel.Font = new Font("Segoe UI", 9.75F);
            mostPopularZoneLabel.ForeColor = Color.FromArgb(0, 0, 0);
            mostPopularZoneLabel.Location = new Point(238, 368);
            mostPopularZoneLabel.Name = "mostPopularZoneLabel";
            mostPopularZoneLabel.Size = new Size(169, 17);
            mostPopularZoneLabel.TabIndex = 21;
            mostPopularZoneLabel.Text = "Самое популярное место: ";
            // 
            // parkingTotalSum
            // 
            parkingTotalSum.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            parkingTotalSum.BackColor = Color.GhostWhite;
            parkingTotalSum.BorderStyle = BorderStyle.None;
            parkingTotalSum.Font = new Font("Consolas", 9.75F);
            parkingTotalSum.ForeColor = Color.FromArgb(0, 0, 0);
            parkingTotalSum.Location = new Point(413, 343);
            parkingTotalSum.Name = "parkingTotalSum";
            parkingTotalSum.ReadOnly = true;
            parkingTotalSum.Size = new Size(405, 16);
            parkingTotalSum.TabIndex = 22;
            parkingTotalSum.Text = "Загрузка . . .";
            // 
            // mostPopularZone
            // 
            mostPopularZone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            mostPopularZone.BackColor = Color.GhostWhite;
            mostPopularZone.BorderStyle = BorderStyle.None;
            mostPopularZone.Font = new Font("Consolas", 9.75F);
            mostPopularZone.ForeColor = Color.FromArgb(0, 0, 0);
            mostPopularZone.Location = new Point(413, 369);
            mostPopularZone.Name = "mostPopularZone";
            mostPopularZone.ReadOnly = true;
            mostPopularZone.Size = new Size(405, 16);
            mostPopularZone.TabIndex = 26;
            mostPopularZone.Text = "Загрузка . . .";
            // 
            // exportToExcel
            // 
            exportToExcel.Anchor = AnchorStyles.None;
            exportToExcel.BackColor = Color.Green;
            tableLayoutPanelMain.SetColumnSpan(exportToExcel, 2);
            exportToExcel.FlatAppearance.BorderColor = Color.DarkGray;
            exportToExcel.FlatStyle = FlatStyle.Flat;
            exportToExcel.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            exportToExcel.ForeColor = Color.White;
            exportToExcel.Location = new Point(286, 511);
            exportToExcel.Name = "exportToExcel";
            exportToExcel.Padding = new Padding(8, 4, 8, 4);
            tableLayoutPanelMain.SetRowSpan(exportToExcel, 3);
            exportToExcel.Size = new Size(248, 48);
            exportToExcel.TabIndex = 37;
            exportToExcel.Text = "Экспортировать в Excel";
            exportToExcel.UseVisualStyleBackColor = false;
            exportToExcel.Click += exportToExcel_Click;
            // 
            // StatsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Margin = new Padding(5, 3, 5, 3);
            Name = "StatsView";
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private Components.Labels.PrimaryLabel userCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox userCount;
        private Components.Labels.PrimaryLabel parkingTotalSumLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox mostPopularZone;
        private Components.Labels.PrimaryLabel zoneCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox zoneCount;
        private Components.Labels.PrimaryLabel mostPopularZoneLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox parkingTotalSum;
        private Components.Labels.PrimaryLabel mostCommonFineLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox mostCommonFine;
        private Components.Labels.PrimaryLabel totalFinePaymentSumLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox totalFinePaymentSum;
        private Components.Labels.PrimaryLabel payedFinesCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox payedFinesCount;
        private Components.Labels.PrimaryLabel activeFinesCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox activeFinesCount;
        private Components.Labels.PrimaryLabel transportCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox transportCount;
        private Components.Labels.PrimaryLabel licenseCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox licenseCount;
        private Components.Labels.PrimaryLabel driverCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox driverCount;
        private Components.Labels.Heading3Label countTitle;
        private Components.Labels.Heading3Label fineStatsTitle;
        private Components.Labels.Heading3Label parikngStatsTitle;
        private Components.Labels.PrimaryLabel acceptedRequestsCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox acceptedRequestsCount;
        private Components.Labels.PrimaryLabel rejectedRequestsCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox rejectedRequestsCount;
        private Components.Labels.PrimaryLabel pendingRequestsCountLabel;
        private Components.Controls.TextBoxes.ReadOnlyTextBox pendingRequestsCount;
        private Components.Labels.Heading3Label heading3Label1;
        private CommonButton exportToExcel;
        private SaveFileDialog saveFileDialog;
    }
}
