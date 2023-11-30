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
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }
        private void t1_Tick(object sender, EventArgs e)
        {
            pmoving.Width += 3;
            if(pmoving.Width >= 600) { 
                t1.Stop();
                Login lgform = new Login();
                lgform.Show();
                this.Hide();
            }
        }
    }
}
