using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeSystem
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        private string con;
        private decimal todaysale;
        private int todayCustomer;
        private int penorder;
    
        public string myConnection()
        {
            con = "Data Source=WIN-OLQG14FG7DN\\SQLEXPRESS;Initial Catalog=POS_CAFE_SYSTEM;Integrated Security=True;Encrypt=False";
            return con;
        }

        public decimal TodayTransaction()
        {
            string sdate = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate1 = sdate + " 00:00:00";
            string EndDate1 = sdate + " 23:59:59";
            conn = new SqlConnection();
            conn.ConnectionString = con;
            conn.Open();
            cm = new SqlCommand("SELECT SUM(c.total * (1 - COALESCE(d.discountPercent, 0) / 100)) as discounted_total FROM tblCart as c LEFT JOIN tblDiscountCart as d ON c.transacno = d.transacno WHERE c.status = 'Sold' AND c.sdate BETWEEN @startDate AND @endDate", conn);
            cm.Parameters.AddWithValue("@startDate", startDate1);
            cm.Parameters.AddWithValue("@endDate", EndDate1);
           object result = cm.ExecuteScalar();
            todaysale = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            conn.Close();
            return todaysale;
        }

        public int TodaysCustomer()
        {
            string sdate = DateTime.Now.ToString("yyyy-MM-dd");
            string startDate1 = sdate + " 00:00:00";
            string EndDate1 = sdate + " 23:59:59";
            conn = new SqlConnection();
            conn.ConnectionString = con;
            conn.Open();
            cm = new SqlCommand("SELECT COUNT (DISTINCT transacno) from tblCart where sdate between @startDate and @endDate and status = 'Sold'", conn);
            cm.Parameters.AddWithValue("@startDate", startDate1);
            cm.Parameters.AddWithValue("@endDate", EndDate1);
            object result = cm.ExecuteScalar();
            todayCustomer = int.Parse(cm.ExecuteScalar().ToString());   
            conn.Close();
            return todayCustomer;
        }

        public int pendingOrders()
        {

            conn = new SqlConnection();
            conn.ConnectionString = con;
            conn.Open();
            cm = new SqlCommand("SELECT count (DISTINCT transacno) from tblCart where status = 'Pending'", conn);
            object result = cm.ExecuteScalar();
            penorder = int.Parse(cm.ExecuteScalar().ToString());
            conn.Close();
            return penorder;
        }

    }
}
