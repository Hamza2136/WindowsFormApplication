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
    public partial class newuserform : Form
    {
        public newuserform()
        {
            InitializeComponent();
        }

        private void btnadduser_Click(object sender, EventArgs e)
        {
            try
            {
                Bank_DatabaseEntities2 con = new Bank_DatabaseEntities2();
                admin_Table adt = new admin_Table();
                if (tbusername.Text != string.Empty && tbemail.Text != string.Empty && tbpass.Text != string.Empty && tbrpass.Text != string.Empty)
                {
                    if (tbpass.Text == tbrpass.Text)
                    {
                        adt.username = tbusername.Text;
                        adt.email = tbemail.Text;
                        adt.password = tbpass.Text;
                        con.admin_Table.Add(adt);
                        con.SaveChanges();
                        MessageBox.Show("New User Successfully Added");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Password and Retype Password Did not Matched");
                    }
                }
                else
                {
                    MessageBox.Show("Required Fields Cannot Be Empty");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
