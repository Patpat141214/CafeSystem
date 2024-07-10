using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Admin
{
    public partial class TransactionHistory : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private readonly string search = "search transaction#";
        public TransactionHistory()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            txtSearch.Text = search;
            filterBySold.SelectedIndex = 0;
            filterByCashier.Text = "All Cashier";
            startDate.MaxDate = DateTime.Now;
            endDate.MaxDate = DateTime.Now;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridTransact.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridTransact.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridTransact.CurrentCell = cell;
                            dataGridTransact.Rows[cell.RowIndex].Selected = true;
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
                    dataGridTransact.ClearSelection();
                }
            }
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

        public void loadCashier()
        {
            filterByCashier.Items.Clear();
            filterByCashier.Items.Add("All Cashier");
            conn.Open();
            cm = new SqlCommand("select * from tblUser where role = 'Cashier'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                filterByCashier.Items.Add(dr["name"].ToString());
            }
            dr.Close();
            conn.Close();
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
                DateTime start = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day, 00, 00, 00); ;
                DateTime end = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day, 23, 59, 59);
                startDate.ShowUpDown = false;
                endDate.ShowUpDown = false;
                dataGridTransact.Rows.Clear();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());

                }
                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByCashier()
        {
            try
            {
                startDate.Enabled = true;
                endDate.Enabled = true;
                startDate.Format = DateTimePickerFormat.Custom;
                endDate.Format = DateTimePickerFormat.Custom;
                startDate.CustomFormat = "yyyy/MM/dd";
                endDate.CustomFormat = "yyyy/MM/dd";
                DateTime start = new DateTime(startDate.Value.Year, startDate.Value.Month, startDate.Value.Day, 00, 00, 00); ;
                DateTime end = new DateTime(endDate.Value.Year, endDate.Value.Month, endDate.Value.Day, 23, 59, 59);
                startDate.ShowUpDown = false;
                endDate.ShowUpDown = false;
                dataGridTransact.Rows.Clear();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and cashier like @cash and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("cash", filterByCashier.Text);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());

                }
                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";

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
                DateTime start = new DateTime(startDate.Value.Year, startDate.Value.Month, 1);
                DateTime end = new DateTime(endDate.Value.Year, endDate.Value.Month, DateTime.DaysInMonth(endDate.Value.Year, endDate.Value.Month), 23, 59, 59);
                dataGridTransact.Rows.Clear();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());
                }
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                dr.Close();
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByMonthCashier()
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
                DateTime start = new DateTime(startDate.Value.Year, startDate.Value.Month, 1);
                DateTime end = new DateTime(endDate.Value.Year, endDate.Value.Month, DateTime.DaysInMonth(endDate.Value.Year, endDate.Value.Month), 23, 59, 59);
                dataGridTransact.Rows.Clear();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and cashier like @cash and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("cash", filterByCashier.Text);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());
                }
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                dr.Close();
                conn.Close();

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


                dataGridSold.Rows.Clear();
                dataGridTransact.Rows.Clear();
                int i = 0;

                conn.Open();
                cm = new SqlCommand("SELECT transacno FROM tblCart WHERE status = 'Sold' AND sdate BETWEEN @startdate AND @enddate GROUP BY transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@enddate", end);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());
                }

                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByWeekCashier()
        {
            try
            {

                startDate.Enabled = false;
                endDate.Enabled = false;
                DateTime currentDate = DateTime.Now.Date;

                DateTime start = currentDate.AddDays(-6);

                DateTime end = currentDate.AddHours(23).AddMinutes(59).AddSeconds(59);


                dataGridSold.Rows.Clear();
                dataGridTransact.Rows.Clear();
                int i = 0;

                conn.Open();
                cm = new SqlCommand("SELECT transacno FROM tblCart WHERE status = 'Sold' and cashier like @cash AND sdate BETWEEN @startdate AND @enddate GROUP BY transacno", conn);
                cm.Parameters.AddWithValue("cash", filterByCashier.Text);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@enddate", end);
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());
                }

                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";

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
                DateTime start = new DateTime(startDate.Value.Year, 1, 1, 00, 00, 00);
                DateTime end = new DateTime(endDate.Value.Year, 12, DateTime.DaysInMonth(endDate.Value.Year, 12), 23, 59, 59);
                dataGridTransact.Rows.Clear();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", start); 
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());
                }
                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void loadTransactGroupByYearCashier()
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
                DateTime start = new DateTime(startDate.Value.Year, 1, 1, 00, 00, 00);
                DateTime end = new DateTime(endDate.Value.Year, 12, DateTime.DaysInMonth(endDate.Value.Year, 12), 23, 59, 59);
                dataGridTransact.Rows.Clear();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and cashier like @cash and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("cash", filterByCashier.Text);
                cm.Parameters.AddWithValue("@startdate", start);
                cm.Parameters.AddWithValue("@endate", end);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridTransact.Rows.Add(i, dr["transacno"].ToString());
                }
                dr.Close();
                conn.Close();
                lblDiscountAmount.Text = "₱0.00";
                lblTotalSold.Text = "₱0.00";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void dataGridTransact_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                string trans = dataGridTransact.Rows[e.RowIndex].Cells[1].Value.ToString();
                decimal totalSold = 0;
                decimal totalDiscount = 0;
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();

                cm = new SqlCommand("select c.transacno, c.ItemName, c.price, c.qty, c.sdate, c.customerName, c.OrderType, c.status, c.total * (1 - COALESCE(d.discountPercent, 0) / 100) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno where c.status = 'Sold' and c.transacno = @trans", conn);
                cm.Parameters.AddWithValue("@trans", trans);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridSold.Rows.Add(i, dr["transacno"].ToString(), dr["ItemName"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["qty"].ToString(), Convert.ToDecimal(dr["discounted_total"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["sdate"].ToString(), dr["customerName"].ToString(), dr["OrderType"].ToString());
                    decimal totalValue = Convert.ToDecimal(dr["discounted_total"]);
                    decimal price = Convert.ToDecimal(dr["price"]);
                    decimal qty = Convert.ToDecimal(dr["qty"]);
                    decimal total = qty * price;
                    totalDiscount += total - totalValue;
                    totalSold += totalValue;
                    dataGridSold.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

        private void filterBySold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroup();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeek();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonth();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYear();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroupByCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeekCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonthCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYearCashier();
            }
        }

        private void filterByCashier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroup();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeek();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonth();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYear();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroupByCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeekCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonthCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYearCashier();
            }
        }

        private void startDate_ValueChanged(object sender, EventArgs e)
        {
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroup();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeek();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonth();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYear();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroupByCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeekCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonthCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYearCashier();
            }
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroup();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeek();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonth();
            }
            if (filterByCashier.Text == "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYear();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 0)
            {
                loadTransactGroupByCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 1)
            {
                loadTransactGroupByWeekCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 2)
            {
                loadTransactGroupByMonthCashier();
            }
            if (filterByCashier.Text != "All Cashier" && filterBySold.SelectedIndex == 3)
            {
                loadTransactGroupByYearCashier();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridTransact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string column = dataGridTransact.Columns[e.ColumnIndex].Name;
        }
    }
}
