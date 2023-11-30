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
    public partial class all_customer : Form
    {
        public all_customer()
        {
            InitializeComponent();
            griddata();
        }
        void griddata()
        {
            gview.AutoGenerateColumns = false;
            Bank_DatabaseEntities2 con = new Bank_DatabaseEntities2();
            var item = con.user_account.ToList();
            gview.DataSource = item;

        }

    }
}
