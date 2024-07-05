namespace CafeSystem.Admin
{
    partial class DashBoardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblTodaySales = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel3 = new Guna.UI.WinForms.GunaElipsePanel();
            this.gunaElipsePanel4 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblTodayTransaction = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipsePanel5 = new Guna.UI.WinForms.GunaElipsePanel();
            this.lblPendingOrders = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaElipsePanel6 = new Guna.UI.WinForms.GunaElipsePanel();
            this.CategoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.filterBySold = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaPanel1.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.gunaElipsePanel4.SuspendLayout();
            this.gunaElipsePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.gunaPanel1.Controls.Add(this.gunaLabel4);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1631, 71);
            this.gunaPanel1.TabIndex = 43;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(109)))), ((int)(((byte)(118)))));
            this.gunaLabel4.Location = new System.Drawing.Point(3, 7);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(258, 56);
            this.gunaLabel4.TabIndex = 14;
            this.gunaLabel4.Text = "Dashboard";
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152)))));
            this.gunaElipsePanel1.Controls.Add(this.lblTodaySales);
            this.gunaElipsePanel1.Controls.Add(this.label5);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(23, 116);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(320, 164);
            this.gunaElipsePanel1.TabIndex = 44;
            // 
            // lblTodaySales
            // 
            this.lblTodaySales.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaySales.ForeColor = System.Drawing.Color.Black;
            this.lblTodaySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTodaySales.Location = new System.Drawing.Point(14, 74);
            this.lblTodaySales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodaySales.Name = "lblTodaySales";
            this.lblTodaySales.Size = new System.Drawing.Size(292, 67);
            this.lblTodaySales.TabIndex = 52;
            this.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(54, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 32);
            this.label5.TabIndex = 51;
            this.label5.Text = "TODAY\'S SALES";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.gunaElipsePanel2.Location = new System.Drawing.Point(23, 313);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(320, 164);
            this.gunaElipsePanel2.TabIndex = 45;
            // 
            // gunaElipsePanel3
            // 
            this.gunaElipsePanel3.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(183)))));
            this.gunaElipsePanel3.Location = new System.Drawing.Point(363, 313);
            this.gunaElipsePanel3.Name = "gunaElipsePanel3";
            this.gunaElipsePanel3.Radius = 20;
            this.gunaElipsePanel3.Size = new System.Drawing.Size(320, 164);
            this.gunaElipsePanel3.TabIndex = 45;
            // 
            // gunaElipsePanel4
            // 
            this.gunaElipsePanel4.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel4.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135)))));
            this.gunaElipsePanel4.Controls.Add(this.lblTodayTransaction);
            this.gunaElipsePanel4.Controls.Add(this.label1);
            this.gunaElipsePanel4.Location = new System.Drawing.Point(363, 116);
            this.gunaElipsePanel4.Name = "gunaElipsePanel4";
            this.gunaElipsePanel4.Radius = 20;
            this.gunaElipsePanel4.Size = new System.Drawing.Size(320, 164);
            this.gunaElipsePanel4.TabIndex = 45;
            // 
            // lblTodayTransaction
            // 
            this.lblTodayTransaction.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayTransaction.ForeColor = System.Drawing.Color.Black;
            this.lblTodayTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTodayTransaction.Location = new System.Drawing.Point(15, 74);
            this.lblTodayTransaction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTodayTransaction.Name = "lblTodayTransaction";
            this.lblTodayTransaction.Size = new System.Drawing.Size(292, 67);
            this.lblTodayTransaction.TabIndex = 53;
            this.lblTodayTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 52;
            this.label1.Text = "TODAY\'S TRANSACTION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipsePanel5
            // 
            this.gunaElipsePanel5.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel5.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(209)))), ((int)(((byte)(248)))));
            this.gunaElipsePanel5.Controls.Add(this.lblPendingOrders);
            this.gunaElipsePanel5.Controls.Add(this.label2);
            this.gunaElipsePanel5.Location = new System.Drawing.Point(702, 116);
            this.gunaElipsePanel5.Name = "gunaElipsePanel5";
            this.gunaElipsePanel5.Radius = 20;
            this.gunaElipsePanel5.Size = new System.Drawing.Size(320, 164);
            this.gunaElipsePanel5.TabIndex = 46;
            // 
            // lblPendingOrders
            // 
            this.lblPendingOrders.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingOrders.ForeColor = System.Drawing.Color.Black;
            this.lblPendingOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPendingOrders.Location = new System.Drawing.Point(13, 74);
            this.lblPendingOrders.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPendingOrders.Name = "lblPendingOrders";
            this.lblPendingOrders.Size = new System.Drawing.Size(292, 67);
            this.lblPendingOrders.TabIndex = 54;
            this.lblPendingOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(49, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 53;
            this.label2.Text = "PENDING ORDERS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gunaElipsePanel6
            // 
            this.gunaElipsePanel6.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel6.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.gunaElipsePanel6.Location = new System.Drawing.Point(702, 313);
            this.gunaElipsePanel6.Name = "gunaElipsePanel6";
            this.gunaElipsePanel6.Radius = 20;
            this.gunaElipsePanel6.Size = new System.Drawing.Size(320, 164);
            this.gunaElipsePanel6.TabIndex = 47;
            // 
            // CategoryChart
            // 
            this.CategoryChart.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 80F;
            chartArea1.Position.Width = 80.20454F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 10F;
            this.CategoryChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.SystemColors.Control;
            legend1.Name = "Legend1";
            this.CategoryChart.Legends.Add(legend1);
            this.CategoryChart.Location = new System.Drawing.Point(1055, 116);
            this.CategoryChart.Name = "CategoryChart";
            this.CategoryChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.CategoryChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(195)))), ((int)(((byte)(152))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(158)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(209)))), ((int)(((byte)(248))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(234)))), ((int)(((byte)(183))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.CategoryChart.Series.Add(series1);
            this.CategoryChart.Size = new System.Drawing.Size(529, 361);
            this.CategoryChart.TabIndex = 48;
            this.CategoryChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Position.Auto = false;
            title1.Position.Height = 4.467012F;
            title1.Position.Width = 78F;
            title1.Position.X = 3F;
            title1.Position.Y = 3F;
            title1.Text = "TOP 5 SELLING CATEGORIES BY QUANTITY";
            title1.TextStyle = System.Windows.Forms.DataVisualization.Charting.TextStyle.Shadow;
            this.CategoryChart.Titles.Add(title1);
            // 
            // ChartSales
            // 
            this.ChartSales.BackColor = System.Drawing.SystemColors.Control;
            this.ChartSales.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea2";
            chartArea2.Position.Auto = false;
            chartArea2.Position.Height = 80F;
            chartArea2.Position.Width = 80.20454F;
            chartArea2.Position.X = 3F;
            chartArea2.Position.Y = 10F;
            this.ChartSales.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.SystemColors.Control;
            legend2.Name = "Legend2";
            this.ChartSales.Legends.Add(legend2);
            this.ChartSales.Location = new System.Drawing.Point(23, 568);
            this.ChartSales.Name = "ChartSales";
            this.ChartSales.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea2";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.Legend = "Legend2";
            series2.Name = "Series2";
            this.ChartSales.Series.Add(series2);
            this.ChartSales.Size = new System.Drawing.Size(1596, 481);
            this.ChartSales.TabIndex = 49;
            this.ChartSales.Text = "ChartSales";
            // 
            // filterBySold
            // 
            this.filterBySold.BackColor = System.Drawing.Color.Transparent;
            this.filterBySold.BaseColor = System.Drawing.Color.White;
            this.filterBySold.BorderColor = System.Drawing.Color.Silver;
            this.filterBySold.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterBySold.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterBySold.FocusedColor = System.Drawing.Color.Empty;
            this.filterBySold.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBySold.ForeColor = System.Drawing.Color.Black;
            this.filterBySold.FormattingEnabled = true;
            this.filterBySold.Items.AddRange(new object[] {
            "WEEKLY SALES",
            "MONTHLY SALES",
            "ANNUAL SALES"});
            this.filterBySold.Location = new System.Drawing.Point(349, 520);
            this.filterBySold.Name = "filterBySold";
            this.filterBySold.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.filterBySold.OnHoverItemForeColor = System.Drawing.Color.White;
            this.filterBySold.Size = new System.Drawing.Size(193, 31);
            this.filterBySold.TabIndex = 53;
            this.filterBySold.SelectedIndexChanged += new System.EventHandler(this.filterBySold_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(243, 525);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Filter By:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // endDate
            // 
            this.endDate.CustomFormat = "";
            this.endDate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(1252, 517);
            this.endDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(187, 30);
            this.endDate.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(1209, 521);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 22);
            this.label4.TabIndex = 55;
            this.label4.Text = "To:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // startDate
            // 
            this.startDate.CustomFormat = "";
            this.startDate.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(1012, 517);
            this.startDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(187, 30);
            this.startDate.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(949, 521);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 22);
            this.label6.TabIndex = 57;
            this.label6.Text = "From:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1631, 1061);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.filterBySold);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChartSales);
            this.Controls.Add(this.CategoryChart);
            this.Controls.Add(this.gunaElipsePanel6);
            this.Controls.Add(this.gunaElipsePanel5);
            this.Controls.Add(this.gunaElipsePanel4);
            this.Controls.Add(this.gunaElipsePanel3);
            this.Controls.Add(this.gunaElipsePanel2);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.gunaElipsePanel4.ResumeLayout(false);
            this.gunaElipsePanel4.PerformLayout();
            this.gunaElipsePanel5.ResumeLayout(false);
            this.gunaElipsePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CategoryChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel3;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel4;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel5;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart CategoryChart;
        public System.Windows.Forms.Label lblTodaySales;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblTodayTransaction;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
        public System.Windows.Forms.Label lblPendingOrders;
        public System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox filterBySold;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.DateTimePicker endDate;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.DateTimePicker startDate;
        public System.Windows.Forms.Label label6;
    }
}