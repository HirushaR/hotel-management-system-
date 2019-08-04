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
    public partial class MenuItemViewer : Form
    {
        private SqlConnection connection;
        public MenuItemViewer()
        {
            InitializeComponent();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            dataGrid_Refresh();
        }

        private void dataGrid_Refresh()
        {
            string query = "SELECT * FROM menuItems";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataSet ds = new DataSet();
            connection.Open();
            adapter.Fill(ds, "menuItems_table");
            connection.Close();
            dataGridView.DataSource = ds;
            dataGridView.DataMember = "menuItems_table";
        }

        private void MenuItemViewer_Load(object sender, EventArgs e)
        {
            connection = db.GetConnection();
            dataGrid_Refresh();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
