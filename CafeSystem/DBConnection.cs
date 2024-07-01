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

    
        public string myConnection()
        {
            con = "Data Source=WIN-1859R8IA7RE\\SQLEXPRESS;Initial Catalog=POS_CAFE_SYSTEM;Integrated Security=True;Encrypt=False";
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
        
    }
}
