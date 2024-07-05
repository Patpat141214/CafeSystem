using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            endDate.Enabled = false;
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
                Series serie1 = ChartSales.Series["Series2"];
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

            private void filterBySold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 0)
            {
                loadTransactGroupByWeek();
            }
        }
    }
    }

