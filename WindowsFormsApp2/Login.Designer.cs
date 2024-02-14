namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnewuser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(289, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "أدخل إسم المستخدم";
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(27, 88);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(228, 46);
            this.txtusername.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(312, 289);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(135, 54);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(32, 171);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(228, 46);
            this.txtpassword.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(294, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "أدخل كلمة المرور";
            // 
            // btnnewuser
            // 
            this.btnnewuser.Location = new System.Drawing.Point(74, 289);
            this.btnnewuser.Name = "btnnewuser";
            this.btnnewuser.Size = new System.Drawing.Size(135, 54);
            this.btnnewuser.TabIndex = 5;
            this.btnnewuser.Text = "Sign-up";
            this.btnnewuser.UseVisualStyleBackColor = true;
            this.btnnewuser.Click += new System.EventHandler(this.btnnewuser_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 389);
            this.Controls.Add(this.btnnewuser);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnewuser;
    }
}