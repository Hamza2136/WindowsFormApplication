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
    public partial class Update_SearchAcc : Form
    {
        Bank_DatabaseEntities2 con;
        MemoryStream ms;
        BindingList<user_account> u1;
       
        public Update_SearchAcc()
        {
            InitializeComponent();
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                decimal acc = Convert.ToDecimal(tbaccountno.Text);
                user_account useraccount = con.user_account.First(s=>s.account_no.Equals(acc));
                useraccount.dob = ctbdob.Text;
                useraccount.name = tbname.Text;
                useraccount.cnic = Convert.ToDecimal(tbcnic.Text);
                useraccount.registration_date = tbregistrationdate.Text;
                useraccount.father_name = tbfathername.Text;
                useraccount.address = tbaddress.Text;
                useraccount.mother_name = tbmothername.Text;
                useraccount.state = tbstate.Text;
                useraccount.district = tbdistrict.Text;
                useraccount.gender = ctbgender.Text;
                useraccount.martial_status = ctbmartials.Text;
                useraccount.balance = Convert.ToDecimal(tbbalance.Text);
                useraccount.phone_no = Convert.ToDecimal(tbphone.Text);
                Image img = picuser.Image;
                if (img.RawFormat != null)
                {
                    if (ms != null)
                    {
                        img.Save(ms, img.RawFormat);
                        useraccount.picture = ms.ToArray();
                    }
                }
                con.SaveChanges();
                MessageBox.Show("Account Updated");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            try
            {
                u1 = new BindingList<user_account>();
                con = new Bank_DatabaseEntities2();
                decimal accno = Convert.ToDecimal(tbaccountno.Text);
                var existingAccount = con.user_account.FirstOrDefault(u => u.account_no == accno);
                if (existingAccount != null)
                {
                    var item = con.user_account.Where(a => a.account_no == accno);
                    foreach (var item1 in item)
                    {
                        u1.Add(item1);
                    }
                    gview.DataSource = u1;
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                u1 = new BindingList<user_account>();
                con = new Bank_DatabaseEntities2();
                string name = tbname.Text;
                var existingAccount = con.user_account.FirstOrDefault(u => u.name == name);
                if (existingAccount != null)
                {
                    var item = con.user_account.Where(a => a.name == name);
                    foreach (var item1 in item)
                    {
                        u1.Add(item1);
                    }
                    gview.DataSource = u1;
                }
                else
                {
                    MessageBox.Show("No Account Found With This Name");
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void gview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                con = new Bank_DatabaseEntities2();
                decimal accno = Convert.ToDecimal(gview.Rows[e.RowIndex].Cells[0].Value);
                var item = con.user_account.Where(a => a.account_no == accno).FirstOrDefault();
                tbregistrationdate.Text = item.registration_date.ToString();
                tbaccountno.Text = item.account_no.ToString();
                tbaddress.Text = item.address.ToString();
                tbname.Text = item.name.ToString();
                tbstate.Text = item.state.ToString();
                tbdistrict.Text = item.district.ToString();
                tbfathername.Text = item.father_name.ToString();
                tbmothername.Text = item.mother_name.ToString();
                tbcnic.Text = item.cnic.ToString();
                tbphone.Text = item.phone_no.ToString();
                tbbalance.Text = item.balance.ToString();
                ctbmartials.Text = item.martial_status.ToString();
                ctbgender.Text = item.gender.ToString();
                DateTime dob = Convert.ToDateTime(item.dob);
                ctbdob.Value = dob;
                byte[] img = item.picture;
                MemoryStream ms = new MemoryStream(img);
                picuser.Image = Image.FromStream(ms);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnuploadpic_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog opendlg = new OpenFileDialog();
                if (opendlg.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(opendlg.FileName);
                    picuser.Image = img;
                    ms = new MemoryStream();
                    img.Save(ms, img.RawFormat);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                u1.RemoveAt(gview.SelectedRows[0].Index);
                con = new Bank_DatabaseEntities2();
                decimal accno = Convert.ToDecimal(tbaccountno.Text);
                var existingAccount = con.user_account.FirstOrDefault(u => u.account_no == accno);
                if (existingAccount != null)
                {
                    user_account acc = con.user_account.First(s => s.account_no.Equals(accno));
                    con.user_account.Remove(acc);
                    con.SaveChanges();
                    MessageBox.Show("Account Successfully Deleted");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account Does not Exist");
                }     
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }
    }
}
