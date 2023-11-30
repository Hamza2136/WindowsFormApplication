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
    public partial class forgetpassform : Form
    {
        public forgetpassform()
        {
            InitializeComponent();
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbusername.Text != string.Empty && tbemail.Text != string.Empty)
                {
                    Bank_DatabaseEntities2 con = new Bank_DatabaseEntities2();
                    var item = con.admin_Table.FirstOrDefault(a => a.username.Equals(tbusername.Text));
                    if (item != null)
                    {
                        if (item.email == tbemail.Text)
                        {
                            MessageBox.Show($"Your Password is ===> {item.password}");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Email does not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username Does not Match");
                    }
                }
                else
                {
                    MessageBox.Show("Fill the Username Or Email");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
