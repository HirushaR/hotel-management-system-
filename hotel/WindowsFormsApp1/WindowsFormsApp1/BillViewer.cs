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
    public partial class BillViewer : Form
    {
        String RoomNumber;
        public BillViewer(string roomNumber)
        {
            InitializeComponent();
            RoomNumber = roomNumber;
        }

        private void BillViewer_Load(object sender, EventArgs e)
        {
            Guest guest = Guest.CustomerNameByRoomNumber(RoomNumber);
            lbl_CustomerName.Text = $"{guest.GetDesignation()}. {guest.GetFirstName()} {guest.GetLastName()}";
            lbl_RoomNumber.Text = RoomNumber;

            string query = $"SELECT * from roomBills where room_number = '{RoomNumber}'";
            SqlConnection connection = db.GetConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds, "roomBills_table");
            connection.Close();
            dataGridView_Bill.DataSource = ds;
            dataGridView_Bill.DataMember = "roomBills_table";

            dataGridView_Bill.Columns[0].Visible = false;
            dataGridView_Bill.Columns[1].Visible = false;

            float total = 0;
            foreach (DataGridViewRow row in dataGridView_Bill.Rows)
            {
                total += (float)Convert.ToDouble(row.Cells[5].Value);
            }

            lbl_TotalPrice.Text = total.ToString();
        }

        private void DataGridView_Bill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
