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

namespace CafeSystem.Admin
{
    public partial class CategoriesList : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ProductsForm prd;
        private string search = "Search here";
        LandingPage land;
        public CategoriesList(ProductsForm prd1, LandingPage land1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            prd = prd1;
            txtSearch.Text = "Search here";
            comboFilterCat.Text = "All";
            dataGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            land = land1;
        }

        public void LoadCategories()
        {
            try
            {
                dataGridCategories.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("SELECT * FROM tblCategory order by category", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridCategories.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString(), dr["status"].ToString());
                    dataGridCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                dr.Close();
                conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
            
        }

        public void LoadCategoriesActive()
        {
            try
            {
                dataGridCategories.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("SELECT * FROM tblCategory where status = 'Active' order by category", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridCategories.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString(), dr["status"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        public void LoadCategoriesArchived()
        {
            try
            {
                dataGridCategories.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("SELECT * FROM tblCategory where status = 'Archived' order by category", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridCategories.Rows.Add(i, dr["id"].ToString(), dr["category"].ToString(), dr["status"].ToString());
                }
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCategory add = new AddCategory(this,land);
            add.ShowDialog();
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex == -1)
            {
                return;
            }

            string column = dataGridCategories.Columns[e.ColumnIndex].Name;
            string _cat = dataGridCategories.Rows[e.RowIndex].Cells[2].Value.ToString();
            string _stat = dataGridCategories.Rows[e.RowIndex].Cells[3].Value.ToString();
            string _catid = dataGridCategories.Rows[e.RowIndex].Cells[1].Value.ToString();

            try
            {
                if (column == "Edit")
                {

                    EditCategory edit = new EditCategory(_cat, this, prd, land);
                    edit.txtCat.Text = _cat;
                    edit.txtId.Text = _catid;
                    edit.ShowDialog();

                }

                else if (column == "Delete" && _stat == "Active")
                {

                    if (MessageBox.Show("Do you want to archive this category?", "Archive Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cm = new SqlCommand("SELECT COUNT(*) FROM tblProduct INNER JOIN tblCategory ON tblProduct.catid = tblCategory.id WHERE tblCategory.category = @catid", conn);
                        cm.Parameters.AddWithValue("@catid", dataGridCategories.Rows[e.RowIndex].Cells[2].Value.ToString());
                        int count = (int)cm.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("You can't Archive this category since it's been used on the product! delete the product or edit it's category!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            conn.Close();
                            return;
                        }

                        cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                        cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                        cm.Parameters.AddWithValue("@name", land.txtName.Text);
                        cm.Parameters.AddWithValue("@action", "Archived Category");
                        cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@delete_data", "Category: " + dataGridCategories.Rows[e.RowIndex].Cells[2].Value.ToString());
                        cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.ExecuteNonQuery();

                        cm = new SqlCommand("UPDATE tblCategory set status = @stat where id = @id", conn);
                        cm.Parameters.AddWithValue("@id", dataGridCategories.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@stat", "Archived");
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Category successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadCategories();
                    }
                }
                else if (column == "Delete" && _stat == "Archived")
                {
                    if (MessageBox.Show("Do you want to activate this category?", "Activate Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cm = new SqlCommand("UPDATE tblCategory set status = @stat where id = @id", conn);
                        cm.Parameters.AddWithValue("@id", dataGridCategories.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@stat", "Active");
                        cm.ExecuteNonQuery();

                        cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                        cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                        cm.Parameters.AddWithValue("@name", land.txtName.Text);
                        cm.Parameters.AddWithValue("@action", "Activated Category");
                        cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@delete_data", "Category: " + dataGridCategories.Rows[e.RowIndex].Cells[2].Value.ToString());
                        cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Category successfully activate!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadCategories();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
         
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == search)
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            txtSearch.Text = search;
            txtSearch.ForeColor = Color.Black;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridCategories.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridCategories.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridCategories.CurrentCell = cell;
                            dataGridCategories.Rows[cell.RowIndex].Selected = true;
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
                    dataGridCategories.ClearSelection();
                }
            }

        }

        private void comboFilterCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilterCat.SelectedIndex == 0)
            {
                LoadCategories();
            }
            else if (comboFilterCat.SelectedIndex == 1)
            {
                LoadCategoriesActive();
            }
            else
            {
                LoadCategoriesArchived();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboFilterCat.SelectedIndex = 0;
            LoadCategories();
        }
    }
}
