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
    public partial class frmBooking : Form
    {
        SqlConnection conn;
        SqlCommand commandCustomer, commandRoom, commandRoomChoose;
        string str = @"Data Source=DESKTOP-I7NUESG\SEKHARSQL;Initial Catalog=ProjectKS;Integrated Security=True";
        // co / thi phai co @
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableRoomList = new DataTable();
        DataTable tableRoomChoose = new DataTable();

        void loaddata()
        {
            commandRoom = conn.CreateCommand();
            //commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked' AND MaxPeople = '"+tbRoomType.Text+"'";
            commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked'";
            adapter.SelectCommand = commandRoom;
            tableRoomList.Clear();
            adapter.Fill(tableRoomList);
            dgvRoomList.DataSource = tableRoomList;
        }

        void loaddataChoose()
        {
            commandRoomChoose = conn.CreateCommand();
            commandRoomChoose.CommandText = "SELECT * FROM ListRoomChoose";
            adapter.SelectCommand = commandRoomChoose;
            tableRoomChoose.Clear();
            adapter.Fill(tableRoomChoose);
            dgvRoomChoose.DataSource = tableRoomChoose;
        }

        void deletedata()
        {
            commandRoomChoose = conn.CreateCommand();
            commandRoomChoose.CommandText = "DELETE FROM ListRoomChoose";
            tableRoomChoose.Clear();
            commandRoomChoose.ExecuteNonQuery();
        }

        void reset()
        {
            cbRoomType.Text = "";
            cbMaxPeople.Text = "";
            tbCustomerName.Text = "";
            tbCustomerPassport.Text = "";
            tbCustomerPhoneNumber.Text = "";
            tbCustomerEmail.Text = "";
            cbCustomerGender.Text = "Male";
            tbEmployeeName.Text = "";
            tbBookingDay.Text = "";
            tbExPaidDay.Text = "";
        }
        public frmBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                commandCustomer = conn.CreateCommand();
                commandCustomer.CommandText = "INSERT INTO Customer(PassportCustomer, FullNameCustomer, PhoneNumberCustomer, GenderCustomer, EmailCustomer) VALUES('"+tbCustomerPassport.Text+"', '"+tbCustomerName.Text+"', '"+tbCustomerPhoneNumber.Text+"', '"+cbCustomerGender.Text+"', '"+tbCustomerEmail.Text+"')";
                commandCustomer.ExecuteNonQuery();

                foreach(DataGridViewRow row in dgvRoomChoose.Rows)
                {
                    commandRoom = conn.CreateCommand();
                    commandRoom.CommandText = "UPDATE ListRoom SET Status = 'booked' WHERE RoomName = '" + row.Cells[0].Value + "'";
                    commandRoom.ExecuteNonQuery();
                }
                reset();
                deletedata();
                loaddata();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
        }

        /*private bool ValidateForm()
        {
            bool output = true;
            if (tbCustomerName.Text.Length == 0 || idValue.Text.Length == 0 || tbCustomerPassport.Text.Length == 0 || phoneValue.Text.Length == 0)
            {
                output = false;
            }

            int idCustomer = 0;
            bool idCustomerValid = int.TryParse(idValue.Text, out idCustomer);
            if (!idCustomerValid)
            {
                output = false;
            }
            if (idCustomer <= 0)
            {
                output = false;
            }

            int passport = 0;
            bool passportValid = int.TryParse(tbCustomerPassport.Text, out passport);
            if (!passportValid)
            {
                output = false;
            }

            int phoneNumber = 0;
            bool phoneNumberValid = int.TryParse(phoneValue.Text, out phoneNumber);
            if (!phoneNumberValid)
            {
                output = false;
            }

            return output;
        } */



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void emailValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvRoomList.CurrentRow.Index;
            commandRoomChoose = conn.CreateCommand();

            //commandRoomChoose.CommandText = "UPDATE ListRoomChoose SET IdRoomChoose = '"+ dgvRoomList.Rows[i].Cells[0].Value.ToString() + "', IdTypeRoom = '"+ dgvRoomList.Rows[i].Cells[1].Value.ToString() + "', RoomName = '"+ dgvRoomList.Rows[i].Cells[2].Value.ToString()+"', TypeRoom = '"+ dgvRoomList.Rows[i].Cells[3].Value.ToString() + "', Floor = '"+ dgvRoomList.Rows[i].Cells[4].Value.ToString() + "', Status = '"+ dgvRoomList.Rows[i].Cells[5].Value.ToString() + "', MaxPeople = '"+ dgvRoomList.Rows[i].Cells[6].Value.ToString() + "'";
            commandRoomChoose.CommandText = "INSERT INTO ListRoomChoose  VALUES ('" + dgvRoomList.Rows[i].Cells[2].Value.ToString() + "') ";
            commandRoomChoose.ExecuteNonQuery();
            loaddataChoose();
            
        }

        private void tbEmployeeName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            commandRoom = conn.CreateCommand();
            commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked' AND MaxPeople = '"+cbMaxPeople.Text+"' AND TypeRoom = '"+cbRoomType.Text+"'";
            //commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked'";
            adapter.SelectCommand = commandRoom;
            tableRoomList.Clear();
            adapter.Fill(tableRoomList);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
            loaddataChoose();
            deletedata();
        }
    }
}
