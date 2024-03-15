using MySql.Data.MySqlClient;

namespace CS_banking
{
    public partial class Sign_in_form : Form
    {
        public Sign_in_form(MySqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
            button_sign_in.Click += button_sign_in_Click;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_sign_in_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;
            if (sign_in(username, password))
            {
                Main_form main_form = new Main_form(connection, username, password);
                this.Hide();
                main_form.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private bool sign_in(string username, string password)
        {
            try
            {
                string query = "SELECT * FROM accounts join passwords on accounts.id = passwords.id WHERE name = '" + username + "' AND password = '" + password + "'";
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
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
