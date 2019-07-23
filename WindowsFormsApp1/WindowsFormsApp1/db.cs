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
        public static SqlConnection GetConnection()
        {
            // this is database class
            string conn =@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\hiru\works\C#\HMS\hotel.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection mycon = new SqlConnection(conn);
            return mycon;
        }
    }
}
