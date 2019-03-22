using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProjectKS
{
    public partial class frmEmployee : Form
    {
        EmployeePosition form2;
        DataTable dt;
        int index;
        List<object> positionL;
        int l;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I7NUESG\SEKHARSQL;Initial Catalog=ProjectKS;Integrated Security=True");

        public frmEmployee()
        {
            InitializeComponent();
            form2 = new EmployeePosition();
            positionL = new List<object>();
        }
        public DataTable createTable()
        {
            DataTable vt = new DataTable();
            vt.Columns.Add("IdEmployee");
            vt.Columns.Add("NameEmployee");
            vt.Columns.Add("PassportEmployee");
            vt.Columns.Add("GenderEmployee");
            vt.Columns.Add("IdPositionEmployee");
            return vt;
        }
        
        private void frmEmployee_Load(object sender, EventArgs e)
        {
            dt = createTable();
            FillData();
            dataGridView1.DataSource = dt;
            dataGridView1.RefreshEdit();
            int m = 0;
            form2.createTable();
            FillDataform2();
            for (int i = 0; i < form2.dt.Rows.Count; i++)
            {
                for (int j = 0; j < form2.testL.Count; j++)
                {
                    if (form2.dt.Rows[i][0].Equals(form2.testL[j]))
                        m++;
                        break;
                }
                if (m == 0)
                {
                    form2.testL.Add(form2.dt.Rows[i][0].ToString());
                }
                m = 0;
            }
            IdPosition.DataSource = form2.testL;
        }
        public void FillData()
        {
            SqlDataAdapter dap = new SqlDataAdapter("Select*from Employees", conn);
            conn.Open();
            dap.Fill(dt);
            conn.Close();
        }
        public void FillDataform2()
        {
            SqlDataAdapter dat = new SqlDataAdapter("Select*from PositionEmployees", conn);
            conn.Open();
            dat.Fill(form2.dt);
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sql = "Update Employees Set NameEmployee='"+Name_text.Text.ToString()+"',PassportEmployee='" 
                    +Passport_text.Text.ToString()+"',GenderEmployee='"+ gender.SelectedItem.ToString() + "',IdPositionEmployee='"
                    + IdPosition.SelectedItem.ToString() + "'Where IdEmployee='"+dt.Rows[index][0]+"'";

                SqlCommand da = new SqlCommand(sql, conn);
                da.ExecuteNonQuery();
                conn.Close();
                frmEmployee_Load(sender, e);
                dataGridView1.DataSource = dt;
                dataGridView1.RefreshEdit();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error is" + exp.ToString());
                conn.Close();
            }
        }

        public bool checkData()
        {
            DataRow[] dl = dt.Select();
            if (string.IsNullOrEmpty(Name_text.Text))
            {
                MessageBox.Show("Employee Name is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Name_text.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(Passport_text.Text))
            {
                MessageBox.Show("Passport is invalid", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Passport_text.Focus();
                return false;
            }
            for(int i = 0; i < dl.Count(); i++)
            {
                if (dl[i].ItemArray[0].Equals(dl.Count()) || dl[i].ItemArray[2].Equals(Passport_text.Text))
                {
                    MessageBox.Show("ID or Passport have existed!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (string.IsNullOrEmpty(gender.Text))
            {
                MessageBox.Show("Choose gender", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gender.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(IdPosition.Text))
            {
                MessageBox.Show("Choose IdPosition", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdPosition.Focus();
                return false;
            }
            if (Passport_text.Text.ToString().Length != 11)
            {
                MessageBox.Show("Passport must be 11 numbers");
                Passport_text.Focus();
                return false;
            }
            return true;
        }

        private void click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            form2.ShowDialog();
            IdPosition.DataSource = form2.dt;
            IdPosition.DataSource = form2.testL;
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                try
                {
                    conn.Open();
                        string sql = "INSERT INTO Employees(NameEmployee,PassportEmployee,GenderEmployee,IdPositionEmployee)VALUES('"+Name_text.Text.ToString() +
                            "','" + Passport_text.Text.ToString() + "','" + gender.SelectedItem.ToString() + "','" + IdPosition.SelectedItem.ToString() + "')";
                        SqlCommand da = new SqlCommand(sql, conn);
                        da.ExecuteNonQuery();
                        conn.Close();
                        frmEmployee_Load(sender, e);
                        dataGridView1.DataSource = dt;
                        dataGridView1.RefreshEdit();        
                }
                catch(System.Exception)
                {
                    conn.Close();
                }
                Name_text.Text = "";
                Passport_text.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to remove Employee", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = "Delete from Employees Where IdEmployee =" + dt.Rows[index].ItemArray[0];
                    SqlCommand da = new SqlCommand(sql, conn);
                    da.ExecuteNonQuery();
                    conn.Close();
                    frmEmployee_Load(sender, e);
                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Error is" + exp.ToString());
                    conn.Close();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            DataTable vt = (DataTable)dataGridView1.DataSource;

            if (vt.Rows.Count > 0 || vt.Rows != null)
            {
                Name_text.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                Passport_text.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
                gender.SelectedItem = dataGridView1.Rows[index].Cells[3].Value.ToString();
                IdPosition.SelectedItem = dataGridView1.Rows[index].Cells[4].Value.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable st = createTable();
            DataRow[] rt = dt.Select();
            for (int i = 0; i < rt.Count(); i++)
            {
                if (rt[i].ItemArray[2].Equals(textBox1.Text.ToString()))
                {
                    st.Rows.Add(rt[i].ItemArray[0], rt[i].ItemArray[1], rt[i].ItemArray[2], rt[i].ItemArray[3], rt[i].ItemArray[4]);
                }
            }
            dataGridView1.DataSource = st;
            dataGridView1.RefreshEdit();
            l = 0;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (l == 0)
            {
                dataGridView1.DataSource = dt;
                dataGridView1.RefreshEdit();
            }
        }

        private void Passport_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch!=8 && ch!=46)
            {
                e.Handled = true;
            }
        }

        private void Name_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46&&ch!=32)
            {
                e.Handled = true;
            }
        }
    }
}
