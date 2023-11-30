using System;
using System.IO;
using System.Windows.Forms;

namespace File_Read_Write
{
    public partial class Form1 : Form
    {
        private DialogResult confirmation;
        public Form1()
        {
            InitializeComponent();

            confirmation = MessageBox.Show("If you want to write data click on yes?\nIf you want to read data click " +
                "on no?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.No)
            {
                this.Text = "Reading Mode";
                btnsubmit.Text = "Read Data";
                tbaddress.Visible = false;
                laddress.Visible = false;
                lgender.Visible = false;
                txgender.Visible = false;
            }
            else if (confirmation == DialogResult.Yes)
            {
                this.Text = "Writing Mode";
                rtbdataviewer.Visible = false;
                lrtdataviewer.Visible = false;
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void WriteData()
        {
            try
            {
                StreamWriter sw = new StreamWriter(Application.StartupPath + "\\Employees\\"
                    + tbfname.Text + " " + tblname.Text + ".txt");
                sw.WriteLine(lfname.Text + " " + tbfname.Text);
                sw.WriteLine(llname.Text + " " + tblname.Text);
                sw.WriteLine(lgender.Text + " " + txgender.Text);
                sw.WriteLine(laddress.Text + " " + tbaddress.Text);
                sw.Close();

                DialogResult result = MessageBox.Show("Record added Successfully" +
                    "\nDo you want to add a new record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tbfname.Clear();
                    tblname.Clear();
                    txgender.SelectedIndex = -1;
                    tbaddress.Clear();
                }
                else if (result == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        private void ReadData()
        {
            try
            {
                StreamReader sr = new StreamReader(Application.StartupPath + "\\Employees\\" + tbfname.Text + " " + tblname.Text + ".txt");
                rtbdataviewer.Text = sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Name not found!");
            }

        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (confirmation == DialogResult.Yes)
            {
                WriteData();
            }
            else if (confirmation == DialogResult.No)
            {
                ReadData();
            }
        }
        private void btnchange_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void rtbdataviewer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

