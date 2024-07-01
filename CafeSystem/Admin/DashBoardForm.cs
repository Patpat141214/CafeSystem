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

            conn.Close();
        }
        }
    }

