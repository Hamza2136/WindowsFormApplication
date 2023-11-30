namespace File_Read_Write
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
            tbfname = new TextBox();
            lfname = new Label();
            llname = new Label();
            tblname = new TextBox();
            lgender = new Label();
            laddress = new Label();
            tbaddress = new TextBox();
            txgender = new ComboBox();
            btnsubmit = new Button();
            rtbdataviewer = new RichTextBox();
            lrtdataviewer = new Label();
            btnchange = new Button();
            SuspendLayout();
            // 
            // tbfname
            // 
            tbfname.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbfname.Location = new Point(123, 29);
            tbfname.Name = "tbfname";
            tbfname.Size = new Size(192, 27);
            tbfname.TabIndex = 0;
            // 
            // lfname
            // 
            lfname.AutoSize = true;
            lfname.Font = new Font("Garamond", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lfname.ForeColor = Color.Snow;
            lfname.Location = new Point(12, 35);
            lfname.Name = "lfname";
            lfname.Size = new Size(92, 18);
            lfname.TabIndex = 1;
            lfname.Text = "First Name:";
            // 
            // llname
            // 
            llname.AutoSize = true;
            llname.Font = new Font("Garamond", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            llname.ForeColor = Color.Snow;
            llname.Location = new Point(12, 67);
            llname.Name = "llname";
            llname.Size = new Size(90, 18);
            llname.TabIndex = 3;
            llname.Text = "Last Name:";
            // 
            // tblname
            // 
            tblname.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tblname.Location = new Point(123, 60);
            tblname.Name = "tblname";
            tblname.Size = new Size(192, 27);
            tblname.TabIndex = 2;
            // 
            // lgender
            // 
            lgender.AutoSize = true;
            lgender.Font = new Font("Garamond", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lgender.Location = new Point(12, 99);
            lgender.Name = "lgender";
            lgender.Size = new Size(64, 18);
            lgender.TabIndex = 5;
            lgender.Text = "Gender:";
            // 
            // laddress
            // 
            laddress.AutoSize = true;
            laddress.Font = new Font("Garamond", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            laddress.Location = new Point(12, 131);
            laddress.Name = "laddress";
            laddress.Size = new Size(69, 18);
            laddress.TabIndex = 7;
            laddress.Text = "Address:";
            // 
            // tbaddress
            // 
            tbaddress.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbaddress.Location = new Point(123, 124);
            tbaddress.Name = "tbaddress";
            tbaddress.Size = new Size(192, 27);
            tbaddress.TabIndex = 6;
            // 
            // txgender
            // 
            txgender.DropDownStyle = ComboBoxStyle.DropDownList;
            txgender.Font = new Font("Gadugi", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txgender.FormattingEnabled = true;
            txgender.Items.AddRange(new object[] { "Male", "Female", "Other" });
            txgender.Location = new Point(123, 91);
            txgender.Name = "txgender";
            txgender.Size = new Size(192, 27);
            txgender.TabIndex = 8;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = SystemColors.ActiveBorder;
            btnsubmit.FlatStyle = FlatStyle.Flat;
            btnsubmit.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsubmit.ForeColor = Color.FromArgb(32, 32, 32);
            btnsubmit.Location = new Point(170, 178);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(100, 26);
            btnsubmit.TabIndex = 9;
            btnsubmit.Text = "Add Data";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // rtbdataviewer
            // 
            rtbdataviewer.Font = new Font("Gadugi", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtbdataviewer.Location = new Point(340, 29);
            rtbdataviewer.Name = "rtbdataviewer";
            rtbdataviewer.Size = new Size(219, 121);
            rtbdataviewer.TabIndex = 10;
            rtbdataviewer.Text = "";
            rtbdataviewer.TextChanged += rtbdataviewer_TextChanged;
            // 
            // lrtdataviewer
            // 
            lrtdataviewer.AutoSize = true;
            lrtdataviewer.Font = new Font("Garamond", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lrtdataviewer.Location = new Point(340, 9);
            lrtdataviewer.Name = "lrtdataviewer";
            lrtdataviewer.Size = new Size(94, 18);
            lrtdataviewer.TabIndex = 11;
            lrtdataviewer.Text = "Data Viewer";
            lrtdataviewer.Click += label5_Click;
            // 
            // btnchange
            // 
            btnchange.BackColor = SystemColors.ActiveBorder;
            btnchange.FlatStyle = FlatStyle.Flat;
            btnchange.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnchange.ForeColor = Color.FromArgb(32, 32, 32);
            btnchange.Location = new Point(143, 210);
            btnchange.Name = "btnchange";
            btnchange.Size = new Size(147, 29);
            btnchange.TabIndex = 12;
            btnchange.Text = "Change Mode";
            btnchange.UseVisualStyleBackColor = false;
            btnchange.Click += btnchange_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(575, 274);
            Controls.Add(btnchange);
            Controls.Add(lrtdataviewer);
            Controls.Add(rtbdataviewer);
            Controls.Add(btnsubmit);
            Controls.Add(txgender);
            Controls.Add(laddress);
            Controls.Add(tbaddress);
            Controls.Add(lgender);
            Controls.Add(llname);
            Controls.Add(tblname);
            Controls.Add(lfname);
            Controls.Add(tbfname);
            ForeColor = Color.Snow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Data Reader/Writer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbfname;
        private Label lfname;
        private Label llname;
        private TextBox tblname;
        private Label lgender;
        private Label laddress;
        private TextBox tbaddress;
        private ComboBox txgender;
        private Button btnsubmit;
        private RichTextBox rtbdataviewer;
        private Label lrtdataviewer;
        private Button btnchange;
    }
}