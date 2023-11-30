using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Banking_Systm_ver1._0
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosed += MenuForm_FormClosed;
        }
        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void newAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewAcc N_acc = new NewAcc();
            N_acc.MdiParent = this;
            N_acc.Show();
        }
        private void updateToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Update_SearchAcc U_S_acc = new Update_SearchAcc();
            U_S_acc.MdiParent = this;
            U_S_acc.Show();
        }
        private void allCustomersToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            all_customer a_customer = new all_customer();
            a_customer.MdiParent = this;
            a_customer.Show();
        }
        private void depositToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            depositform d_form = new depositform();
            d_form.MdiParent = this;
            d_form.Show();
        }
        private void withdrawToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            withdrawform w_form = new withdrawform();
            w_form.MdiParent = this;
            w_form.Show();
        }
        private void transferToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            transferform t_form = new transferform();
            t_form.MdiParent = this;
            t_form.Show();
        }
        private void fDFORMToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FDform f_form = new FDform();
            f_form.MdiParent = this;
            f_form.Show();
        }
        private void balnceSheetToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            balancesheetform f_bsheet = new balancesheetform();
            f_bsheet.MdiParent = this;
            f_bsheet.Show();
        }
        private void viewToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            viewfdform f_viewfd = new viewfdform();
            f_viewfd.MdiParent = this;
            f_viewfd.Show();
        }
        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            changePassform form_cp = new changePassform();
            form_cp.MdiParent = this;
            form_cp.Show();
        }
        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
