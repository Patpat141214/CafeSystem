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
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Xml.Linq;

namespace CafeSystem.Admin
{
    public partial class ProfileSettings : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        LandingPage land;
        string OrigPass, name, usn, id;
        AccountForm acc;
        
       
        public ProfileSettings(string orig, string _name, string _usn, LandingPage land1, string _id, AccountForm acc1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            OrigPass = orig;
            name = _name;
            usn = _usn;
            this.KeyPreview = true;
            this.Shown += ProfileSettings_Shown;
            land = land1;
            id = _id;
            acc = acc1;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
  
        }

        async void disableButton()
        {
            btnVisible.Enabled = false;
            txtPass.PasswordChar = '\0';
            await Task.Delay(TimeSpan.FromSeconds(.50));
            btnVisible.Enabled = true;
            txtPass.PasswordChar = '•';
        }


        private void btnVisible_Click(object sender, EventArgs e)
        {
            disableButton();
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtName.Text = name;
            txtPass.Text = OrigPass;
            txtUser.Text = usn;
            txtUser.Focus();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                if(txtName.Text == name && txtPass.Text == OrigPass && txtUser.Text == usn)
                {
                    MessageBox.Show("There are no changes", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }

                conn.Open();
                cm = new SqlCommand("select count (*) from tbluser where username = @usn", conn);
                cm.Parameters.AddWithValue("@usn", txtUser.Text.Trim());
                int count1 = (int)cm.ExecuteScalar();
                if (count1 > 0)
                {
                    MessageBox.Show("Username already existing!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    conn.Close();
                    return;
                }
                conn.Close();

                if (MessageBox.Show("Do you want to update your profile?", "Update Profile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    conn.Open();
                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", land.txtUser.Text);
                    cm.Parameters.AddWithValue("@name", land.txtName.Text);
                    cm.Parameters.AddWithValue("@action", "Updated Account");
                    if (txtPass.Text != OrigPass)
                    {
                        cm.Parameters.AddWithValue("@add_data", "Old Info" + "\n" + "Username: " + usn + "\n" + "Name: " + name + "\n" + "Updated Info" + "\n" + "Username: " + txtUser.Text + "\n" + "Name: " + txtName.Text + "\n" + "New Password");
                    }
                    else
                    {
                        cm.Parameters.AddWithValue("@add_data", "Old Info" + "\n" + "Username: " + usn + "\n" + "Name: " + name + "\n" + "Updated Info" + "\n" + "Username: " + txtUser.Text + "\n" + "Name: " + txtName.Text);
                    }
                  
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@role", land.txtLevel.Text);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();

                    cm = new SqlCommand("Update tblUser set password = @pass, name = @name, username = @user where id = @id", conn);
                    cm.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                    cm.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cm.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                    cm.Parameters.AddWithValue("@id", id);
                    cm.ExecuteNonQuery();
                    conn.Close();
                    acc.LoadAccounts();
                    MessageBox.Show("Profile successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();

                }
                txtUser.Focus();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                
            }
        }

        private void ProfileSettings_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void ProfileSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }
    }
}
