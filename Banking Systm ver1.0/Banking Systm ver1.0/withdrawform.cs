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
    public partial class withdrawform : Form
    {
        Bank_DatabaseEntities2 con;
        decimal serial_no;
        public withdrawform()
        {
            InitializeComponent();
            loadaccount();
            loaddate();
        }
        void loaddate()
        {
            tbwithdrawdate.Text = DateTime.Now.ToString();
        }
        void loadaccount()
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                var item = con.debits.ToArray();
                if (item.Length > 0)
                {
                    serial_no = item[item.Length - 1].serial_no + 1;
                }
                else
                {
                    serial_no = 1;
                }
                lserialno.Text = serial_no.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbaccountno.Text == string.Empty)
                {
                    MessageBox.Show("Enter An Account Number For Fetching Details");
                }
                else
                {
                    con = new Bank_DatabaseEntities2();
                    decimal accountno = Convert.ToDecimal(tbaccountno.Text);
                    var accnoexist = con.user_account.FirstOrDefault(u => u.account_no == accountno);
                    if (accnoexist != null)
                    {
                        var item = (from u in con.user_account
                                    where u.account_no == accountno
                                    select u).FirstOrDefault();
                        tbname.Text = item.name;
                        tbaccountbalance.Text = Convert.ToString(item.balance);
                    }
                    else
                    {
                        MessageBox.Show("Account Does not exist");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                debit dp = new debit();
                dp.account_no = Convert.ToDecimal(tbaccountno.Text);
                dp.debit_date = tbwithdrawdate.Text;
                dp.serial_no = serial_no;
                dp.old_balance = Convert.ToDecimal(tbaccountbalance.Text);
                dp.debit_amount = Convert.ToDecimal(tbwithdrawamount.Text);
                dp.debit_Mode = ctbmode.Text;
                dp.name = tbname.Text;
                con.debits.Add(dp);
                decimal acc = Convert.ToDecimal(tbaccountno.Text);
                var item = (from u in con.user_account
                            where u.account_no == acc
                            select u).FirstOrDefault();
                if (Convert.ToDecimal(tbaccountbalance.Text) > Convert.ToDecimal(tbwithdrawamount.Text))
                {
                    item.balance = item.balance - Convert.ToDecimal(tbwithdrawamount.Text);
                    con.SaveChanges();
                    MessageBox.Show("Money Withdraw Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("You Don't Have Enough Amount To Withdraw\nEnter Your Amount According To Your Account Balance");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}