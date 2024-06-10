using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Admin
{
    public partial class ManageDiscount : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        decimal disPer;
        public ManageDiscount(decimal disPer1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            disPer = disPer1;
            this.Shown += ManageDiscount_Shown;
            this.KeyPreview = true;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPercentage_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtPercentage.Text = disPer.ToString() + "%";
            txtPercentage.Focus();
        }

        private void ManageDiscount_Shown(object sender, EventArgs e)
        {
            txtPercentage.Focus();
        }

        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtPercentage.SelectionStart;

            // Remove currency symbol, commas, and whitespace
            string percentText = txtPercentage.Text.Replace("%", "").Replace(",", "").Trim();

            // Check if the text can be parsed as a decimal
            decimal percent;
            if (decimal.TryParse(percentText, out percent))
            {
                // Format the percentage with two decimal places and append "%" at the end
                string formattedPercent = percent.ToString("#0.00") + "%";

                // Update the textbox text
                txtPercentage.TextChanged -= txtPercentage_TextChanged;
                txtPercentage.Text = formattedPercent;
                txtPercentage.TextChanged += txtPercentage_TextChanged;

                // Restore the cursor position after formatting
                txtPercentage.SelectionStart = Math.Min(cursorPosition, txtPercentage.Text.Length);
            }
            else
            {
                // If the parsing fails, set the text to "0.00%" and place the cursor at the end
                txtPercentage.Text = "0.00%";
                txtPercentage.SelectionStart = txtPercentage.Text.Length;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPercentage.Text)) 
                {
                    MessageBox.Show("Input Discount", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPercentage.Focus();
                    return;
                }
                if (txtPercentage.Text == "0%")
                {
                    MessageBox.Show("Cannot set the discount to 0%. Please disable the discount instead.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPercentage.Focus();
                    return;
                }
                string status = "";
                conn.Open();
                cm = new SqlCommand("select _status from tblDiscount where id = 1", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    status = dr["_status"].ToString();
                }
                conn.Close();
                dr.Close();

                if (status == "Deactivated")
                {
                    MessageBox.Show("Enable the discount first!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Do you want to update this Discount?", "Update Discount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("UPDATE tblDiscount set _discountPercent = @discount where id = 1", conn);
                    cm.Parameters.AddWithValue("@discount", decimal.Parse(txtPercentage.Text.Replace("%", "").Replace(",", "").Trim()));
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Discount successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
            }
            catch (Exception ex) { 
              conn.Close();
              MessageBox.Show(ex.Message);
            }
        }

      

        private void btnDisable_Click_1(object sender, EventArgs e)
        {
            try
            {
                    string status = "";
                    conn.Open();
                    cm = new SqlCommand("select _status from tblDiscount where id = 1", conn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        status = dr["_status"].ToString();
                    }
                    conn.Close();
                    dr.Close();

                    if(status == "Deactivated")
                    {
                        MessageBox.Show("Discount already deactivated!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPercentage.Focus();
                        return;
                    }

                if (MessageBox.Show("Do you want to disable this Discount?", "Disable Discount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("UPDATE tblDiscount set _status = 'Deactivated' where id = 1", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Discount successfully disabled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                txtPercentage.Focus();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            try
            {               
                    string status = "";
                    conn.Open();
                    cm = new SqlCommand("select _status from tblDiscount where id = 1", conn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        status = dr["_status"].ToString();
                    }
                    conn.Close();
                    dr.Close();

                    if (status == "Active")
                    {
                        MessageBox.Show("Discount already active!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPercentage.Focus();
                        return;
                    }
                if (MessageBox.Show("Do you want to enable this Discount?", "Enable Discount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("UPDATE tblDiscount set _status = 'Active' where id = 1", conn);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Discount successfully enabled!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                }
                txtPercentage.Focus();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void ManageDiscount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
