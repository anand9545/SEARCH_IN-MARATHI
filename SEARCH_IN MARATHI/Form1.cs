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

namespace SEARCH_IN_MARATHI
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-SUF46S1\\SQLEXPRESS;Initial Catalog=testing database;Integrated Security=True");
        SqlDataAdapter adp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string table_name;
            // string added show table name
            adp = new SqlDataAdapter("select * from tests WHERE name LIKE N'" + textBox1.Text + "%'", con);
            DataTable dt = new DataTable();

            adp.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
