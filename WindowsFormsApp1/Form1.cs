using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string connectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private System.Data.DataTable Query_DB(string query)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand command = new MySqlCommand(query, connection);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    //dataGridView1.DataSource = dataTable; // Wyświetlanie danych w DataGridView
                    return dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd podczas pobierania danych: {ex.Message}");
                    return null;
                }
            }
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            connectionString = $"server=localhost;database=Project;uid={textBox_login.Text};";
            //if(textBox_password.Text.Length > 0)
            //connectionString += $"pwd={textBox_password.Text};";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show($"Połączenie nawiązane pomyślnie!\nConnection string: {connectionString}");
                    label_login.Visible = false;
                    label_password.Visible = false;
                    textBox_password.Visible=false;
                    textBox_login.Visible=false;
                    button_connect.Visible=false;
                    dataGridView1.Visible = true;
                    button_query.Visible = true;
                    dataGridView1.DataSource=Query_DB("select * from test");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd połączenia: {ex.Message} \nConnection string: {connectionString}");
                }
            }

        }

        private void button_query_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=Query_DB("select * from test");
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            Query_DB($"INSERT INTO `test` (`id`, `co`, `ile_szt`) VALUES (NULL, '{textBox_add.Text}', '{textBox_add2.Text}')");
            textBox_add.Text = "";
            textBox_add2.Text = "";
        }
    }
}
