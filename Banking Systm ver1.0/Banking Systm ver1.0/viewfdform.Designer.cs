namespace Banking_Systm_ver1._0
{
    partial class viewfdform
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
            this.btnviewfd = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gview = new System.Windows.Forms.DataGridView();
            this.ctbdatetime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnviewfd
            // 
            this.btnviewfd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnviewfd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnviewfd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnviewfd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnviewfd.FillColor = System.Drawing.Color.Black;
            this.btnviewfd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewfd.ForeColor = System.Drawing.Color.White;
            this.btnviewfd.Location = new System.Drawing.Point(236, 70);
            this.btnviewfd.Name = "btnviewfd";
            this.btnviewfd.Size = new System.Drawing.Size(108, 36);
            this.btnviewfd.TabIndex = 1;
            this.btnviewfd.Text = "View FD\'s";
            this.btnviewfd.Click += new System.EventHandler(this.btnviewfd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "View FD\'s Form";
            // 
            // gview
            // 
            this.gview.BackgroundColor = System.Drawing.Color.White;
            this.gview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gview.Location = new System.Drawing.Point(0, 130);
            this.gview.Name = "gview";
            this.gview.Size = new System.Drawing.Size(1042, 392);
            this.gview.TabIndex = 4;
            // 
            // ctbdatetime
            // 
            this.ctbdatetime.Checked = true;
            this.ctbdatetime.FillColor = System.Drawing.Color.MintCream;
            this.ctbdatetime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ctbdatetime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.ctbdatetime.Location = new System.Drawing.Point(12, 70);
            this.ctbdatetime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.ctbdatetime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.ctbdatetime.Name = "ctbdatetime";
            this.ctbdatetime.Size = new System.Drawing.Size(200, 36);
            this.ctbdatetime.TabIndex = 5;
            this.ctbdatetime.Value = new System.DateTime(2023, 6, 13, 20, 15, 59, 816);
            // 
            // viewfdform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 522);
            this.Controls.Add(this.ctbdatetime);
            this.Controls.Add(this.gview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnviewfd);
            this.Name = "viewfdform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewfdform";
            ((System.ComponentModel.ISupportInitialize)(this.gview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnviewfd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gview;
        private Guna.UI2.WinForms.Guna2DateTimePicker ctbdatetime;
    }
}