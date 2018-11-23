namespace Prj138
{
    partial class frmLogin
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
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPasswords = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(347, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(348, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "کلمه عبور";
            // 
            // tbxUsername
            // 
            this.tbxUsername.BackColor = System.Drawing.Color.White;
            this.tbxUsername.Location = new System.Drawing.Point(102, 106);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(226, 21);
            this.tbxUsername.TabIndex = 0;
            // 
            // tbxPasswords
            // 
            this.tbxPasswords.Location = new System.Drawing.Point(102, 156);
            this.tbxPasswords.Name = "tbxPasswords";
            this.tbxPasswords.PasswordChar = '*';
            this.tbxPasswords.Size = new System.Drawing.Size(226, 21);
            this.tbxPasswords.TabIndex = 1;
            this.tbxPasswords.MouseEnter += new System.EventHandler(this.tbxPasswords_MouseEnter);
            this.tbxPasswords.MouseLeave += new System.EventHandler(this.tbxPasswords_MouseLeave);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOk.Location = new System.Drawing.Point(180, 205);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(92, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "ورود";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::Prj138.Properties.Resources.error_32x;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(419, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 26);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Prj138.Properties.Resources.fresh_login_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(467, 275);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxPasswords);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود کاربران";
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPasswords;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnExit;
    }
}