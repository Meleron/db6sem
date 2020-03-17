using MySql.Data.MySqlClient;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=student;database=mydb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();
            MySqlCommand createUserCommand = new MySqlCommand(
                "INSERT INTO mydb.name1 set name1 = 'Вася';" +
                "INSERT INTO mydb.name2 set name2 = 'Пупкин';" +
                "INSERT INTO mydb.name3 set name3 = 'Васильевич';", connection);
            try
            {
                createUserCommand.ExecuteNonQuery();
                MessageBox.Show("Suceed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Hide();
            }
            connection.Close();
        }
    }
}
