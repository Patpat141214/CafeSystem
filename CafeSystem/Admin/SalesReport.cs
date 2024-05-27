using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Admin
{
    public partial class SalesReport : Form
    {
        private readonly string search = "search transaction#";
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        LandingPage land;
        public SalesReport(LandingPage land1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            txtSearch.Text = "search transaction#";
            dataGridSoldReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            startDate.MaxDate = DateTime.Now;
            endDate.MaxDate = DateTime.Now;
            filterBySold.SelectedIndex = 0;
            this.KeyPreview = true;
            land = land1;
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = search;
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == search)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridTransactNoSold.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridTransactNoSold.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridTransactNoSold.CurrentCell = cell;
                            dataGridTransactNoSold.Rows[cell.RowIndex].Selected = true;
                            found = true;
                            break; // Break out of inner loop once a match is found
                        }
                    }

                    if (found)
                    {
                        break; // Break out of outer loop if a match is found
                    }
                }

                if (!found)
                {
                    dataGridTransactNoSold.ClearSelection();
                }
            }
        }
        public void loadTransactGroup()
        {
            try
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                startDate.Format = DateTimePickerFormat.Custom;
                endDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "yyyy/MM/dd";
                endDate.CustomFormat = "yyyy/MM/dd";
                Boolean hasrecord = false;
                DateTime start = startDate.Value;
                DateTime end = endDate.Value;
                startDate.ShowUpDown = false;
                endDate.ShowUpDown = false;
                dataGridSoldReport.Rows.Clear();
                dataGridTransactNoSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransactNoSold.Rows.Add(i, dr["transacno"].ToString());
                    hasrecord = true;
                }
                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByMonth()
        {
            try
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                startDate.Format = DateTimePickerFormat.Custom;
                endDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "yyyy/MM";
                endDate.CustomFormat = "yyyy/MM";
                startDate.ShowUpDown = true; 
                endDate.ShowUpDown = true;
                Boolean hasrecord = false;
                DateTime start = new DateTime(startDate.Value.Year, startDate.Value.Month, 1);
                DateTime end = new DateTime(endDate.Value.Year, endDate.Value.Month, DateTime.DaysInMonth(endDate.Value.Year, endDate.Value.Month), 23, 59, 59);
                dataGridSoldReport.Rows.Clear();
                dataGridTransactNoSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransactNoSold.Rows.Add(i, dr["transacno"].ToString());
                    hasrecord = true;
                }
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                dr.Close();
                conn.Close();
                if(hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByWeek()
        {
            try
            {

                startDate.Enabled = false;
                endDate.Enabled = false;
                DateTime currentDate = DateTime.Now.Date;

                DateTime start = currentDate.AddDays(-6);

                DateTime end = currentDate.AddHours(23).AddMinutes(59).AddSeconds(59);

                Boolean hasrecord = false;


                dataGridSoldReport.Rows.Clear();
                dataGridTransactNoSold.Rows.Clear();
                int i = 0;

                conn.Open();
                cm = new SqlCommand("SELECT transacno FROM tblCart WHERE status = 'Sold' AND sdate BETWEEN @startdate AND @enddate GROUP BY transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@enddate", end);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridTransactNoSold.Rows.Add(i, dr["transacno"].ToString());
                    hasrecord = true;
                }

                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
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
                endDate.Enabled = true;
                startDate.Format = DateTimePickerFormat.Custom;
                endDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "yyyy";
                endDate.CustomFormat = "yyyy";
                startDate.ShowUpDown = true;
                endDate.ShowUpDown = true;
                Boolean hasrecord = false;
                DateTime start = new DateTime(startDate.Value.Year, 1, 1, 12,00,00);
                DateTime end = new DateTime(endDate.Value.Year, 12, DateTime.DaysInMonth(endDate.Value.Year, 12), 23, 59, 59);
                dataGridSoldReport.Rows.Clear();
                dataGridTransactNoSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransactNoSold.Rows.Add(i, dr["transacno"].ToString());
                    hasrecord = true;
                }
                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }


        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 0)
            {
                loadTransactGroup();
            }
            else if (filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeek();
            }
            else if (filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonth();
            }
            else
            {
                loadTransactGroupByYear();
            }
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 0)
            {
                loadTransactGroup();
            }
            else if (filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeek();
            }
            else if (filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonth();
            }
            else
            {
                loadTransactGroupByYear();
            }
        }

        private void dataGridTransactNoSold_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                string trans = dataGridTransactNoSold.Rows[e.RowIndex].Cells[1].Value.ToString();
                decimal totalSold = 0;
                decimal totalDiscount = 0;
                dataGridSoldReport.Rows.Clear();
                int i = 0;
                conn.Open();

                cm = new SqlCommand("select c.transacno, c.ItemName, c.price, c.qty, c.sdate, c.customerName, c.OrderType, c.status, c.total * (1 - COALESCE(d.discountPercent, 0) / 100) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno where c.status = 'Sold' and c.transacno = @trans", conn);
                cm.Parameters.AddWithValue("@trans", trans);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridSoldReport.Rows.Add(i, dr["transacno"].ToString(), dr["ItemName"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["qty"].ToString(), Convert.ToDecimal(dr["discounted_total"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["sdate"].ToString(), dr["customerName"].ToString(), dr["OrderType"].ToString());
                    decimal totalValue = Convert.ToDecimal(dr["discounted_total"]);
                    decimal price = Convert.ToDecimal(dr["price"]);
                    decimal qty = Convert.ToDecimal(dr["qty"]);
                    decimal total = qty * price;
                    totalDiscount += total - totalValue;
                    totalSold += totalValue;
                    dataGridSoldReport.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                dr.Close();
                conn.Close();
                lblTotalSold.Text = "₱" + totalSold.ToString("#,##0.00");
                lblDiscountAmount.Text = "₱" + totalDiscount.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void SalesReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                btnGenerateReport_Click(sender, e);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now.Date;

            DateTime start = currentDate.AddDays(-6);

            DateTime end = currentDate.AddHours(23).AddMinutes(59).AddSeconds(59);
            ReportsRDLC rdlc = new ReportsRDLC(this, land) ;

            if (filterBySold.SelectedIndex == 0)
            {
                rdlc.loadSalesReport("select c.transacno, c.ItemName, c.price, c.qty, c.sdate, c.customerName, c.OrderType, c.status, c.total * (1 - COALESCE(d.discountPercent, 0) / 100) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno where c.status = 'Sold' and sdate between @start and @end", "From: " + startDate.Value.ToString("yyyy/MM/dd ") + "|" + " To: " + endDate.Value.ToString("yyyy/MM/dd"), "CUSTOM DATE");
            }
            else if (filterBySold.SelectedIndex == 1)
            {
                rdlc.loadSalesReport("select c.transacno, c.ItemName, c.price, c.qty, c.sdate, c.customerName, c.OrderType, c.status, c.total * (1 - COALESCE(d.discountPercent, 0) / 100) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno where c.status = 'Sold' and sdate between @start and @end", "From: " + start.ToString("yyyy/MM/dd ") + "|" + " To: " + end.ToString("yyyy/MM/dd"), "WEEKLY SALES");
            }
            else if (filterBySold.SelectedIndex == 2)
            {
                rdlc.loadSalesReport("select c.transacno, c.ItemName, c.price, c.qty, c.sdate, c.customerName, c.OrderType, c.status, c.total * (1 - COALESCE(d.discountPercent, 0) / 100) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno where c.status = 'Sold' and sdate between @start and @end", "From: " + startDate.Value.ToString("yyyy/MM ") + "|" + " To: " + endDate.Value.ToString("yyyy/MM"), "MONTHLY SALES");
            }
            else
            {
                rdlc.loadSalesReport("select c.transacno, c.ItemName, c.price, c.qty, c.sdate, c.customerName, c.OrderType, c.status, c.total * (1 - COALESCE(d.discountPercent, 0) / 100) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno where c.status = 'Sold' and sdate between @start and @end", "From: " + startDate.Value.ToString("yyyy ") + "|" + " To: " + endDate.Value.ToString("yyyy"), "ANNUAL SALES");
            }
            rdlc.ShowDialog();
           
        }

        private void filterBySold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 0)
            {
               
                loadTransactGroup();
            }
            else if (filterBySold.SelectedIndex == 1)
            {
              
                loadTransactGroupByWeek();
            }
            else if (filterBySold.SelectedIndex == 2)
            {
                
                loadTransactGroupByMonth();
            }
            else
            {
                
                loadTransactGroupByYear();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            startDate.Format = DateTimePickerFormat.Custom;
            endDate.Format = DateTimePickerFormat.Custom;
            startDate.CustomFormat = "yyyy/MM/dd";
            endDate.CustomFormat = "yyyy/MM/dd";
            startDate.ShowUpDown = false;
            endDate.ShowUpDown = false;
            startDate.MaxDate = DateTime.Now;
            endDate.MaxDate = DateTime.Now;
            filterBySold.SelectedIndex = 0;
           
            loadTransactGroup();

        }
    }
}
