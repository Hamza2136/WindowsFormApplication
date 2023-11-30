using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banking_Systm_ver1._0
{
    public partial class NewAcc : Form
    {
        Bank_DatabaseEntities2 con;
        MemoryStream ms;
        decimal new_acc_no;

        public NewAcc()
        {
            InitializeComponent();
            loaddate();
            loadaccount();
        }

        void loaddate()
        {
            linputdate.Text = DateTime.Now.ToString("dd-MMM-yyyy");
        }
        void loadaccount()
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                var item = con.user_account.ToArray();
                new_acc_no = item.LastOrDefault().account_no + 1;
                linacc_no.Text = new_acc_no.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnuploadpic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDlg = new OpenFileDialog();
                if (openFileDlg.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDlg.FileName);
                    picuser.Image = img;
                    ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                user_account acc = new user_account();
                acc.account_no = Convert.ToDecimal(linacc_no.Text);
                acc.name = tbname.Text;
                acc.dob = ctbdob.Text;
                acc.cnic = Convert.ToDecimal(tbcnicnumber.Text);
                acc.registration_date = linputdate.Text;
                acc.picture = ms.ToArray();
                acc.father_name = tbfathername.Text;
                acc.address = tbaddress.Text;
                acc.mother_name = tbmothername.Text;
                acc.state = tbstate.Text;
                acc.district = tbdistrict.Text;
                acc.gender = ctbgender.Text;
                acc.martial_status = ctbmartialstatus.Text;
                acc.balance = Convert.ToDecimal(tbbalance.Text);
                acc.phone_no = Convert.ToDecimal(tbphoneno.Text);
                con.user_account.Add(acc);
                con.SaveChanges();
                MessageBox.Show("Account Added");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
