using CafeSystem.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeSystem
{
    public partial class LandingPage : Form
    {
       
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ContextMenuStrip contextMenuStrip1 = new ContextMenuStrip();

        public LandingPage()
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contextMenu_ItemClicked);
            retrieveImage();
        }
        public void retrieveImage()
        {
            conn.Open();
            cm = new SqlCommand("SELECT image FROM tblStoreInfo WHERE id = 1", conn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                byte[] imageData = (byte[])dr["image"];
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    storePic.BackgroundImage = Image.FromStream(ms);
                }
            }

            conn.Close();
            dr.Close();
        }



        private void btnManageProducts_Click(object sender, EventArgs e)
        {

            ProductsForm prd = new ProductsForm();
            prd.TopLevel = false;
            panel1.Controls.Add(prd);
            prd.BringToFront();
            prd.LoadProducts();
            prd.Show();
        }

        private void btnManageProducts_MouseHover(object sender, EventArgs e)
        {
            btnManageProducts.Cursor = Cursors.Hand;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Items.Clear();
            
                ToolStripMenuItem logoutMenuItem = new ToolStripMenuItem("    Logout");              
                ToolStripMenuItem StoreMenuItem = new ToolStripMenuItem("    Store Setting");

                StoreMenuItem.Name = "StoreMenu";
                StoreMenuItem.Image = Properties.Resources.shop1;
                StoreMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
                StoreMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                StoreMenuItem.BackColor = Color.FromArgb(201, 158, 135);
                StoreMenuItem.ForeColor = Color.White;
                StoreMenuItem.Font = new Font("Consolas", 13, FontStyle.Bold);
                StoreMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                logoutMenuItem.Name = "logOutMenuItem";
                logoutMenuItem.Image = Properties.Resources.logout1;
                logoutMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
                logoutMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                logoutMenuItem.BackColor = Color.FromArgb(201, 158, 135);
                logoutMenuItem.ForeColor = Color.White;
                logoutMenuItem.Font = new Font("Consolas", 13, FontStyle.Bold);
                logoutMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
   
                contextMenuStrip1.Items.Add(StoreMenuItem);
                contextMenuStrip1.Items.Add(logoutMenuItem);
                contextMenuStrip1.Opened += (_sender, _e) => contextMenuStrip1.Show(btnSetting, new Point(0 - (contextMenuStrip1.Size.Width - btnSetting.Size.Width), btnSetting.Size.Height));
                contextMenuStrip1.Show(btnSetting, new Point(0, 0));
                contextMenuStrip1.Size = new Size(175, 45);


        }

        void contextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name == "logOutMenuItem")
                {
                    if (MessageBox.Show("Do you want to logout?", "Logout?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Dispose();
                        LogInPage login = new LogInPage();
                        login.ShowDialog();
                    }
                }
               
                else if (e.ClickedItem.Name == "StoreMenu")
                {


                    
                    string StoreName = "";
                    string Address = "";
                    byte[] storeImageData = null;
                    conn.Open();
                    cm = new SqlCommand("select storeName, address, image from tblStoreInfo where id = 1", conn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        storeImageData = (byte[])dr["image"];
                        StoreName = dr["storeName"].ToString();
                        Address = dr["address"].ToString();
                    }
                    conn.Close();
                    dr.Close();
                    StoreSettings store = new StoreSettings(StoreName, Address, storeImageData, this);
                    store.ShowDialog();


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }


        }

        private void btnStore_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAccountMain_Click(object sender, EventArgs e)
        {
            AccountForm acc = new AccountForm();
            acc.TopLevel = false;
            panel1.Controls.Add(acc);
            acc.BringToFront();
            acc.LoadAccounts();
            acc.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportsModule report = new ReportsModule(this);
            report.TopLevel = false;
            panel1.Controls.Add(report);
            report.BringToFront();
            report.Show();
        }
    }
}
