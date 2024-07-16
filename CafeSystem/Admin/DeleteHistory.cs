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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CafeSystem.Admin
{
    public partial class DeleteHistory : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        ActivityLogForm act;
        LandingPage land;
        public DeleteHistory(ActivityLogForm act1, LandingPage land1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            act = act1;
            land = land1;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                 


                if (MessageBox.Show("Do you want to delete all activity logs?", "Delete all activity logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    cm = new SqlCommand("select count(*) from tblActivityLogs", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Activity Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all activity logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
       
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete all category logs?", "Delete all category logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();

                    cm = new SqlCommand("select count(*) from tblActivityLogs where action IN ('Added Category', 'Updated Category', 'Activated Category', 'Archived Category')", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs where action IN ('Added Category', 'Updated Category', 'Activated Category', 'Archived Category')", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Category Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all category logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete all product logs?", "Delete all product logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("select count(*) from tblActivityLogs where action IN ('Added Product', 'Updated Product', 'Activated Product', 'Archived Product')", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs where action IN ('Added Product', 'Updated Product', 'Activated Product', 'Archived Product')", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Product Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all product logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteDiscount_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete all manage discount logs?", "Delete all manage discount logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("select count(*) from tblActivityLogs where action IN ('Updated Discount', 'Activated Discount', 'Deactivated Discount')", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs where action IN ('Updated Discount', 'Activated Discount', 'Deactivated Discount')", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Manage Discount Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all manage discount logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void btnDeleteUsers_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete all account maintenance logs?", "Delete all account maintenance logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("select count(*) from tblActivityLogs where action IN ('Added Account', 'Updated Account', 'Activated Account', 'Deactivated Account')", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs where action IN ('Added Account', 'Updated Account', 'Activated Account', 'Deactivated Account')", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Account Maintenance Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all account maintenance logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteLoginLogout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete all login/logout logs?", "Delete all login/logout logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("select count(*) from tblActivityLogs where action IN ('Log In', 'Log Out')", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs where action IN ('Log In', 'Log Out')", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Login/Logout Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all login/logout logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteTransac_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to delete all transactions logs?", "Delete all transactions logs?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("select count(*) from tblActivityLogs where action = 'Deleted Transactions'", conn);
                    int rowCount = (int)cm.ExecuteScalar();

                    if (rowCount == 0)
                    {
                        MessageBox.Show("No records to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        conn.Close();
                        return;
                    }

                    cm = new SqlCommand("delete from tblActivityLogs where action = 'Deleted Transactions'", conn);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Deleted All Transactions Logs");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", "Deleted all transactions logs");
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();


                    MessageBox.Show("Successfully Deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    act.refreshAllActivities();
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
