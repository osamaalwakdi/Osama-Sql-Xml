namespace WindowsFormsApp2
{
    partial class Booking_Xml
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
            this.btnclearxml = new System.Windows.Forms.Button();
            this.Osa_dataGridViewxml = new System.Windows.Forms.DataGridView();
            this.Osa_RoomTypexml = new System.Windows.Forms.ComboBox();
            this.Osa_OutDatexml = new System.Windows.Forms.DateTimePicker();
            this.Osa_InDatexml = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Osa_GuestsNoxml = new System.Windows.Forms.NumericUpDown();
            this.btnupdatexml = new System.Windows.Forms.Button();
            this.btnaddxml = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Osa_CustEmailxml = new System.Windows.Forms.TextBox();
            this.Osa_CustNamexml = new System.Windows.Forms.TextBox();
            this.BookingID = new System.Windows.Forms.TextBox();
            this.btndeletexml = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Osa_dataGridViewxml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Osa_GuestsNoxml)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclearxml
            // 
            this.btnclearxml.BackColor = System.Drawing.Color.RosyBrown;
            this.btnclearxml.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearxml.Location = new System.Drawing.Point(40, 625);
            this.btnclearxml.Name = "btnclearxml";
            this.btnclearxml.Size = new System.Drawing.Size(173, 54);
            this.btnclearxml.TabIndex = 9;
            this.btnclearxml.Text = "Clear";
            this.btnclearxml.UseVisualStyleBackColor = false;
            this.btnclearxml.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Osa_dataGridViewxml
            // 
            this.Osa_dataGridViewxml.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Osa_dataGridViewxml.Location = new System.Drawing.Point(6, 281);
            this.Osa_dataGridViewxml.Name = "Osa_dataGridViewxml";
            this.Osa_dataGridViewxml.RowHeadersWidth = 62;
            this.Osa_dataGridViewxml.RowTemplate.Height = 29;
            this.Osa_dataGridViewxml.Size = new System.Drawing.Size(1115, 239);
            this.Osa_dataGridViewxml.TabIndex = 14;
            this.Osa_dataGridViewxml.SelectionChanged += new System.EventHandler(this.Osa_dataGridViewxml_SelectionChanged);
            // 
            // Osa_RoomTypexml
            // 
            this.Osa_RoomTypexml.FormattingEnabled = true;
            this.Osa_RoomTypexml.Items.AddRange(new object[] {
            "غرفة ديلوكس",
            "غرفة عائلي ملكي",
            "جناح ملكي"});
            this.Osa_RoomTypexml.Location = new System.Drawing.Point(288, 167);
            this.Osa_RoomTypexml.Name = "Osa_RoomTypexml";
            this.Osa_RoomTypexml.Size = new System.Drawing.Size(190, 27);
            this.Osa_RoomTypexml.TabIndex = 13;
            // 
            // Osa_OutDatexml
            // 
            this.Osa_OutDatexml.Location = new System.Drawing.Point(279, 93);
            this.Osa_OutDatexml.Name = "Osa_OutDatexml";
            this.Osa_OutDatexml.Size = new System.Drawing.Size(200, 27);
            this.Osa_OutDatexml.TabIndex = 12;
            // 
            // Osa_InDatexml
            // 
            this.Osa_InDatexml.Location = new System.Drawing.Point(279, 20);
            this.Osa_InDatexml.Name = "Osa_InDatexml";
            this.Osa_InDatexml.Size = new System.Drawing.Size(200, 27);
            this.Osa_InDatexml.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 44);
            this.label7.TabIndex = 10;
            this.label7.Text = "نوع الحجز";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 44);
            this.label6.TabIndex = 9;
            this.label6.Text = "تاريخ المغادرة";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(536, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 40);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاريخ الوصول ";
            // 
            // Osa_GuestsNoxml
            // 
            this.Osa_GuestsNoxml.Location = new System.Drawing.Point(847, 239);
            this.Osa_GuestsNoxml.Name = "Osa_GuestsNoxml";
            this.Osa_GuestsNoxml.Size = new System.Drawing.Size(91, 27);
            this.Osa_GuestsNoxml.TabIndex = 7;
            this.Osa_GuestsNoxml.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnupdatexml
            // 
            this.btnupdatexml.BackColor = System.Drawing.Color.RosyBrown;
            this.btnupdatexml.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatexml.Location = new System.Drawing.Point(672, 625);
            this.btnupdatexml.Name = "btnupdatexml";
            this.btnupdatexml.Size = new System.Drawing.Size(173, 54);
            this.btnupdatexml.TabIndex = 7;
            this.btnupdatexml.Text = "Update";
            this.btnupdatexml.UseVisualStyleBackColor = false;
            this.btnupdatexml.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnaddxml
            // 
            this.btnaddxml.BackColor = System.Drawing.Color.RosyBrown;
            this.btnaddxml.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddxml.Location = new System.Drawing.Point(981, 625);
            this.btnaddxml.Name = "btnaddxml";
            this.btnaddxml.Size = new System.Drawing.Size(173, 54);
            this.btnaddxml.TabIndex = 6;
            this.btnaddxml.Text = "Add";
            this.btnaddxml.UseVisualStyleBackColor = false;
            this.btnaddxml.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(965, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 44);
            this.label4.TabIndex = 6;
            this.label4.Text = "عدد الافراد";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(928, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 44);
            this.label3.TabIndex = 5;
            this.label3.Text = "البريد الالكتروني";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(959, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الحجز";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Osa_CustEmailxml
            // 
            this.Osa_CustEmailxml.Location = new System.Drawing.Point(740, 167);
            this.Osa_CustEmailxml.Multiline = true;
            this.Osa_CustEmailxml.Name = "Osa_CustEmailxml";
            this.Osa_CustEmailxml.Size = new System.Drawing.Size(194, 44);
            this.Osa_CustEmailxml.TabIndex = 2;
            // 
            // Osa_CustNamexml
            // 
            this.Osa_CustNamexml.Location = new System.Drawing.Point(740, 93);
            this.Osa_CustNamexml.Multiline = true;
            this.Osa_CustNamexml.Name = "Osa_CustNamexml";
            this.Osa_CustNamexml.Size = new System.Drawing.Size(194, 44);
            this.Osa_CustNamexml.TabIndex = 1;
            // 
            // BookingID
            // 
            this.BookingID.Location = new System.Drawing.Point(740, 20);
            this.BookingID.Multiline = true;
            this.BookingID.Name = "BookingID";
            this.BookingID.Size = new System.Drawing.Size(194, 44);
            this.BookingID.TabIndex = 0;
            // 
            // btndeletexml
            // 
            this.btndeletexml.BackColor = System.Drawing.Color.RosyBrown;
            this.btndeletexml.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeletexml.Location = new System.Drawing.Point(344, 625);
            this.btndeletexml.Name = "btndeletexml";
            this.btndeletexml.Size = new System.Drawing.Size(173, 54);
            this.btndeletexml.TabIndex = 8;
            this.btndeletexml.Text = "Delete";
            this.btndeletexml.UseVisualStyleBackColor = false;
            this.btndeletexml.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(959, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "إسم العميل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Osa_dataGridViewxml);
            this.groupBox1.Controls.Add(this.Osa_RoomTypexml);
            this.groupBox1.Controls.Add(this.Osa_OutDatexml);
            this.groupBox1.Controls.Add(this.Osa_InDatexml);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Osa_GuestsNoxml);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Osa_CustEmailxml);
            this.groupBox1.Controls.Add(this.Osa_CustNamexml);
            this.groupBox1.Controls.Add(this.BookingID);
            this.groupBox1.Location = new System.Drawing.Point(34, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1127, 533);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp2.Properties.Resources._2;
            this.pictureBox1.Location = new System.Drawing.Point(6, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.RosyBrown;
            this.label8.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(392, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(410, 50);
            this.label8.TabIndex = 16;
            this.label8.Text = "فنادق القمة العربية السياحي";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Booking_Xml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(1183, 701);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnclearxml);
            this.Controls.Add(this.btnupdatexml);
            this.Controls.Add(this.btnaddxml);
            this.Controls.Add(this.btndeletexml);
            this.Controls.Add(this.groupBox1);
            this.Name = "Booking_Xml";
            this.Text = "Booking_Xml";
            this.Load += new System.EventHandler(this.Booking_Xml_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Osa_dataGridViewxml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Osa_GuestsNoxml)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclearxml;
        private System.Windows.Forms.DataGridView Osa_dataGridViewxml;
        private System.Windows.Forms.ComboBox Osa_RoomTypexml;
        private System.Windows.Forms.DateTimePicker Osa_OutDatexml;
        private System.Windows.Forms.DateTimePicker Osa_InDatexml;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Osa_GuestsNoxml;
        private System.Windows.Forms.Button btnupdatexml;
        private System.Windows.Forms.Button btnaddxml;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Osa_CustEmailxml;
        private System.Windows.Forms.TextBox Osa_CustNamexml;
        private System.Windows.Forms.TextBox BookingID;
        private System.Windows.Forms.Button btndeletexml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}