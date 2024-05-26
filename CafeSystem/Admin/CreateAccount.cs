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
    public partial class CreateAccount : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        AccountForm accountForm;

        public CreateAccount(AccountForm accountForm)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.Shown += CreateAccount_Shown;
            this.accountForm = accountForm;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void clearAll()
        {
            txtUser.Clear();
            txtName.Clear();
            txtPass.Clear();
            txtConfirm.Clear();          
            txtRole.Text = null;
            txtUser.Focus();

        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void CreateAccount_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtRole.Text) || string.IsNullOrWhiteSpace(txtConfirm.Text)) 
                {
                    MessageBox.Show("Required Empty Field", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                if(txtPass.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Password does not match!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPass.Focus();
                    return;
                }
                              
                if (MessageBox.Show("Do you want to create this account?", "Create Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    conn.Open();
                    cm = new SqlCommand("SELECT COUNT (*) from tblUser where role = @role", conn);
                    cm.Parameters.AddWithValue("@role", txtRole.Text);
                    int count = (int)cm.ExecuteScalar();
                    if (count >= 2)
                    {
                        MessageBox.Show("Only a maximum of 2 super administrators are allowed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUser.Focus();
                        conn.Close();
                        return;
                    }

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
           
                    cm = new SqlCommand("INSERT into tblUser(username, name, role, status, password)values(@username, @name, @role, @status, @password)", conn);
                    cm.Parameters.AddWithValue("@username", txtUser.Text.Trim());
                    cm.Parameters.AddWithValue("@name", txtName.Text);
                    cm.Parameters.AddWithValue("@role", txtRole.Text);
                    cm.Parameters.AddWithValue("@status", "Active");
                    cm.Parameters.AddWithValue("@password", txtConfirm.Text.Trim());
                    cm.ExecuteNonQuery();
                    conn.Close();
                    accountForm.LoadAccounts();
                    MessageBox.Show("Account created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearAll();

                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            disableButton();
        }

        private void btnVisible2_Click(object sender, EventArgs e)
        {
            disableButton1();
        }

        async void disableButton()
        {
            btnVisible.Enabled = false;
            txtPass.PasswordChar = '\0';
            await Task.Delay(TimeSpan.FromSeconds(.50));
            btnVisible.Enabled = true;
            txtPass.PasswordChar = '•';
        }

        async void disableButton1()
        {
            btnVisible.Enabled = false;
            txtConfirm.PasswordChar = '\0';
            await Task.Delay(TimeSpan.FromSeconds(.50));
            btnVisible.Enabled = true;
            txtConfirm.PasswordChar = '•';
        }
    }
}
