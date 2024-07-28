using CafeSystem.CashierLevel.Reports;
using CafeSystem.SystemReports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CafeSystem.CashierLevel
{
    public partial class ReceiptPayment : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Cashier cshier;

        public ReceiptPayment(Cashier cshier1)
        {
            InitializeComponent();
            conn = new SqlConnection(dbcon.myConnection());
            cshier = cshier1;
        }

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReceiptPayment_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void loadReport(string cash, string change)
        {
            ReportDataSource rpdatasource;
            try
            {



                string reportFileName = "Reports\\ReceiptPaymentReport.rdlc";
                string reportPath = Path.Combine(Application.StartupPath, reportFileName);

                // Set the report path
                reportViewer1.LocalReport.ReportPath = reportPath;

                SystemReports.DataSetsForReports ds = new SystemReports.DataSetsForReports();
                SqlDataAdapter da = new SqlDataAdapter();

                conn.Open();
                da.SelectCommand = new SqlCommand("select * from tblCart where transacno like '" + cshier.lblTransu.Text + "'", conn);
                
                da.Fill(ds.Tables["dtReceipt"]);
                conn.Close();

                ReportParameter Discount;
                ReportParameter Total;
                ReportParameter DiscountedTotal;
                if (cshier.lblDiscountPercent.Visible == true)
                {
                    Discount = new ReportParameter("pDiscount", "Discount: " + cshier.lblDiscountAmount.Text);
                    Total = new ReportParameter("pTotal", "Subtotal: " + cshier.lblTotalAmount.Text);
                    DiscountedTotal = new ReportParameter("pDiscountedOrNotTotal", "Total Amount" + cshier.lblDiscountedTotal.Text);
                }
                else
                {
                    Discount = new ReportParameter("pDiscount", "Discount: " + "₱0.00");
                    Total = new ReportParameter("pTotal", "Subtotal: " + cshier.lblTotalAmount.Text);
                    DiscountedTotal = new ReportParameter("pDiscountedOrNotTotal", "Total Amount: " + cshier.lblTotalAmount.Text);
                }

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

                ReportParameter CustomerCash = new ReportParameter("pCustomerCash", "Cash: " + cash);
                ReportParameter CustomerChange = new ReportParameter("pCustomerChange", "Change: " + change);
                ReportParameter StoreName = new ReportParameter("pStoreName", "Store: " + storeName1);
                ReportParameter StoreAddress = new ReportParameter("pStoreAddress", "Addess: " + address1);
                ReportParameter TransactNo = new ReportParameter("pTransactNo", "Invoice #: " + cshier.lblTransu.Text);
                ReportParameter Cashier = new ReportParameter("pCashier", "Cashier: " + cshier.txtName.Text);
                ReportParameter CustName = new ReportParameter("pCustomer", "Customer: " + cshier.txtCustomerName.Text);
                ReportParameter orderType = new ReportParameter("pOrderType", "Type: " + cshier.txtOrderType.Text);

                reportViewer1.LocalReport.SetParameters(Discount);
                reportViewer1.LocalReport.SetParameters(Total);
                reportViewer1.LocalReport.SetParameters(DiscountedTotal);
                reportViewer1.LocalReport.SetParameters(CustomerCash);
                reportViewer1.LocalReport.SetParameters(CustomerChange);
                reportViewer1.LocalReport.SetParameters(StoreName);
                reportViewer1.LocalReport.SetParameters(StoreAddress);
                reportViewer1.LocalReport.SetParameters(TransactNo);
                reportViewer1.LocalReport.SetParameters(Cashier);
                reportViewer1.LocalReport.SetParameters(CustName);
                reportViewer1.LocalReport.SetParameters(orderType);

                rpdatasource = new ReportDataSource("DataSet1", ds.Tables["dtReceipt"]);
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
