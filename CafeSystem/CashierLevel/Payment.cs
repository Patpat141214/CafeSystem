using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.CashierLevel
{
    public partial class Payment : Form
    {

        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        Cashier cashier;
        
        public Payment(Cashier cash1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.Shown += Payment_Shown;
            cashier = cash1;
            this.KeyPreview = true;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Payment_Shown(object sender, EventArgs e)
        {           
           txtCash.Text = "₱0.00";
            txtCash.Focus();
            
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal sale, cash;

                string saleText = txtTotal.Text.Replace("₱", "").Replace(",", "").Trim();
                string cashText = txtCash.Text.Replace("₱", "").Replace(",", "").Trim();

                if (decimal.TryParse(saleText, out sale) && decimal.TryParse(cashText, out cash))
                {
                    decimal change = cash - sale;
                    txtChange.Text = "₱" + change.ToString("#,##0.00");

                    // Save cursor position before formatting
                    int cursorPosition = txtCash.SelectionStart;

                    // Format the cash amount with a peso sign, comma separator for thousands, and two decimal places
                    txtCash.TextChanged -= txtCash_TextChanged;
                    txtCash.Text = "₱" + cash.ToString("#,##0.00");
                    txtCash.TextChanged += txtCash_TextChanged;

                    // Restore the cursor position after formatting
                    txtCash.SelectionStart = Math.Min(cursorPosition, txtCash.Text.Length);
                }
                else
                {
                    txtChange.Text = "₱0.00";

                    // If parsing fails, set the text to "₱0.00" and place the cursor at the end
                    txtCash.TextChanged -= txtCash_TextChanged;
                    txtCash.Text = "₱0.00";
                    txtCash.TextChanged += txtCash_TextChanged;
                    txtCash.SelectionStart = txtCash.Text.Length;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);              
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtCash.Text = "₱0.00";
            txtCash.Focus();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            try
            {
                string changeText = txtChange.Text.Replace("₱", "").Replace(",", "").Trim();
                string cashText = txtCash.Text.Replace("₱", "").Replace(",", "").Trim();
                decimal change, cash; 
               if(string.IsNullOrWhiteSpace(txtCash.Text))
                {
                    MessageBox.Show("Input Cash", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCash.Focus();
                    return;
                }
                if (decimal.TryParse(changeText, out change) && decimal.TryParse(cashText, out cash) && (change < 0 || cash == 0))
                {
                    MessageBox.Show("Insufficient cash amount. Please enter the correct amount!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCash.Focus();
                    return;
                }
                if (MessageBox.Show("Proceed Payment?", "Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < cashier.dataGridCart.Rows.Count; i++)
                    {
                        conn.Open();
                        cm = new SqlCommand("update tblCart set status = 'Sold', disPer = @_disPer, sdate = CURRENT_TIMESTAMP, cashier = @cashier where id = @id", conn);
                        cm.Parameters.AddWithValue("@id", cashier.dataGridCart.Rows[i].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@cashier", cashier.txtName.Text);
                        cm.Parameters.AddWithValue("@_disPer", decimal.Parse(txtPercent.Text.Replace("%", "").Replace(",", "").Trim()));
                        cm.ExecuteNonQuery();
                        conn.Close();
                    }
                    if (cashier.lblDiscountPercent.Visible == true) // Check if discount is applied
                    {
                        string transactno = cashier.lblTransu.Text; // Replace this with the variable storing the transaction number
                        decimal discountPercentage = decimal.Parse(cashier.lblDiscountPercent.Text.Replace("%", ""));
                        decimal totalAmount = decimal.Parse(cashier.lblDiscountedTotal.Text.Replace("₱", "").Replace(",", ""));
                        decimal discountedAmount = (decimal)(totalAmount * (discountPercentage / 100));

                        conn.Open();
                        cm = new SqlCommand("INSERT INTO tblDiscountCart (transacno, discountPercent, discountAmount, dateApplied) VALUES (@transactno, @discount, @discounted_amount, CURRENT_TIMESTAMP)", conn);
                        cm.Parameters.AddWithValue("@transactno", transactno);
                        cm.Parameters.AddWithValue("@discount", discountPercentage);
                        cm.Parameters.AddWithValue("@discounted_amount", discountedAmount);
                        cm.ExecuteNonQuery();
                        conn.Close();
                        


                    }


                    ReceiptPayment rec = new ReceiptPayment(cashier);
                    rec.loadReport(txtCash.Text, txtChange.Text);
                    rec.ShowDialog();

                    cashier.getTrans();
                    cashier.LoadDataToGrid();
                    cashier.getTrans();
                    MessageBox.Show("Payment success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    cashier.txtCustomerName.Clear();
                    cashier.txtCustomerName.Focus();

  


                }
                txtCash.Focus();
                        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
          }
        }

        private void Payment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnProceed_Click(sender, e);    
            }
        }

 
    }
}
