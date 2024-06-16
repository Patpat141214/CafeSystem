using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CafeSystem.Admin
{
    public partial class EditProduct : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ProductsForm frm;
        LandingPage land;
    
        string originalCat;
        string originalDesc;
        string originalPrice;
        string originalAvailability;
        byte[] originalImageData;
        private bool isNewImageSelected = false;


        public EditProduct(string cat, string desc, string price, ProductsForm frm1, byte[] img, LandingPage land1, string originalavail)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            originalCat = cat;
            originalDesc = desc;
            originalPrice = price;
            frm = frm1;
            originalImageData = img;
            this.KeyPreview = true;
            land = land1;
            originalAvailability = originalavail;
        }



        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
            openFileDialog1.Title = "Select Image";
            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image
                    editImage.Image = Image.FromFile(openFileDialog1.FileName);
                    isNewImageSelected = true;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that might occur during loading
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        public void LoadCat()
        {
            try
            {
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtDesc.Text) || (string.IsNullOrWhiteSpace(txtPrice.Text) || (txtPrice.Text == "₱0.00")))
                {
                    MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDesc.Focus();
                    return;
                }
                if (editImage.Image == null)
                {
                    MessageBox.Show("Please select an image.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                byte[] arrimage = originalImageData; // Use original image data by default.

                if (isNewImageSelected)
                {
                    // Logic to convert the new image in the PictureBox to a byte array
                    using (MemoryStream ms = new MemoryStream())
                    {
                        editImage.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        arrimage = ms.ToArray(); // arrimage should be saved to the database
                    }
                }

                if (MessageBox.Show("Do you want to update the product?", "Update Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
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
                    cm.Parameters.AddWithValue("@action", "Updated Product");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    if (checkboxAv.Checked)
                    {
                        cm.Parameters.AddWithValue("@update_data", "Old Product" + "\n" + "Item: " + originalDesc + "\n" + "Category: " + originalCat + "\n" + "Price: " + originalPrice.Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + originalAvailability + "\n" + "Updated Product" + "\n" + "Item: " + txtDesc.Text.Trim() + "\n" + "Category: " + txtCat.Text + "\n" + "Price: " + txtPrice.Text.Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + "Available");
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@update_data", "Old Product" + "\n" + "Item: " + originalDesc + "\n" + "Category: " + originalCat + "\n" + "Price: " + originalPrice.Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + originalAvailability + "\n" + "Updated Product" + "\n" + "Item: " + txtDesc.Text.Trim() + "\n" + "Category: " + txtCat.Text + "\n" + "Price: " + txtPrice.Text.Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + "Not Available");
                    }
                    
                    cm.Parameters.AddWithValue("@delete_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("UPDATE tblProduct set description = @des, catid = @catid, price = @price, AvailOrNot = @avail, image = @img where id = @id", conn);
                    cm.Parameters.AddWithValue("@des", txtDesc.Text.Trim());
                    cm.Parameters.AddWithValue("@catid", catid);
                    cm.Parameters.AddWithValue("@price", decimal.Parse(txtPrice.Text.Replace("₱", "").Replace(",", "").Trim()));
                    cm.Parameters.AddWithValue("@img", arrimage);
                    cm.Parameters.AddWithValue("@id", txtId.Text);
                    if (checkboxAv.Checked)
                    {
                        cm.Parameters.AddWithValue("@avail", "Available");
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@avail", "Not Available");
                    }
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Product successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frm.LoadProducts();
                }
                txtDesc.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
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

        private void btnReturn_Click(object sender, EventArgs e)
        {
            txtDesc.Focus();
            txtCat.Text = originalCat;
            txtDesc.Text = originalDesc;
            txtPrice.Text = originalPrice;
            using (MemoryStream ms = new MemoryStream(originalImageData))
            {
                Image originalImage = Image.FromStream(ms);
                // Create a deep copy of the image to avoid GDI+ error.
                editImage.Image = new Bitmap(originalImage);
                originalImage.Dispose(); // Dispose of the original image after copying it.
            }

            // Since we're reverting to the original image, ensure the flag reflects this state.
            isNewImageSelected = false;

        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
  
        private void EditProduct_Shown(object sender, EventArgs e)
        {
            txtDesc.Focus();
        }

        private void editImage_ImageChanged(object sender, EventArgs e)
        {
            isNewImageSelected = true;
        }

        private void EditProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(sender, e);
            }
        }
    }
}
