using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MenuItemManager : Form
    {
        private SqlConnection connection;
        public MenuItemManager()
        {
            InitializeComponent();
        }

        private void btn_SearchByName_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null; // this is null because of the try/catch block.
            try
            {
                string query = $"SELECT * FROM menuItems WHERE item_name = '{txt_SearchInput.Text}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_ItemNumber.Text = reader["item_no"].ToString();
                    txt_ItemName.Text = reader["item_name"].ToString();
                    txt_ItemDescription.Text = reader["item_description"].ToString();
                    txt_ItemPrice.Text = reader["item_price"].ToString();
                    txt_ItemCategory.Text = reader["item_category"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }

                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void MenuItemManager_Load(object sender, EventArgs e)
        {
            connection = db.GetConnection();
        }

        private void Btn_SearchByNumber_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null; // this is null because of the try/catch block.
            try
            {
                string query = $"SELECT * FROM menuItems WHERE item_no = '{txt_SearchInput.Text}'";
                SqlCommand cmd = new SqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txt_ItemNumber.Text = reader["item_no"].ToString();
                    txt_ItemName.Text = reader["item_name"].ToString();
                    txt_ItemDescription.Text = reader["item_description"].ToString();
                    txt_ItemPrice.Text = reader["item_price"].ToString();
                    txt_ItemCategory.Text = reader["item_category"].ToString();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if(reader != null)
                {
                    reader.Close();
                }

                if(connection != null)
                {
                    connection.Close();
                }
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertString = $@"
                    INSERT INTO menuItems
                    (item_no, item_name, item_description, item_price, item_category)
                    VALUES(
                    '{txt_ItemNumber.Text}',
                    '{txt_ItemName.Text}',
                    '{txt_ItemDescription.Text}',
                    {txt_ItemPrice.Text},
                    '{txt_ItemCategory.Text}')";

                SqlCommand cmd = new SqlCommand(insertString, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if(connection != null)
                {
                    connection.Close();
                }

                MessageBox.Show("Added Successfully!");
                Clear_Text();
            }
        }

        /**
         * To run the UPDATE SQL query a WHERE clause is needed.
         * I am using item_no as the WHERE clause.
         * Assuming that item_no doesn't change.
         */
        private void Btn_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                string updateString = $@"
                    UPDATE menuItems
                    SET 
                    item_name = '{txt_ItemName.Text}',
                    item_description = '{txt_ItemDescription.Text}',
                    item_price = '{txt_ItemPrice.Text}',
                    item_category = '{txt_ItemCategory.Text}'
                    WHERE
                    item_no = '{txt_ItemNumber.Text}'";

                SqlCommand cmd = new SqlCommand(updateString, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

                MessageBox.Show("Modified Successfully!");
                Clear_Text();
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteString = $"DELETE from menuItems where item_no = '{txt_ItemNumber.Text}'";
                SqlCommand cmd = new SqlCommand(deleteString, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SqlException occured. Timeout.");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("InvalidOperationException occured. The connection to database was either not open, or closed during operation.");
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }

                MessageBox.Show("Deleted Successfully!");
                Clear_Text();
            }
        }

        private void Txt_SearchInput_Click(object sender, EventArgs e)
        {
            txt_SearchInput.Text = "";
        }
        private void Clear_Text()
        {
            txt_ItemNumber.Text = "";
            txt_ItemName.Text = "";
            txt_ItemName.Text = "";
            txt_ItemDescription.Text = "";
            txt_ItemPrice.Text = "";
            txt_ItemCategory.Text = "";
        }
    }
}
