using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CafeSystem.Admin
{
    public partial class DashBoardForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public DashBoardForm()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            startDate.MaxDate = DateTime.Now;
            topSellingProductsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            filterBySold.SelectedIndex = 0;
        }

        public void loadTop5SellingProductsByCategory()
        {
            string query = @"SELECT TOP 5 c.category, SUM(cart.qty) AS totalqty
FROM tblCart cart
JOIN tblProduct p ON cart.pid = p.id
JOIN tblCategory c ON p.catid = c.id
where cart.status ='Sold'
GROUP BY c.category
ORDER BY totalqty DESC";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();
            da.Fill(ds, "Sales");

            // Check if the query returned any results
            if (ds.Tables["Sales"].Rows.Count == 0)
            {
                DataTable dt = ds.Tables["Sales"];
                // Manually add a row with zero values
                DataRow row = dt.NewRow();
                row["category"] = "No Sales";
                row["totalqty"] = 0;
                dt.Rows.Add(row);
                CategoryChart.Visible = true;
            }

            CategoryChart.DataSource = ds.Tables["Sales"];
            Series serie1 = CategoryChart.Series["Series1"];
            serie1.ChartType = SeriesChartType.Pie;
            serie1.LabelBackColor = Color.Transparent;



            var chart = CategoryChart;
            chart.Series[serie1.Name].XValueMember = "category";
            chart.Series[serie1.Name].YValueMembers = "totalqty";
            chart.Series[serie1.Name].Font = new Font("Arial", 9, FontStyle.Bold);
            chart.Series[serie1.Name].LabelForeColor = Color.Black;
            chart.Series[0].IsValueShownAsLabel = true;
            chart.DataBind();
            conn.Close();
        }

        public void loadTransactGroupByWeek()
        {
            startDate.Enabled = false;
            DateTime currentDate = DateTime.Now.Date;

            DateTime start = currentDate.AddDays(-6);
            DateTime end = currentDate.AddHours(23).AddMinutes(59).AddSeconds(59);

            string query = @"
        SELECT 
            DATENAME(weekday, sdate) AS day_of_week, 
            ISNULL(SUM(c.total * (1 - COALESCE(d.discountPercent, 0) / 100)), 0) AS total_sales_with_discounts,
            DATEPART(dw, sdate) AS day_index
        FROM tblCart AS c 
        LEFT JOIN tblDiscountCart AS d ON c.transacno = d.transacno 
        WHERE c.status = 'Sold'
        AND CONVERT(date, sdate) BETWEEN @StartDate AND @EndDate
        GROUP BY DATENAME(weekday, sdate), DATEPART(dw, sdate)
        ORDER BY 
            (DATEPART(dw, sdate) + @@DATEFIRST + 6 - DATEPART(dw, GETDATE())) % 7 DESC";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StartDate", start);
                cmd.Parameters.AddWithValue("@EndDate", end);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "WeeklySales1");

                // Check if the query returned any results
                if (ds.Tables["WeeklySales1"].Rows.Count == 0)
                {
                    DataTable dt = ds.Tables["WeeklySales1"];
                    // Manually add a row with zero values
                    DataRow row = dt.NewRow();
                    row["day_of_week"] = "No Sales";
                    row["total_sales_with_discounts"] = 0;
                    dt.Rows.Add(row);
                }

                ChartSales.DataSource = ds.Tables["WeeklySales1"];
                //ChartSales.Series.Add("Sales");
                Series serie1 = ChartSales.Series["Sales"];
                serie1.ChartType = SeriesChartType.Bar;
                serie1.LabelBackColor = Color.Transparent;

                var chart = ChartSales;
                chart.Series[serie1.Name].XValueMember = "day_of_week";
                chart.Series[serie1.Name].YValueMembers = "total_sales_with_discounts";
                chart.Series[serie1.Name].LabelFormat = "₱ #,##0.00";
                chart.Series[serie1.Name].Font = new Font("Arial", 12, FontStyle.Bold);
                chart.Series[serie1.Name].LabelForeColor = Color.Black;

                chart.Series[0].IsValueShownAsLabel = true;
                Title chartTitle = new Title();
                chartTitle.Text = "Weekly Sales";
                chartTitle.Font = new Font("Arial", 14, FontStyle.Bold);
                chartTitle.ForeColor = Color.Black;
                chart.Titles.Clear();
                chart.Titles.Add(chartTitle);
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                chart.DataBind();

                conn.Close();
            }
        }

        public void loadTransactGroupByMonth()
        {
            try
            {
                startDate.Enabled = true;
                startDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "yyyy/MM";
                startDate.ShowUpDown = true;
                DateTime start = new DateTime(startDate.Value.Year, startDate.Value.Month, 1);
                DateTime end = start.AddMonths(1).AddSeconds(-1); // End of the selected month

                string query = @"
            SELECT 
                FORMAT(c.sdate, 'yyyy, MMMM') AS month_year, 
                ISNULL(SUM(c.total * (1 - COALESCE(d.discountPercent, 0) / 100)), 0) AS discounted_total
            FROM tblCart AS c 
            LEFT JOIN tblDiscountCart AS d ON c.transacno = d.transacno 
            WHERE c.status = 'Sold' 
            AND c.sdate BETWEEN @StartDate AND @EndDate
            GROUP BY FORMAT(c.sdate, 'yyyy, MMMM')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "MonthlySales");

                    // Check if the query returned any results
                    if (ds.Tables["MonthlySales"].Rows.Count == 0)
                    {
                        DataTable dt = ds.Tables["MonthlySales"];
                        // Manually add a row with zero values
                        DataRow row = dt.NewRow();
                        row["month_year"] = $"{start.Year}, {start.ToString("MMMM")}";
                        row["discounted_total"] = 0;
                        dt.Rows.Add(row);
                    }

                    //Debug.WriteLine(start.ToString());
                    //Debug.WriteLine(end.ToString());
                    ChartSales.DataSource = ds.Tables["MonthlySales"];
                    Series serie1 = ChartSales.Series["Sales"];
                    serie1.ChartType = SeriesChartType.Bar;
                    serie1.LabelBackColor = Color.Transparent;

                    var chart = ChartSales;
                    chart.Series[serie1.Name].XValueMember = "month_year";
                    chart.Series[serie1.Name].YValueMembers = "discounted_total";
                    chart.Series[serie1.Name].LabelFormat = "₱ #,##0.00";
                    chart.Series[serie1.Name].Font = new Font("Arial", 12, FontStyle.Bold);
                    chart.Series[serie1.Name].LabelForeColor = Color.Black;
                    chart.Series[0].IsValueShownAsLabel = true;

                    Title chartTitle = new Title();
                    chartTitle.Text = "Monthly Sales";
                    chartTitle.Font = new Font("Arial", 14, FontStyle.Bold);
                    chartTitle.ForeColor = Color.Black;
                    chart.Titles.Clear();
                    chart.Titles.Add(chartTitle);

                    chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chart.DataBind();

                    conn.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByYear()
        {
            try
            {
                startDate.Enabled = true;
                startDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "yyyy";
                startDate.ShowUpDown = true;
                DateTime start = new DateTime(startDate.Value.Year, 1, 1);
                DateTime end = start.AddYears(1).AddSeconds(-1); // End of the selected year

                string query = @"
        SELECT 
            FORMAT(c.sdate, 'yyyy') AS year, 
            ISNULL(SUM(c.total * (1 - COALESCE(d.discountPercent, 0) / 100)), 0) AS discounted_total
        FROM tblCart AS c 
        LEFT JOIN tblDiscountCart AS d ON c.transacno = d.transacno 
        WHERE c.status = 'Sold' 
        AND c.sdate BETWEEN @StartDate AND @EndDate
        GROUP BY FORMAT(c.sdate, 'yyyy')";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@StartDate", start);
                    cmd.Parameters.AddWithValue("@EndDate", end);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "YearlySales");

                    // Check if the query returned any results
                    if (ds.Tables["YearlySales"].Rows.Count == 0)
                    {
                        DataTable dt = ds.Tables["YearlySales"];
                        // Manually add a row with zero values
                        DataRow row = dt.NewRow();
                        row["year"] = start.Year.ToString();
                        row["discounted_total"] = 0;
                        dt.Rows.Add(row);
                    }
                    Debug.WriteLine(start.ToString());
                    Debug.WriteLine(end.ToString());
                    ChartSales.DataSource = ds.Tables["YearlySales"];
                    Series serie1 = ChartSales.Series["Sales"];
                    serie1.ChartType = SeriesChartType.Bar;
                    serie1.LabelBackColor = Color.Transparent;

                    var chart = ChartSales;
                    chart.Series[serie1.Name].XValueMember = "year";
                    chart.Series[serie1.Name].YValueMembers = "discounted_total";
                    chart.Series[serie1.Name].LabelFormat = "₱ #,##0.00";
                    chart.Series[serie1.Name].Font = new Font("Arial", 12, FontStyle.Bold);
                    chart.Series[serie1.Name].LabelForeColor = Color.Black;
                    chart.Series[0].IsValueShownAsLabel = true;

                    Title chartTitle = new Title();
                    chartTitle.Text = "Annual Sales";
                    chartTitle.Font = new Font("Arial", 14, FontStyle.Bold);
                    chartTitle.ForeColor = Color.Black;
                    chart.Titles.Clear();
                    chart.Titles.Add(chartTitle);

                    chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                    chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                    chart.DataBind();

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void filterBySold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 0)
            {
                loadTransactGroupByWeek();
            }
            if (filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByMonth();
            }
            if (filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByYear();
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByMonth();
            }
            if (filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByYear();

            }
        }

        public void Top5SellingItems()
        {
            topSellingProductsGrid.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("SELECT TOP 5 cart.ItemName, c.category, SUM(cart.qty) AS totalqty FROM tblCart cart JOIN tblProduct p ON cart.pid = p.id JOIN tblCategory c ON p.catid = c.id where cart.status ='Sold' GROUP BY cart.ItemName, c.category ORDER BY totalqty DESC", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                topSellingProductsGrid.Rows.Add(i, dr["ItemName"].ToString(), dr["category"].ToString(), dr["totalqty"].ToString());
                topSellingProductsGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }
    }
}

