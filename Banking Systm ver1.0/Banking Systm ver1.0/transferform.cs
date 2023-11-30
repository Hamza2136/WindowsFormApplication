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
    public partial class transferform : Form
    {
        Bank_DatabaseEntities2 con;
        decimal serial_no;
        public transferform()
        {
            InitializeComponent();
            loaddate();
            loadserial_no();
        }
        void loaddate()
        {
            tbtransferdate.Text = DateTime.Now.ToString();
        }
        void loadserial_no()
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                var item = con.transfers.ToArray();
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
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbfaccountno.Text == string.Empty)
                {
                    MessageBox.Show("Enter An Account Number For Fetching Details");
                }
                else
                {
                    con = new Bank_DatabaseEntities2();
                    decimal faccno = Convert.ToDecimal(tbfaccountno.Text);
                    var existingAccount = con.user_account.FirstOrDefault(u => u.account_no == faccno);
                    if (existingAccount != null)
                    {
                        var item = (from u in con.user_account
                                    where u.account_no == faccno
                                    select u).FirstOrDefault();
                        tbname.Text = item.name;
                        tbtotalbalance.Text = Convert.ToString(item.balance);
                    }
                    else
                    {
                        MessageBox.Show("Account No Does not Exist\nEnter a Valid Account No");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                decimal faccno = Convert.ToDecimal(tbfaccountno.Text);
                var facxexist = con.user_account.FirstOrDefault(a => a.account_no == faccno);
                if (facxexist != null)
                {
                    var item = (from u in con.user_account
                                where u.account_no == faccno
                                select u).FirstOrDefault();
                    decimal totalbalance = Convert.ToDecimal(item.balance);
                    decimal transferamount = Convert.ToDecimal(tbamount.Text);
                    decimal taccno = Convert.ToDecimal(tbdaccountno.Text);
                    var daccexist = con.user_account.FirstOrDefault(a => a.account_no == taccno);
                    if (daccexist != null)
                    {
                        if (taccno == faccno)
                        {
                            MessageBox.Show("You can't send money to the same account");
                            this.Close();

                        }
                        else
                        {
                            if (totalbalance > transferamount)
                            {
                                var item2 = (from u in con.user_account
                                             where u.account_no == taccno
                                             select u).FirstOrDefault();
                                item2.balance = item2.balance + transferamount;
                                item.balance = item.balance - transferamount;
                                transfer trans = new transfer();
                                trans.account_no = faccno;
                                trans.transfer_to = taccno;
                                trans.transfer_date = tbtransferdate.Text;
                                trans.s_no = serial_no;
                                trans.balance = transferamount;
                                trans.name = tbname.Text;
                                con.transfers.Add(trans);
                                con.SaveChanges();
                                MessageBox.Show("Money Tranfer Successfully");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Your Balance is lower than the transfer amount");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Transfer Account Does not Exist");
                    }
                }
                else
                {
                    MessageBox.Show("From Account Does not Exist");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
