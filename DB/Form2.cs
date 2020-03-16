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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=student;database=mydb";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            connection.Open();
            dataGridView1.Columns.Add("asd", "asd");
            MySqlCommand command = new MySqlCommand("SELECT mydb.user.id, mydb.name1.name1, mydb.name2.name2, mydb.name3.name3, mydb.user.email, mydb.user.username, mydb.user.password, mydb.user.rating, mydb.role.role, mydb.user.status, mydb.user.registration_date, mydb.user.last_visit_time, mydb.user.blocked_from, mydb.user.blocked_untill FROM mydb.user " +
                                                    "inner join mydb.pers_info on mydb.user.pers_info_id = mydb.pers_info.id " +
                                                    "inner join mydb.role on mydb.user.role_id = mydb.role.id " +
                                                    "inner join mydb.name1 on mydb.pers_info.name1_id = mydb.name1.id " +
                                                    "inner join mydb.name2 on mydb.pers_info.name2_id = mydb.name2.id " +
                                                    "inner join mydb.name3 on mydb.pers_info.name3_id = mydb.name3.id", connection);
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.Rows.Clear();

            foreach (var row in table.AsEnumerable())
            {
                dataGridView1.Rows.Add(new object[] {
                    row.ItemArray[0],
                    row.ItemArray[1],
                    row.ItemArray[2],
                    row.ItemArray[3],
                    row.ItemArray[4],
                    row.ItemArray[5],
                    row.ItemArray[6],
                    row.ItemArray[7],
                    row.ItemArray[8],
                    row.ItemArray[9],
                    row.ItemArray[10],
                    row.ItemArray[11],
                    row.ItemArray[12],
                    row.ItemArray[13],
                });
            }
            connection.Close();
        }
    }
}
