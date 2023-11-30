namespace Calculator_Project__1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnltitle = new Panel();
            btnmin = new Button();
            btnmax = new Button();
            btnexit = new Button();
            pnlhistory = new Panel();
            rtboxhistory = new RichTextBox();
            btnclearhistory = new Button();
            panel1 = new Panel();
            btnmenu = new Button();
            btnhistory = new Button();
            txtdisplay2 = new TextBox();
            txtdisplay1 = new TextBox();
            btneraser = new Button();
            btnpercentage = new Button();
            btnce = new Button();
            btnc = new Button();
            btnunderroot = new Button();
            btnsquare = new Button();
            btnbar = new Button();
            btndivide = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btnmultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnminus = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnplus = new Button();
            btnpoint = new Button();
            btn0 = new Button();
            btnpm = new Button();
            btnequal = new Button();
            pnltitle.SuspendLayout();
            pnlhistory.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnltitle
            // 
            pnltitle.Controls.Add(btnmin);
            pnltitle.Controls.Add(btnmax);
            pnltitle.Controls.Add(btnexit);
            pnltitle.Dock = DockStyle.Top;
            pnltitle.Location = new Point(0, 0);
            pnltitle.Margin = new Padding(0);
            pnltitle.Name = "pnltitle";
            pnltitle.Size = new Size(350, 39);
            pnltitle.TabIndex = 0;
            // 
            // btnmin
            // 
            btnmin.Dock = DockStyle.Right;
            btnmin.FlatAppearance.BorderSize = 0;
            btnmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnmin.FlatStyle = FlatStyle.Flat;
            btnmin.Image = (Image)resources.GetObject("btnmin.Image");
            btnmin.Location = new Point(191, 0);
            btnmin.Margin = new Padding(0);
            btnmin.Name = "btnmin";
            btnmin.Size = new Size(53, 39);
            btnmin.TabIndex = 2;
            btnmin.Text = " ";
            btnmin.UseVisualStyleBackColor = true;
            btnmin.Click += btnmin_Click;
            // 
            // btnmax
            // 
            btnmax.Dock = DockStyle.Right;
            btnmax.FlatAppearance.BorderSize = 0;
            btnmax.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnmax.FlatStyle = FlatStyle.Flat;
            btnmax.Image = (Image)resources.GetObject("btnmax.Image");
            btnmax.Location = new Point(244, 0);
            btnmax.Margin = new Padding(0);
            btnmax.Name = "btnmax";
            btnmax.Size = new Size(53, 39);
            btnmax.TabIndex = 1;
            btnmax.Text = " ";
            btnmax.UseVisualStyleBackColor = true;
            btnmax.Click += btnmax_Click;
            // 
            // btnexit
            // 
            btnexit.Dock = DockStyle.Right;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Image = (Image)resources.GetObject("btnexit.Image");
            btnexit.Location = new Point(297, 0);
            btnexit.Margin = new Padding(0);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(53, 39);
            btnexit.TabIndex = 0;
            btnexit.Text = " ";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // pnlhistory
            // 
            pnlhistory.Controls.Add(rtboxhistory);
            pnlhistory.Controls.Add(btnclearhistory);
            pnlhistory.Dock = DockStyle.Bottom;
            pnlhistory.Location = new Point(0, 565);
            pnlhistory.Margin = new Padding(0);
            pnlhistory.Name = "pnlhistory";
            pnlhistory.Size = new Size(350, 5);
            pnlhistory.TabIndex = 1;
            // 
            // rtboxhistory
            // 
            rtboxhistory.BackColor = Color.FromArgb(32, 32, 32);
            rtboxhistory.BorderStyle = BorderStyle.None;
            rtboxhistory.Dock = DockStyle.Fill;
            rtboxhistory.ForeColor = Color.Silver;
            rtboxhistory.Location = new Point(0, 0);
            rtboxhistory.Margin = new Padding(0);
            rtboxhistory.Name = "rtboxhistory";
            rtboxhistory.ScrollBars = RichTextBoxScrollBars.Horizontal;
            rtboxhistory.Size = new Size(350, 0);
            rtboxhistory.TabIndex = 4;
            rtboxhistory.Text = "";
            // 
            // btnclearhistory
            // 
            btnclearhistory.Dock = DockStyle.Bottom;
            btnclearhistory.FlatAppearance.BorderSize = 0;
            btnclearhistory.FlatStyle = FlatStyle.Flat;
            btnclearhistory.Image = (Image)resources.GetObject("btnclearhistory.Image");
            btnclearhistory.Location = new Point(0, -34);
            btnclearhistory.Margin = new Padding(0);
            btnclearhistory.Name = "btnclearhistory";
            btnclearhistory.Size = new Size(350, 39);
            btnclearhistory.TabIndex = 3;
            btnclearhistory.Text = " ";
            btnclearhistory.UseVisualStyleBackColor = true;
            btnclearhistory.Click += btnclearhistory_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnmenu);
            panel1.Controls.Add(btnhistory);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 39);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 39);
            panel1.TabIndex = 2;
            // 
            // btnmenu
            // 
            btnmenu.Dock = DockStyle.Left;
            btnmenu.FlatAppearance.BorderSize = 0;
            btnmenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnmenu.FlatStyle = FlatStyle.Flat;
            btnmenu.Image = (Image)resources.GetObject("btnmenu.Image");
            btnmenu.Location = new Point(0, 0);
            btnmenu.Margin = new Padding(0);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(53, 39);
            btnmenu.TabIndex = 2;
            btnmenu.Text = " ";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnhistory
            // 
            btnhistory.Dock = DockStyle.Right;
            btnhistory.FlatAppearance.BorderSize = 0;
            btnhistory.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 50, 50);
            btnhistory.FlatStyle = FlatStyle.Flat;
            btnhistory.Image = (Image)resources.GetObject("btnhistory.Image");
            btnhistory.Location = new Point(297, 0);
            btnhistory.Margin = new Padding(0);
            btnhistory.Name = "btnhistory";
            btnhistory.Size = new Size(53, 39);
            btnhistory.TabIndex = 0;
            btnhistory.Text = " ";
            btnhistory.UseVisualStyleBackColor = true;
            btnhistory.Click += btnhistory_Click;
            // 
            // txtdisplay2
            // 
            txtdisplay2.BackColor = Color.FromArgb(32, 32, 32);
            txtdisplay2.BorderStyle = BorderStyle.None;
            txtdisplay2.Font = new Font("Gadugi", 15.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtdisplay2.ForeColor = Color.DarkGray;
            txtdisplay2.Location = new Point(0, 89);
            txtdisplay2.Margin = new Padding(0);
            txtdisplay2.Multiline = true;
            txtdisplay2.Name = "txtdisplay2";
            txtdisplay2.Size = new Size(350, 25);
            txtdisplay2.TabIndex = 3;
            txtdisplay2.Text = "0";
            txtdisplay2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtdisplay1
            // 
            txtdisplay1.BackColor = Color.FromArgb(32, 32, 32);
            txtdisplay1.BorderStyle = BorderStyle.None;
            txtdisplay1.Font = new Font("Gadugi", 36F, FontStyle.Bold, GraphicsUnit.Point);
            txtdisplay1.ForeColor = Color.DarkGray;
            txtdisplay1.Location = new Point(0, 114);
            txtdisplay1.Margin = new Padding(0);
            txtdisplay1.Multiline = true;
            txtdisplay1.Name = "txtdisplay1";
            txtdisplay1.Size = new Size(350, 50);
            txtdisplay1.TabIndex = 4;
            txtdisplay1.Text = "0";
            txtdisplay1.TextAlign = HorizontalAlignment.Right;
            // 
            // btneraser
            // 
            btneraser.ForeColor = Color.FromArgb(60, 60, 60);
            btneraser.Image = (Image)resources.GetObject("btneraser.Image");
            btneraser.Location = new Point(265, 195);
            btneraser.Name = "btneraser";
            btneraser.Size = new Size(85, 56);
            btneraser.TabIndex = 5;
            btneraser.UseVisualStyleBackColor = true;
            btneraser.Click += btneraser_Click;
            // 
            // btnpercentage
            // 
            btnpercentage.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpercentage.ForeColor = Color.FromArgb(60, 60, 60);
            btnpercentage.Location = new Point(1, 195);
            btnpercentage.Name = "btnpercentage";
            btnpercentage.Size = new Size(85, 56);
            btnpercentage.TabIndex = 6;
            btnpercentage.Text = "%";
            btnpercentage.UseVisualStyleBackColor = true;
            btnpercentage.Click += singlebtnoperation_click;
            // 
            // btnce
            // 
            btnce.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnce.ForeColor = Color.FromArgb(60, 60, 60);
            btnce.Location = new Point(89, 195);
            btnce.Name = "btnce";
            btnce.Size = new Size(85, 56);
            btnce.TabIndex = 7;
            btnce.Text = "CE";
            btnce.UseVisualStyleBackColor = true;
            btnce.Click += btnce_Click;
            // 
            // btnc
            // 
            btnc.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnc.ForeColor = Color.FromArgb(60, 60, 60);
            btnc.Location = new Point(177, 195);
            btnc.Name = "btnc";
            btnc.Size = new Size(85, 56);
            btnc.TabIndex = 8;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // btnunderroot
            // 
            btnunderroot.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnunderroot.ForeColor = Color.FromArgb(60, 60, 60);
            btnunderroot.Location = new Point(177, 257);
            btnunderroot.Name = "btnunderroot";
            btnunderroot.Size = new Size(85, 56);
            btnunderroot.TabIndex = 12;
            btnunderroot.Text = "√X";
            btnunderroot.UseVisualStyleBackColor = true;
            btnunderroot.Click += singlebtnoperation_click;
            // 
            // btnsquare
            // 
            btnsquare.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnsquare.ForeColor = Color.FromArgb(60, 60, 60);
            btnsquare.Location = new Point(89, 257);
            btnsquare.Name = "btnsquare";
            btnsquare.Size = new Size(85, 56);
            btnsquare.TabIndex = 11;
            btnsquare.Text = "X²";
            btnsquare.UseVisualStyleBackColor = true;
            btnsquare.Click += singlebtnoperation_click;
            // 
            // btnbar
            // 
            btnbar.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnbar.ForeColor = Color.FromArgb(60, 60, 60);
            btnbar.Location = new Point(1, 257);
            btnbar.Name = "btnbar";
            btnbar.Size = new Size(85, 56);
            btnbar.TabIndex = 10;
            btnbar.Text = "1/x";
            btnbar.UseVisualStyleBackColor = true;
            btnbar.Click += singlebtnoperation_click;
            // 
            // btndivide
            // 
            btndivide.ForeColor = Color.FromArgb(60, 60, 60);
            btndivide.Location = new Point(265, 257);
            btndivide.Name = "btndivide";
            btndivide.Size = new Size(85, 56);
            btndivide.TabIndex = 9;
            btndivide.Text = "÷";
            btndivide.UseVisualStyleBackColor = true;
            btndivide.Click += btnmathoperation_click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.ForeColor = Color.FromArgb(60, 60, 60);
            btn9.Location = new Point(177, 319);
            btn9.Name = "btn9";
            btn9.Size = new Size(85, 56);
            btn9.TabIndex = 16;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_num_click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.ForeColor = Color.FromArgb(60, 60, 60);
            btn8.Location = new Point(89, 319);
            btn8.Name = "btn8";
            btn8.Size = new Size(85, 56);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_num_click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.ForeColor = Color.FromArgb(60, 60, 60);
            btn7.Location = new Point(1, 319);
            btn7.Name = "btn7";
            btn7.Size = new Size(85, 56);
            btn7.TabIndex = 14;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_num_click;
            // 
            // btnmultiply
            // 
            btnmultiply.ForeColor = Color.FromArgb(60, 60, 60);
            btnmultiply.Location = new Point(265, 319);
            btnmultiply.Name = "btnmultiply";
            btnmultiply.Size = new Size(85, 56);
            btnmultiply.TabIndex = 13;
            btnmultiply.Text = "x";
            btnmultiply.UseVisualStyleBackColor = true;
            btnmultiply.Click += btnmathoperation_click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.ForeColor = Color.FromArgb(60, 60, 60);
            btn6.Location = new Point(176, 381);
            btn6.Name = "btn6";
            btn6.Size = new Size(85, 56);
            btn6.TabIndex = 20;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_num_click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.ForeColor = Color.FromArgb(60, 60, 60);
            btn5.Location = new Point(88, 381);
            btn5.Name = "btn5";
            btn5.Size = new Size(85, 56);
            btn5.TabIndex = 19;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_num_click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.ForeColor = Color.FromArgb(60, 60, 60);
            btn4.Location = new Point(0, 381);
            btn4.Name = "btn4";
            btn4.Size = new Size(85, 56);
            btn4.TabIndex = 18;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_num_click;
            // 
            // btnminus
            // 
            btnminus.ForeColor = Color.FromArgb(60, 60, 60);
            btnminus.Location = new Point(264, 381);
            btnminus.Name = "btnminus";
            btnminus.Size = new Size(85, 56);
            btnminus.TabIndex = 17;
            btnminus.Text = "-";
            btnminus.UseVisualStyleBackColor = true;
            btnminus.Click += btnmathoperation_click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.ForeColor = Color.FromArgb(60, 60, 60);
            btn3.Location = new Point(177, 443);
            btn3.Name = "btn3";
            btn3.Size = new Size(85, 56);
            btn3.TabIndex = 24;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_num_click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.ForeColor = Color.FromArgb(60, 60, 60);
            btn2.Location = new Point(89, 443);
            btn2.Name = "btn2";
            btn2.Size = new Size(85, 56);
            btn2.TabIndex = 23;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_num_click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.ForeColor = Color.FromArgb(60, 60, 60);
            btn1.Location = new Point(1, 443);
            btn1.Name = "btn1";
            btn1.Size = new Size(85, 56);
            btn1.TabIndex = 22;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_num_click;
            // 
            // btnplus
            // 
            btnplus.ForeColor = Color.FromArgb(60, 60, 60);
            btnplus.Location = new Point(265, 443);
            btnplus.Name = "btnplus";
            btnplus.Size = new Size(85, 56);
            btnplus.TabIndex = 21;
            btnplus.Text = "+";
            btnplus.UseVisualStyleBackColor = true;
            btnplus.Click += btnmathoperation_click;
            // 
            // btnpoint
            // 
            btnpoint.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpoint.ForeColor = Color.FromArgb(60, 60, 60);
            btnpoint.Location = new Point(177, 505);
            btnpoint.Name = "btnpoint";
            btnpoint.Size = new Size(85, 56);
            btnpoint.TabIndex = 28;
            btnpoint.Text = ".";
            btnpoint.UseVisualStyleBackColor = true;
            btnpoint.Click += btn_num_click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.ForeColor = Color.FromArgb(60, 60, 60);
            btn0.Location = new Point(89, 505);
            btn0.Name = "btn0";
            btn0.Size = new Size(85, 56);
            btn0.TabIndex = 27;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn_num_click;
            // 
            // btnpm
            // 
            btnpm.Font = new Font("Gadugi", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnpm.ForeColor = Color.FromArgb(60, 60, 60);
            btnpm.Location = new Point(1, 505);
            btnpm.Name = "btnpm";
            btnpm.Size = new Size(85, 56);
            btnpm.TabIndex = 26;
            btnpm.Text = "±";
            btnpm.UseVisualStyleBackColor = true;
            btnpm.Click += singlebtnoperation_click;
            // 
            // btnequal
            // 
            btnequal.ForeColor = Color.FromArgb(60, 60, 60);
            btnequal.Image = (Image)resources.GetObject("btnequal.Image");
            btnequal.Location = new Point(265, 505);
            btnequal.Name = "btnequal";
            btnequal.Size = new Size(85, 56);
            btnequal.TabIndex = 25;
            btnequal.UseVisualStyleBackColor = true;
            btnequal.Click += btnequal_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(btnpoint);
            Controls.Add(btn0);
            Controls.Add(btnpm);
            Controls.Add(btnequal);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnplus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnminus);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnmultiply);
            Controls.Add(btnunderroot);
            Controls.Add(btnsquare);
            Controls.Add(btnbar);
            Controls.Add(btndivide);
            Controls.Add(btnc);
            Controls.Add(btnce);
            Controls.Add(btnpercentage);
            Controls.Add(btneraser);
            Controls.Add(txtdisplay1);
            Controls.Add(txtdisplay2);
            Controls.Add(panel1);
            Controls.Add(pnlhistory);
            Controls.Add(pnltitle);
            Font = new Font("Gadugi", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Click += btn_num_click;
            pnltitle.ResumeLayout(false);
            pnlhistory.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnltitle;
        private Button btnmin;
        private Button btnmax;
        private Button btnexit;
        private Panel pnlhistory;
        private Panel panel1;
        private Button btnmenu;
        private Button btnhistory;
        private TextBox txtdisplay2;
        private TextBox txtdisplay1;
        private RichTextBox rtboxhistory;
        private Button btnclearhistory;
        private Button btneraser;
        private Button btnpercentage;
        private Button btnce;
        private Button btnc;
        private Button btnunderroot;
        private Button btnsquare;
        private Button btnbar;
        private Button btndivide;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btnmultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnminus;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnplus;
        private Button btnpoint;
        private Button btn0;
        private Button btnpm;
        private Button btnequal;
    }
}