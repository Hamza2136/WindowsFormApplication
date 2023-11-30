namespace Banking_Systm_ver1._0
{
    partial class balancesheetform
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
            this.tbaccountno = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnview = new Guna.UI2.WinForms.Guna2Button();
            this.gviewwithdraw = new System.Windows.Forms.DataGridView();
            this.gviewdeposit = new System.Windows.Forms.DataGridView();
            this.gviewtransfer = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gviewwithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewdeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewtransfer)).BeginInit();
            this.SuspendLayout();
            // 
            // tbaccountno
            // 
            this.tbaccountno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tbaccountno.BorderThickness = 4;
            this.tbaccountno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbaccountno.DefaultText = "";
            this.tbaccountno.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbaccountno.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbaccountno.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbaccountno.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbaccountno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbaccountno.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbaccountno.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbaccountno.Location = new System.Drawing.Point(12, 64);
            this.tbaccountno.Name = "tbaccountno";
            this.tbaccountno.PasswordChar = '\0';
            this.tbaccountno.PlaceholderText = "";
            this.tbaccountno.SelectedText = "";
            this.tbaccountno.Size = new System.Drawing.Size(290, 36);
            this.tbaccountno.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.tbaccountno.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Balance Sheet";
            // 
            // btnview
            // 
            this.btnview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnview.FillColor = System.Drawing.Color.Black;
            this.btnview.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.ForeColor = System.Drawing.Color.White;
            this.btnview.Location = new System.Drawing.Point(322, 65);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(135, 35);
            this.btnview.TabIndex = 2;
            this.btnview.Text = "View";
            this.btnview.Click += new System.EventHandler(this.btnview_Click);
            // 
            // gviewwithdraw
            // 
            this.gviewwithdraw.BackgroundColor = System.Drawing.Color.White;
            this.gviewwithdraw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewwithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewwithdraw.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gviewwithdraw.Location = new System.Drawing.Point(12, 148);
            this.gviewwithdraw.Name = "gviewwithdraw";
            this.gviewwithdraw.Size = new System.Drawing.Size(469, 460);
            this.gviewwithdraw.TabIndex = 3;
            // 
            // gviewdeposit
            // 
            this.gviewdeposit.BackgroundColor = System.Drawing.Color.White;
            this.gviewdeposit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewdeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewdeposit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gviewdeposit.Location = new System.Drawing.Point(499, 148);
            this.gviewdeposit.Name = "gviewdeposit";
            this.gviewdeposit.Size = new System.Drawing.Size(469, 460);
            this.gviewdeposit.TabIndex = 4;
            // 
            // gviewtransfer
            // 
            this.gviewtransfer.BackgroundColor = System.Drawing.Color.White;
            this.gviewtransfer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gviewtransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gviewtransfer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gviewtransfer.Location = new System.Drawing.Point(987, 148);
            this.gviewtransfer.Name = "gviewtransfer";
            this.gviewtransfer.Size = new System.Drawing.Size(469, 460);
            this.gviewtransfer.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Withdraw Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(493, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "Deposit Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Copperplate Gothic Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(981, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Transfer Details";
            // 
            // balancesheetform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gviewtransfer);
            this.Controls.Add(this.gviewdeposit);
            this.Controls.Add(this.gviewwithdraw);
            this.Controls.Add(this.btnview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbaccountno);
            this.Name = "balancesheetform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "balancesheetform";
            ((System.ComponentModel.ISupportInitialize)(this.gviewwithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewdeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gviewtransfer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox tbaccountno;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnview;
        private System.Windows.Forms.DataGridView gviewwithdraw;
        private System.Windows.Forms.DataGridView gviewdeposit;
        private System.Windows.Forms.DataGridView gviewtransfer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}