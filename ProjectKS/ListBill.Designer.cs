namespace ProjectKS
{
    partial class ListBill
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
            this.txtPassport = new System.Windows.Forms.TextBox();
            this.btnView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TimeBill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCustomer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBooking1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdBooking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalRoomFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalServiceFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassport
            // 
            this.txtPassport.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPassport.Location = new System.Drawing.Point(490, 76);
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.Size = new System.Drawing.Size(116, 20);
            this.txtPassport.TabIndex = 15;
            this.txtPassport.Text = "Passport";
            this.txtPassport.Enter += new System.EventHandler(this.txtPassport_Enter);
            this.txtPassport.Leave += new System.EventHandler(this.txtPassport_Leave);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(22, 77);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 23);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "View All";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(628, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "click vào hóa đơn để xem thông tin chi tiết";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(762, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " ";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(622, 76);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimeBill,
            this.IdCustomer1,
            this.IdBooking1,
            this.FullNameCustomer,
            this.IdBooking,
            this.TotalRoomFee,
            this.TotalServiceFee,
            this.TotalFee});
            this.dataGridView1.Location = new System.Drawing.Point(22, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(815, 248);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // TimeBill
            // 
            this.TimeBill.DataPropertyName = "TimeBill";
            this.TimeBill.FillWeight = 88.83249F;
            this.TimeBill.HeaderText = "TimeBill";
            this.TimeBill.Name = "TimeBill";
            // 
            // IdCustomer1
            // 
            this.IdCustomer1.DataPropertyName = "IdBill";
            this.IdCustomer1.FillWeight = 101.8613F;
            this.IdCustomer1.HeaderText = "IdBill";
            this.IdCustomer1.Name = "IdCustomer1";
            // 
            // IdBooking1
            // 
            this.IdBooking1.DataPropertyName = "IdCustomer";
            this.IdBooking1.FillWeight = 101.8613F;
            this.IdBooking1.HeaderText = "IdCustomer";
            this.IdBooking1.Name = "IdBooking1";
            // 
            // FullNameCustomer
            // 
            this.FullNameCustomer.DataPropertyName = "FullNameCustomer";
            this.FullNameCustomer.HeaderText = "FullNameCustomer";
            this.FullNameCustomer.Name = "FullNameCustomer";
            // 
            // IdBooking
            // 
            this.IdBooking.DataPropertyName = "IdBooking";
            this.IdBooking.FillWeight = 101.8613F;
            this.IdBooking.HeaderText = "IdBooking";
            this.IdBooking.Name = "IdBooking";
            // 
            // TotalRoomFee
            // 
            this.TotalRoomFee.DataPropertyName = "TotalRoomFee";
            this.TotalRoomFee.FillWeight = 101.8613F;
            this.TotalRoomFee.HeaderText = "TotalRoomFee";
            this.TotalRoomFee.Name = "TotalRoomFee";
            // 
            // TotalServiceFee
            // 
            this.TotalServiceFee.DataPropertyName = "TotalServiceFee";
            this.TotalServiceFee.FillWeight = 101.8613F;
            this.TotalServiceFee.HeaderText = "TotalServiceFee";
            this.TotalServiceFee.Name = "TotalServiceFee";
            // 
            // TotalFee
            // 
            this.TotalFee.DataPropertyName = "TotalFee";
            this.TotalFee.FillWeight = 101.8613F;
            this.TotalFee.HeaderText = "TotalFee";
            this.TotalFee.Name = "TotalFee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "List Bill";
            // 
            // ListBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 450);
            this.Controls.Add(this.txtPassport);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "ListBill";
            this.Text = "ListBill";
            this.Load += new System.EventHandler(this.ListBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassport;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCustomer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBooking1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalRoomFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalServiceFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalFee;
        private System.Windows.Forms.Label label1;
    }
}