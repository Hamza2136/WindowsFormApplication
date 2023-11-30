using System;
using System.Data.OracleClient;

namespace Login_Page__with_database_

{
    public partial class Form1 : Form

    {
        OracleConnection con = new OracleConnection("User Id=hr;Password=12345678;Data Source=localhost:1521/xe");
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

        }
        void sigin()
        {
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand($"select username from login where username = :username", con);
                cmd.Parameters.Add(":username", OracleType.VarChar).Value = tbusername.Text;

                OracleDataReader reader = cmd.ExecuteReader();
                bool userExists = reader.HasRows;

                if (userExists)
                {
                    reader.Close();
                    OracleCommand cmd1 = new OracleCommand($"select password from login where username = :username", con);
                    cmd1.Parameters.Add(":username", OracleType.VarChar).Value = tbusername.Text;
                    string password = cmd1.ExecuteScalar()?.ToString();
                    if (tbpassword.Text == password)
                    {

                        loading scr = new loading();
                        scr.ShowDialog();

                    }
                    else
                    {
                        tbusername.Clear();
                        tbpassword.Clear();
                        MessageBox.Show("Username Or Password not Correct");
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                sigin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnregister_Click(object sender, EventArgs e)
        {
            registration_form r_form = new registration_form();
            r_form.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                if (this.WindowState == FormWindowState.Maximized)
                    this.WindowState = FormWindowState.Normal;
                else
                    this.WindowState = FormWindowState.Maximized;
            }
        }
        private void btnforgetpassword_Click(object sender, EventArgs e)
        {
            forget_password f_password = new forget_password();
            f_password.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
