using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKS
{
    public partial class TypeRoom : Form
    {
        string str = @"Data Source=DESKTOP-I7NUESG\SEKHARSQL;Initial Catalog=ProjectKS;Integrated Security=True";
        public TypeRoom()
        {
            InitializeComponent();
        }

        private void TypeRoom_Load(object sender, EventArgs e)
        {
            LockControl();
            Connection();
        }

        private void Connection()
        {
            {
                try
                {
                    // ham ket noi
                    SqlConnection connect = new SqlConnection(str);
                    connect.Open(); // mo ket noi
                    string sql = "SELECT * FROM TypeRoom"; // lay hiet du lieu trong bang ListService
                    SqlCommand cmd = new SqlCommand(sql, connect);// thuc hien cau lenh truy van
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter con = new SqlDataAdapter(cmd); // van chuyen du lieu ve
                    DataTable table = new DataTable(); // tao 1 kho lu lieu ao luu tru du lieu
                    con.Fill(table); // do du lieu vao kho
                    dataGridView1.DataSource = table; // do du lieu trong kho ra datagridView

                    //Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True
                }
                catch
                {
                    MessageBox.Show("Ket noi db bị lỗi!!Vui long thu lai");
                }
                finally
                {
                    SqlConnection connect = new SqlConnection(str);
                    connect.Close();
                }
            }
        }

        private void clear()
        {
            idTypeValue.Text = "";
            typeValue.Text = "";
            priceValue.Text = "";
        }

        public void LockControl()
        {
            insertButton.Enabled = true;
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
        }


       

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            idTypeValue.Text = "";
            typeValue.Text = "";
            priceValue.Text = "";
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            insertButton.Enabled = true;
        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string query = "INSERT INTO TypeRoom VALUES('" + idTypeValue.Text + "','" + typeValue.Text + "','" + priceValue.Text + "')";
            SqlCommand cmdthem = new SqlCommand(query, connect);
            cmdthem.ExecuteNonQuery();

            Connection();
            MessageBox.Show("Them thanh cong");
            clear();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = true;
            insertButton.Enabled = false;

            try
            {
                SqlConnection connect = new SqlConnection(str);
                connect.Open();
                string sua = "UPDATE TypeRoom SET IdTypeRoom='" + idTypeValue.Text + "', TypeNameRoom='" + typeValue.Text + "',PriceRoom='" + priceValue.Text + "' WHERE IdTypeRoom='" + idTypeValue.Text + "'";
                SqlCommand cmdsua = new SqlCommand(sua, connect);
                cmdsua.ExecuteNonQuery();

                Connection();
                MessageBox.Show("Sua thanh cong");
                clear();
            }
            catch
            {
                MessageBox.Show("Loi, khong sua duoc");
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            insertButton.Enabled = true;
            clearButton.Enabled = true;

            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string xoa = "DELETE TypeRoom WHERE IdTypeRoom='" + idTypeValue.Text + "'";
            SqlCommand cmdxoa = new SqlCommand(xoa, connect);
            cmdxoa.ExecuteNonQuery();

            Connection();
            MessageBox.Show("Xoa thanh cong");
            clear();

            deleteButton.Enabled = false;
            updateButton.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            idTypeValue.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            typeValue.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            priceValue.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();


            insertButton.Enabled = false;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            clearButton.Enabled = true;
        }
    }
}
