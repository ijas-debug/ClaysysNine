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

namespace LoginFormOne
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-CJ6SAAMH\SQLEXPRESS;Initial Catalog=UIPATH;Persist Security Info=True;User ID=sa;Password=***********");
            SqlDataAdapter sda = new SqlDataAdapter("Select  Count (*) From Userone where Username='" + textBox1.Text + "' and Password ='" +textBox2.Text+ "'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Main ss = new Main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check your Username and Password");
            }
            
        } 
    }
}
