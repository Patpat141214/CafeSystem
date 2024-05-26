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
    public partial class EditQtyCart : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        Cashier frm;
        public EditQtyCart(Cashier frm1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.Shown += EditQtyCart_Shown;
            this.KeyPreview = true;
            frm = frm1;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtQty.Text))
                {
                    MessageBox.Show("Input Quantity!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }
                if(int.Parse(txtQty.Text) == 0)
                {
                    MessageBox.Show("0 Quantity is Invalid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQty.Focus();
                    return;
                }
                conn.Open();
                cm = new SqlCommand("UPDATE tblCart set qty = @qty, total = @total where id = @id and transacno = @transacno", conn);
                cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                cm.Parameters.AddWithValue("@total", decimal.Parse(txtTotal.Text.Replace("₱", "").Replace(",", "").Trim()));
                cm.Parameters.AddWithValue("@id", int.Parse(lblCartId.Text));
                cm.Parameters.AddWithValue("@transacno", frm.lblTransu.Text);
                cm.ExecuteNonQuery();             
                conn.Close();
                frm.LoadDataToGrid();
                this.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void EditQtyCart_Shown(object sender, EventArgs e)
        {
            txtQty.Focus();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            decimal parsedDecimal;
            decimal.TryParse(txtPrice.Text, NumberStyles.Currency, CultureInfo.GetCultureInfo("en-PH"), out parsedDecimal);
            int qty;
            if (int.TryParse(txtQty.Text, out qty))
            {

                decimal total = parsedDecimal * qty;
                txtTotal.Text = total.ToString("c", CultureInfo.GetCultureInfo("en-PH"));

            }
            else
            {
                txtTotal.Text = "₱0.00";
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        { 
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }           
        }

        private void EditQtyCart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(sender, e);
            }
        }
    }
}
