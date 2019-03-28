namespace ProjectKS
{
    partial class frmEmployee
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.click = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PassportEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPositionEmployee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPosition = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Passport_text = new System.Windows.Forms.TextBox();
            this.Name_text = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(476, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 48;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(382, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 47;
            this.button4.Text = "Search";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(49, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Input passport";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 204);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 45;
            // 
            // click
            // 
            this.click.AutoSize = true;
            this.click.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.click.LinkColor = System.Drawing.Color.Red;
            this.click.Location = new System.Drawing.Point(636, 96);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(126, 13);
            this.click.TabIndex = 44;
            this.click.TabStop = true;
            this.click.Text = "Click here to add position";
            this.click.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.click_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEmployee,
            this.NameEmployee,
            this.PassportEmployee,
            this.GenderEmployee,
            this.IdPositionEmployee});
            this.dataGridView1.Location = new System.Drawing.Point(44, 246);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 182);
            this.dataGridView1.TabIndex = 43;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // IdEmployee
            // 
            this.IdEmployee.DataPropertyName = "IdEmployee";
            this.IdEmployee.HeaderText = "IDEmployee";
            this.IdEmployee.Name = "IdEmployee";
            this.IdEmployee.Visible = false;
            // 
            // NameEmployee
            // 
            this.NameEmployee.DataPropertyName = "NameEmployee";
            this.NameEmployee.HeaderText = "EmployeeName";
            this.NameEmployee.Name = "NameEmployee";
            // 
            // PassportEmployee
            // 
            this.PassportEmployee.DataPropertyName = "PassportEmployee";
            this.PassportEmployee.HeaderText = "EmployeePassport";
            this.PassportEmployee.Name = "PassportEmployee";
            // 
            // GenderEmployee
            // 
            this.GenderEmployee.DataPropertyName = "GenderEmployee";
            this.GenderEmployee.HeaderText = "Gender";
            this.GenderEmployee.Name = "GenderEmployee";
            // 
            // IdPositionEmployee
            // 
            this.IdPositionEmployee.DataPropertyName = "IdPositionEmployee";
            this.IdPositionEmployee.HeaderText = "IdPositionEmployee";
            this.IdPositionEmployee.Name = "IdPositionEmployee";
            // 
            // IdPosition
            // 
            this.IdPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.IdPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.IdPosition.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.IdPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdPosition.FormattingEnabled = true;
            this.IdPosition.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IdPosition.Location = new System.Drawing.Point(499, 92);
            this.IdPosition.Name = "IdPosition";
            this.IdPosition.Size = new System.Drawing.Size(121, 21);
            this.IdPosition.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(234, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 41;
            this.button3.Text = "Change";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(341, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 40;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 39;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passport_text
            // 
            this.Passport_text.Location = new System.Drawing.Point(129, 89);
            this.Passport_text.Name = "Passport_text";
            this.Passport_text.Size = new System.Drawing.Size(252, 20);
            this.Passport_text.TabIndex = 38;
            this.Passport_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Passport_text_KeyPress);
            // 
            // Name_text
            // 
            this.Name_text.Location = new System.Drawing.Point(129, 43);
            this.Name_text.Name = "Name_text";
            this.Name_text.Size = new System.Drawing.Size(252, 20);
            this.Name_text.TabIndex = 37;
            this.Name_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_text_KeyPress);
            // 
            // gender
            // 
            this.gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(499, 45);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(121, 21);
            this.gender.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(404, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "IdPosition";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(404, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(53, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Passport";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(53, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.click);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.IdPosition);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Passport_text);
            this.Controls.Add(this.Name_text);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel click;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox IdPosition;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Passport_text;
        private System.Windows.Forms.TextBox Name_text;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassportEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPositionEmployee;
    }
}