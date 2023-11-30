using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Systm_ver1._0
{
    public partial class FDform : Form
    {
        Bank_DatabaseEntities2 con;
        decimal serial_no;
        public FDform()
        {
            InitializeComponent();
            loaddate();
            loadserialno();
        }
        void loaddate()
        {
            tbdate.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }
        private void loadserialno()
        {
            con = new Bank_DatabaseEntities2();
            var item = con.FDs.ToArray();
            if (item.Length > 0)
            {
                serial_no = item[item.Length - 1].s_no + 1;
            }
            else
            {
                serial_no = 1;
            }
            lserialno.Text = serial_no.ToString();
        }
        private void btnstartfd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbaccountnumber.Text == String.Empty)
                {
                    MessageBox.Show("Enter Account Number");
                }
                else
                {
                    con = new Bank_DatabaseEntities2();
                    decimal accno = Convert.ToDecimal(tbaccountnumber.Text);
                    var accountexist = con.user_account.FirstOrDefault(a => a.account_no == accno);
                    if (accountexist != null)
                    {
                        var accounts = con.user_account.Where(a => a.account_no == accno).SingleOrDefault();
                        FD fdform = new FD();
                        fdform.account_no = accno;
                        fdform.rupees = Convert.ToDecimal(tbrupees.Text);
                        fdform.intrest_rate = Convert.ToDecimal(tbintrestrate.Text);
                        fdform.fd_mode = ctbmode.Text;
                        fdform.period = Convert.ToInt32(tbperiod.Text);
                        fdform.start_date = DateTime.Now.ToString("MM/dd/yyyy");
                        fdform.maturity_date = (DateTime.Now.AddDays(Convert.ToInt32(tbperiod.Text))).ToString();
                        fdform.maturity_amount = ((Convert.ToDecimal(tbrupees.Text) * Convert.ToInt32(tbperiod.Text) * Convert.ToDecimal(tbintrestrate.Text)) / (100 * 12 * 30)) + (Convert.ToDecimal(tbrupees.Text));
                        fdform.s_no = Convert.ToDecimal(lserialno.Text);
                        con.FDs.Add(fdform);
                        decimal amount = Convert.ToDecimal(tbrupees.Text);
                        decimal totalamount = Convert.ToDecimal(accounts.balance);
                        decimal fdamount = totalamount - amount;
                        accounts.balance = fdamount;
                        con.SaveChanges();
                        MessageBox.Show("FD Started Now");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Account Does not Exist");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
