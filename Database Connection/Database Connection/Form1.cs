using System.Data.OracleClient;
namespace Database_Connection
{
    public partial class Form1 : Form
    {
        OracleConnection con = new OracleConnection("User Id=hr;Password=12345678;Data Source=localhost:1521/xe");

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string dbVersion = con.ServerVersion;
                con.Close();

                ldbstatus.Text = "Database Version: " + dbVersion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        private void btnsavedata_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OracleCommand cmd = new OracleCommand("insert into login(username, password) values(:username,:password)", con);
                cmd.Parameters.Add(":username", OracleType.VarChar).Value = tbusername.Text;
                cmd.Parameters.Add(":password", OracleType.VarChar).Value = tbpassword.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data does not inserted" + Convert.ToString(ex));
            }
        }
    }
}
