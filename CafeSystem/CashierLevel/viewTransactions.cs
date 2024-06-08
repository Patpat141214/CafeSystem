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

namespace CafeSystem.CashierLevel
{
    public partial class viewTransactions : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private readonly string search = "search transaction#";
        public viewTransactions()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            txtSearch.Text = "search transaction#";
            dataGridSold.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridSold.BorderStyle = BorderStyle.FixedSingle;
            dataGridTransactNo.BorderStyle = BorderStyle.FixedSingle; 

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void loadTransactGroup()
        {
            try
            {
                DateTime date = DateTime.Today;
                DateTime date1 = new DateTime(date.Year, date.Month, date.Day, 23, 59, 59);
                dataGridTransactNo.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select transacno from tblCart where status = 'Sold' and sdate between @startdate and @endate group by transacno", conn);
                cm.Parameters.AddWithValue("@startdate", date.ToString());
                cm.Parameters.AddWithValue("@endate", date1.ToString());
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    dataGridTransactNo.Rows.Add(i, dr["transacno"].ToString());
                }
                dr.Close();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridTransactNo.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridTransactNo.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridTransactNo.CurrentCell = cell;
                            dataGridTransactNo.Rows[cell.RowIndex].Selected = true;
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
                    dataGridTransactNo.ClearSelection();
                }
            }
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == search)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = search;
            txtSearch.ForeColor = Color.Black;
        }

        private void dataGridTransactNo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            try
            {
                decimal totalSold = 0;
                decimal totalDiscount = 0;
                string trans = dataGridTransactNo.Rows[e.RowIndex].Cells[1].Value.ToString();
                dataGridSold.Rows.Clear();
                int i = 0;
                conn.Open();
                //cm = new SqlCommand("select * from tblCart where status = 'Sold' and transacno = @trans", conn);
                //cm.Parameters.AddWithValue("@trans", trans);
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

    }
}
