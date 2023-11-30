namespace Login_Page
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
            picbox = new PictureBox();
            lmain = new Label();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            lusername = new Label();
            lpassword = new Label();
            btnlogin = new Button();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // picbox
            // 
            picbox.Image = (Image)resources.GetObject("picbox.Image");
            picbox.Location = new Point(20, 70);
            picbox.Margin = new Padding(0);
            picbox.Name = "picbox";
            picbox.Size = new Size(398, 333);
            picbox.SizeMode = PictureBoxSizeMode.Zoom;
            picbox.TabIndex = 0;
            picbox.TabStop = false;
            // 
            // lmain
            // 
            lmain.AutoSize = true;
            lmain.Font = new Font("Jokerman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lmain.ForeColor = Color.Snow;
            lmain.Location = new Point(84, 35);
            lmain.Name = "lmain";
            lmain.Size = new Size(265, 35);
            lmain.TabIndex = 1;
            lmain.Text = "Student Login Form";
            // 
            // tbusername
            // 
            tbusername.BorderStyle = BorderStyle.None;
            tbusername.Location = new Point(534, 179);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(254, 19);
            tbusername.TabIndex = 2;
            tbusername.TextChanged += textBox1_TextChanged;
            // 
            // tbpassword
            // 
            tbpassword.BorderStyle = BorderStyle.None;
            tbpassword.Location = new Point(534, 247);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(254, 19);
            tbpassword.TabIndex = 3;
            // 
            // lusername
            // 
            lusername.AutoSize = true;
            lusername.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lusername.Location = new Point(421, 174);
            lusername.Name = "lusername";
            lusername.Size = new Size(113, 26);
            lusername.TabIndex = 4;
            lusername.Text = "Username:";
            // 
            // lpassword
            // 
            lpassword.AutoSize = true;
            lpassword.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lpassword.Location = new Point(421, 242);
            lpassword.Name = "lpassword";
            lpassword.Size = new Size(107, 26);
            lpassword.TabIndex = 5;
            lpassword.Text = "Password:";
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.FromArgb(70, 70, 70);
            btnlogin.FlatAppearance.BorderSize = 0;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnlogin.ForeColor = SystemColors.Highlight;
            btnlogin.Location = new Point(598, 313);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(98, 26);
            btnlogin.TabIndex = 6;
            btnlogin.Text = "Login";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(lpassword);
            Controls.Add(lusername);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(lmain);
            Controls.Add(picbox);
            ForeColor = SystemColors.ControlLight;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picbox;
        private Label lmain;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Label lusername;
        private Label lpassword;
        private Button btnlogin;
    }
}