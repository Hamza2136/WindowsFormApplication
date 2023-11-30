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
    public partial class changePassform : Form
    {
        public changePassform()
        {
            InitializeComponent();
        }

        private void btnchangepass_Click(object sender, EventArgs e)
        {
            try
            {
                Bank_DatabaseEntities2 con = new Bank_DatabaseEntities2();
                if (tbusername.Text != string.Empty && tboldpass.Text != string.Empty && tbnewpass.Text != string.Empty && tbrnewpass.Text != string.Empty)
                {
                    admin_Table ad = con.admin_Table.FirstOrDefault(a => a.username.Equals(tbusername.Text));
                    if (ad != null)
                    {
                        if (ad.password == tboldpass.Text)
                        {
                            if (tbnewpass.Text == tbrnewpass.Text)
                            {
                                ad.password = tbnewpass.Text;
                                con.SaveChanges();
                                MessageBox.Show("Password Changed Successfully");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("New Password and Re-type new Password Not Matched");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Old Password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User Not Exist");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
