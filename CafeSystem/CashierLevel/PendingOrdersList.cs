using Guna.UI.WinForms;
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
    public partial class PendingOrdersList : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Cashier cash;
        private readonly string search = "search here";

        public PendingOrdersList(Cashier cash1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            cash = cash1;
            dataGridPending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            txtSearch.Text = "search here";
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        public void LoadPendingOrders()
        {
            try
            {
                dataGridPending.Rows.Clear();
                conn.Open();
                int i = 0;
                cm = new SqlCommand("select MAX(id) as id, MAX(transacno) as transacno, MAX(customerName) as customerName, MAX(OrderType) as OrderType from tblCart where status = 'Pending' group by transacno", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridPending.Rows.Add(i, dr["id"].ToString(), dr["transacno"].ToString(), dr["customerName"].ToString(), dr["OrderType"].ToString());
                    dataGridPending.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                conn.Close();
                dr.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
         
        }

        private void dataGridPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            try
            {
                string column = dataGridPending.Columns[e.ColumnIndex].Name;
                if (column == "Delete")
                {
                    if (MessageBox.Show("Do you want to remove this pending orders?", "Remove pending orders?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cm = new SqlCommand("Delete from tblCart where transacno = @transac and status = 'Pending'", conn);
                        cm.Parameters.AddWithValue("@transac", dataGridPending.Rows[e.RowIndex].Cells[2].Value.ToString());
                        cm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Item successfully removed!", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cash.LoadDataToGrid();
                        LoadPendingOrders();
                        cash.getTrans();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
           
        }

        private void dataGridPending_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (cash.lblDiscountPercent.Visible == true)
            {
                MessageBox.Show("Remove the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string idCart = dataGridPending.Rows[e.RowIndex].Cells[1].Value.ToString();
            string transacno = dataGridPending.Rows[e.RowIndex].Cells[2].Value.ToString();
            string customerName = dataGridPending.Rows[e.RowIndex].Cells[3].Value.ToString();
            string OrderType = dataGridPending.Rows[e.RowIndex].Cells[4].Value.ToString();

            try
            {

                Boolean hasrow = false;
                cash.dataGridCart.Rows.Clear();
                int i = 0;
                decimal total = 0;
                conn.Open();
                cm = new SqlCommand("select * from tblCart where transacno = @trans and status = 'Pending'", conn);
                cm.Parameters.AddWithValue("@trans", transacno);
                dr = cm.ExecuteReader();
                while(dr.Read())
                {
                    i++;
                    decimal totalValue = Convert.ToDecimal(dr["total"]);
                    total += totalValue;
                    cash.dataGridCart.Rows.Add(i, dr["id"].ToString(), dr["ItemName"].ToString(), dr["qty"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), Convert.ToDecimal(dr["total"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")));
                    hasrow = true;
                    cash.txtCustomerName.Text = customerName;
                    cash.txtOrderType.Text = OrderType;
                    cash.lblTransu.Text = transacno;
                }
                conn.Close();
                dr.Close();
                cash.lblTotalAmount.Text = "₱" + total.ToString("#,##0.00");
                cash.lblTotalAmount1.Text = "₱" + total.ToString("#,##0.00");
                if (hasrow)
                {
                    cash.btnClearCart.Enabled = true;
                    cash.txtCustomerName.Enabled = false;
                    cash.txtOrderType.Enabled = false;
                    cash.btnPayment.Enabled = true;
                    cash.btnApplyDiscount.Enabled = true;
                    cash.btnRemoveDiscount.Enabled = true;
                    cash.btnMovePending .Enabled = true;
                }
                else
                {
                    cash.btnClearCart.Enabled = false;
                    cash.txtCustomerName.Enabled = true;
                    cash.txtOrderType.Enabled = true;
                    cash.lblDiscountedTotal.Visible = false;
                    cash.lblDiscountAmount.Visible = false;
                    cash.lblDiscountPercent.Visible = false;
                    cash.btnPayment.Enabled = false;
                    cash.btnApplyDiscount.Enabled = false;
                    cash.btnRemoveDiscount.Enabled = false;
                    cash.btnMovePending.Enabled = false;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridPending.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridPending.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridPending.CurrentCell = cell;
                            dataGridPending.Rows[cell.RowIndex].Selected = true;
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
                    dataGridPending.ClearSelection();
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
    }
}
