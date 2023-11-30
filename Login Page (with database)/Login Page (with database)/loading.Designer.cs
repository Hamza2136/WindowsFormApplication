namespace Login_Page__with_database_
{
    partial class loading
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
            button2 = new Button();
            button1 = new Button();
            btnexit = new Button();
            lmain = new Label();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(788, 0);
            button2.Name = "button2";
            button2.Size = new Size(60, 40);
            button2.TabIndex = 16;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(854, 0);
            button1.Name = "button1";
            button1.Size = new Size(60, 40);
            button1.TabIndex = 15;
            button1.Text = "🗖";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.LightGray;
            btnexit.FlatAppearance.BorderSize = 0;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Copperplate Gothic Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnexit.Location = new Point(920, 0);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(60, 40);
            btnexit.TabIndex = 14;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = false;
            btnexit.Click += btnexit_Click;
            // 
            // lmain
            // 
            lmain.AutoSize = true;
            lmain.FlatStyle = FlatStyle.Flat;
            lmain.Font = new Font("Copperplate Gothic Bold", 72F, FontStyle.Italic, GraphicsUnit.Point);
            lmain.Location = new Point(116, 262);
            lmain.Name = "lmain";
            lmain.Size = new Size(733, 107);
            lmain.TabIndex = 17;
            lmain.Text = "Welcome Sir";
            // 
            // loading
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 670);
            Controls.Add(lmain);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnexit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loading";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private Button button1;
        private Button btnexit;
        private Label lmain;
    }
}