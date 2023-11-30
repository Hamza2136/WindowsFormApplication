using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Systm_ver1._0
{
    public partial class balancesheetform : Form
    {
        Bank_DatabaseEntities2 con;
        public balancesheetform()
        {
            InitializeComponent();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            con = new Bank_DatabaseEntities2();
            decimal accno = Convert.ToDecimal(tbaccountno.Text);
            var existingAccount = con.user_account.FirstOrDefault(u => u.account_no == accno);
            if (existingAccount != null)
            {
                var withdraw = (from u in con.debits
                                where u.account_no == accno
                                select u);
                gviewwithdraw.DataSource = withdraw.ToList();
                var deposit = (from u in con.deposits
                               where u.account_no == accno
                               select u);
                gviewdeposit.DataSource = deposit.ToList();
                var transfer = (from u in con.transfers
                                where u.account_no == accno
                                select u);
                gviewtransfer.DataSource = transfer.ToList();
            }
            else
            {
                MessageBox.Show("Account No Does not Exist\nEnter a Valid Account No");
            }


        }
    }
}
