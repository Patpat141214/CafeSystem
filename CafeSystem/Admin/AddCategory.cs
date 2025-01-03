﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CafeSystem.Admin
{
    public partial class AddCategory : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        CategoriesList cat;
        LandingPage land;
        public AddCategory(CategoriesList cat1, LandingPage land1)
        {          
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            cat = cat1;
            this.Shown += AddCategory_Shown;
            land = land1;
        }

        private void txtCat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtCat.Text))
                {
                    MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCat.Focus();
                    return;
                    
                }
                if (MessageBox.Show("Do you want to save this category?", "Add Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                    cm.Parameters.AddWithValue("@action", "Added Category");
                    cm.Parameters.AddWithValue("@add_data", "Category: " + txtCat.Text.Trim());
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();               


                    cm = new SqlCommand("INSERT INTO tblCategory (category, status) values (@cat, @status)", conn);
                    cm.Parameters.AddWithValue("@cat", txtCat.Text.Trim());
                    cm.Parameters.AddWithValue("@status", "Active");
                    cm.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Category successfully save!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cat.LoadCategories();
                    txtCat.Focus();
                    txtCat.Clear();
                }
                txtCat.Focus();

            }catch (Exception ex) {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void AddCategory_Shown(object sender, EventArgs e)
        {
            txtCat.Focus();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtCat.Clear();
            txtCat.Focus();
            
        }
    }
}
