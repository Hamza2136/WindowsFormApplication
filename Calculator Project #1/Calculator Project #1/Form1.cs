namespace Calculator_Project__1
{
    public partial class Form1 : Form
    {
        //Fields
        Double result = 0;
        string operation = string.Empty;
        string fstnum, sndnum;
        bool entervalue = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void pnlhistory_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pnlhistory_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btn_num_click(object sender, EventArgs e)
        {
            try
            {
                if (sender.GetType().Name != "Form1")
                {
                    Button btn = (Button)sender;
                    if (txtdisplay1.Text == "0" || entervalue) txtdisplay1.Text = string.Empty;
                    entervalue = false;
                    if (txtdisplay1.Text.Contains("."))
                        txtdisplay1.Text = txtdisplay1.Text + btn.Text;
                    else
                        txtdisplay1.Text = txtdisplay1.Text + btn.Text;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnmathoperation_click(object sender, EventArgs e)
        {
            if (result != 0) btnequal.PerformClick();
            else result = Double.Parse(txtdisplay1.Text);
            Button btn = (Button)sender;
            operation = btn.Text;
            entervalue = true;
            if (txtdisplay1.Text != "0")
            {
                txtdisplay2.Text = fstnum = $"{result} {operation}";
                txtdisplay1.Text = string.Empty;
            }

        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            sndnum = txtdisplay1.Text;
            txtdisplay2.Text = $"{txtdisplay2.Text} {txtdisplay1.Text} = ";
            if (txtdisplay1.Text != string.Empty)
            {
                if (txtdisplay1.Text == "0") txtdisplay2.Text = string.Empty;
                switch (operation)
                {
                    case "+":
                        txtdisplay1.Text = (result + Double.Parse(txtdisplay1.Text)).ToString();
                        rtboxhistory.AppendText($"{fstnum} {sndnum} = {txtdisplay1.Text}\n");
                        break;
                    case "-":
                        txtdisplay1.Text = (result - Double.Parse(txtdisplay1.Text)).ToString();
                        rtboxhistory.AppendText($"{fstnum} {sndnum} = {txtdisplay1.Text}\n");
                        break;
                    case "x":
                        txtdisplay1.Text = (result * Double.Parse(txtdisplay1.Text)).ToString();
                        rtboxhistory.AppendText($"{fstnum} {sndnum} = {txtdisplay1.Text}\n");
                        break;
                    case "÷":
                        txtdisplay1.Text = (result / Double.Parse(txtdisplay1.Text)).ToString();
                        rtboxhistory.AppendText($"{fstnum} {sndnum} = {txtdisplay1.Text}\n");
                        break;
                    default:
                        txtdisplay2.Text = $"{txtdisplay1.Text}=";
                        break;
                }
                result = Double.Parse(txtdisplay1.Text);
                operation = string.Empty;
            }
        }
        private void btnhistory_Click(object sender, EventArgs e)
        {
            pnlhistory.Height = (pnlhistory.Height == 5) ? pnlhistory.Height = 345 : 5;
            if (pnlhistory.Height == 5)
            {
                btn0.Visible = true;
                btn1.Visible = true;
                btn2.Visible = true;
                btn3.Visible = true;
                btn4.Visible = true;
                btn5.Visible = true;
                btn6.Visible = true;
                btn7.Visible = true;
                btn8.Visible = true;
                btn9.Visible = true;
                btnpoint.Visible = true;
                btnpercentage.Visible = true;
                btnce.Visible = true;
                btnc.Visible = true;
                btneraser.Visible = true;
                btnbar.Visible = true;
                btnsquare.Visible = true;
                btnunderroot.Visible = true;
                btndivide.Visible = true;
                btnmultiply.Visible = true;
                btnplus.Visible = true;
                btnminus.Visible = true;
                btnequal.Visible = true;
                btnpm.Visible = true;
            }
            else
            {
                btn0.Visible = false;
                btn1.Visible = false;
                btn2.Visible = false;
                btn3.Visible = false;
                btn4.Visible = false;
                btn5.Visible = false;
                btn6.Visible = false;
                btn7.Visible = false;
                btn8.Visible = false;
                btn9.Visible = false;
                btnpoint.Visible = false;
                btnpercentage.Visible = false;
                btnce.Visible = false;
                btnc.Visible = false;
                btneraser.Visible = false;
                btnbar.Visible = false;
                btnsquare.Visible = false;
                btnunderroot.Visible = false;
                btndivide.Visible = false;
                btnmultiply.Visible = false;
                btnplus.Visible = false;
                btnminus.Visible = false;
                btnequal.Visible = false;
                btnpm.Visible = false;
            }
        }
        private void btnclearhistory_Click(object sender, EventArgs e)
        {
            rtboxhistory.Clear();
            rtboxhistory.Text = string.Empty;
            rtboxhistory.Text = "There's no History!";
        }
        private void btneraser_Click(object sender, EventArgs e)
        {
            if (txtdisplay1.Text.Length > 0)
            {
                txtdisplay1.Text = txtdisplay1.Text.Remove(txtdisplay1.Text.Length - 1, 1);
            }
            if (txtdisplay1.Text == string.Empty)
            {
                txtdisplay1.Text = "0";
            }
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = "0";
            txtdisplay2.Text = string.Empty;
            result = 0;
        }
        private void btnce_Click(object sender, EventArgs e)
        {
            txtdisplay1.Text = "0";
        }
        private void singlebtnoperation_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            switch (operation)
            {
                case "√X":
                    txtdisplay2.Text = $"√({txtdisplay1.Text})";
                    txtdisplay1.Text = Convert.ToString(Math.Sqrt(Double.Parse(txtdisplay1.Text)));
                    rtboxhistory.AppendText($"{txtdisplay2.Text} = {txtdisplay1.Text}\n");
                    break;
                case "X²":
                    txtdisplay2.Text = $"{txtdisplay1.Text}²";
                    txtdisplay1.Text = Convert.ToString(Convert.ToDouble(txtdisplay1.Text) * Convert.ToDouble(txtdisplay1.Text));
                    rtboxhistory.AppendText($"{txtdisplay2.Text} = {txtdisplay1.Text}\n");
                    break;
                case "1/x":
                    txtdisplay2.Text = $"1/{txtdisplay1.Text}";
                    txtdisplay1.Text = Convert.ToString(1 / Convert.ToDouble(txtdisplay1.Text));
                    rtboxhistory.AppendText($"{txtdisplay2.Text} = {txtdisplay1.Text}\n");
                    break;
                case "%":
                    txtdisplay2.Text = $"%{txtdisplay1.Text}";
                    txtdisplay1.Text = Convert.ToString(Convert.ToDouble(txtdisplay1.Text) / Convert.ToDouble(100));
                    rtboxhistory.AppendText($"{txtdisplay2.Text} = {txtdisplay1.Text}\n");
                    break;
                case "±":
                    txtdisplay1.Text = Convert.ToString(-1 * Convert.ToDouble(txtdisplay1.Text));
                    rtboxhistory.AppendText($"{txtdisplay2.Text} = {txtdisplay1.Text}\n");
                    break;
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btnmax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
        private void btnmenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry This is Not a Scientific Calculator");
        }
    }
}