using System;
using System.Data.OracleClient;

namespace Login_Page__with_database_
{
    public partial class registration_form : Form
    {
        OracleConnection con = new OracleConnection("User Id=hr;Password=12345678;Data Source=localhost:1521/xe");
        public registration_form()
        {
            InitializeComponent();
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {

            try
            {
                if (tbrpassword.Text == tbrcpassword.Text)
                {
                    con.Open();
                    OracleCommand cmd = new OracleCommand("insert into login(username, password, name, email) values(:username,:password,:name,:email)", con);
                    cmd.Parameters.Add(":username", OracleType.VarChar).Value = tbrusername.Text;
                    cmd.Parameters.Add(":password", OracleType.VarChar).Value = tbrpassword.Text;
                    cmd.Parameters.Add(":name", OracleType.VarChar).Value = tbname.Text;
                    cmd.Parameters.Add(":email", OracleType.VarChar).Value = tbemail.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show($"User {tbrusername.Text} added to database");
                    this.Close();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password did not matched");
                }

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

        private void btnbtlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnmax_Click_1(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
                else
                    this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}
