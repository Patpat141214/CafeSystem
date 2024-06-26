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
using System.Globalization;
using System.IO;
using static System.Windows.Forms.AxHost;

namespace CafeSystem.Admin
{
    public partial class ProductsForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private string search = "Search here";
        LandingPage land;
        public ProductsForm(LandingPage land1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            txtSearch.Text = "Search here";
            comboFilterProduct.Text = "All";
            land = land1;
        }

        public void LoadProducts()
        {
            try
            {
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, p.status, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id order by p.description asc", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                }
                conn.Close();
                dr.Close();

                for (var p = 0; p <= dataGridProducts.Rows.Count - 1; p++)
                {
                    DataGridViewRow r = dataGridProducts.Rows[p];
                    r.Height = 150;
                }

                var imageColumn = (DataGridViewImageColumn)dataGridProducts.Columns["Column5"];
                imageColumn.Width = 150;
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
           
        
        }

        public void LoadProductsActive()
        {
            try
            {
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.status = 'Active'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                }
                conn.Close();
                dr.Close();

                for (var p = 0; p <= dataGridProducts.Rows.Count - 1; p++)
                {
                    DataGridViewRow r = dataGridProducts.Rows[p];
                    r.Height = 150;
                }

                var imageColumn = (DataGridViewImageColumn)dataGridProducts.Columns["Column5"];
                imageColumn.Width = 150;
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }


        }

        public void LoadProductsArchived()
        {
            try
            {
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.status = 'Archived'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                }
                conn.Close();
                dr.Close();

                for (var p = 0; p <= dataGridProducts.Rows.Count - 1; p++)
                {
                    DataGridViewRow r = dataGridProducts.Rows[p];
                    r.Height = 150;
                }

                var imageColumn = (DataGridViewImageColumn)dataGridProducts.Columns["Column5"];
                imageColumn.Width = 150;
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }


        }
        public void LoadProductsAvailable()
        {
            try
            {
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.AvailOrNot = 'Available'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                }
                conn.Close();
                dr.Close();

                for (var p = 0; p <= dataGridProducts.Rows.Count - 1; p++)
                {
                    DataGridViewRow r = dataGridProducts.Rows[p];
                    r.Height = 150;
                }

                var imageColumn = (DataGridViewImageColumn)dataGridProducts.Columns["Column5"];
                imageColumn.Width = 150;
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }


        }

        public void LoadProductsNotAvailable()
        {
            try
            {
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.AvailOrNot = 'Not Available'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                }
                conn.Close();
                dr.Close();

                for (var p = 0; p <= dataGridProducts.Rows.Count - 1; p++)
                {
                    DataGridViewRow r = dataGridProducts.Rows[p];
                    r.Height = 150;
                }

                var imageColumn = (DataGridViewImageColumn)dataGridProducts.Columns["Column5"];
                imageColumn.Width = 150;
                imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

        }

        private void dataGridProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            string column = dataGridProducts.Columns[e.ColumnIndex].Name;
            string _desc = dataGridProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            string _cat = dataGridProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            string _price = dataGridProducts.Rows[e.RowIndex].Cells[4].Value.ToString();
            string _AvailOrNot = dataGridProducts.Rows[e.RowIndex].Cells[5].Value.ToString();
            string _status = dataGridProducts.Rows[e.RowIndex].Cells[6].Value.ToString();
            byte[] img = (byte[])dataGridProducts.Rows[e.RowIndex].Cells[7].Value;

            try
            {
                if (column == "Edit")
                {
                    EditProduct edit = new EditProduct(_cat, _desc, _price, this, img, land, _AvailOrNot);
                    edit.txtDesc.Text = _desc;
                    edit.txtCat.Text = _cat;
                    edit.txtPrice.Text = _price;
                    edit.txtId.Text = dataGridProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if (_AvailOrNot == "Available")
                    {
                        edit.checkboxAv.Checked = true;
                    }
                    else
                    {
                        edit.checkboxAv.Checked = false;
                    }

                    if (img != null)
                    {
                        using (MemoryStream ms = new MemoryStream(img))
                        {
                            edit.editImage.Image = Image.FromStream(ms);
                        }
                    }
                    edit.LoadCat();
                    edit.ShowDialog();

                }
                else if (column == "Delete" && _status == "Active")
                {
                    if (MessageBox.Show("Do you want to archive this product?", "Archive Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                        cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                        cm.Parameters.AddWithValue("@name", land.txtName.Text);
                        cm.Parameters.AddWithValue("@action", "Archived Product");
                        cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@delete_data", "Item: " + dataGridProducts.Rows[e.RowIndex].Cells[2].Value.ToString() + "\n" + "Category: " + dataGridProducts.Rows[e.RowIndex].Cells[3].Value.ToString() + "\n" + "Price: " + dataGridProducts.Rows[e.RowIndex].Cells[4].Value.ToString().Replace("₱", "").Replace(",", "").Trim() + "\n" + "Availability: " + _AvailOrNot + "\n" + "Status: " + _status);
                        cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.ExecuteNonQuery();

                        cm = new SqlCommand("Update tblProduct set status = @status where id = @id", conn);
                        cm.Parameters.AddWithValue("@id", dataGridProducts.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@status", "Archived");
                        cm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Product successfully archived!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
                    }

                }
                else if (column == "Delete" && _status == "Archived")
                {
                    if (MessageBox.Show("Do you want to activate this product?", "Activate Product?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                        cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                        cm.Parameters.AddWithValue("@name", land.txtName.Text);
                        cm.Parameters.AddWithValue("@action", "Activated Product");
                        cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                        cm.Parameters.AddWithValue("@delete_data", "Item: " + dataGridProducts.Rows[e.RowIndex].Cells[2].Value.ToString() + "\n" + "Category: " + dataGridProducts.Rows[e.RowIndex].Cells[3].Value.ToString() + "\n" + "Price: " + dataGridProducts.Rows[e.RowIndex].Cells[4].Value.ToString().Replace("₱", "").Replace(", ", "").Trim() + "\n" + "Availability: " + _AvailOrNot + "\n" + "Status: " + _status);
                        cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                        cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                        cm.ExecuteNonQuery();

                        cm = new SqlCommand("Update tblProduct set status = @status where id = @id", conn);
                        cm.Parameters.AddWithValue("@id", dataGridProducts.Rows[e.RowIndex].Cells[1].Value.ToString());
                        cm.Parameters.AddWithValue("@status", "Active");
                        cm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Product successfully activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProducts();
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
                dataGridProducts.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridProducts.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridProducts.CurrentCell = cell;
                            dataGridProducts.Rows[cell.RowIndex].Selected = true;
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
                    dataGridProducts.ClearSelection();
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboFilterProduct.SelectedIndex = 0;
            LoadProducts();
        }

        private void comboFilterProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilterProduct.SelectedIndex == 0)
            {
                LoadProducts();
            }
            else if (comboFilterProduct.SelectedIndex == 1)
            {
                LoadProductsActive();
            }
            else if (comboFilterProduct.SelectedIndex == 2)
            {
                LoadProductsArchived();
            }
            else if (comboFilterProduct.SelectedIndex == 3)
            {
                LoadProductsAvailable();
            }
            else
            {
                LoadProductsNotAvailable();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            AddProduct prd = new AddProduct(this, land);
            prd.ShowDialog();
        }

        private void btnCategory_Click_1(object sender, EventArgs e)
        {
            CategoriesList cat = new CategoriesList(this, land);
            cat.LoadCategories();
            cat.ShowDialog();
        }
    }
}
