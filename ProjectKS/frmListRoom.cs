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
    public partial class frmListRoom : Form
    {
        DataTable table;
        int index;
        public frmListRoom()
        {
            InitializeComponent();
        }

        private void frmListRoom_Load(object sender, EventArgs e)
        {
            LockControl();
            Connection();
            LoadComboBox();
        }

        private void Connection()
        {
            try
                {
                    // ham ket noi
                    SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True");
                    connect.Open(); // mo ket noi
                    string sql = "SELECT * FROM Room"; // lay hiet du lieu trong bang ListService
                    SqlCommand cmd = new SqlCommand(sql, connect);// thuc hien cau lenh truy van
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter con = new SqlDataAdapter(cmd); // van chuyen du lieu ve
                    table = new DataTable();
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
                    SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True");
                    connect.Close();
                }
        }

        private void clear()
        {
            nameRoomValue.Text = "";
            floorValue.Text = "";
            roomTypeValue.Text = "";

        }

        public void LockControl()
        {
            insertButton.Enabled = true;
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;
            //IdRoomValue.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            nameRoomValue.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            //idTypeRoom.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            roomTypeValue.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            floorValue.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();          
            statusValue.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            maxValue.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();


            insertButton.Enabled = false;
            updateButton.Enabled = true;
            deleteButton.Enabled = true;
            clearButton.Enabled = true;
        }

       
        private void clearButton_Click(object sender, EventArgs e)
        {
            nameRoomValue.Text = "";
            floorValue.Text = "";
            roomTypeValue.Text = "";
            statusValue.Text = "";
            maxValue.Text = "";
            updateButton.Enabled = false;
            deleteButton.Enabled = false;
            insertButton.Enabled = true;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (ValidateRoom())
            {
                SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True");
                connect.Open();
                string query = "INSERT INTO Room VALUES('" + nameRoomValue.Text + "','" + roomTypeValue.SelectedValue + "','" + roomTypeValue.Text + "','" + floorValue.Text + "','" + statusValue.Text + "','" + maxValue.Text + "')";
                SqlCommand cmdthem = new SqlCommand(query, connect);
                cmdthem.ExecuteNonQuery();

                Connection();
                MessageBox.Show("Them thanh cong");
                clear();
            }
            else
            {
                MessageBox.Show("Invalidate values");
            }
            
        }

        private bool ValidateRoom()
        {
            bool output = true;
            if (nameRoomValue.Text.Length == 0 || roomTypeValue.Text.Length == 0 || floorValue.Text.Length == 0 || statusValue.Text.Length == 0 || maxValue.Text.Length == 0)
            {
                output = false;
                
            }

            int roomName = 0;
            bool roomNameValid = int.TryParse(nameRoomValue.Text, out roomName);

            if (!roomNameValid)
            {
                output = false;
                
            }

            if (roomName < 0)
            {
                output = false;
                
            }

            int floor = 0;
            bool floorValid = int.TryParse(floorValue.Text, out floor);

            if(!floorValid)
            {
                output = false;
                MessageBox.Show("This form required to enter numbers");
            }
            if (floor < 0)
            {
                output = false;
                MessageBox.Show("Required number is greater than 0");
            }

            int maxPeople = 0;
            bool maxPeopleValid = int.TryParse(nameRoomValue.Text, out maxPeople);

            if (!maxPeopleValid)
            {
                output = false;
                MessageBox.Show("This form required to enter numbers");
            }

            if (maxPeople < 0)
            {
                output = false;
                MessageBox.Show("Required number is greater than 0");
            }
            return output;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            insertButton.Enabled = true;
            clearButton.Enabled = true;

            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True");
            connect.Open();
            string xoa = "DELETE Room WHERE RoomName = '" + nameRoomValue.Text + "'";
            SqlCommand cmdxoa = new SqlCommand(xoa, connect);
            cmdxoa.ExecuteNonQuery();

            Connection();
            MessageBox.Show("Xoa thanh cong");
            clear();

            deleteButton.Enabled = false;
            updateButton.Enabled = false;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            updateButton.Enabled = true;
            insertButton.Enabled = false;

            try
            {
                SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True");
                connect.Open();
                string sua = "UPDATE Room SET RoomName = '" + nameRoomValue.Text + "', TypeRoom = '" + roomTypeValue.Text + "', Floor = '" + floorValue.Text + "', Status = '" + statusValue.Text + "', MaxPeople = '" + maxValue.Text + "' WHERE IdRoom = '" + table.Rows[index][0] + "'";
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

        private void LoadComboBox()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-TB9VOSG;Initial Catalog=Hotel;Integrated Security=True");
            connect.Open(); // mo ket noi
            string sql = "SELECT * FROM TypeRoom"; // lay hiet du lieu trong bang ListService
            SqlCommand cmd = new SqlCommand(sql, connect);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            roomTypeValue.DisplayMember = "TypeNameRoom"; //hien thi list chon la NameService
            roomTypeValue.ValueMember = "IdTypeRoom";    //co the lay id nay bang cach cbNameService.SelectValue
            roomTypeValue.DataSource = dt;
            
        }
    }
}
