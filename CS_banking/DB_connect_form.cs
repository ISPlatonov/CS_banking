using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// MySQL library
using MySql.Data.MySqlClient;

namespace CS_banking
{
    public partial class DB_connect_form : Form
    {
        public DB_connect_form()
        {
            InitializeComponent();
            db_connect_button.Click += db_connect_button_Click;
        }

        private void db_connect_button_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            string host = db_address.Text;
            if (connect_to_db(username, password, host))
            {
                Sign_in_form sign_in_form = new Sign_in_form(this.connection);
                this.Hide();
                sign_in_form.Show();
            }
        }

        private bool connect_to_db(string username, string password, string host)
        {
            // Connect to the MySQL database
            string connectionString = "server=" + host + ";user id=" + username + ";password=" + password + ";database=banking";
            this.connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private MySqlConnection connection;
    }
}
