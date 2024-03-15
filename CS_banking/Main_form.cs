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
            send_money.Click += send_money_Click;
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

        private void send_money_Click(object sender, EventArgs e)
        {
            Send_money_form send_money_form = new Send_money_form(connection, username);
            // Block the main form until the send_money_form is closed
            this.Hide();
            send_money_form.ShowDialog();
            this.Show();
            // Update the balance after the send_money_form is closed
            label2.Text = "Balance: " + get_balance();
        }

        private MySqlConnection connection;
        private string username;
        private string password;
    }
}
