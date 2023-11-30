using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Banking_Systm_ver1._0
{
    partial class NewAcc
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ldate = new System.Windows.Forms.Label();
            this.picuser = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnuploadpic = new Guna.UI2.WinForms.Guna2Button();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.tbname = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctbgender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbcnicnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbmothername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbfathername = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctbmartialstatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbbalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.linputdate = new System.Windows.Forms.Label();
            this.linacc_no = new System.Windows.Forms.Label();
            this.tbstate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbdistrict = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbaddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbphoneno = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctbdob = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F);
            this.label1.Location = new System.Drawing.Point(273, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Information Form";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label2.Location = new System.Drawing.Point(31, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label3.Location = new System.Drawing.Point(155, 192);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label4.Location = new System.Drawing.Point(166, 243);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "DOB";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label5.Location = new System.Drawing.Point(55, 290);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label6.Location = new System.Drawing.Point(123, 340);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label7.Location = new System.Drawing.Point(129, 393);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "District";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label8.Location = new System.Drawing.Point(156, 444);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label9.Location = new System.Drawing.Point(577, 192);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Father Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label10.Location = new System.Drawing.Point(572, 243);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Mother Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label11.Location = new System.Drawing.Point(573, 290);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "CNIC Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label12.Location = new System.Drawing.Point(637, 340);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Gender";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label13.Location = new System.Drawing.Point(553, 393);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(174, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Martial Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.label14.Location = new System.Drawing.Point(626, 444);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(101, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Balance";
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.ldate.Location = new System.Drawing.Point(15, 90);
            this.ldate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(208, 21);
            this.ldate.TabIndex = 14;
            this.ldate.Text = "Registration Date";
            // 
            // picuser
            // 
            this.picuser.FillColor = System.Drawing.Color.Black;
            this.picuser.ImageRotate = 0F;
            this.picuser.Location = new System.Drawing.Point(615, 88);
            this.picuser.Margin = new System.Windows.Forms.Padding(2);
            this.picuser.Name = "picuser";
            this.picuser.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picuser.Size = new System.Drawing.Size(112, 74);
            this.picuser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picuser.TabIndex = 16;
            this.picuser.TabStop = false;
            // 
            // btnuploadpic
            // 
            this.btnuploadpic.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnuploadpic.BorderRadius = 10;
            this.btnuploadpic.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnuploadpic.BorderThickness = 4;
            this.btnuploadpic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnuploadpic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnuploadpic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnuploadpic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnuploadpic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnuploadpic.Font = new System.Drawing.Font("Copperplate Gothic Bold", 11.25F);
            this.btnuploadpic.ForeColor = System.Drawing.Color.White;
            this.btnuploadpic.Location = new System.Drawing.Point(732, 103);
            this.btnuploadpic.Margin = new System.Windows.Forms.Padding(2);
            this.btnuploadpic.Name = "btnuploadpic";
            this.btnuploadpic.Size = new System.Drawing.Size(115, 43);
            this.btnuploadpic.TabIndex = 17;
            this.btnuploadpic.Text = "upload Photo";
            this.btnuploadpic.Click += new System.EventHandler(this.btnuploadpic_Click);
            // 
            // btnsave
            // 
            this.btnsave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(30)))));
            this.btnsave.BorderRadius = 10;
            this.btnsave.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.btnsave.BorderThickness = 4;
            this.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnsave.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(457, 526);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(120, 53);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "Save ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // tbname
            // 
            this.tbname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbname.BorderThickness = 4;
            this.tbname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbname.DefaultText = "";
            this.tbname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbname.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbname.Location = new System.Drawing.Point(231, 187);
            this.tbname.Margin = new System.Windows.Forms.Padding(2);
            this.tbname.Name = "tbname";
            this.tbname.PasswordChar = '\0';
            this.tbname.PlaceholderText = "";
            this.tbname.SelectedText = "";
            this.tbname.Size = new System.Drawing.Size(241, 35);
            this.tbname.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbname.TabIndex = 20;
            // 
            // ctbgender
            // 
            this.ctbgender.AllowDrop = true;
            this.ctbgender.BackColor = System.Drawing.Color.Transparent;
            this.ctbgender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ctbgender.BorderThickness = 4;
            this.ctbgender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctbgender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctbgender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctbgender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctbgender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctbgender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ctbgender.ItemHeight = 30;
            this.ctbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.ctbgender.Location = new System.Drawing.Point(732, 334);
            this.ctbgender.Margin = new System.Windows.Forms.Padding(2);
            this.ctbgender.Name = "ctbgender";
            this.ctbgender.Size = new System.Drawing.Size(241, 36);
            this.ctbgender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ctbgender.TabIndex = 44;
            // 
            // tbcnicnumber
            // 
            this.tbcnicnumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbcnicnumber.BorderThickness = 4;
            this.tbcnicnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbcnicnumber.DefaultText = "";
            this.tbcnicnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbcnicnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbcnicnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcnicnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbcnicnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcnicnumber.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbcnicnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbcnicnumber.Location = new System.Drawing.Point(732, 284);
            this.tbcnicnumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbcnicnumber.Name = "tbcnicnumber";
            this.tbcnicnumber.PasswordChar = '\0';
            this.tbcnicnumber.PlaceholderText = "";
            this.tbcnicnumber.SelectedText = "";
            this.tbcnicnumber.Size = new System.Drawing.Size(241, 35);
            this.tbcnicnumber.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbcnicnumber.TabIndex = 41;
            // 
            // tbmothername
            // 
            this.tbmothername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbmothername.BorderThickness = 4;
            this.tbmothername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmothername.DefaultText = "";
            this.tbmothername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbmothername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbmothername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmothername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmothername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmothername.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbmothername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbmothername.Location = new System.Drawing.Point(732, 236);
            this.tbmothername.Margin = new System.Windows.Forms.Padding(2);
            this.tbmothername.Name = "tbmothername";
            this.tbmothername.PasswordChar = '\0';
            this.tbmothername.PlaceholderText = "";
            this.tbmothername.SelectedText = "";
            this.tbmothername.Size = new System.Drawing.Size(241, 35);
            this.tbmothername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbmothername.TabIndex = 40;
            // 
            // tbfathername
            // 
            this.tbfathername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbfathername.BorderThickness = 4;
            this.tbfathername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbfathername.DefaultText = "";
            this.tbfathername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbfathername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbfathername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbfathername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbfathername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbfathername.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbfathername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbfathername.Location = new System.Drawing.Point(732, 188);
            this.tbfathername.Margin = new System.Windows.Forms.Padding(2);
            this.tbfathername.Name = "tbfathername";
            this.tbfathername.PasswordChar = '\0';
            this.tbfathername.PlaceholderText = "";
            this.tbfathername.SelectedText = "";
            this.tbfathername.Size = new System.Drawing.Size(241, 35);
            this.tbfathername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbfathername.TabIndex = 39;
            // 
            // ctbmartialstatus
            // 
            this.ctbmartialstatus.AllowDrop = true;
            this.ctbmartialstatus.BackColor = System.Drawing.Color.Transparent;
            this.ctbmartialstatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ctbmartialstatus.BorderThickness = 4;
            this.ctbmartialstatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ctbmartialstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctbmartialstatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctbmartialstatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ctbmartialstatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ctbmartialstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ctbmartialstatus.ItemHeight = 30;
            this.ctbmartialstatus.Items.AddRange(new object[] {
            "Married",
            "UnMarried"});
            this.ctbmartialstatus.Location = new System.Drawing.Point(732, 388);
            this.ctbmartialstatus.Margin = new System.Windows.Forms.Padding(2);
            this.ctbmartialstatus.Name = "ctbmartialstatus";
            this.ctbmartialstatus.Size = new System.Drawing.Size(241, 36);
            this.ctbmartialstatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ctbmartialstatus.TabIndex = 47;
            // 
            // tbbalance
            // 
            this.tbbalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbbalance.BorderThickness = 4;
            this.tbbalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbbalance.DefaultText = "";
            this.tbbalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbbalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbbalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbbalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbbalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbbalance.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbbalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbbalance.Location = new System.Drawing.Point(732, 437);
            this.tbbalance.Margin = new System.Windows.Forms.Padding(2);
            this.tbbalance.Name = "tbbalance";
            this.tbbalance.PasswordChar = '\0';
            this.tbbalance.PlaceholderText = "";
            this.tbbalance.SelectedText = "";
            this.tbbalance.Size = new System.Drawing.Size(241, 35);
            this.tbbalance.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbbalance.TabIndex = 48;
            // 
            // linputdate
            // 
            this.linputdate.AutoSize = true;
            this.linputdate.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.linputdate.Location = new System.Drawing.Point(227, 90);
            this.linputdate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linputdate.Name = "linputdate";
            this.linputdate.Size = new System.Drawing.Size(0, 21);
            this.linputdate.TabIndex = 15;
            // 
            // linacc_no
            // 
            this.linacc_no.AutoSize = true;
            this.linacc_no.Font = new System.Drawing.Font("Copperplate Gothic Bold", 14.25F);
            this.linacc_no.Location = new System.Drawing.Point(223, 141);
            this.linacc_no.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linacc_no.Name = "linacc_no";
            this.linacc_no.Size = new System.Drawing.Size(0, 21);
            this.linacc_no.TabIndex = 49;
            // 
            // tbstate
            // 
            this.tbstate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbstate.BorderThickness = 4;
            this.tbstate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbstate.DefaultText = "";
            this.tbstate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbstate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbstate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbstate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbstate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbstate.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbstate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbstate.Location = new System.Drawing.Point(231, 437);
            this.tbstate.Margin = new System.Windows.Forms.Padding(2);
            this.tbstate.Name = "tbstate";
            this.tbstate.PasswordChar = '\0';
            this.tbstate.PlaceholderText = "";
            this.tbstate.SelectedText = "";
            this.tbstate.Size = new System.Drawing.Size(241, 35);
            this.tbstate.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbstate.TabIndex = 54;
            // 
            // tbdistrict
            // 
            this.tbdistrict.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbdistrict.BorderThickness = 4;
            this.tbdistrict.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbdistrict.DefaultText = "";
            this.tbdistrict.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbdistrict.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbdistrict.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbdistrict.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbdistrict.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbdistrict.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbdistrict.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbdistrict.Location = new System.Drawing.Point(231, 388);
            this.tbdistrict.Margin = new System.Windows.Forms.Padding(2);
            this.tbdistrict.Name = "tbdistrict";
            this.tbdistrict.PasswordChar = '\0';
            this.tbdistrict.PlaceholderText = "";
            this.tbdistrict.SelectedText = "";
            this.tbdistrict.Size = new System.Drawing.Size(241, 35);
            this.tbdistrict.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbdistrict.TabIndex = 53;
            // 
            // tbaddress
            // 
            this.tbaddress.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbaddress.BorderThickness = 4;
            this.tbaddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbaddress.DefaultText = "";
            this.tbaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbaddress.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbaddress.Location = new System.Drawing.Point(231, 334);
            this.tbaddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbaddress.Name = "tbaddress";
            this.tbaddress.PasswordChar = '\0';
            this.tbaddress.PlaceholderText = "";
            this.tbaddress.SelectedText = "";
            this.tbaddress.Size = new System.Drawing.Size(241, 35);
            this.tbaddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbaddress.TabIndex = 52;
            // 
            // tbphoneno
            // 
            this.tbphoneno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbphoneno.BorderThickness = 4;
            this.tbphoneno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbphoneno.DefaultText = "";
            this.tbphoneno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbphoneno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbphoneno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbphoneno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbphoneno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbphoneno.Font = new System.Drawing.Font("Constantia", 9.75F);
            this.tbphoneno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbphoneno.Location = new System.Drawing.Point(231, 284);
            this.tbphoneno.Margin = new System.Windows.Forms.Padding(2);
            this.tbphoneno.Name = "tbphoneno";
            this.tbphoneno.PasswordChar = '\0';
            this.tbphoneno.PlaceholderText = "";
            this.tbphoneno.SelectedText = "";
            this.tbphoneno.Size = new System.Drawing.Size(241, 35);
            this.tbphoneno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbphoneno.TabIndex = 51;
            // 
            // ctbdob
            // 
            this.ctbdob.Location = new System.Drawing.Point(231, 245);
            this.ctbdob.Margin = new System.Windows.Forms.Padding(2);
            this.ctbdob.Name = "ctbdob";
            this.ctbdob.Size = new System.Drawing.Size(241, 20);
            this.ctbdob.TabIndex = 50;
            // 
            // NewAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1024, 619);
            this.Controls.Add(this.tbstate);
            this.Controls.Add(this.tbdistrict);
            this.Controls.Add(this.tbaddress);
            this.Controls.Add(this.tbphoneno);
            this.Controls.Add(this.ctbdob);
            this.Controls.Add(this.linacc_no);
            this.Controls.Add(this.tbbalance);
            this.Controls.Add(this.ctbmartialstatus);
            this.Controls.Add(this.ctbgender);
            this.Controls.Add(this.tbcnicnumber);
            this.Controls.Add(this.tbmothername);
            this.Controls.Add(this.tbfathername);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnuploadpic);
            this.Controls.Add(this.picuser);
            this.Controls.Add(this.linputdate);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account Form";
            ((System.ComponentModel.ISupportInitialize)(this.picuser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label ldate;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picuser;
        private Guna.UI2.WinForms.Guna2Button btnuploadpic;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private Guna.UI2.WinForms.Guna2TextBox tbname;
        private Guna.UI2.WinForms.Guna2ComboBox ctbgender;
        private Guna.UI2.WinForms.Guna2TextBox tbcnicnumber;
        private Guna.UI2.WinForms.Guna2TextBox tbmothername;
        private Guna.UI2.WinForms.Guna2TextBox tbfathername;
        private Guna.UI2.WinForms.Guna2ComboBox ctbmartialstatus;
        private Guna.UI2.WinForms.Guna2TextBox tbbalance;
        private Label linputdate;
        private Label linacc_no;
        private Guna.UI2.WinForms.Guna2TextBox tbstate;
        private Guna.UI2.WinForms.Guna2TextBox tbdistrict;
        private Guna.UI2.WinForms.Guna2TextBox tbaddress;
        private Guna.UI2.WinForms.Guna2TextBox tbphoneno;
        private DateTimePicker ctbdob;
    }
}