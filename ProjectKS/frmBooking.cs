using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjectKS
{
    public partial class frmBooking : Form
    {
        SqlConnection conn;
        SqlCommand commandBooking, commandCustomer, commandRoom, commandRoomChoose, commandListRoomBooking;
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

        void deletedatafromListRoomChoose()
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
            tbEmployeePassport.Text = "";
            dtBookingDay.Text = "";
            dtExPaidDay.Text = "";
        }
        public frmBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validate())
                {
                    string AddCustomer;
                    AddCustomer = "INSERT INTO Customer(PassportCustomer, FullNameCustomer, PhoneNumberCustomer, GenderCustomer, EmailCustomer) VALUES('" + tbCustomerPassport.Text.ToString() + "', '" + tbCustomerName.Text.ToString() + "', '" + tbCustomerPhoneNumber.Text.ToString() + "', '" + cbCustomerGender.Text.ToString() + "', '" + tbCustomerEmail.Text.ToString() + "')"; ;
                    //tbDeleteRoomChoose.Text = "IF NOT EXISTS (SELECT * FROM Customer WHERE PassportCustomer = '" + tbCustomerPassport.Text.ToString() + "') BEGIN " + AddCustomer + " END";
                    //return;
                    commandCustomer = conn.CreateCommand();
                    commandCustomer.CommandText = "IF NOT EXISTS (SELECT * FROM Customer WHERE PassportCustomer = '"+ tbCustomerPassport.Text.ToString() +"') BEGIN " + AddCustomer + " END";
                    commandCustomer.ExecuteNonQuery();
                    
                    CultureInfo provider = CultureInfo.InvariantCulture;
                    DateTime bookingDay = DateTime.ParseExact(dtBookingDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);
                    DateTime exPaidDay = DateTime.ParseExact(dtExPaidDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);
                    string BookingDay = bookingDay.ToString("yyyy-MM-dd");
                    string ExPaidDay = exPaidDay.ToString("yyyy-MM-dd");

                    commandBooking = conn.CreateCommand();
                    commandBooking.CommandText = @"INSERT INTO Booking VALUES" + "((SELECT IdCustomer FROM Customer WHERE PassportCustomer = '" + tbCustomerPassport.Text.ToString() + "'), (SELECT IdEmployee FROM Employees WHERE NameEmployee = '" + tbEmployeeName.Text.ToString() + "' AND PassportEmployee = '" + tbEmployeePassport.Text.ToString() + "'), '" + BookingDay + "', '" + ExPaidDay + "')";
                    commandBooking.ExecuteNonQuery();
                    //tbEmployeeName.Text = dtBookingDay.Text;
                    //return;

                    //tbDeleteRoomChoose.Text = @"INSERT INTO Booking VALUES" + "((SELECT IdCustomer FROM Customer WHERE FullNameCustomer = '" + tbCustomerName.Text.ToString() + "' AND PassportCustomer = '" + tbCustomerPassport.Text.ToString() + "'), (SELECT IdEmployee FROM Employees WHERE NameEmployee = '" + tbEmployeeName.Text.ToString() + "' AND PassportEmployee = '" + tbEmployeePassport.Text.ToString() + "'), '" + BookingDay + "', '" + ExPaidDay + "')";

                    foreach (DataGridViewRow row in dgvRoomChoose.Rows)
                    {
                        string valueRoomName = Convert.ToString(row.Cells[0].Value);
                        commandRoom = conn.CreateCommand();
                        commandRoom.CommandText = "UPDATE ListRoom SET Status = 'booked' WHERE RoomName = @RoomName";
                        commandRoom.Parameters.Add("@RoomName", SqlDbType.NVarChar).Value = valueRoomName;
                        commandRoom.ExecuteNonQuery();
                        //tbEmployeeName.Text = @"INSERT INTO ListRoomBOOKING VALUES" + "((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text + "') AND CheckIn = '" + bookingDay + "'), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + row.Cells[0].Value + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                        // tbDeleteRoomChoose.Text = "INSERT INTO ListRoomBOOKING VALUES ((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text.ToString() + "')), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + row.Cells[0].Value.ToString() + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                        //return;
                    }

                    for (int i = 0; i < (dgvRoomChoose.Rows.Count - 1); i++)
                    {
                        string valueRoomName = Convert.ToString(dgvRoomChoose.Rows[i].Cells[0].Value);
                        //tbEmployeeName.Text = @"INSERT INTO ListRoomBOOKING VALUES" + "((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text + "') AND CheckIn = '" + bookingDay + "'), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + row.Cells[0].Value + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                        //tbDeleteRoomChoose.Text = @"INSERT INTO ListRoomBOOKING " + "VALUES ((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text + "')), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + valueRoomName1 + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                        //return;
                        commandListRoomBooking = conn.CreateCommand();
                        commandListRoomBooking.CommandText = @"INSERT INTO ListRoomBOOKING(IdBooking, IdRoom, RoomBookingFee) VALUES" + "((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text.ToString() + "') AND CheckIn = '"+BookingDay+"'), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + valueRoomName + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                        commandListRoomBooking.ExecuteNonQuery();
                    }


                    reset();
                    deletedatafromListRoomChoose();
                    loaddata();
                }
            } 
            catch (Exception ex)
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

            commandRoomChoose.CommandText = "IF NOT EXISTS(SELECT * FROM ListRoomChoose WHERE RoomName = '"+ dgvRoomList.Rows[i].Cells[2].Value.ToString() + "') BEGIN INSERT INTO ListRoomChoose  VALUES ('" + dgvRoomList.Rows[i].Cells[2].Value.ToString() + "', (SELECT PriceRoom FROM TypeRoom WHERE TypeNameRoom = '"+ dgvRoomList.Rows[i].Cells[3].Value.ToString() + "')) END ";
            commandRoomChoose.ExecuteNonQuery();
            loaddataChoose();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            commandRoomChoose = conn.CreateCommand();
            commandRoomChoose.CommandText = "DELETE FROM ListRoomChoose WHERE RoomName = '" + tbDeleteRoomChoose.Text + "'";
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
            deletedatafromListRoomChoose();
        }
    }
}
