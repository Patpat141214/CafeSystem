using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CafeSystem
{
    public class DBConnection
    {
        private string con;


    
        public string myConnection()
        {
            con = "Data Source=WIN-1859R8IA7RE\\SQLEXPRESS;Initial Catalog=POS_CAFE_SYSTEM;Integrated Security=True;Encrypt=False";
            return con;
        }
    }
}
