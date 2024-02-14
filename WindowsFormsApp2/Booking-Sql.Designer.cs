namespace WindowsFormsApp2
{
    partial class Booking_Sql
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RoomType = new System.Windows.Forms.ComboBox();
            this.OutDate = new System.Windows.Forms.DateTimePicker();
            this.InDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GuestNo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustEmail = new System.Windows.Forms.TextBox();
            this.CustName = new System.Windows.Forms.TextBox();
            this.BookingID = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.osatimersql = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.pictureBox1);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Move += new System.EventHandler(this.groupBox1_Move);
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
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // RoomType
            // 
            this.RoomType.FormattingEnabled = true;
            this.RoomType.Items.AddRange(new object[] {
            "غرفة ديلوكس",
            "غرفة عائلي ملكي",
            "جناح ملكي"});
            this.RoomType.Location = new System.Drawing.Point(293, 174);
            this.RoomType.Name = "RoomType";
            this.RoomType.Size = new System.Drawing.Size(190, 27);
            this.RoomType.TabIndex = 13;
            this.RoomType.SelectedIndexChanged += new System.EventHandler(this.RoomType_SelectedIndexChanged);
            this.RoomType.Click += new System.EventHandler(this.RoomType_Click);
            this.RoomType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RoomType_KeyPress);
            this.RoomType.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RoomType_MouseClick);
            // 
            // OutDate
            // 
            this.OutDate.Location = new System.Drawing.Point(284, 100);
            this.OutDate.Name = "OutDate";
            this.OutDate.Size = new System.Drawing.Size(200, 27);
            this.OutDate.TabIndex = 12;
            this.OutDate.ValueChanged += new System.EventHandler(this.OutDate_ValueChanged);
            // 
            // InDate
            // 
            this.InDate.Location = new System.Drawing.Point(284, 27);
            this.InDate.Name = "InDate";
            this.InDate.Size = new System.Drawing.Size(200, 27);
            this.InDate.TabIndex = 11;
            this.InDate.ValueChanged += new System.EventHandler(this.InDate_ValueChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 44);
            this.label7.TabIndex = 10;
            this.label7.Text = "نوع الحجز";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(541, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 44);
            this.label6.TabIndex = 9;
            this.label6.Text = "تاريخ المغادرة";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ الوصول ";
            // 
            // GuestNo
            // 
            this.GuestNo.Location = new System.Drawing.Point(852, 246);
            this.GuestNo.Name = "GuestNo";
            this.GuestNo.Size = new System.Drawing.Size(91, 27);
            this.GuestNo.TabIndex = 7;
            this.GuestNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GuestNo.ValueChanged += new System.EventHandler(this.GuestNo_ValueChanged);
            this.GuestNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GuestNo_KeyDown);
            this.GuestNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuestNo_KeyPress);
            this.GuestNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GuestNo_MouseClick);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(970, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "عدد الافراد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(933, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "البريد الالكتروني";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(964, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "إسم العميل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(964, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الحجز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CustEmail
            // 
            this.CustEmail.Location = new System.Drawing.Point(745, 174);
            this.CustEmail.Multiline = true;
            this.CustEmail.Name = "CustEmail";
            this.CustEmail.Size = new System.Drawing.Size(194, 44);
            this.CustEmail.TabIndex = 2;
            this.CustEmail.TextChanged += new System.EventHandler(this.CustEmail_TextChanged);
            // 
            // CustName
            // 
            this.CustName.Location = new System.Drawing.Point(745, 100);
            this.CustName.Multiline = true;
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(194, 44);
            this.CustName.TabIndex = 1;
            this.CustName.TextChanged += new System.EventHandler(this.CustName_TextChanged);
            // 
            // BookingID
            // 
            this.BookingID.Location = new System.Drawing.Point(745, 27);
            this.BookingID.Multiline = true;
            this.BookingID.Name = "BookingID";
            this.BookingID.Size = new System.Drawing.Size(194, 44);
            this.BookingID.TabIndex = 0;
            this.BookingID.TextChanged += new System.EventHandler(this.BookingID_TextChanged);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.RosyBrown;
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(959, 614);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(173, 54);
            this.btnadd.TabIndex = 1;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.RosyBrown;
            this.btnupdate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(650, 614);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(173, 54);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.RosyBrown;
            this.btndelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(322, 614);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(173, 54);
            this.btndelete.TabIndex = 3;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.RosyBrown;
            this.btnclear.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(18, 614);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(173, 54);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // osatimersql
            // 
            this.osatimersql.Interval = 10000;
            this.osatimersql.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(380, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "فنادق القمة العربية السياحي";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(3, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Booking_Sql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1167, 680);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.groupBox1);
            this.Name = "Booking_Sql";
            this.Text = "Booking_Sql";
            this.Load += new System.EventHandler(this.Booking_Sql_Load);
            this.Enter += new System.EventHandler(this.Booking_Sql_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Booking_Sql_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Booking_Sql_KeyPress);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Booking_Sql_MouseMove);
            this.Move += new System.EventHandler(this.Booking_Sql_Move);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuestNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox RoomType;
        private System.Windows.Forms.DateTimePicker OutDate;
        private System.Windows.Forms.DateTimePicker InDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown GuestNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustEmail;
        private System.Windows.Forms.TextBox CustName;
        private System.Windows.Forms.TextBox BookingID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Timer osatimersql;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}