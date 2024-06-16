using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CafeSystem.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CafeSystem
{
    public partial class AddProduct : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ProductsForm frm;
        LandingPage land;

        public AddProduct(ProductsForm frm1, LandingPage land1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.Shown += AddProduct_Shown;
            frm = frm1;
            this.KeyPreview = true;
            land = land1;
        }
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";

            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image
                    importImage.BackgroundImage = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that might occur during loading
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtDesc.Text) || (string.IsNullOrWhiteSpace(txtCat.Text) || (txtPrice.Text == "₱0.00")))
                {
                    MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesc.Focus();
                    return;
                }
                if (importImage.BackgroundImage == null)
                {
                    MessageBox.Show("Please select an image", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesc.Focus();
                    return;
                }
                MemoryStream ms = new MemoryStream();
                importImage.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrimage = ms.GetBuffer();        

                if (MessageBox.Show("Do you want to save this Product?", "Add Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("SELECT COUNT (*) from tblProduct where description = @desc", conn);
                    cm.Parameters.AddWithValue("@desc", txtDesc.Text.Trim());
                    int count = (int)cm.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This Product is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);          
                        conn.Close();
                        txtDesc.Focus();
                        return;
                    }

                    string catid = "";
                    cm = new SqlCommand("Select id from tblCategory where category like '" + txtCat.Text + "'", conn);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        catid = dr[0].ToString();
                    }
                    dr.Close();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Added Product");
                    if (checkboxAv.Checked)
                    {
                        cm.Parameters.AddWithValue("@add_data", "Item: " + txtDesc.Text.Trim() + "\n" + "Category: " + txtCat.Text + "\n" + "Price: " + txtPrice.Text.Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + "Available");
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@add_data", "Item: " + txtDesc.Text.Trim() + "\n" + "Category: " + txtCat.Text + "\n" + "Price: " + txtPrice.Text.Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + "Not Available");
                    }
                    
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblProduct(description, catid, price, image, status, AvailOrNot)values(@description, @catid, @price, @image, @status, @AvailOrNot)", conn);
                    cm.Parameters.AddWithValue("@description", txtDesc.Text.Trim());
                    cm.Parameters.AddWithValue("@catid", catid);
                    cm.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Replace("₱", "").Replace(",", "").Trim()));
                    cm.Parameters.AddWithValue("@image", arrimage);
                    if(checkboxAv.Checked)
                    {
                        cm.Parameters.AddWithValue("@AvailOrNot", "Available");
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@AvailOrNot", "Not Available");
                    }
                    cm.Parameters.AddWithValue("@status", "Active");
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product successfully save!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                    txtDesc.Focus();
                    frm.LoadProducts();


                }
                txtDesc.Focus();

               
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddProduct_Shown(object sender, EventArgs e)
        {
            txtDesc.Focus();
            txtPrice.Text = "₱0.00";

        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            int cursorPosition = txtPrice.SelectionStart;

            // Remove currency symbol, commas, and whitespace
            string priceText = txtPrice.Text.Replace("₱", "").Replace(",", "").Trim();

            // Check if the text can be parsed as a decimal
            decimal price;
            if (decimal.TryParse(priceText, out price))
            {
                // Format the price with a comma separator for thousands
                string formattedPrice = "₱" + price.ToString("#,##0.00");

                // Check if ".00" is present at the end, if not, append it
                if (!formattedPrice.EndsWith(".00"))
                {
                    formattedPrice += "₱0.00";
                }

                // Update the textbox text
                txtPrice.TextChanged -= txtPrice_TextChanged;
                txtPrice.Text = formattedPrice;
                txtPrice.TextChanged += txtPrice_TextChanged;

                // Restore the cursor position after formatting
                txtPrice.SelectionStart = Math.Min(cursorPosition, txtPrice.Text.Length);
            }
            else
            {
                // If the parsing fails, set the text to "₱0.00" and place the cursor at the end
                txtPrice.Text = "₱0.00";
                txtPrice.SelectionStart = txtPrice.Text.Length;
            }
        }

        private void ClearAll()
        {
            txtPrice.Clear();
            txtDesc.Clear();
            txtCat.Text = null;
            importImage.BackgroundImage = null;
            txtPrice.Text = "₱0.00";
            txtDesc.Focus();
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {
            ClearAll();

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            txtPrice.Text = "₱0.00";
            txtCat.Items.Clear();
            conn.Open();
            cm = new SqlCommand("Select category from tblCategory where status = 'Active'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                txtCat.Items.Add(dr["category"].ToString());

            }
            dr.Close();
            conn.Close();
        }

        private void AddProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
