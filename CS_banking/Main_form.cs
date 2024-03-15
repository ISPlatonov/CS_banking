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
    public partial class Main_form : Form
    {
        public Main_form(MySqlConnection connection, String username, String password)
        {
            InitializeComponent();
            this.connection = connection;
            this.username = username;
            this.password = password;
            label1.Text = "Welcome " + username;
            label2.Text = "Balance: " + get_balance();
        }

        private decimal get_balance()
        {
            try
            {
                string query = "SELECT balance FROM accounts WHERE name = '" + username + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                decimal balance = reader.GetDecimal(0);
                reader.Close();
                return balance;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
        }

        private MySqlConnection connection;
        private string username;
        private string password;
    }
}
