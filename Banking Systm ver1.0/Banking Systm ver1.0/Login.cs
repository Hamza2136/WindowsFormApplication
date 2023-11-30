using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Systm_ver1._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosed += LoginPage_FormClosed;
        }
     
    private void btnlogin_Click(object sender, EventArgs e)
        {
            Bank_DatabaseEntities2 dbe = new Bank_DatabaseEntities2();
            if(tbusername.Text!=string.Empty&&tbpassword.Text!=string.Empty)
            {
                var user1 = dbe.admin_Table.FirstOrDefault(a => a.username.Equals(tbusername.Text));
                if(user1!=null){
                    if(user1.password.Equals(tbpassword.Text))
                    {
                        Menu menu = new Menu();
                        menu.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Password Not Correct");
                    }
                }
                else
                {
                    MessageBox.Show("User not Exist");
                }
            }
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            forgetpassform fpform = new forgetpassform();
            fpform.ShowDialog();
        }
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            newuserform nuform = new newuserform();
            nuform.ShowDialog();
        }
        private void LoginPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

}
