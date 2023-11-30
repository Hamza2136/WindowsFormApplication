using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Banking_Systm_ver1._0
{
    partial class Login
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
            this.llabel = new System.Windows.Forms.Label();
            this.lusername = new System.Windows.Forms.Label();
            this.tbusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lpassword = new System.Windows.Forms.Label();
            this.btnlogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // llabel
            // 
            this.llabel.AutoSize = true;
            this.llabel.Font = new System.Drawing.Font("Copperplate Gothic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llabel.Location = new System.Drawing.Point(54, 22);
            this.llabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llabel.Name = "llabel";
            this.llabel.Size = new System.Drawing.Size(324, 53);
            this.llabel.TabIndex = 0;
            this.llabel.Text = "Login Page";
            // 
            // lusername
            // 
            this.lusername.AutoSize = true;
            this.lusername.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.lusername.Location = new System.Drawing.Point(10, 171);
            this.lusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lusername.Name = "lusername";
            this.lusername.Size = new System.Drawing.Size(118, 21);
            this.lusername.TabIndex = 1;
            this.lusername.Text = "Username";
            // 
            // tbusername
            // 
            this.tbusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbusername.BorderRadius = 2;
            this.tbusername.BorderThickness = 4;
            this.tbusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbusername.DefaultText = "";
            this.tbusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.Font = new System.Drawing.Font("Courier New", 12F);
            this.tbusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbusername.Location = new System.Drawing.Point(134, 163);
            this.tbusername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbusername.Name = "tbusername";
            this.tbusername.PasswordChar = '\0';
            this.tbusername.PlaceholderText = "Enter Username Here...";
            this.tbusername.SelectedText = "";
            this.tbusername.Size = new System.Drawing.Size(264, 35);
            this.tbusername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbusername.TabIndex = 2;
            // 
            // tbpassword
            // 
            this.tbpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbpassword.BorderRadius = 2;
            this.tbpassword.BorderThickness = 4;
            this.tbpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbpassword.DefaultText = "";
            this.tbpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpassword.Font = new System.Drawing.Font("Courier New", 12F);
            this.tbpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbpassword.Location = new System.Drawing.Point(134, 213);
            this.tbpassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.PasswordChar = '*';
            this.tbpassword.PlaceholderText = "Enter Password Here...";
            this.tbpassword.SelectedText = "";
            this.tbpassword.Size = new System.Drawing.Size(264, 38);
            this.tbpassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbpassword.TabIndex = 4;
            // 
            // lpassword
            // 
            this.lpassword.AutoSize = true;
            this.lpassword.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.lpassword.Location = new System.Drawing.Point(10, 221);
            this.lpassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lpassword.Name = "lpassword";
            this.lpassword.Size = new System.Drawing.Size(120, 21);
            this.lpassword.TabIndex = 3;
            this.lpassword.Text = "Password";
            // 
            // btnlogin
            // 
            this.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlogin.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnlogin.Font = new System.Drawing.Font("Copperplate Gothic Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(148, 331);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(167, 40);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton1.Location = new System.Drawing.Point(121, 255);
            this.guna2GradientButton1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(134, 21);
            this.guna2GradientButton1.TabIndex = 6;
            this.guna2GradientButton1.Text = "Forget Password";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2GradientButton2.Location = new System.Drawing.Point(336, 255);
            this.guna2GradientButton2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(76, 21);
            this.guna2GradientButton2.TabIndex = 7;
            this.guna2GradientButton2.Text = "Sign Up";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 491);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.lpassword);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.lusername);
            this.Controls.Add(this.llabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label llabel;
        private Label lusername;
        private Guna.UI2.WinForms.Guna2TextBox tbusername;
        private Guna.UI2.WinForms.Guna2TextBox tbpassword;
        private Label lpassword;
        private Guna.UI2.WinForms.Guna2GradientButton btnlogin;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
    }
}