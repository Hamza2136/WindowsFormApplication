namespace Login_Page__with_database_
{
    partial class forget_password
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnminimized = new Button();
            btnmax = new Button();
            btnexit = new Button();
            label1 = new Label();
            lmain = new Label();
            tbfemail = new Guna.UI2.WinForms.Guna2TextBox();
            lemail = new Label();
            tbfusername = new Guna.UI2.WinForms.Guna2TextBox();
            lusername = new Label();
            btngetpassword = new Guna.UI2.WinForms.Guna2Button();
            lhaveacc = new Label();
            btnbtlogin = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnminimized
            // 
            btnminimized.BackColor = Color.LightGray;
            btnminimized.FlatAppearance.BorderSize = 0;
            btnminimized.FlatStyle = FlatStyle.Flat;
            btnminimized.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnminimized.Location = new Point(789, 1);
            btnminimized.Name = "btnminimized";
            btnminimized.Size = new Size(60, 40);
            btnminimized.TabIndex = 21;
            btnminimized.Text = "-";
            btnminimized.UseVisualStyleBackColor = false;
            btnminimized.Click += btnminimized_Click;
            // 
            // btnmax
            // 
            btnmax.BackColor = Color.LightGray;
            btnmax.FlatAppearance.BorderSize = 0;
            btnmax.FlatStyle = FlatStyle.Flat;
            btnmax.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnmax.Location = new Point(855, 1);
            btnmax.Name = "btnmax";
            btnmax.Size = new Size(60, 40);
            btnmax.TabIndex = 20;
            btnmax.Text = "🗖";
            btnmax.UseVisualStyleBackColor = false;
            btnmax.Click += btnmax_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.LightGray;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnexit.Location = new Point(921, 1);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(60, 40);
            btnexit.TabIndex = 19;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Copperplate Gothic Light", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(259, 140);
            label1.Name = "label1";
            label1.Size = new Size(489, 26);
            label1.TabIndex = 18;
            label1.Text = "Remember Your Password After This";
            // 
            // lmain
            // 
            lmain.AutoSize = true;
            lmain.FlatStyle = FlatStyle.Flat;
            lmain.Font = new Font("Copperplate Gothic Bold", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            lmain.Location = new Point(288, 107);
            lmain.Name = "lmain";
            lmain.Size = new Size(400, 33);
            lmain.TabIndex = 17;
            lmain.Text = "Forget Password Form";
            // 
            // tbfemail
            // 
            tbfemail.BorderColor = Color.OrangeRed;
            tbfemail.BorderRadius = 8;
            tbfemail.BorderThickness = 4;
            tbfemail.CustomizableEdges = customizableEdges1;
            tbfemail.DefaultText = "";
            tbfemail.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbfemail.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbfemail.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbfemail.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbfemail.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbfemail.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbfemail.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbfemail.Location = new Point(383, 318);
            tbfemail.Margin = new Padding(4, 3, 4, 3);
            tbfemail.Name = "tbfemail";
            tbfemail.PasswordChar = '\0';
            tbfemail.PlaceholderForeColor = SystemColors.ControlDark;
            tbfemail.PlaceholderText = "Enter Email Here.....";
            tbfemail.SelectedText = "";
            tbfemail.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbfemail.Size = new Size(272, 41);
            tbfemail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            tbfemail.TabIndex = 31;
            // 
            // lemail
            // 
            lemail.AutoSize = true;
            lemail.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lemail.Location = new Point(316, 337);
            lemail.Name = "lemail";
            lemail.Size = new Size(60, 22);
            lemail.TabIndex = 30;
            lemail.Text = "Email";
            // 
            // tbfusername
            // 
            tbfusername.BorderColor = Color.OrangeRed;
            tbfusername.BorderRadius = 8;
            tbfusername.BorderThickness = 4;
            tbfusername.CustomizableEdges = customizableEdges3;
            tbfusername.DefaultText = "";
            tbfusername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbfusername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbfusername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbfusername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbfusername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbfusername.Font = new Font("Courier New", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbfusername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbfusername.Location = new Point(383, 237);
            tbfusername.Margin = new Padding(4, 3, 4, 3);
            tbfusername.Name = "tbfusername";
            tbfusername.PasswordChar = '\0';
            tbfusername.PlaceholderForeColor = SystemColors.ControlDark;
            tbfusername.PlaceholderText = "Enter Username Here.....";
            tbfusername.SelectedText = "";
            tbfusername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbfusername.Size = new Size(272, 41);
            tbfusername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            tbfusername.TabIndex = 29;
            // 
            // lusername
            // 
            lusername.AutoSize = true;
            lusername.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lusername.Location = new Point(286, 256);
            lusername.Name = "lusername";
            lusername.Size = new Size(90, 22);
            lusername.TabIndex = 28;
            lusername.Text = "Username";
            // 
            // btngetpassword
            // 
            btngetpassword.BackColor = Color.Transparent;
            btngetpassword.BorderRadius = 8;
            btngetpassword.CustomBorderColor = Color.FromArgb(0, 0, 192);
            btngetpassword.CustomBorderThickness = new Padding(0, 0, 0, 6);
            btngetpassword.CustomizableEdges = customizableEdges5;
            btngetpassword.DisabledState.BorderColor = Color.DarkGray;
            btngetpassword.DisabledState.CustomBorderColor = Color.DarkGray;
            btngetpassword.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btngetpassword.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btngetpassword.FillColor = Color.FromArgb(0, 192, 192);
            btngetpassword.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btngetpassword.ForeColor = Color.Black;
            btngetpassword.Location = new Point(411, 409);
            btngetpassword.Name = "btngetpassword";
            btngetpassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btngetpassword.Size = new Size(213, 58);
            btngetpassword.TabIndex = 32;
            btngetpassword.Text = "Get Password";
            btngetpassword.Click += btngetpassword_Click;
            // 
            // lhaveacc
            // 
            lhaveacc.AutoSize = true;
            lhaveacc.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lhaveacc.Location = new Point(383, 378);
            lhaveacc.Name = "lhaveacc";
            lhaveacc.Size = new Size(210, 14);
            lhaveacc.TabIndex = 34;
            lhaveacc.Text = "Already Remeberd my Password?";
            // 
            // btnbtlogin
            // 
            btnbtlogin.BackColor = Color.Transparent;
            btnbtlogin.BorderColor = Color.Silver;
            btnbtlogin.BorderRadius = 8;
            btnbtlogin.BorderThickness = 2;
            btnbtlogin.CustomBorderColor = Color.Transparent;
            btnbtlogin.CustomBorderThickness = new Padding(0, 0, 0, 4);
            btnbtlogin.CustomizableEdges = customizableEdges7;
            btnbtlogin.DisabledState.BorderColor = Color.DarkGray;
            btnbtlogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnbtlogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnbtlogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnbtlogin.FillColor = Color.Transparent;
            btnbtlogin.Font = new Font("Copperplate Gothic Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnbtlogin.ForeColor = Color.Red;
            btnbtlogin.Location = new Point(599, 365);
            btnbtlogin.Name = "btnbtlogin";
            btnbtlogin.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnbtlogin.Size = new Size(69, 38);
            btnbtlogin.TabIndex = 33;
            btnbtlogin.Text = "Login";
            btnbtlogin.Click += btnbtlogin_Click;
            // 
            // forget_password
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 670);
            Controls.Add(lhaveacc);
            Controls.Add(btnbtlogin);
            Controls.Add(btngetpassword);
            Controls.Add(tbfemail);
            Controls.Add(lemail);
            Controls.Add(tbfusername);
            Controls.Add(lusername);
            Controls.Add(btnminimized);
            Controls.Add(btnmax);
            Controls.Add(btnexit);
            Controls.Add(label1);
            Controls.Add(lmain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "forget_password";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forget_password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnminimized;
        private Button btnmax;
        private Button btnexit;
        private Label label1;
        private Label lmain;
        private Guna.UI2.WinForms.Guna2TextBox tbfemail;
        private Label lemail;
        private Guna.UI2.WinForms.Guna2TextBox tbfusername;
        private Label lusername;
        private Guna.UI2.WinForms.Guna2Button btngetpassword;
        private Label lhaveacc;
        private Guna.UI2.WinForms.Guna2Button btnbtlogin;
    }
}