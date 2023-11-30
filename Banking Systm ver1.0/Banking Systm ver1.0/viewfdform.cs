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
    public partial class viewfdform : Form
    {
        BindingList<FD> b1;
        Bank_DatabaseEntities2 con;
        public viewfdform()
        {
            InitializeComponent();
        }

        private void btnviewfd_Click(object sender, EventArgs e)
        {
            b1 = new BindingList<FD>();
            con = new Bank_DatabaseEntities2();
            string date = ctbdatetime.Value.ToString("MM/dd/yyyy");
            MessageBox.Show(date);
            var item = con.FDs.Where(a => a.start_date.Equals(date));
            gview.DataSource = item.ToList();
        }
    }
}
