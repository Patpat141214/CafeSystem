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
using System.Xml.Linq;

namespace CafeSystem.Admin
{
    public partial class AccountForm : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private readonly string search = "Search here";
        public AccountForm()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            txtSearch.Text = "Search here";
            comboFilterAcount.SelectedIndex = 0;
            dataGridCAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        
        public void LoadAccounts()
        {
            try
            {
                int i = 0;
                dataGridCAccounts.Rows.Clear();
                conn.Open();
                cm = new SqlCommand("select * from tblUser order by name", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridCAccounts.Rows.Add(i, dr["id"].ToString(), dr["name"].ToString(), dr["username"].ToString(), dr["role"].ToString(), dr["status"].ToString());
                    dataGridCAccounts.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                conn.Close();
                dr.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void LoadAccountsActive()
        {
            try
            {
                int i = 0;
                dataGridCAccounts.Rows.Clear();
                conn.Open();
                cm = new SqlCommand("select * from tblUser where status = 'Active' order by name", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridCAccounts.Rows.Add(i, dr["id"].ToString(), dr["name"].ToString(), dr["username"].ToString(), dr["role"].ToString(), dr["status"].ToString());
                }
                conn.Close();
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        public void LoadAccountsDeactivated()
        {
            try
            {
                int i = 0;
                dataGridCAccounts.Rows.Clear();
                conn.Open();
                cm = new SqlCommand("select * from tblUser where status = 'Deactivated' order by name", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dataGridCAccounts.Rows.Add(i, dr["id"].ToString(), dr["name"].ToString(), dr["username"].ToString(), dr["role"].ToString(), dr["status"].ToString());
                }
                conn.Close();
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void dataGridCAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            string column = dataGridCAccounts.Columns[e.ColumnIndex].Name;
            string _name = dataGridCAccounts.Rows[e.RowIndex].Cells[2].Value.ToString();
            string _role = dataGridCAccounts.Rows[e.RowIndex].Cells[4].Value.ToString();
            string _usn = dataGridCAccounts.Rows[e.RowIndex].Cells[3].Value.ToString();
            string _stat = dataGridCAccounts.Rows[e.RowIndex].Cells[5].Value.ToString();
            try
            {
                if (column == "Edit")
                {
                    
                        string pass = "";
                        conn.Open();
                        cm = new SqlCommand("select password from tblUser where username = @username", conn);
                        cm.Parameters.AddWithValue("@username", _usn);
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            pass = dr["password"].ToString();
                        }
                        conn.Close();
                        ProfileSettings prof = new ProfileSettings(pass, _name, _usn);
                        prof.txtName.Text = _name;
                        prof.txtUser.Text = _usn;
                        prof.txtPass.Text = pass;
                        prof.ShowDialog();


                    
                }
                else if (column == "Delete" && _stat == "Active")
                {
                    if (MessageBox.Show("Do you want to deactivate this Account?", "Deactivate Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if(_role == "Super Administrator")
                        {
                            MessageBox.Show("You can't deactivate an super administrator account!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        conn.Open();
                        cm = new SqlCommand("update tblUser set status = @stat where username = @usn", conn);
                        cm.Parameters.AddWithValue("@stat", "Deactivated");
                        cm.Parameters.AddWithValue("@usn", _usn);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Account successfully deactivated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                      
                        conn.Close();
                        LoadAccounts();
                    }
                }
                else if (column == "Delete" && _stat == "Deactivated")
                {
                    if (MessageBox.Show("Do you want to activate this Account?", "Activate Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        cm = new SqlCommand("update tblUser set status = @stat where username = @usn", conn);
                        cm.Parameters.AddWithValue("@stat", "Active");
                        cm.Parameters.AddWithValue("@usn", _usn);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Account successfully activated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        LoadAccounts();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            comboFilterAcount.SelectedIndex = 0;
            LoadAccounts();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Equals(string.Empty))
            {
                dataGridCAccounts.ClearSelection();
            }
            else
            {
                bool found = false;
                foreach (DataGridViewRow row in dataGridCAccounts.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Visible && (cell.Value ?? "N/A").ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                        {
                            dataGridCAccounts.CurrentCell = cell;
                            dataGridCAccounts.Rows[cell.RowIndex].Selected = true;
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
                    dataGridCAccounts.ClearSelection();
                }
            }
        }

        private void comboFilterAcount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilterAcount.SelectedIndex == 0)
            {
                LoadAccounts();
            }
            else if (comboFilterAcount.SelectedIndex == 1)
            {
              LoadAccountsActive();
            }
            else
            {
               LoadAccountsDeactivated();
            }
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount create = new CreateAccount(this);
            create.ShowDialog();    
        }
    }
}
