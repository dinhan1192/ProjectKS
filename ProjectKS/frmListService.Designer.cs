namespace ProjectKS
{
    partial class frmListService
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoaService = new System.Windows.Forms.Button();
            this.btnSuaService = new System.Windows.Forms.Button();
            this.btnThemService = new System.Windows.Forms.Button();
            this.txtPriceService = new System.Windows.Forms.TextBox();
            this.txtNameService = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectQuanlykhachsanDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectQuanlykhachsanDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnXoaService);
            this.groupBox1.Controls.Add(this.btnSuaService);
            this.groupBox1.Controls.Add(this.btnThemService);
            this.groupBox1.Controls.Add(this.txtPriceService);
            this.groupBox1.Controls.Add(this.txtNameService);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(159, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong tin dich vu";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(384, 33);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnXoaService
            // 
            this.btnXoaService.Location = new System.Drawing.Point(384, 73);
            this.btnXoaService.Name = "btnXoaService";
            this.btnXoaService.Size = new System.Drawing.Size(75, 23);
            this.btnXoaService.TabIndex = 10;
            this.btnXoaService.Text = "Xoa";
            this.btnXoaService.UseVisualStyleBackColor = true;
            this.btnXoaService.Click += new System.EventHandler(this.btnXoaService_Click);
            // 
            // btnSuaService
            // 
            this.btnSuaService.Location = new System.Drawing.Point(303, 73);
            this.btnSuaService.Name = "btnSuaService";
            this.btnSuaService.Size = new System.Drawing.Size(75, 23);
            this.btnSuaService.TabIndex = 9;
            this.btnSuaService.Text = "Sua";
            this.btnSuaService.UseVisualStyleBackColor = true;
            this.btnSuaService.Click += new System.EventHandler(this.btnSuaService_Click);
            // 
            // btnThemService
            // 
            this.btnThemService.Location = new System.Drawing.Point(303, 33);
            this.btnThemService.Name = "btnThemService";
            this.btnThemService.Size = new System.Drawing.Size(75, 23);
            this.btnThemService.TabIndex = 8;
            this.btnThemService.Text = "Them";
            this.btnThemService.UseVisualStyleBackColor = true;
            this.btnThemService.Click += new System.EventHandler(this.btnThemService_Click);
            // 
            // txtPriceService
            // 
            this.txtPriceService.Location = new System.Drawing.Point(149, 73);
            this.txtPriceService.Name = "txtPriceService";
            this.txtPriceService.Size = new System.Drawing.Size(100, 20);
            this.txtPriceService.TabIndex = 7;
            this.txtPriceService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceService_KeyPress);
            // 
            // txtNameService
            // 
            this.txtNameService.Location = new System.Drawing.Point(149, 33);
            this.txtNameService.Name = "txtNameService";
            this.txtNameService.Size = new System.Drawing.Size(100, 20);
            this.txtNameService.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "PriceService";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NameService";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(159, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(531, 205);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach dich vu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdService,
            this.NameService,
            this.PriceService});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 186);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // IdService
            // 
            this.IdService.DataPropertyName = "IdService";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.IdService.DefaultCellStyle = dataGridViewCellStyle22;
            this.IdService.HeaderText = "IdService";
            this.IdService.Name = "IdService";
            // 
            // NameService
            // 
            this.NameService.DataPropertyName = "NameService";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NameService.DefaultCellStyle = dataGridViewCellStyle23;
            this.NameService.HeaderText = "NameService";
            this.NameService.Name = "NameService";
            // 
            // PriceService
            // 
            this.PriceService.DataPropertyName = "PriceService";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PriceService.DefaultCellStyle = dataGridViewCellStyle24;
            this.PriceService.HeaderText = "PriceService";
            this.PriceService.Name = "PriceService";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(330, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sach dich vu";
            // 
            // frmListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListService";
            this.Text = "frmListService";
            this.Load += new System.EventHandler(this.frmListService_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectQuanlykhachsanDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoaService;
        private System.Windows.Forms.Button btnSuaService;
        private System.Windows.Forms.Button btnThemService;
        private System.Windows.Forms.TextBox txtPriceService;
        private System.Windows.Forms.TextBox txtNameService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource projectQuanlykhachsanDataSetBindingSource;

        private System.Windows.Forms.DataGridViewTextBoxColumn IdService;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameService;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceService;
    }
}