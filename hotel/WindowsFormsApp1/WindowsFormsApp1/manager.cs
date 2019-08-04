using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    class manager:login
    {
        public override int log(string unm, string psw)
        {
            using (var connection = db.GetConnection())
            {

                string qer = "select * from users where manager=1 and name='" + unm + "' and password ='" + psw + "'";
                SqlCommand cmd = new SqlCommand(qer, connection);
                connection.Open();
                SqlDataReader sr = cmd.ExecuteReader();
                if (sr.Read())
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
