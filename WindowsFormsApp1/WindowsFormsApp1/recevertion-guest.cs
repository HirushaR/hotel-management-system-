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
    public partial class recevertion_guest : Form
    {
        public recevertion_guest()
        {
            InitializeComponent();
        }

        private void MonthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string fnm = textBox2.Text;
            string lnm = textBox3.Text;
            string desig = textBox4.Text;
            string add1 = textBox5.Text;
            string add2 = textBox6.Text;
            string country = textBox7.Text;
            string date = textBox8.Text;
            string remarks = textBox9.Text;
            string likes = textBox10.Text;
            string diss = textBox11.Text;
            string gutitle = textBox12.Text;
            string status = textBox13.Text;
            string nic = textBox14.Text;
            string passport = textBox15.Text;
            string tp = textBox16.Text;
            string email = textBox17.Text;
            string nationality = textBox18.Text;
            string creator = Form1.unm;
            string cdate = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            MessageBox.Show("" + cdate + ""+ creator);
        }
    }
}
