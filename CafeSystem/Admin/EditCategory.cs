using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CafeSystem.Admin
{
    public partial class EditCategory : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        string origCat;
        CategoriesList list;
        ProductsForm prd;
        LandingPage land;
        public EditCategory(string cat, CategoriesList list1, ProductsForm prd1, LandingPage land1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            origCat = cat;
            list = list1;
            prd = prd1;
            this.KeyPreview = true;
            land = land1;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtCat.Text = origCat;
            txtCat.Focus();
        }

        private void EditCategory_Shown(object sender, EventArgs e)
        {
            txtCat.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCat.Text))
                {
                    MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCat.Focus();
                    return;
                }
                if (txtCat.Text == origCat) {
                    MessageBox.Show("No Changes!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCat.Focus();
                    return;
                }
                if (MessageBox.Show("Do you want to update the Category?", "Update Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("SELECT COUNT (*) from tblCategory where category = @cat", conn);
                    cm.Parameters.AddWithValue("@cat", txtCat.Text.Trim());
                    int count = (int)cm.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("This Category is already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        txtCat.Focus();
                        return;
                    }
                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Updated Category");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", "Category: " + origCat + "\n" + "Updated Category: " + txtCat.Text.Trim());
                    cm.Parameters.AddWithValue("@delete_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();



                  cm = new SqlCommand("UPDATE tblCategory set category = @cat where id = @id", conn);
                  cm.Parameters.AddWithValue("@cat", txtCat.Text.Trim());
                  cm.Parameters.AddWithValue("@id", txtId.Text);
                  cm.ExecuteNonQuery();
                  conn.Close();                   
                  MessageBox.Show("Category successfully Updated!", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  list.LoadCategories();
                  prd.LoadProducts();
                    this.Dispose();
                }
                txtCat.Focus();

              
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void EditCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnUpdate_Click(sender, e);
            }
        }
    }
}
