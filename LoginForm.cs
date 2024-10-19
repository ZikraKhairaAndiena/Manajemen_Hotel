using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Manajemen_Hotel3
{
    public partial class LoginForm : Form
    {
        DBconnect connect = new DBconnect();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim().Equals("") || txtPassword.Text == "")
            {
                MessageBox.Show("Enter Your Username and password", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                string selectquery = "SELECT * FROM `users` WHERE `username` = @usn AND `password`= @pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = txtUsername.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = txtPassword.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);


                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {
                    MessageBox.Show("Your Username and password doesn't exists", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}