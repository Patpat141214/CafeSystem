using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Admin
{
    public partial class ReportsModule : Form
    {
        LandingPage land;
        public ReportsModule(LandingPage land1)
        {
            InitializeComponent();
            land = land1;
        }

        private void btnShowSoldReport_Click(object sender, EventArgs e)
        {
            SalesReport sales = new SalesReport(land);
            sales.TopLevel = false;
            panel1.Controls.Add(sales);
            sales.loadTransactGroup();
            sales.BringToFront();
            sales.Show();
            
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            InventoryReport inv = new InventoryReport(land);
            inv.TopLevel = false;
            panel1.Controls.Add(inv);
            inv.BringToFront();
            inv.LoadProducts();
            inv.Show();
        }
    }
}
