using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class mainMenuCalculation : Form
    {
        public mainMenuCalculation()
        {
            InitializeComponent();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {
            panel_Menu.BringToFront();
        }

        private void Btn_Calculate_Click(object sender, EventArgs e)
        {
            panel_Calculate.BringToFront();
        }

        private void Btn_AddModifyDelete_Click(object sender, EventArgs e)
        {
            MenuItemManager menuItemManager = new MenuItemManager();
            menuItemManager.ShowDialog();
        }

        private void Btn_Show_Click(object sender, EventArgs e)
        {
            MenuItemViewer menuItemViewer = new MenuItemViewer();
            menuItemViewer.ShowDialog();
        }

        private void Btn_Go_Click(object sender, EventArgs e)
        {
            string roomNumber = txt_RoomNumber.Text;
            if(roomNumber == null)
            {
                BillEditor billEditor = new BillEditor();
                billEditor.ShowDialog();
            }
            else
            {
                BillEditor billEditor = new BillEditor(roomNumber);
                billEditor.ShowDialog();
            }
        }
    }
}
