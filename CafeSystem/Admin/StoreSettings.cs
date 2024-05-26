using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;


namespace CafeSystem.Admin
{
    public partial class StoreSettings : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        string origShopName;
        string origAddress;
        byte[] storeImageData1;
        private bool isNewImageSelected = false;
        LandingPage land;
        public StoreSettings(string origShopName1, string origAddress1, byte[] storeImageData, LandingPage land)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            origShopName = origShopName1;
            origAddress = origAddress1;
            txtAddress.Text = origAddress;
            txtShopName.Text = origShopName;
            storeImageData1 = storeImageData;
            callImage();
            this.land = land;
        }

        private void callImage()
        {
            if (storeImageData1 != null)
            {
                using (MemoryStream ms = new MemoryStream(storeImageData1))
                {
                    storePicture.Image = Image.FromStream(ms);
                }
            }
        }
     

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtAddress.Text = origAddress;
            txtShopName.Text = origShopName;
            txtShopName.Focus();
            callImage();
        }

        private void StoreSettings_Shown(object sender, EventArgs e)
        {
            txtShopName.Focus();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtShopName.Text))
            {
               MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShopName.Focus();
                return;
            }
            try
               
            {
                if (MessageBox.Show("Do you want to update your store information?", "Update store information?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    byte[] arrimage = storeImageData1; // Use original image data by default.

                    if (isNewImageSelected)
                    {
                        // Logic to convert the new image in the PictureBox to a byte array
                        using (MemoryStream ms = new MemoryStream())
                        {
                            storePicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            arrimage = ms.ToArray(); // arrimage should be saved to the database
                        }
                    }
                   
                    conn.Open();
                    cm = new SqlCommand("UPDATE tblStoreInfo set storeName = @store, address = @add, image = @image where id = 1", conn);
                    cm.Parameters.AddWithValue("@store", txtShopName.Text.Trim());
                    cm.Parameters.AddWithValue("@add", txtAddress.Text.Trim());
                    cm.Parameters.AddWithValue("@image", arrimage);
                    cm.ExecuteNonQuery();
                    conn.Close();                    
                    MessageBox.Show("Store information successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    land.retrieveImage();
                }
                  

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void storePicture_Click(object sender, EventArgs e)
        {
           
        }

        private void editImage_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.png;*.jpg;*.gif)|*.png;*.jpg;*.gif";
            openFileDialog1.Title = "Select Image";
            // Show the dialog and check if the user clicked OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Load the selected image
                    storePicture.Image = Image.FromFile(openFileDialog1.FileName);
                    isNewImageSelected = true;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that might occur during loading
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }
    }
}
