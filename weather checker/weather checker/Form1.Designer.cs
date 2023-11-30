namespace weather_checker
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
            lcityname = new Label();
            tbcityname = new TextBox();
            btnsearch = new Button();
            lconditiontxt = new Label();
            ldescriptiontxt = new Label();
            ltempreturetxt = new Label();
            lwindspeedtxt = new Label();
            lsunsettxt = new Label();
            lsunrisetxt = new Label();
            lpressuretxt = new Label();
            lcondition = new Label();
            ldescription = new Label();
            ltempreture = new Label();
            lwindspeed = new Label();
            lpressure = new Label();
            lsunrise = new Label();
            lsunset = new Label();
            SuspendLayout();
            // 
            // lcityname
            // 
            lcityname.AutoSize = true;
            lcityname.BackColor = Color.Transparent;
            lcityname.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lcityname.ForeColor = Color.Snow;
            lcityname.Location = new Point(41, 53);
            lcityname.Name = "lcityname";
            lcityname.Size = new Size(97, 29);
            lcityname.TabIndex = 0;
            lcityname.Text = "City Name:";
            // 
            // tbcityname
            // 
            tbcityname.BackColor = Color.FromArgb(32, 32, 32);
            tbcityname.Font = new Font("Rockwell Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tbcityname.ForeColor = Color.Transparent;
            tbcityname.Location = new Point(135, 54);
            tbcityname.Name = "tbcityname";
            tbcityname.Size = new Size(196, 30);
            tbcityname.TabIndex = 1;
            tbcityname.TextChanged += tbcityname_TextChanged;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(32, 32, 32);
            btnsearch.FlatStyle = FlatStyle.Flat;
            btnsearch.Font = new Font("Rockwell Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.ForeColor = Color.Snow;
            btnsearch.Location = new Point(340, 55);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(74, 27);
            btnsearch.TabIndex = 2;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // lconditiontxt
            // 
            lconditiontxt.AutoSize = true;
            lconditiontxt.BackColor = Color.Transparent;
            lconditiontxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lconditiontxt.ForeColor = Color.Snow;
            lconditiontxt.Location = new Point(41, 149);
            lconditiontxt.Name = "lconditiontxt";
            lconditiontxt.Size = new Size(86, 29);
            lconditiontxt.TabIndex = 3;
            lconditiontxt.Text = "Condition:";
            // 
            // ldescriptiontxt
            // 
            ldescriptiontxt.AutoSize = true;
            ldescriptiontxt.BackColor = Color.Transparent;
            ldescriptiontxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ldescriptiontxt.ForeColor = Color.Snow;
            ldescriptiontxt.Location = new Point(41, 207);
            ldescriptiontxt.Name = "ldescriptiontxt";
            ldescriptiontxt.Size = new Size(101, 29);
            ldescriptiontxt.TabIndex = 4;
            ldescriptiontxt.Text = "Description:";
            // 
            // ltempreturetxt
            // 
            ltempreturetxt.AutoSize = true;
            ltempreturetxt.BackColor = Color.Transparent;
            ltempreturetxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ltempreturetxt.ForeColor = Color.Snow;
            ltempreturetxt.Location = new Point(41, 262);
            ltempreturetxt.Name = "ltempreturetxt";
            ltempreturetxt.Size = new Size(102, 29);
            ltempreturetxt.TabIndex = 5;
            ltempreturetxt.Text = "Tempreture:";
            // 
            // lwindspeedtxt
            // 
            lwindspeedtxt.AutoSize = true;
            lwindspeedtxt.BackColor = Color.Transparent;
            lwindspeedtxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lwindspeedtxt.ForeColor = Color.Snow;
            lwindspeedtxt.Location = new Point(41, 315);
            lwindspeedtxt.Name = "lwindspeedtxt";
            lwindspeedtxt.Size = new Size(106, 29);
            lwindspeedtxt.TabIndex = 6;
            lwindspeedtxt.Text = "Wind Speed:";
            // 
            // lsunsettxt
            // 
            lsunsettxt.AutoSize = true;
            lsunsettxt.BackColor = Color.Transparent;
            lsunsettxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lsunsettxt.ForeColor = Color.Snow;
            lsunsettxt.Location = new Point(282, 262);
            lsunsettxt.Name = "lsunsettxt";
            lsunsettxt.Size = new Size(66, 29);
            lsunsettxt.TabIndex = 9;
            lsunsettxt.Text = "Sunset:";
            // 
            // lsunrisetxt
            // 
            lsunrisetxt.AutoSize = true;
            lsunrisetxt.BackColor = Color.Transparent;
            lsunrisetxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lsunrisetxt.ForeColor = Color.Snow;
            lsunrisetxt.Location = new Point(282, 207);
            lsunrisetxt.Name = "lsunrisetxt";
            lsunrisetxt.Size = new Size(72, 29);
            lsunrisetxt.TabIndex = 8;
            lsunrisetxt.Text = "Sunrise:";
            // 
            // lpressuretxt
            // 
            lpressuretxt.AutoSize = true;
            lpressuretxt.BackColor = Color.Transparent;
            lpressuretxt.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lpressuretxt.ForeColor = Color.Snow;
            lpressuretxt.Location = new Point(282, 149);
            lpressuretxt.Name = "lpressuretxt";
            lpressuretxt.Size = new Size(82, 29);
            lpressuretxt.TabIndex = 11;
            lpressuretxt.Text = "Pressure:";
            // 
            // lcondition
            // 
            lcondition.AutoSize = true;
            lcondition.BackColor = Color.Transparent;
            lcondition.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lcondition.ForeColor = Color.Snow;
            lcondition.Location = new Point(135, 149);
            lcondition.Name = "lcondition";
            lcondition.Size = new Size(0, 29);
            lcondition.TabIndex = 12;
            // 
            // ldescription
            // 
            ldescription.AutoSize = true;
            ldescription.BackColor = Color.Transparent;
            ldescription.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ldescription.ForeColor = Color.Snow;
            ldescription.Location = new Point(135, 207);
            ldescription.Name = "ldescription";
            ldescription.Size = new Size(0, 29);
            ldescription.TabIndex = 13;
            // 
            // ltempreture
            // 
            ltempreture.AutoSize = true;
            ltempreture.BackColor = Color.Transparent;
            ltempreture.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ltempreture.ForeColor = Color.Snow;
            ltempreture.Location = new Point(135, 262);
            ltempreture.Name = "ltempreture";
            ltempreture.Size = new Size(0, 29);
            ltempreture.TabIndex = 14;
            // 
            // lwindspeed
            // 
            lwindspeed.AutoSize = true;
            lwindspeed.BackColor = Color.Transparent;
            lwindspeed.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lwindspeed.ForeColor = Color.Snow;
            lwindspeed.Location = new Point(135, 315);
            lwindspeed.Name = "lwindspeed";
            lwindspeed.Size = new Size(0, 29);
            lwindspeed.TabIndex = 15;
            // 
            // lpressure
            // 
            lpressure.AutoSize = true;
            lpressure.BackColor = Color.Transparent;
            lpressure.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lpressure.ForeColor = Color.Snow;
            lpressure.Location = new Point(357, 149);
            lpressure.Name = "lpressure";
            lpressure.Size = new Size(0, 29);
            lpressure.TabIndex = 16;
            // 
            // lsunrise
            // 
            lsunrise.AutoSize = true;
            lsunrise.BackColor = Color.Transparent;
            lsunrise.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lsunrise.ForeColor = Color.Snow;
            lsunrise.Location = new Point(357, 207);
            lsunrise.Name = "lsunrise";
            lsunrise.Size = new Size(0, 29);
            lsunrise.TabIndex = 17;
            // 
            // lsunset
            // 
            lsunset.AutoSize = true;
            lsunset.BackColor = Color.Transparent;
            lsunset.Font = new Font("Rockwell Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lsunset.ForeColor = Color.Snow;
            lsunset.Location = new Point(357, 262);
            lsunset.Name = "lsunset";
            lsunset.Size = new Size(0, 29);
            lsunset.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(467, 443);
            Controls.Add(lsunset);
            Controls.Add(lsunrise);
            Controls.Add(lpressure);
            Controls.Add(lwindspeed);
            Controls.Add(ltempreture);
            Controls.Add(ldescription);
            Controls.Add(lcondition);
            Controls.Add(lpressuretxt);
            Controls.Add(lsunsettxt);
            Controls.Add(lsunrisetxt);
            Controls.Add(lwindspeedtxt);
            Controls.Add(ltempreturetxt);
            Controls.Add(ldescriptiontxt);
            Controls.Add(lconditiontxt);
            Controls.Add(btnsearch);
            Controls.Add(tbcityname);
            Controls.Add(lcityname);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weather Checker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lcityname;
        private TextBox tbcityname;
        private Button btnsearch;
        private Label lconditiontxt;
        private Label ldescriptiontxt;
        private Label ltempreturetxt;
        private Label lwindspeedtxt;
        private Label lsunsettxt;
        private Label lsunrisetxt;
        private Label lpressuretxt;
        private Label lcondition;
        private Label ldescription;
        private Label ltempreture;
        private Label lwindspeed;
        private Label lpressure;
        private Label lsunrise;
        private Label lsunset;
    }
}