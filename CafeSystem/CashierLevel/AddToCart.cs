using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem
{
    public partial class AddToCart : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private decimal price;
        Cashier frm;
        public AddToCart(decimal _price, Cashier frm1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.Shown += AddToCart_Shown;
            txtQty.Text = "1";
            price = _price;
            txtPrice.Text = price.ToString("c", CultureInfo.GetCultureInfo("en-PH"));
            txtQty_TextChanged(txtQty, EventArgs.Empty);
            frm = frm1;
            this.KeyPreview = true;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    MessageBox.Show("Input Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }
                if (int.Parse(txtQty.Text) == 0)
                {
                    MessageBox.Show("0 Quantity is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Text = "1";
                    txtQty.Focus();
                    return;
                }
                String id = "";
                int cartqty = 0;
                bool found = false;
                conn.Open();
                cm = new SqlCommand("select * from tblCart where transacno = @transacno and pid = @pid", conn);
                cm.Parameters.AddWithValue("@transacno", frm.lblTransu.Text);
                cm.Parameters.AddWithValue("@pid", lblPid.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    id = (dr["id"].ToString());
                    cartqty = int.Parse(dr["qty"].ToString());
                }
                else
                {
                    found = false;
                }
                dr.Close();
                conn.Close();

                if (found == true)
                {
 
                    conn.Open();
                    int newQty = int.Parse(txtQty.Text) + cartqty;
                    decimal newTotal = newQty * price; // Calculate the new total

                    cm = new SqlCommand("update tblCart set qty = @newQty, total = @newTotal where id = @id", conn);
                    cm.Parameters.AddWithValue("@newQty", newQty);
                    cm.Parameters.AddWithValue("@newTotal", newTotal);
                    cm.Parameters.AddWithValue("@id", id);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    frm.LoadDataToGrid();
                    this.Dispose();

                }
                else
                {
                    conn.Open();
                    cm = new SqlCommand("Insert Into tblCart(transacno, pid, price, qty, total, sdate, status, ItemName, OrderType, customerName, cashier)values(@transacno, @pid, @price, @qty, @total, @sdate, @status, @ItemName, @OrderType, @customerName, @cashier)", conn);
                    cm.Parameters.AddWithValue("@transacno", frm.lblTransu.Text);
                    cm.Parameters.AddWithValue("@pid", lblPid.Text);
                    cm.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Replace("₱", "").Replace(",", "").Trim()));
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    cm.Parameters.AddWithValue("@total", decimal.Parse(txtTotal.Text.Replace("₱", "").Replace(",", "").Trim()));
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.Parameters.AddWithValue("@status", "Pending");
                    cm.Parameters.AddWithValue("@ItemName", txtItem.Text);
                    cm.Parameters.AddWithValue("@OrderType", frm.txtOrderType.Text);
                    cm.Parameters.AddWithValue("@customerName", frm.txtCustomerName.Text);
                    cm.Parameters.AddWithValue("@cashier", frm.txtName.Text) ;
                    cm.ExecuteNonQuery();
                    conn.Close();
                    frm.LoadDataToGrid();
                    this.Close();
                }
               
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                    e.Handled = true;
            }
        }

        private void AddToCart_Shown(object sender, EventArgs e)
        {
            txtQty.Focus();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            int qty;
            if (int.TryParse(txtQty.Text, out qty))
            {

                decimal total = price * qty;
                txtTotal.Text = total.ToString("c", CultureInfo.GetCultureInfo("en-PH"));
            }
            else
            {
                txtTotal.Text = "₱0.00";
            }
        }

        private void AddToCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
