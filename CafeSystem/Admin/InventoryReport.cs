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

namespace CafeSystem.Admin
{
    public partial class InventoryReport : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public InventoryReport()
        {
            InitializeComponent();        
            conn = new SqlConnection(dbcon.myConnection());
            filterBySold.SelectedIndex = 0;
        }

        public void LoadProducts()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, p.status, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                    hasrecord = true;
                }
                conn.Close();
                dr.Close();
                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
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
        public void LoadProductsActive()
        {
            try
            {
                Boolean hasrecord = false;
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, p.status, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.status = 'Active'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                    hasrecord = true;

                }
                conn.Close();
                dr.Close();

                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
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
                Boolean hasrecord = false;
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, p.status, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.status = 'Archived'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                    hasrecord = true;
                }
                conn.Close();
                dr.Close();

                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
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
                Boolean hasrecord = false;
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, p.status, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.AvailOrNot = 'Available'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                    hasrecord = true;
                }
                conn.Close();
                dr.Close();

                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }

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
                Boolean hasrecord = false;
                dataGridProducts.Rows.Clear();
                int i = 0;
                conn.Open();
                cm = new SqlCommand("select p.id, p.price, p.status, p.AvailOrNot, p.image, p.description, p.status, c.category FROM tblProduct AS p INNER JOIN tblCategory as c on p.catid = c.id where p.AvailOrNot = 'Not Available'", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridProducts.Rows.Add(i, dr["id"].ToString(), dr["description"].ToString(), dr["category"].ToString(), Convert.ToDecimal(dr["price"]).ToString("c", CultureInfo.GetCultureInfo("en-PH")), dr["AvailOrNot"].ToString(), dr["status"].ToString(), dr["image"]);
                    hasrecord = true;
                }
                conn.Close();
                dr.Close();
                if (hasrecord)
                {
                    btnGenerateReport.Enabled = true;
                }
                else
                {
                    btnGenerateReport.Enabled = false;
                }
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

        private void filterBySold_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterBySold.SelectedIndex == 0)
            {
                LoadProducts();
            }
            else if (filterBySold.SelectedIndex == 1)
            {
                LoadProductsActive();
            }
            else if (filterBySold.SelectedIndex == 2)
            {
                LoadProductsArchived();
            }
            else if (filterBySold.SelectedIndex == 3)
            {
                LoadProductsAvailable();
            }
            else
            {
                LoadProductsNotAvailable();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            filterBySold.SelectedIndex = 0;
            LoadProducts();
        }
    }
}
