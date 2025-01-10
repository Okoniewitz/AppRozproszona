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
        private string connectionString = "Server=193.106.130.55;Database=Project;";
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
                    return dataTable;
                    //dataGridView1.DataSource = dataTable; // Wyświetlanie danych w DataGridView
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
            connectionString+= $"Uid = {textBox_login}; Pwd = {textBox_password}";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Połączenie nawiązane pomyślnie!");
                    label_login.Visible = false;
                    label_password.Visible = false;
                    textBox_password.Visible=false;
                    textBox_login.Visible=false;
                    button_connect.Visible=false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Błąd połączenia: {ex.Message}");
                }
            }

        }
    }
}
