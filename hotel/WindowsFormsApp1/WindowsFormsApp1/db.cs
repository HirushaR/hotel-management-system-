using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class db
    {
        static string DB_PATH = "E:\\C# Assignment\\hotel\\hotel.mdf";
       
        public static SqlConnection GetConnection()
        {
            // this is database class
            string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DB_PATH + ";Integrated Security=True;Connect Timeout=30";
            SqlConnection mycon = new SqlConnection(conn);
            return mycon;
        }
    }
}
