using CafeSystem.CashierLevel.Reports;
using CafeSystem.SystemReports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSystem.Admin
{
    public partial class ReportsRDLC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        SalesReport srp;
        LandingPage land;
        public ReportsRDLC(SalesReport srp1, LandingPage land1)
        {           
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            srp = srp1;
            land = land1;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }

        private void ReportsRDLC_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void loadSalesReport(string sql, string param, string label)
        {
            ReportDataSource rpdatasource;
            try
            {
                decimal totalDiscount = 0;
                decimal totalSold = 0;


                string reportFileName = "Reports\\SalesReport.rdlc";
                string reportPath = Path.Combine(Application.StartupPath, reportFileName);

                // Set the report path
                reportViewer1.LocalReport.ReportPath = reportPath;

                SystemReports.DataSetsForReports ds = new SystemReports.DataSetsForReports();
                SqlDataAdapter da = new SqlDataAdapter();
                conn.Open();

                DateTime start1 = new DateTime(srp.startDate.Value.Year, srp.startDate.Value.Month, srp.startDate.Value.Day, 00, 00, 00); ;
                DateTime end1 = new DateTime(srp.endDate.Value.Year, srp.endDate.Value.Month, srp.endDate.Value.Day, 23, 59, 59);

                DateTime currentDate = DateTime.Now.Date;

                DateTime start2 = currentDate.AddDays(-6);

                DateTime end2 = currentDate.AddHours(23).AddMinutes(59).AddSeconds(59);

                DateTime start3 = new DateTime(srp.startDate.Value.Year, srp.startDate.Value.Month, 1);
                DateTime end3 = new DateTime(srp.endDate.Value.Year, srp.endDate.Value.Month, DateTime.DaysInMonth(srp.endDate.Value.Year, srp.endDate.Value.Month), 23, 59, 59);

                DateTime start4 = new DateTime(srp.startDate.Value.Year, 1, 1, 00, 00, 00);
                DateTime end4 = new DateTime(srp.endDate.Value.Year, 12, DateTime.DaysInMonth(srp.endDate.Value.Year, 12), 23, 59, 59);

                SqlCommand cmd = new SqlCommand(sql, conn);
                if (srp.filterBySold.SelectedIndex == 0)
                {
                    cmd.Parameters.AddWithValue("@start", start1.ToString());
                    cmd.Parameters.AddWithValue("@end", end1.ToString());
                }
                else if (srp.filterBySold.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@start", start2.ToString());
                    cmd.Parameters.AddWithValue("@end", end2.ToString());
                }
                else if (srp.filterBySold.SelectedIndex == 2)
                {
                    cmd.Parameters.AddWithValue("@start", start3.ToString());
                    cmd.Parameters.AddWithValue("@end", end3.ToString());
                }
                else
                {
                    cmd.Parameters.AddWithValue("@start", start4.ToString());
                    cmd.Parameters.AddWithValue("@end", end4.ToString());
                }
                da.SelectCommand = cmd;
                da.Fill(ds.Tables["dtSalesReport"]);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    decimal totalValue = Convert.ToDecimal(dr["discounted_total"]);
                    decimal price = Convert.ToDecimal(dr["price"]);
                    decimal qty = Convert.ToDecimal(dr["qty"]);
                    decimal total = qty * price;
                    totalDiscount += total - totalValue;
                    totalSold += totalValue;
                }
                conn.Close();
                dr.Close();


                string storeName1 = "", address1 = "";

                conn.Open();
                cm = new SqlCommand("select * from tblStoreInfo where id = 1", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    storeName1 = dr["storeName"].ToString();
                    address1 = dr["address"].ToString();
                }
                dr.Close();
                conn.Close();


                ReportParameter StoreName = new ReportParameter("pStoreName", "Store: " + storeName1);
                ReportParameter StoreAddress = new ReportParameter("pStoreAddress", "Addess: " + address1);
                ReportParameter date = new ReportParameter("pDate", param);
                ReportParameter discount = new ReportParameter("pTotalDiscount", "Total Discount \n" + "₱" + totalDiscount.ToString("N2"));
                ReportParameter sales = new ReportParameter("pTotalSold", "Total Sales \n" + "₱" + totalSold.ToString("N2"));
                ReportParameter generatedby = new ReportParameter("pGeneratedBy", "Generated By: " + land.txtName.Text + "\nDate/Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"));
                ReportParameter title = new ReportParameter("pLabel", label);
                reportViewer1.LocalReport.SetParameters(StoreName);
                reportViewer1.LocalReport.SetParameters(StoreAddress);
                reportViewer1.LocalReport.SetParameters(date);
                reportViewer1.LocalReport.SetParameters(discount);
                reportViewer1.LocalReport.SetParameters(sales);
                reportViewer1.LocalReport.SetParameters(generatedby);
                reportViewer1.LocalReport.SetParameters(title);
                rpdatasource = new ReportDataSource("DataSet1", ds.Tables["dtSalesReport"]);
                reportViewer1.LocalReport.DataSources.Add(rpdatasource);
                reportViewer1.RefreshReport();
                reportViewer1.ZoomMode = ZoomMode.PageWidth;



            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        public void loadInventoryReport(string sql, string label)
        {
            ReportDataSource rpdatasource;
            try
            {

                string reportFileName = "Reports\\InventoryReport.rdlc";
                string reportPath = Path.Combine(Application.StartupPath, reportFileName);

                // Set the report path
                reportViewer1.LocalReport.ReportPath = reportPath;

                SystemReports.DataSetsForReports ds = new SystemReports.DataSetsForReports();
                SqlDataAdapter da = new SqlDataAdapter();

                conn.Open();

                SqlCommand cmd = new SqlCommand(sql, conn);
                da.SelectCommand = cmd;
                da.Fill(ds.Tables["dtInventoryReport"]);

                conn.Close();
             


                string storeName1 = "", address1 = "";

                conn.Open();
                cm = new SqlCommand("select * from tblStoreInfo where id = 1", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    storeName1 = dr["storeName"].ToString();
                    address1 = dr["address"].ToString();
                }
                dr.Close();
                conn.Close();


                ReportParameter StoreName = new ReportParameter("pStoreName", "Store: " + storeName1);
                ReportParameter StoreAddress = new ReportParameter("pStoreAddress", "Addess: " + address1);
                ReportParameter generatedby = new ReportParameter("pGeneratedBy", "Generated By: " + land.txtName.Text + "\nDate/Time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss tt"));
                ReportParameter title = new ReportParameter("pLabel", label);
                reportViewer1.LocalReport.SetParameters(StoreName);
                reportViewer1.LocalReport.SetParameters(StoreAddress);
                reportViewer1.LocalReport.SetParameters(generatedby);
                reportViewer1.LocalReport.SetParameters(title);
                rpdatasource = new ReportDataSource("DataSet1", ds.Tables["dtInventoryReport"]);
                reportViewer1.LocalReport.DataSources.Add(rpdatasource);
                reportViewer1.RefreshReport();
                reportViewer1.ZoomMode = ZoomMode.PageWidth;



            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
     
    }

