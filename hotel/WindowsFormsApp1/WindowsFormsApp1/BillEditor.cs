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
    public partial class BillEditor : Form
    {
        private SqlConnection connection;
        public BillEditor()
        {
            InitializeComponent();
        }

        public BillEditor(string roomNumber)
        {
            InitializeComponent();
            CustomerNameByRoomNumber(roomNumber);

        }

        private void CustomerNameByRoomNumber(string roomNumber)
        {
            lbl_RoomNumber.Text = roomNumber;
            Guest guest = Guest.CustomerNameByRoomNumber(roomNumber);
            lbl_CustomerName.Text = $"{guest.GetDesignation()}. {guest.GetFirstName()} {guest.GetLastName()}";
        }
        private void Btn_Room_Click(object sender, EventArgs e)
        {
            CustomerNameByRoomNumber(txt_RoomNumberInput.Text);
            refreshDataGridView();
        }

        private void BillEditor_Load(object sender, EventArgs e)
        {
            connection = db.GetConnection();
            refreshDataGridView();
        }

        private void Txt_ItemNumberInput_TextChanged(object sender, EventArgs e)
        {
            MenuItemByItemNumber(txt_ItemNumberInput.Text);
        }

        private void MenuItemByItemNumber(string item_number)
        {
            MenuItem menuItem = MenuItem.MenuItemByItemNumber(item_number);
            lbl_ItemNumber.Text = menuItem.GetItemNumber();
            lbl_ItemName.Text = menuItem.GetItemName();
            lbl_ItemPrice.Text = menuItem.GetItemPrice().ToString();
            TxtQuantityChanged();
        }

        private void Txt_QuantityInput_TextChanged(object sender, EventArgs e)
        {
            TxtQuantityChanged();   
        }

        // This method is delegated because it is called from another location.
        // So its better if its not an event handler.
        private void TxtQuantityChanged()
        {
            try
            {
                float price = float.Parse(lbl_ItemPrice.Text);
                int quantity = int.Parse(txt_QuantityInput.Text);
                float total = price * quantity;
                lbl_ItemTotal.Text = total.ToString();
            }
            catch (FormatException ex)
            {
                // this is here to ignore errors, we don't have to react to it here.
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string insertString = $@"
                    INSERT INTO roomBills
                    (room_number, item_number, item_price, item_quantity, item_total)
                    VALUES(
                    '{lbl_RoomNumber.Text}',
                    '{txt_ItemNumberInput.Text}',
                    {lbl_ItemPrice.Text},
                    {txt_QuantityInput.Text},
                    {lbl_ItemTotal.Text})";

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
                if (connection != null)
                {
                    connection.Close();
                }
                refreshDataGridView();
            }
        }

        private void refreshDataGridView()
        {
            string query = $"SELECT * from roomBills where room_number = '{lbl_RoomNumber.Text}'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds, "roomBills_table");
            connection.Close();
            dataGridView_Bill.DataSource = ds;
            dataGridView_Bill.DataMember = "roomBills_table";

            dataGridView_Bill.Columns[0].Visible = false;
            dataGridView_Bill.Columns[1].Visible = false;
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            refreshDataGridView();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            BillViewer billViewer = new BillViewer(lbl_RoomNumber.Text);
            billViewer.ShowDialog();
            
        }

        private void Lbl_ItemNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
