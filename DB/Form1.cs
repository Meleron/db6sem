﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=student;database=mydb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            //admin:123
            MySqlCommand command = new MySqlCommand($"SELECT * FROM mydb.user WHERE user.username = '{loginBox.Text}' AND user.password = '{passwordBox.Text}'", connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Wrong password!");
                return;
            }
            else
                MessageBox.Show("Login succeed!");
            connection.Close();
            this.Hide();
            new Form2().Show();
            
        }
    }
}
