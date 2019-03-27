﻿using System;
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
    public partial class EmployeePosition : Form
    {
        public DataTable dt;
        public DataRow[] rt;
       public int index;
        public List<object> testL;
        
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True");
      
        public DataTable createTable()
        {
            dt = new DataTable();
            dt.Columns.Add("IdPosition");
            dt.Columns.Add("NamePosition");
            return dt;
        }

        public EmployeePosition()
        {
            InitializeComponent();
            testL = new List<object>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int m = 0;
            if (checkData())
            {
                       
                DataRow[] dl = dt.Select();
                try
                {
                    conn.Open();
                    string sql = "INSERT INTO PositionEmployees(NamePosition)VALUES('"+textBox1.Text.ToString()+"')";
                    SqlCommand da = new SqlCommand(sql, conn);
                    da.ExecuteNonQuery();
                    conn.Close();
                    EmployeePosition_Load(sender, e);
                    dataGridView1.DataSource = dt;
                    dataGridView1.RefreshEdit();
                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Error is" + exp.ToString());
                    conn.Close();
                }
                testL = new List<object>();
                for (int i = 0; i < dl.Count(); i++)
                {                 
                    for (int j = 0; j < testL.Count; j++)
                    {
                        if (dl[i].ItemArray[0].Equals(testL[j]))
                        {
                            m++;
                            break;
                        }
                    }
                    if (m == 0)
                    {
                        testL.Add(dt.Rows[i][0].ToString());
                    }
                    m = 0;
                }
                textBox1.Text = "";
            }
        }
        public bool checkData()
        {
            DataRow[] dl = dt.Select();
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter the name for position", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return false;
            }
            for(int i = 0; i < dl.Count(); i++)
            {
                if (dl[i].ItemArray[1].Equals(textBox1.Text))
                {
                    MessageBox.Show("Position has existed!!");
                    return false;
                }
            }
            return true;
        }


        private void EmployeePosition_Load(object sender, EventArgs e)
        {
               dt= createTable();
                SqlDataAdapter dap = new SqlDataAdapter("Select*from PositionEmployees", conn);
                conn.Open();
                dap.Fill(dt);
                conn.Close();
                dataGridView1.DataSource = dt;
                dataGridView1.RefreshEdit();
            testL = new List<object>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                testL.Add(dt.Rows[i][0]);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridView1.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridView1.DataSource;
            if (dt.Rows.Count > 0 || dt.Rows != null)
            {
                textBox1.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove Position", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    conn.Open();
                    string sql = "Delete from PositionEmployees Where IdPosition = '"+ dt.Rows[index].ItemArray[0] + "'";
                    SqlCommand da = new SqlCommand(sql, conn);
                    da.ExecuteNonQuery();
                    conn.Close();
                    EmployeePosition_Load(sender, e);

                }
                catch (System.Exception exp)
                {
                    MessageBox.Show("Error is" + exp.ToString());
                    conn.Close();
                }
            }          
        }

        private void button3_Click(object sender, EventArgs e)
        {    
            try
            {
                conn.Open();
                string sql = "Update PositionEmployees Set NamePosition='" + textBox1.Text.ToString() +
                    "'Where IdPosition='"+dt.Rows[index][0]+"'";
                SqlCommand da = new SqlCommand(sql, conn);
                da.ExecuteNonQuery();
                conn.Close();
                EmployeePosition_Load(sender, e);
                dataGridView1.DataSource = dt;
                dataGridView1.RefreshEdit();
            }
            catch (System.Exception exp)
            {
                MessageBox.Show("Error is" + exp.ToString());
                conn.Close();
            }
        }

    }
}
    

