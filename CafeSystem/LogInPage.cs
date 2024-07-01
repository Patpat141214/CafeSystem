using Microsoft.VisualBasic.Logging;
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

namespace CafeSystem
{
    public partial class LogInPage : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;

        public LogInPage()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            this.Shown += LogInPage_Shown;
            txtUser.Font = new Font("Consolas", 12, FontStyle.Bold);
            txtPass.Font = new Font("Consolas", 12, FontStyle.Bold);
            this.KeyPreview = true;
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            string username = "", role = "", name = "", status = "";
            try
            {
                if (string.IsNullOrWhiteSpace(txtPass.Text) || string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    MessageBox.Show("Please input password or username!.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }

                bool found = false;
                conn.Open();
                cm = new SqlCommand("select * from tblUser where username COLLATE Latin1_General_BIN = @username COLLATE Latin1_General_BIN and password = @password", conn);
                cm.Parameters.AddWithValue("@username", txtUser.Text);
                cm.Parameters.AddWithValue("@password", txtPass.Text);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    username = dr["username"].ToString();
                    role = dr["role"].ToString();
                    name = dr["name"].ToString();
                    status = dr["status"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();
                conn.Close();

                if (found == true && status != "Deactivated")
                {
                    conn.Open();
                    cm = new SqlCommand("Insert into tblActivityLogs (username, name, action, add_data, update_data, delete_data, role, sdate)values(@username, @name, @action, @add_data, @update_data, @delete_data, @role, @sdate)", conn);
                    cm.Parameters.AddWithValue("@username", txtUser.Text);
                    cm.Parameters.AddWithValue("@name", name);
                    cm.Parameters.AddWithValue("@action", "Log In");
                    cm.Parameters.AddWithValue("@add_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@update_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@delete_data", DBNull.Value);
                    cm.Parameters.AddWithValue("@role", role);
                    cm.Parameters.AddWithValue("@sdate", DateTime.Now);
                    cm.ExecuteNonQuery();
                    conn.Close();


                    if (role == "Cashier")
                    {
                        string storeName = "";

                        conn.Open();
                        cm = new SqlCommand("Select storeName from tblStoreInfo where id = 1", conn);
                        dr = cm.ExecuteReader();
                        while (dr.Read())
                        {
                            storeName = dr["storeName"].ToString();
                        }
                        dr.Close();
                        conn.Close();


                        MessageBox.Show("Welcome " + name + "!");
                        this.Hide();
                        Cashier cash = new Cashier();
                        cash.LoadData();
                        //cash.lblUser.Text = username;
                        //cash.lblNameCash.Text = name;
                        //cash.lblLevel.Text = role;
                        //cash.lblNameCash.Visible = true;
                        //cash.lblLevel.Visible = true;
                        //cash.getTransNum();
                        //cash.gunaDataGridView2.Visible = false;
                        //cash.txtsearch.Visible = false;
                        //cash.LoadAddToCashier();]
                        cash.txtName.Text = name;
                        cash.lblCafeName.Text = storeName;
                        cash.txtLevel.Text = role;
                        cash.txtUser.Text = username;
                        cash.lblNameAndRole.Text = name + " | " + role;
                        cash.getTrans();
                        cash.ShowDialog();


                    }
                    else if (role == "Administrator")
                    {
                        MessageBox.Show("Welcome " + name + "!");
                        this.Hide();
                        LandingPage admin = new LandingPage();
                        admin.txtName.Text = name;
                        admin.txtLevel.Text = role;
                        admin.txtUser.Text = username;
                        admin.btnDiscount.Visible = false;
                        admin.btnAccountMain.Visible = false;
                        admin.MyDashboard();
                        admin.ShowDialog();
                        //admin.MyDashboard();
                        //admin.UpdateBellIcons();
                    }
                    else
                    {
                        MessageBox.Show("Welcome " + name + "!");
                        this.Hide();
                        LandingPage admin = new LandingPage();
                        admin.txtName.Text = name;
                        admin.txtLevel.Text = role;
                        admin.txtUser.Text = username;
                        admin.MyDashboard();
                        admin.ShowDialog();
                        //admin.MyDashboard();
                        //admin.UpdateBellIcons();
                    }


                }
                else if (found == true && status == "Deactivated")
                {
                    MessageBox.Show("This account has been deactivated! Please contact the Super Administrator.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUser.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void LogInPage_Shown(object sender, EventArgs e)
        {
            txtUser.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            txtUser.Focus();
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(sender, e);
            }
        }

        private void btnVisible_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Input Password!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Focus();
                return;
            }
            disableButton();
        }

        async void disableButton()
        {
            btnVisible.Enabled = false;
            txtPass.PasswordChar = '\0';
            await Task.Delay(TimeSpan.FromSeconds(.50));
            btnVisible.Enabled = true;
            txtPass.PasswordChar = '•';
        }

        private void LogInPage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnCloseWindow_Click(sender, e);
            }
        }


        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit the application?", "Exit Application?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
      
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void LogInPage_Load(object sender, EventArgs e)
        {
            string name = "";
            try
            {
                conn.Open();
                cm = new SqlCommand("Select storeName from tblStoreInfo where id = 1", conn);
                dr = cm.ExecuteReader();
                 while (dr.Read())
                {
                    name = dr["storeName"].ToString();

                }
                dr.Close();
                conn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }

            lblCafeName.Text = name;

        }
    }
}
