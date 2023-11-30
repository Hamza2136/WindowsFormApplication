using System.Windows.Forms;

namespace student_form_UI_design
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pnlstats.Visible = false;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label23_Click(object sender, EventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {


        }
        private void btndashboard_Click(object sender, EventArgs e)
        {
            try
            {
                pnlstats.Visible = true;
                pnlstats.Top = btndashboard.Top;
                pnlstats.Height = btndashboard.Height;
                if (sender == btndashboard)
                {
                    dashboardpanel.Visible = true;
                    calender_panel.Visible = false;
                    courses_panel.Visible = false;
                    message_panel.Visible = false;
                    forum_panel.Visible = false;
                    Ann_panel.Visible = false;
                    ann_panel_txt.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Convert.ToString(ex)} + Invalid Error");
            }

        }
        public void addpanel()
        {
            Panel cover = new Panel();
            cover.Size = new Size(855, 98);
            cover.Location = new Point(213, 0);
            cover.BackColor = Color.Teal;
            this.Controls.Add(cover);
        }
        private void btncalender_Click(object sender, EventArgs e)
        {
            pnlstats.Visible = true;
            pnlstats.Top = btncalender.Top;
            pnlstats.Height = btncalender.Height;
            if (sender == btncalender)
            {
                addpanel();
                calender_panel.Visible = true;
                dashboardpanel.Visible = false;
                courses_panel.Visible = false;
                message_panel.Visible = false;
                forum_panel.Visible = false;
                Ann_panel.Visible = false;
                ann_panel_txt.Visible = false;
            }
        }
        private void btncourses_Click(object sender, EventArgs e)
        {
            pnlstats.Visible = true;
            pnlstats.Top = btncourses.Top;
            pnlstats.Height = btncourses.Height;
            if (sender == btncourses)
            {
                addpanel();
                courses_panel.Visible = true;
                dashboardpanel.Visible = false;
                calender_panel.Visible = false;
                message_panel.Visible = false;
                forum_panel.Visible = false;
                Ann_panel.Visible = false;
                ann_panel_txt.Visible = false;
            }
        }
        private void btnannouncement_Click(object sender, EventArgs e)
        {
            pnlstats.Visible = true;
            pnlstats.Top = btnannouncement.Top;
            pnlstats.Height = btnannouncement.Height;
            if (sender == btnannouncement)
            {
                addpanel();
                ann_panel_txt.Visible = true;
                Ann_panel.Visible = true;
                dashboardpanel.Visible = false;
                calender_panel.Visible = false;
                message_panel.Visible = false;
                forum_panel.Visible = false;
                courses_panel.Visible = false;
            }
        }
        private void btnmessages_Click(object sender, EventArgs e)
        {
            pnlstats.Visible = true;
            pnlstats.Top = btnmessages.Top;
            pnlstats.Height = btnmessages.Height;
            if (sender == btnmessages)
            {
                addpanel();
                message_panel.Visible = true;
                dashboardpanel.Visible = false;
                calender_panel.Visible = false;
                ann_panel_txt.Visible = false;
                Ann_panel.Visible = false;
                forum_panel.Visible = false;
                courses_panel.Visible = false;
            }
        }
        private void btnforum_Click(object sender, EventArgs e)
        {
            pnlstats.Visible = true;
            pnlstats.Top = btnforum.Top;
            pnlstats.Height = btnforum.Height;
            if (sender == btnforum)
            {
                addpanel();
                forum_panel.Visible = true;
                dashboardpanel.Visible = false;
                calender_panel.Visible = false;
                ann_panel_txt.Visible = false;
                Ann_panel.Visible = false;
                message_panel.Visible = false;
                courses_panel.Visible = false;
            }
        }
        private void btnlogout_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
        private void picbtn_Click(object sender, EventArgs e)
        {
            if (sender == picbtn)
            {
                dashboardpanel.Visible = true;
                courses_panel.Visible = true;
                message_panel.Visible = true;
                forum_panel.Visible = true;
                Ann_panel.Visible = true;
                ann_panel_txt.Visible = true;
                calender_panel.Visible = true;
            }
        }
        private void pnlstats_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnsetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This option is not avaliable for students!");
        }
    }
}