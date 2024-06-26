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
    public partial class ActivityLogForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private readonly string search = "search here";
        public ActivityLogForm()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            comboFilterLogs.SelectedIndex = 0;
            txtSearch.Text = search;

        }

        public void LoadLogs()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsAllCategory()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Added Category', 'Updated Category', 'Activated Category', 'Archived Category')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsAddedCategory()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Added Category'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsUpdatedCategory()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Updated Category'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsActivatedArchivedCategory()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Archived Category', 'Activated Category')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsAllProduct()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Added Product', 'Updated Product', 'Activated Product', 'Archived Product')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsAddedProduct()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Added Product'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsUpdatedProduct()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Updated Product'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsArchivedActivatedProduct()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Archived Product', 'Activated Product')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }
        public void LoadLogsAllDiscount()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Updated Discount', 'Activated Discount', 'Deactivated Discount')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsUpdatedDiscount()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Updated Discount'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsActivatedDeactivatedDiscount()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Activated Discount', 'Deactivated Discount')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsAllAccounts()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Added Account', 'Updated Account', 'Activated Account', 'Deactivated Account')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsAddedAccount()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Added Account'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsUpdatedAccount()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action = 'Updated Account'", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        public void LoadLogsActivateddDeactivatedAccount()
        {
            dataGridLogs.Rows.Clear();
            int i = 0;
            conn.Open();
            cm = new SqlCommand("Select * from tblActivityLogs where action IN ('Activated Account', 'Deactivated Account')", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridLogs.Rows.Add(i, dr["id"].ToString(), dr["username"].ToString(), dr["name"].ToString(), dr["role"].ToString(), dr["action"].ToString(), dr["add_data"].ToString(), dr["update_data"].ToString(), dr["delete_data"].ToString(), dr["sdate"].ToString());
                dataGridLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            conn.Close();
            dr.Close();
        }

        private void comboFilterLogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilterLogs.SelectedIndex == 0)
            {
                LoadLogs();
                comboAction.Items.Clear();
                comboAction.Enabled = false;
                comboAction.Text = null;
            }
            if (comboFilterLogs.SelectedIndex == 1)
            {
                comboAction.Items.Clear();
                comboAction.Enabled = true;
                comboAction.Items.Add("All");
                comboAction.Items.Add("Added Category");
                comboAction.Items.Add("Updated Category");
                comboAction.Items.Add("Archived/Activated Category");
            }
            if (comboFilterLogs.SelectedIndex == 2)
            {
                comboAction.Items.Clear();
                comboAction.Enabled = true;
                comboAction.Items.Add("All");
                comboAction.Items.Add("Added Product");
                comboAction.Items.Add("Updated Product");
                comboAction.Items.Add("Archived/Activated Product");
            }
            if (comboFilterLogs.SelectedIndex == 3)
            {
                comboAction.Items.Clear();
                comboAction.Enabled = true;
                comboAction.Items.Add("All");
                comboAction.Items.Add("Updated Discount");
                comboAction.Items.Add("Archived/Activated Discount");
            }
            if (comboFilterLogs.SelectedIndex == 4)
            {
                comboAction.Items.Clear();
                comboAction.Enabled = true;
                comboAction.Items.Add("All");
                comboAction.Items.Add("Added Account");
                comboAction.Items.Add("Updated Account");
                comboAction.Items.Add("Archived/Activated Account");
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridLogs.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridLogs.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridLogs.CurrentCell = cell;
                            dataGridLogs.Rows[cell.RowIndex].Selected = true;
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
                    dataGridLogs.ClearSelection();
                }
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

        private void comboAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAction.SelectedIndex == 0 && comboFilterLogs.SelectedIndex == 1) {
             LoadLogsAllCategory();

            }
            if (comboAction.SelectedIndex == 1 && comboFilterLogs.SelectedIndex == 1)
            {
                LoadLogsAddedCategory();

            }
            if (comboAction.SelectedIndex == 2 && comboFilterLogs.SelectedIndex == 1)
            {
                LoadLogsUpdatedCategory();

            }
            if (comboAction.SelectedIndex == 3 && comboFilterLogs.SelectedIndex == 1)
            {
                LoadLogsActivatedArchivedCategory();

            }
            if (comboAction.SelectedIndex == 0 && comboFilterLogs.SelectedIndex == 2)
            {
                LoadLogsAllProduct();

            }
            if (comboAction.SelectedIndex == 1 && comboFilterLogs.SelectedIndex == 2)
            {
                LoadLogsAddedProduct();

            }
            if (comboAction.SelectedIndex == 2 && comboFilterLogs.SelectedIndex == 2)
            {
                LoadLogsUpdatedProduct();
            }
            if (comboAction.SelectedIndex == 3 && comboFilterLogs.SelectedIndex == 2)
            {
                LoadLogsArchivedActivatedProduct();
            }
            if (comboAction.SelectedIndex == 0 && comboFilterLogs.SelectedIndex == 3)
            {
                LoadLogsAllDiscount();

            }
            if (comboAction.SelectedIndex == 1 && comboFilterLogs.SelectedIndex == 3)
            {
                LoadLogsUpdatedDiscount();

            }
            if (comboAction.SelectedIndex == 2 && comboFilterLogs.SelectedIndex == 3)
            {
                LoadLogsActivatedDeactivatedDiscount();

            }
            if (comboAction.SelectedIndex == 0 && comboFilterLogs.SelectedIndex == 4)
            {

                LoadLogsAllAccounts();
            }
            if (comboAction.SelectedIndex == 1 && comboFilterLogs.SelectedIndex == 4)
            {

                LoadLogsAddedAccount();
            }
            if (comboAction.SelectedIndex == 2 && comboFilterLogs.SelectedIndex == 4)
            {

                  LoadLogsUpdatedAccount();
            }
            if (comboAction.SelectedIndex == 3 && comboFilterLogs.SelectedIndex == 4)
            {

                LoadLogsActivateddDeactivatedAccount();
            }
        }
    }  
}
