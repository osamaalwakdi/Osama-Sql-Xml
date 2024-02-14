namespace WindowsFormsApp2
{
    partial class OsaCreateUsers
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
            this.btnbacklogin = new System.Windows.Forms.Button();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnewuser = new System.Windows.Forms.Button();
            this.txtnewusername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbacklogin
            // 
            this.btnbacklogin.Location = new System.Drawing.Point(65, 270);
            this.btnbacklogin.Name = "btnbacklogin";
            this.btnbacklogin.Size = new System.Drawing.Size(135, 54);
            this.btnbacklogin.TabIndex = 11;
            this.btnbacklogin.Text = "Back";
            this.btnbacklogin.UseVisualStyleBackColor = true;
            this.btnbacklogin.Click += new System.EventHandler(this.btnbacklogin_Click);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(23, 152);
            this.txtnewpassword.Multiline = true;
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(228, 46);
            this.txtnewpassword.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(285, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 43);
            this.label2.TabIndex = 9;
            this.label2.Text = "أدخل كلمة المرور";
            // 
            // btnnewuser
            // 
            this.btnnewuser.Location = new System.Drawing.Point(303, 270);
            this.btnnewuser.Name = "btnnewuser";
            this.btnnewuser.Size = new System.Drawing.Size(135, 54);
            this.btnnewuser.TabIndex = 8;
            this.btnnewuser.Text = "Add";
            this.btnnewuser.UseVisualStyleBackColor = true;
            this.btnnewuser.Click += new System.EventHandler(this.btnnewuser_Click);
            // 
            // txtnewusername
            // 
            this.txtnewusername.Location = new System.Drawing.Point(18, 69);
            this.txtnewusername.Multiline = true;
            this.txtnewusername.Name = "txtnewusername";
            this.txtnewusername.Size = new System.Drawing.Size(228, 46);
            this.txtnewusername.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(280, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "أدخل إسم المستخدم";
 //           this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OsaCreateUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 393);
            this.Controls.Add(this.btnbacklogin);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnnewuser);
            this.Controls.Add(this.txtnewusername);
            this.Controls.Add(this.label1);
            this.Name = "OsaCreateUsers";
            this.Text = "OsaCreateUsers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbacklogin;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnewuser;
        private System.Windows.Forms.TextBox txtnewusername;
        private System.Windows.Forms.Label label1;
    }
}