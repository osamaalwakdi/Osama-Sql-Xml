namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnclear = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.OutDate = new System.Windows.Forms.DateTimePicker();
            this.InDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GuestNo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustEmail = new System.Windows.Forms.TextBox();
            this.CustName = new System.Windows.Forms.TextBox();
            this.BookingID = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestNo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(45, 615);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(173, 54);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "button4";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(677, 615);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(173, 54);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "button2";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1115, 239);
            this.dataGridView1.TabIndex = 14;
//            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // RoomType
            // 
            this.RoomType.FormattingEnabled = true;
            this.RoomType.Items.AddRange(new object[] {
            "غرفة",
            "جناح ملكي"});
            this.RoomType.Location = new System.Drawing.Point(293, 174);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(190, 27);
            this.RoomType.TabIndex = 13;
            // 
            // OutDate
            // 
            this.OutDate.Location = new System.Drawing.Point(284, 100);
            this.OutDate.Name = "OutDate";
            this.OutDate.Size = new System.Drawing.Size(200, 27);
            this.OutDate.TabIndex = 12;
            // 
            // InDate
            // 
            this.InDate.Location = new System.Drawing.Point(284, 27);
            this.InDate.Name = "InDate";
            this.InDate.Size = new System.Drawing.Size(200, 27);
            this.InDate.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(541, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 44);
            this.label7.TabIndex = 10;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(541, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 44);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(986, 615);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(173, 54);
            this.btnadd.TabIndex = 6;
            this.btnadd.Text = "button1";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(541, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // GuestNo
            // 
            this.GuestNo.Location = new System.Drawing.Point(884, 246);
            this.GuestNo.Name = "GuestNo";
            this.GuestNo.Size = new System.Drawing.Size(91, 27);
            this.GuestNo.TabIndex = 7;
            this.GuestNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(981, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(981, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(987, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // CustEmail
            // 
            this.CustEmail.Location = new System.Drawing.Point(777, 174);
            this.CustEmail.Multiline = true;
            this.CustEmail.Name = "CustEmail";
            this.CustEmail.Size = new System.Drawing.Size(194, 44);
            this.CustEmail.TabIndex = 2;
            // 
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(777, 100);
            this.CustName.Multiline = true;
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(194, 44);
            this.CustName.TabIndex = 1;
            // 
            // BookingID
            // 
            this.BookingID.Location = new System.Drawing.Point(777, 27);
            this.BookingID.Multiline = true;
            this.BookingID.Name = "BookingID";
            this.BookingID.Size = new System.Drawing.Size(194, 44);
            this.BookingID.TabIndex = 0;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(349, 615);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(173, 54);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "button3";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.RoomType);
            this.groupBox1.Controls.Add(this.OutDate);
            this.groupBox1.Controls.Add(this.InDate);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GuestNo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CustEmail);
            this.groupBox1.Controls.Add(this.CustName);
            this.groupBox1.Controls.Add(this.BookingID);
            this.groupBox1.Location = new System.Drawing.Point(39, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 533);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(981, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 739);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestNo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.DateTimePicker OutDate;
        private System.Windows.Forms.DateTimePicker InDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown GuestNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustEmail;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.TextBox BookingID;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
    }
}

