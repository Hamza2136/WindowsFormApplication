namespace Database_Connection
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tbusername = new Guna.UI2.WinForms.Guna2TextBox();
            lusername = new Label();
            lpassword = new Label();
            tbpassword = new Guna.UI2.WinForms.Guna2TextBox();
            lmain = new Label();
            btnsavedata = new Guna.UI2.WinForms.Guna2Button();
            ldbstatus = new Label();
            SuspendLayout();
            // 
            // tbusername
            // 
            tbusername.BackColor = Color.Transparent;
            tbusername.BorderRadius = 1;
            tbusername.BorderThickness = 0;
            tbusername.CustomizableEdges = customizableEdges1;
            tbusername.DefaultText = "";
            tbusername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbusername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbusername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbusername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbusername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbusername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbusername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbusername.ImeMode = ImeMode.NoControl;
            tbusername.Location = new Point(365, 178);
            tbusername.Name = "tbusername";
            tbusername.PasswordChar = '\0';
            tbusername.PlaceholderText = "";
            tbusername.SelectedText = "";
            tbusername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbusername.Size = new Size(200, 28);
            tbusername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            tbusername.TabIndex = 0;
            // 
            // lusername
            // 
            lusername.AutoSize = true;
            lusername.BackColor = Color.Transparent;
            lusername.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lusername.Location = new Point(267, 188);
            lusername.Name = "lusername";
            lusername.Size = new Size(84, 18);
            lusername.TabIndex = 1;
            lusername.Text = "Username:";
            // 
            // lpassword
            // 
            lpassword.AutoSize = true;
            lpassword.BackColor = Color.Transparent;
            lpassword.Font = new Font("Garamond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lpassword.Location = new Point(267, 243);
            lpassword.Name = "lpassword";
            lpassword.Size = new Size(78, 18);
            lpassword.TabIndex = 3;
            lpassword.Text = "Password:";
            // 
            // tbpassword
            // 
            tbpassword.BackColor = Color.Transparent;
            tbpassword.BorderRadius = 78;
            tbpassword.CustomizableEdges = customizableEdges3;
            tbpassword.DefaultText = "";
            tbpassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbpassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbpassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbpassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbpassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbpassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbpassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbpassword.Location = new Point(365, 232);
            tbpassword.Name = "tbpassword";
            tbpassword.PasswordChar = '\0';
            tbpassword.PlaceholderText = "";
            tbpassword.SelectedText = "";
            tbpassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbpassword.Size = new Size(200, 29);
            tbpassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            tbpassword.TabIndex = 2;
            // 
            // lmain
            // 
            lmain.AutoSize = true;
            lmain.Font = new Font("Garamond", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lmain.Location = new Point(240, 129);
            lmain.Name = "lmain";
            lmain.Size = new Size(369, 27);
            lmain.TabIndex = 4;
            lmain.Text = "Oracle Database Connection Setup";
            // 
            // btnsavedata
            // 
            btnsavedata.CustomizableEdges = customizableEdges5;
            btnsavedata.DisabledState.BorderColor = Color.DarkGray;
            btnsavedata.DisabledState.CustomBorderColor = Color.DarkGray;
            btnsavedata.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnsavedata.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnsavedata.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsavedata.ForeColor = Color.White;
            btnsavedata.Location = new Point(365, 286);
            btnsavedata.Name = "btnsavedata";
            btnsavedata.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnsavedata.Size = new Size(130, 45);
            btnsavedata.TabIndex = 5;
            btnsavedata.Text = "Save Data";
            btnsavedata.Click += btnsavedata_Click;
            // 
            // ldbstatus
            // 
            ldbstatus.AutoSize = true;
            ldbstatus.Font = new Font("Garamond", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ldbstatus.Location = new Point(35, 153);
            ldbstatus.Name = "ldbstatus";
            ldbstatus.Size = new Size(0, 21);
            ldbstatus.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ldbstatus);
            Controls.Add(btnsavedata);
            Controls.Add(lmain);
            Controls.Add(lpassword);
            Controls.Add(tbpassword);
            Controls.Add(lusername);
            Controls.Add(tbusername);
            Name = "Form1";
            Text = "connection";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbusername;
        private Label lusername;
        private Label lpassword;
        private Guna.UI2.WinForms.Guna2TextBox tbpassword;
        private Label lmain;
        private Guna.UI2.WinForms.Guna2Button btnsavedata;
        private Label ldbstatus;
    }
}