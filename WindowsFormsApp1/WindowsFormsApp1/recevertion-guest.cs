﻿using System;
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
            string bdate = dateTimePicker1.Value.ToShortDateString();
            string nic = textBox14.Text;
            string passport = textBox15.Text;
            string email = textBox17.Text;
            string nationality = textBox18.Text;
            string remarks = textBox9.Text;
            string likes = textBox10.Text;
            string diss = textBox11.Text;
            string gutitle = textBox12.Text;
            string status = textBox13.Text; 
            string tp = textBox16.Text;
            string sex = "";
            bool isChecked = rgMale.Checked;
            if (isChecked)
                sex = rgMale.Text;
            else
                sex = rgFemale.Text;


            string creator = Form1.unm;
            string cdate = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");

            using (var connection = db.GetConnection())
            {
                string qry = "insert into guests values('"+fnm+"','"+lnm+ "','" + desig + "','" + add1+ "','" + country + "', '"+ bdate + "' ,'" + sex+ "','" + nic + "','" + passport + "','" + tp + "','" + email + "','" + nationality + "','" + remarks + "','" + likes + "','" + diss + "','" + DateTime.Now + "','" + creator + "'); SELECT SCOPE_IDENTITY()";
                
                SqlCommand cmd = new SqlCommand(qry, connection);
                try
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                    label20.Text =""+insertedID;
                }
                catch(SqlException sq)
                {
                    MessageBox.Show(""+sq);
                }
            }
        }

        private void DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }
    }
}
