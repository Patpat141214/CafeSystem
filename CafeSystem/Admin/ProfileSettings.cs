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
    public partial class ProfileSettings : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        string OrigPass, name, usn;
        
       
        public ProfileSettings(string orig, string _name, string _usn)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            OrigPass = orig;
            name = _name;
            usn = _usn;
            this.KeyPreview = true;
            this.Shown += ProfileSettings_Shown;
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
                if (MessageBox.Show("Do you want to update your profile?", "Update Profile?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("Update tblUser set password = @pass, name = @name where username = @user", conn);
                    cm.Parameters.AddWithValue("@pass", txtPass.Text.Trim());
                    cm.Parameters.AddWithValue("@name", txtName.Text.Trim());
                    cm.Parameters.AddWithValue("@user", txtUser.Text.Trim());
                    cm.ExecuteNonQuery();
                    conn.Close();
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
