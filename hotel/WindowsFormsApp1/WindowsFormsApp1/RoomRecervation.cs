using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RoomRecervation : UserControl
    {
        public RoomRecervation()
        {
            InitializeComponent();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            //System.Diagnostics.Process.Start("http://www.facebook.com");

        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            recevertion_guest rg = new recevertion_guest();
            rg.Show();
            this.Hide();
        }

        private void RoomRecervation_Load(object sender, EventArgs e)
        {

        }
    }
}
