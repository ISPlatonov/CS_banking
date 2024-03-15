using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// MySQL library
using MySql.Data.MySqlClient;

namespace CS_banking
{
    public partial class Send_money_form : Form
    {
        public Send_money_form(MySqlConnection connection, string username)
        {
            InitializeComponent();
            this.connection = connection;
            this.username = username;
            send_button.Click += send_button_Click;
            load_recipients();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            string recipient = recipient_combobox.Text;
            decimal amount = Convert.ToDecimal(amount_textbox.Text);
            if (send_money(recipient, Convert.ToInt32(amount)))
            {
                MessageBox.Show("Money Sent");
                this.Close();
            }
            else
            {
                MessageBox.Show("Money Not Sent");
            }
        }

        private bool send_money(string recipient, int amount)
        {
            // Send money to the recipient
            try
            {
                string amount_query = "SELECT balance FROM accounts WHERE name = '" + this.username + "'";
                MySqlCommand amount_command = new MySqlCommand(amount_query, connection);
                int balance = Convert.ToInt32(amount_command.ExecuteScalar());
                if (balance < amount)
                {
                    MessageBox.Show("Insufficient funds (" + balance + ")" );
                    return false;
                }
                string take_money_query = "UPDATE accounts SET balance =" + Convert.ToString(balance - amount) + " WHERE name = '" + this.username + "'";
                MySqlCommand take_money_command = new MySqlCommand(take_money_query, connection);
                take_money_command.ExecuteNonQuery();
                string recipient_amount_query = "SELECT balance FROM accounts WHERE name = '" + recipient + "'";
                MySqlCommand recipient_amount_command = new MySqlCommand(recipient_amount_query, connection);
                int recipient_balance = Convert.ToInt32(recipient_amount_command.ExecuteScalar());
                string give_money_query = "UPDATE accounts SET balance =" + (recipient_balance + amount) + " WHERE name = '" + recipient + "'";
                MySqlCommand give_money_command = new MySqlCommand(give_money_query, connection);
                give_money_command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void load_recipients()
        {
            // Load the recipients into the combobox
            try
            {
                string query = "SELECT name FROM accounts WHERE name != '" + this.username + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    recipient_combobox.Items.Add(reader.GetString("name"));
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MySqlConnection connection;
        private string username;
    }
}
