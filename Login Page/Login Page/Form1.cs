using Oracle.ManagedDataAccess.Client;
using System.Data;
using Oracle.ManagedDataAccess.Types;

namespace Login_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            if (username == "Hamza208" && password == "hamza")
            {
                MessageBox.Show("Welcome Here");
            }
            else
            {
                MessageBox.Show("Username or password does not match");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}