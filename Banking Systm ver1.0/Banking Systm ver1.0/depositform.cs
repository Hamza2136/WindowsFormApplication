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
    public partial class depositform : Form
    {
        Bank_DatabaseEntities2 con;
        decimal serial_no;
        public depositform()
        {
            InitializeComponent();
            loaddate();
            loadserialno();
        }
        private void loadserialno()
        {
            con = new Bank_DatabaseEntities2();
            var item = con.deposits.ToArray();
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
        void loaddate()
        {
            tbdepositdate.Text = DateTime.Now.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Bank_DatabaseEntities2 con = new Bank_DatabaseEntities2();
            decimal acc_no = Convert.ToDecimal(tbaccountno.Text);
            var existingAccount = con.user_account.FirstOrDefault(u => u.account_no == acc_no);
            if (existingAccount != null)
            {
                var item = (from u in con.user_account
                            where u.account_no == acc_no
                            select u).FirstOrDefault();
                tbname.Text = item.name;
                tboldbalance.Text = item.balance.ToString();
            }
            else
            {
                MessageBox.Show("Account Does not Exist");
            }


        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                Bank_DatabaseEntities2 con = new Bank_DatabaseEntities2();
                deposit dp = new deposit();
                dp.deposit_date = tbdepositdate.Text.ToString();
                dp.serial_no = serial_no;
                dp.account_no = Convert.ToDecimal(tbaccountno.Text);
                dp.old_balance = Convert.ToDecimal(tboldbalance.Text);
                dp.name = tbname.Text;
                dp.deposit_amount = Convert.ToDecimal(tbdepositamount.Text);
                dp.deposit_Mode = ctbmode.Text;
                con.deposits.Add(dp);
                con.SaveChanges();
                decimal acc_no = Convert.ToDecimal(tbaccountno.Text);
                var existingAccount = con.user_account.FirstOrDefault(u => u.account_no == acc_no);
                if (existingAccount != null)
                {
                    var item = (from u in con.user_account
                                where u.account_no == acc_no
                                select u).FirstOrDefault();
                    item.balance = item.balance + Convert.ToDecimal(tbdepositamount.Text);
                    con.SaveChanges();
                    MessageBox.Show("Amount Deposit Successfully");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account Does not Exist");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
