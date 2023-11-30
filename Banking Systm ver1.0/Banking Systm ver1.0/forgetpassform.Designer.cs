namespace Banking_Systm_ver1._0
{
    partial class forgetpassform
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchangepass = new Guna.UI2.WinForms.Guna2Button();
            this.tbemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label2.Location = new System.Drawing.Point(98, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 21);
            this.label2.TabIndex = 108;
            this.label2.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label6.Location = new System.Drawing.Point(51, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 21);
            this.label6.TabIndex = 107;
            this.label6.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(400, 33);
            this.label1.TabIndex = 106;
            this.label1.Text = "Forget Password Form";
            // 
            // btnchangepass
            // 
            this.btnchangepass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(30)))));
            this.btnchangepass.BorderRadius = 10;
            this.btnchangepass.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnchangepass.BorderThickness = 4;
            this.btnchangepass.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnchangepass.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnchangepass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnchangepass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnchangepass.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnchangepass.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btnchangepass.ForeColor = System.Drawing.Color.White;
            this.btnchangepass.Location = new System.Drawing.Point(143, 231);
            this.btnchangepass.Margin = new System.Windows.Forms.Padding(2);
            this.btnchangepass.Name = "btnchangepass";
            this.btnchangepass.Size = new System.Drawing.Size(185, 53);
            this.btnchangepass.TabIndex = 105;
            this.btnchangepass.Text = "Show Password";
            this.btnchangepass.Click += new System.EventHandler(this.btnchangepass_Click);
            // 
            // tbemail
            // 
            this.tbemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbemail.BorderThickness = 4;
            this.tbemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbemail.DefaultText = "";
            this.tbemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbemail.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbemail.Location = new System.Drawing.Point(177, 157);
            this.tbemail.Margin = new System.Windows.Forms.Padding(2);
            this.tbemail.Name = "tbemail";
            this.tbemail.PasswordChar = '\0';
            this.tbemail.PlaceholderText = "";
            this.tbemail.SelectedText = "";
            this.tbemail.Size = new System.Drawing.Size(241, 35);
            this.tbemail.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbemail.TabIndex = 102;
            // 
            // tbusername
            // 
            this.tbusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbusername.BorderThickness = 4;
            this.tbusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbusername.DefaultText = "";
            this.tbusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.Location = new System.Drawing.Point(177, 103);
            this.tbusername.Margin = new System.Windows.Forms.Padding(2);
            this.tbusername.Name = "tbusername";
            this.tbusername.PasswordChar = '\0';
            this.tbusername.PlaceholderText = "";
            this.tbusername.SelectedText = "";
            this.tbusername.Size = new System.Drawing.Size(241, 35);
            this.tbusername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbusername.TabIndex = 101;
            // 
            // forgetpassform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchangepass);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbusername);
            this.Name = "forgetpassform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "forgetpassform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnchangepass;
        private Guna.UI2.WinForms.Guna2TextBox tbemail;
        private Guna.UI2.WinForms.Guna2TextBox tbusername;
    }
}