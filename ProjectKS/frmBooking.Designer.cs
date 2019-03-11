namespace ProjectKS
{
    partial class frmBooking
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteRoomChoose = new System.Windows.Forms.Button();
            this.tbDeleteRoomChoose = new System.Windows.Forms.TextBox();
            this.tbEmployeePassport = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtExPaidDay = new System.Windows.Forms.DateTimePicker();
            this.dtBookingDay = new System.Windows.Forms.DateTimePicker();
            this.dgvRoomChoose = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbMaxPeople = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChooseRoom = new System.Windows.Forms.Button();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRoomList = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBooking = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbCustomerGender = new System.Windows.Forms.ComboBox();
            this.tbCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbCustomerEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCustomerPassport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomChoose)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Booking day";
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(338, 388);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(103, 20);
            this.tbEmployeeName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.btnDeleteRoomChoose);
            this.groupBox1.Controls.Add(this.tbDeleteRoomChoose);
            this.groupBox1.Controls.Add(this.tbEmployeePassport);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtExPaidDay);
            this.groupBox1.Controls.Add(this.dtBookingDay);
            this.groupBox1.Controls.Add(this.dgvRoomChoose);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.tbEmployeeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnBooking);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 556);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booking room";
            // 
            // btnDeleteRoomChoose
            // 
            this.btnDeleteRoomChoose.Location = new System.Drawing.Point(338, 274);
            this.btnDeleteRoomChoose.Name = "btnDeleteRoomChoose";
            this.btnDeleteRoomChoose.Size = new System.Drawing.Size(150, 23);
            this.btnDeleteRoomChoose.TabIndex = 22;
            this.btnDeleteRoomChoose.Text = "Delete Room Choose";
            this.btnDeleteRoomChoose.UseVisualStyleBackColor = true;
            this.btnDeleteRoomChoose.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbDeleteRoomChoose
            // 
            this.tbDeleteRoomChoose.Location = new System.Drawing.Point(338, 307);
            this.tbDeleteRoomChoose.Name = "tbDeleteRoomChoose";
            this.tbDeleteRoomChoose.Size = new System.Drawing.Size(72, 20);
            this.tbDeleteRoomChoose.TabIndex = 21;
            this.tbDeleteRoomChoose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDeleteRoomChoose_KeyPress);
            // 
            // tbEmployeePassport
            // 
            this.tbEmployeePassport.Location = new System.Drawing.Point(338, 488);
            this.tbEmployeePassport.Name = "tbEmployeePassport";
            this.tbEmployeePassport.Size = new System.Drawing.Size(103, 20);
            this.tbEmployeePassport.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(335, 441);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Employee Passport";
            // 
            // dtExPaidDay
            // 
            this.dtExPaidDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExPaidDay.Location = new System.Drawing.Point(465, 488);
            this.dtExPaidDay.Name = "dtExPaidDay";
            this.dtExPaidDay.Size = new System.Drawing.Size(92, 20);
            this.dtExPaidDay.TabIndex = 17;
            // 
            // dtBookingDay
            // 
            this.dtBookingDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBookingDay.Location = new System.Drawing.Point(465, 385);
            this.dtBookingDay.Name = "dtBookingDay";
            this.dtBookingDay.Size = new System.Drawing.Size(92, 20);
            this.dtBookingDay.TabIndex = 16;
            // 
            // dgvRoomChoose
            // 
            this.dgvRoomChoose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomChoose.Location = new System.Drawing.Point(18, 307);
            this.dgvRoomChoose.Name = "dgvRoomChoose";
            this.dgvRoomChoose.Size = new System.Drawing.Size(302, 201);
            this.dgvRoomChoose.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "List of Room Choosed";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(462, 441);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Expected paid day";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbMaxPeople);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnChooseRoom);
            this.groupBox2.Controls.Add(this.cbRoomType);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dgvRoomList);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 233);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choosing Room:";
            // 
            // cbMaxPeople
            // 
            this.cbMaxPeople.FormattingEnabled = true;
            this.cbMaxPeople.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbMaxPeople.Location = new System.Drawing.Point(118, 50);
            this.cbMaxPeople.Name = "cbMaxPeople";
            this.cbMaxPeople.Size = new System.Drawing.Size(77, 21);
            this.cbMaxPeople.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "People Number";
            // 
            // btnChooseRoom
            // 
            this.btnChooseRoom.Location = new System.Drawing.Point(220, 25);
            this.btnChooseRoom.Name = "btnChooseRoom";
            this.btnChooseRoom.Size = new System.Drawing.Size(85, 47);
            this.btnChooseRoom.TabIndex = 14;
            this.btnChooseRoom.Text = "Choose Room From List";
            this.btnChooseRoom.UseVisualStyleBackColor = true;
            this.btnChooseRoom.Click += new System.EventHandler(this.btnChooseRoom_Click);
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "VIP",
            "NOT VIP"});
            this.cbRoomType.Location = new System.Drawing.Point(8, 49);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(82, 21);
            this.cbRoomType.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Type of Room";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // dgvRoomList
            // 
            this.dgvRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoomList.Location = new System.Drawing.Point(3, 90);
            this.dgvRoomList.Name = "dgvRoomList";
            this.dgvRoomList.Size = new System.Drawing.Size(577, 134);
            this.dgvRoomList.TabIndex = 8;
            this.dgvRoomList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomList_CellContentClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(733, 461);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 47);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(809, 335);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(107, 47);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            this.btnBooking.Location = new System.Drawing.Point(636, 335);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(107, 47);
            this.btnBooking.TabIndex = 10;
            this.btnBooking.Text = "Booking";
            this.btnBooking.UseVisualStyleBackColor = true;
            this.btnBooking.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbCustomerGender);
            this.groupBox3.Controls.Add(this.tbCustomerPhoneNumber);
            this.groupBox3.Controls.Add(this.tbCustomerEmail);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tbCustomerName);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbCustomerPassport);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(607, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 275);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Customer Information";
            // 
            // cbCustomerGender
            // 
            this.cbCustomerGender.FormattingEnabled = true;
            this.cbCustomerGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbCustomerGender.Location = new System.Drawing.Point(18, 130);
            this.cbCustomerGender.Name = "cbCustomerGender";
            this.cbCustomerGender.Size = new System.Drawing.Size(100, 21);
            this.cbCustomerGender.TabIndex = 25;
            // 
            // tbCustomerPhoneNumber
            // 
            this.tbCustomerPhoneNumber.Location = new System.Drawing.Point(185, 57);
            this.tbCustomerPhoneNumber.Name = "tbCustomerPhoneNumber";
            this.tbCustomerPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerPhoneNumber.TabIndex = 24;
            this.tbCustomerPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerPhoneNumber_KeyPress);
            // 
            // tbCustomerEmail
            // 
            this.tbCustomerEmail.Location = new System.Drawing.Point(185, 130);
            this.tbCustomerEmail.Name = "tbCustomerEmail";
            this.tbCustomerEmail.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerEmail.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(182, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Gender";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Phone number";
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(18, 57);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerName.TabIndex = 17;
            this.tbCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Name";
            // 
            // tbCustomerPassport
            // 
            this.tbCustomerPassport.Location = new System.Drawing.Point(19, 211);
            this.tbCustomerPassport.Name = "tbCustomerPassport";
            this.tbCustomerPassport.Size = new System.Drawing.Size(100, 20);
            this.tbCustomerPassport.TabIndex = 15;
            this.tbCustomerPassport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCustomerPassport_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Passport";
            // 
            // frmBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBooking";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomChoose)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomList)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvRoomList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBooking;
        private System.Windows.Forms.TextBox tbCustomerPassport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChooseRoom;
        private System.Windows.Forms.ComboBox cbCustomerGender;
        private System.Windows.Forms.TextBox tbCustomerPhoneNumber;
        private System.Windows.Forms.TextBox tbCustomerEmail;
        private System.Windows.Forms.ComboBox cbMaxPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRoomChoose;
        private System.Windows.Forms.DateTimePicker dtExPaidDay;
        private System.Windows.Forms.DateTimePicker dtBookingDay;
        private System.Windows.Forms.TextBox tbEmployeePassport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDeleteRoomChoose;
        private System.Windows.Forms.Button btnDeleteRoomChoose;
    }
}