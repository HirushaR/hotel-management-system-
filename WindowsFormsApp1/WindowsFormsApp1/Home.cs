﻿using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            roomRecervation1.BringToFront();

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            roomRecervation1.BringToFront();
        }

        private void RoomRecervation1_Load(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
