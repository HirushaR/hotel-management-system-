using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static string unm;
       
        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string psw;
            unm = textBox1.Text;
            psw = textBox2.Text;

            manager mn = new manager();
            int a = mn.log(unm,psw);
            if(a == 0)
            {
                MessageBox.Show("username password dosent match");
            }
            else
            {
                Home hm = new Home();
                this.Hide();
                hm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
