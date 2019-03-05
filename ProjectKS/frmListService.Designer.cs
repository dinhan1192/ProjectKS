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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnXoaService = new System.Windows.Forms.Button();
            this.btnSuaService = new System.Windows.Forms.Button();
            this.btnThemService = new System.Windows.Forms.Button();
            this.priceValue = new System.Windows.Forms.TextBox();
            this.nameServiceValue = new System.Windows.Forms.TextBox();
            this.idServiceValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnXoaService);
            this.groupBox1.Controls.Add(this.btnSuaService);
            this.groupBox1.Controls.Add(this.btnThemService);
            this.groupBox1.Controls.Add(this.priceValue);
            this.groupBox1.Controls.Add(this.nameServiceValue);
            this.groupBox1.Controls.Add(this.idServiceValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(37, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 342);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Information";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(93, 220);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnXoaService
            // 
            this.btnXoaService.Location = new System.Drawing.Point(10, 221);
            this.btnXoaService.Name = "btnXoaService";
            this.btnXoaService.Size = new System.Drawing.Size(75, 23);
            this.btnXoaService.TabIndex = 10;
            this.btnXoaService.Text = "Delete";
            this.btnXoaService.UseVisualStyleBackColor = true;
            // 
            // btnSuaService
            // 
            this.btnSuaService.Location = new System.Drawing.Point(93, 183);
            this.btnSuaService.Name = "btnSuaService";
            this.btnSuaService.Size = new System.Drawing.Size(75, 23);
            this.btnSuaService.TabIndex = 9;
            this.btnSuaService.Text = "Update";
            this.btnSuaService.UseVisualStyleBackColor = true;
            // 
            // btnThemService
            // 
            this.btnThemService.Location = new System.Drawing.Point(12, 183);
            this.btnThemService.Name = "btnThemService";
            this.btnThemService.Size = new System.Drawing.Size(75, 23);
            this.btnThemService.TabIndex = 8;
            this.btnThemService.Text = "Insert";
            this.btnThemService.UseVisualStyleBackColor = true;
            this.btnThemService.Click += new System.EventHandler(this.btnThemService_Click);
            // 
            // priceValue
            // 
            this.priceValue.Location = new System.Drawing.Point(86, 101);
            this.priceValue.Name = "priceValue";
            this.priceValue.Size = new System.Drawing.Size(100, 20);
            this.priceValue.TabIndex = 7;
            // 
            // nameServiceValue
            // 
            this.nameServiceValue.Location = new System.Drawing.Point(86, 67);
            this.nameServiceValue.Name = "nameServiceValue";
            this.nameServiceValue.Size = new System.Drawing.Size(100, 20);
            this.nameServiceValue.TabIndex = 5;
            // 
            // idServiceValue
            // 
            this.idServiceValue.Location = new System.Drawing.Point(86, 32);
            this.idServiceValue.Name = "idServiceValue";
            this.idServiceValue.Size = new System.Drawing.Size(100, 20);
            this.idServiceValue.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "PriceService";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "NameService";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "IdService";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(245, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 339);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(369, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(235, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Service";
            // 
            // frmListService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmListService";
            this.Text = "frmListService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnXoaService;
        private System.Windows.Forms.Button btnSuaService;
        private System.Windows.Forms.Button btnThemService;
        private System.Windows.Forms.TextBox priceValue;
        private System.Windows.Forms.TextBox nameServiceValue;
        private System.Windows.Forms.TextBox idServiceValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
    }
}