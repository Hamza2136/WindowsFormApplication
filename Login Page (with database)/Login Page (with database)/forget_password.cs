using System;
using System.Data.OracleClient;

namespace Login_Page__with_database_
{
    public partial class forget_password : Form
    {
        OracleConnection con = new OracleConnection("User Id=hr;Password=12345678;Data Source=localhost:1521/xe");
        public forget_password()
        {
            InitializeComponent();
        }

        private void btngetpassword_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("select username from login where username = :username", con);
                cmd.Parameters.Add(":username", OracleType.VarChar).Value = tbfusername.Text;
                cmd.ExecuteNonQuery();
                OracleDataReader reader = cmd.ExecuteReader();
                bool userexist = reader.HasRows;
                if (userexist == true)
                {
                    reader.Close();
                    OracleCommand cmd1 = new OracleCommand("Select email from login where username = :username", con);
                    cmd1.Parameters.Add(":username", OracleType.VarChar).Value = tbfusername.Text;
                    string email = cmd1.ExecuteScalar()?.ToString();
                    if (string.Equals(email, tbfemail.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        OracleCommand cmd2 = new OracleCommand("Select password from login where email = :email", con);
                        cmd2.Parameters.Add(":email", OracleType.VarChar).Value = tbfemail.Text;
                        string password = cmd2.ExecuteScalar()?.ToString();
                        MessageBox.Show("Your Password is\n" + password);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Email does not match");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void btnminimized_Click(object sender, EventArgs e)
        {
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btnbtlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}