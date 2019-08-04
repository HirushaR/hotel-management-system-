using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class MenuItem
    {
        private string ItemNumber;
        private string ItemName;
        private float ItemPrice;

        public void SetItemNumber(string itemnumber)
        {
            ItemNumber = itemnumber;
        }
        public void SetItemName(string itemname)
        {
            ItemName = itemname;
        }
        public void SetItemPrice(float itemprice)
        {
            ItemPrice = itemprice;
        }

        public string GetItemNumber()
        {
            return ItemNumber;
        }
        public string GetItemName()
        {
            return ItemName;
        }
        public float GetItemPrice()
        {
            return ItemPrice;
        }


        public static MenuItem MenuItemByItemNumber(string item_number)
        {
            SqlConnection connection = db.GetConnection();
            SqlDataReader reader = null;
            MenuItem menuItem = new MenuItem();
            try
            {
                string query = $"SELECT * FROM menuItems WHERE item_no = '{item_number}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    menuItem.SetItemNumber(reader["item_no"].ToString().Trim());
                    menuItem.SetItemName(reader["item_name"].ToString().Trim());
                    menuItem.SetItemPrice(float.Parse(reader["item_price"].ToString().Trim()));
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }

                if (connection != null)
                {
                    connection.Close();
                }
            }

            return menuItem;
        }
    }
}
