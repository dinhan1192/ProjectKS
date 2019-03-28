using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        SqlCommand command, commandUpdate, commandBooking, commandCustomer, commandRoom,
            commandRoomChoose, commandListRoomBooking, commandValidateDay, commandValidateCustomer, commandValidateEmail;
        string str = @"Data Source=DESKTOP-I7NUESG\SEKHARSQL;Initial Catalog=ProjectKS;Integrated Security=True;" + " MultipleActiveResultSets=True;";
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

        void loadComboBoxEmployee()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Employees Where IdPositionEmployee = (SELECT IdPosition From PositionEmployees Where NamePosition = 'Trading')";
            var dr = command.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            /* tbEmployeeName.DisplayMember = "NameEmployee";
             tbEmployeeName.ValueMember = "IdEmployee";
             tbEmployeeName.DataSource = dt;*/

            tbEmployeeName.DisplayMember = "NameEmployee";
            tbEmployeeName.ValueMember = "IdEmployee";
            tbEmployeeName.DataSource = dt;
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
            tbTotalExCost.Text = "";
        }
        public frmBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm() && ValidateRoom() && ValidateEmail() && ValidatePassport() && ValidateDayandCustomer() && ValidateBetweenDays())
            {
                command = conn.CreateCommand();
                command.CommandText = "SELECT * FROM Customer";
                SqlDataReader readerCustomer = command.ExecuteReader();
                while (readerCustomer.Read())
                {
                    if (tbCustomerPassport.Text == ((string)readerCustomer["PassportCustomer"]).ToString())
                    {
                        MessageBox.Show("Customer is already in Customer List");
                        break;
                    }
                }

                commandValidateCustomer = conn.CreateCommand();
                commandValidateCustomer.CommandText = "SELECT PassportCustomer FROM Customer";
                SqlDataReader cr = commandValidateCustomer.ExecuteReader();
                while (cr.Read())
                {
                    if (tbCustomerPassport.Text == ((string)cr["PassportCustomer"]).ToString())
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult dialogResult = MessageBox.Show("Do you want to update Customer Information ?", "Customer", buttons);
                        if (dialogResult == DialogResult.Yes)
                        {
                            commandUpdate = conn.CreateCommand();
                            commandUpdate.CommandText = "UPDATE Customer SET FullNameCustomer = '" + tbCustomerName.Text + "', PhoneNumberCustomer = '" + tbCustomerPhoneNumber.Text + "', GenderCustomer = '" + cbCustomerGender.Text + "', EmailCustomer = '" + tbCustomerEmail.Text + "' where PassportCustomer = '" + tbCustomerPassport.Text + "'";
                            commandUpdate.ExecuteNonQuery();
                        } else if (dialogResult == DialogResult.No)
                        {
                            break;
                        } 
                    }
                }
                string AddCustomer;
                AddCustomer = "INSERT INTO Customer(PassportCustomer, FullNameCustomer, PhoneNumberCustomer, GenderCustomer, EmailCustomer) VALUES('" + tbCustomerPassport.Text.ToString() + "', '" + tbCustomerName.Text.ToString() + "', '" + tbCustomerPhoneNumber.Text.ToString() + "', '" + cbCustomerGender.Text.ToString() + "', '" + tbCustomerEmail.Text.ToString() + "')"; ;
                //tbDeleteRoomChoose.Text = "IF NOT EXISTS (SELECT * FROM Customer WHERE PassportCustomer = '" + tbCustomerPassport.Text.ToString() + "') BEGIN " + AddCustomer + " END";
                //return;
                commandCustomer = conn.CreateCommand();
                commandCustomer.CommandText = "IF NOT EXISTS (SELECT * FROM Customer WHERE PassportCustomer = '" + tbCustomerPassport.Text.ToString() + "') BEGIN " + AddCustomer + " END";
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
                    TimeSpan diff = exPaidDay.Subtract(bookingDay);
                    int valuediff = Convert.ToInt32(diff.TotalDays);
                    string valueRoomName = Convert.ToString(dgvRoomChoose.Rows[i].Cells[0].Value);
                    //tbEmployeeName.Text = @"INSERT INTO ListRoomBOOKING VALUES" + "((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text + "') AND CheckIn = '" + bookingDay + "'), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + row.Cells[0].Value + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                    //tbDeleteRoomChoose.Text = @"INSERT INTO ListRoomBOOKING " + "VALUES ((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text + "')), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + valueRoomName1 + "'), (SELECT SUM(PriceRoom) FROM ListRoomChoose))";
                    //return;
                    commandListRoomBooking = conn.CreateCommand();
                    commandListRoomBooking.CommandText = @"INSERT INTO ListRoomBOOKING(IdBooking, IdRoom, RoomBookingFee) VALUES" + "((SELECT IdBooking FROM Booking WHERE IdCustomer = (SELECT IdCustomer FROM Customer WHERE PassportCustomer ='" + tbCustomerPassport.Text.ToString() + "') AND CheckIn = '" + BookingDay + "'), (SELECT IdRoom FROM ListRoom WHERE RoomName = '" + valueRoomName + "'), ((SELECT PriceRoom FROM ListRoomChoose WHERE RoomName = '" + valueRoomName + "') * '" + valuediff + "'))";
                    commandListRoomBooking.ExecuteNonQuery();
                }


                reset();
                deletedatafromListRoomChoose();
                loaddata();

            }
        }

        private bool ValidateEmail()
        {
            bool output = true;
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,6}$");
            // phai co a-z nua, Neu ko A-Z thi chi la viet hoa moi dc
            if (tbCustomerEmail.Text.Length > 0)
            {
                if (!rEmail.IsMatch(tbCustomerEmail.Text))
                {
                    output = false;
                    MessageBox.Show("invalid email address !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            commandValidateEmail = conn.CreateCommand();
            commandValidateEmail.CommandText = "SELECT EmailCustomer FROM Customer Where PassportCustomer <> '"+ tbCustomerPassport.Text +"'";
            commandValidateCustomer = conn.CreateCommand();
            commandValidateCustomer.CommandText = "SELECT PassportCustomer FROM Customer";
            SqlDataReader readerEmail = commandValidateEmail.ExecuteReader();
            SqlDataReader readerPassport = commandValidateCustomer.ExecuteReader();

            string customerSearch = tbCustomerPassport.Text;
            string emailSearch = tbCustomerEmail.Text;

            while (readerPassport.Read())
            {
                if (customerSearch == ((string)readerPassport["PassportCustomer"]).ToString())
                {
                    while(readerEmail.Read())
                    {
                        if (emailSearch == ((string)readerEmail["EmailCustomer"]).ToString())
                        {
                            output = false;
                            MessageBox.Show("Wrong Email !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                } else
                {
                    while(readerEmail.Read())
                    {
                        if (emailSearch == ((string)readerEmail["EmailCustomer"]).ToString())
                        {
                            output = false;
                            MessageBox.Show("Wrong Email !!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                }
            }

            return output;
        }

        private bool ValidateRoom()
        {
            bool output = true;

            if ((dgvRoomChoose.Rows.Count - 1) == 0)
            {
                MessageBox.Show("Room is not enterred yet !!!");
                output = false;
            }

            return output;
        }

        private bool ValidateBetweenDays()
        {
            bool output = true;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime bookingDay = DateTime.ParseExact(dtBookingDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);
            DateTime exPaidDay = DateTime.ParseExact(dtExPaidDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);

            int compareValue = DateTime.Compare(exPaidDay, bookingDay);

            if (compareValue <= 0)
            {
                MessageBox.Show("Wrong Date !!!");
                output = false;
            }

            return output;
        }

        private bool ValidateDayandCustomer()
        {
            bool output = true;
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime bookingDay = DateTime.ParseExact(dtBookingDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);
            string daySearch = bookingDay.ToString("yyyy-MM-dd");
            string customerSearch = tbCustomerPassport.Text;

            commandValidateDay = conn.CreateCommand();
            commandValidateDay.CommandText = "SELECT CheckIn FROM Booking";
            commandValidateCustomer = conn.CreateCommand();
            commandValidateCustomer.CommandText = "SELECT PassportCustomer FROM Customer";
            SqlDataReader dr = commandValidateDay.ExecuteReader();
            SqlDataReader cr = commandValidateCustomer.ExecuteReader();
            while (dr.Read())
            {
                if (daySearch == ((DateTime)dr["CheckIn"]).ToString("yyyy-MM-dd"))
                {
                    while (cr.Read())
                    {
                        if (customerSearch == ((string)cr["PassportCustomer"]).ToString())
                        {
                            //daySearch == ((DateTime)dr["CheckIn"]).ToString("yyyy-MM-dd")
                            output = false;
                            MessageBox.Show("Datetime or Customer is mistaken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        }
                    }
                    break;
                }
            }

            return output;

        }

        private bool ValidateForm()
        {
            bool output = true;
            if (tbCustomerName.Text.Length == 0 || tbCustomerPassport.Text.Length == 0 || tbCustomerPhoneNumber.Text.Length == 0 || tbCustomerEmail.Text.Length == 0 || cbCustomerGender.Text.Length == 0)
            {
                output = false;
                MessageBox.Show("This form can not have empty values");
            }


            return output;
        }

        private bool ValidatePassport()
        {
            bool output = true;
            if (tbCustomerPassport.Text.Length != 8 && tbCustomerPassport.Text.Length != 12)
            {
                output = false;
                MessageBox.Show("Passport must have 8 or 12 digit numbers !!");
            }
            return output;
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

        private void dgvRoomList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvRoomList.CurrentRow.Index;
            commandRoomChoose = conn.CreateCommand();
            int valueMaxPeople = Convert.ToInt32(dgvRoomList.Rows[i].Cells[6].Value);

            commandRoomChoose.CommandText = "IF NOT EXISTS(SELECT * FROM ListRoomChoose WHERE RoomName = '" + dgvRoomList.Rows[i].Cells[2].Value.ToString() + "') BEGIN INSERT INTO ListRoomChoose  VALUES ('" + dgvRoomList.Rows[i].Cells[2].Value.ToString() + "', (SELECT PriceRoom FROM TypeRoom WHERE TypeNameRoom = '" + dgvRoomList.Rows[i].Cells[3].Value.ToString() + "') * '" + valueMaxPeople + "') END ";
            commandRoomChoose.ExecuteNonQuery();
            loaddataChoose();
        }

        private void tbCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsLetter(ch) && ch != 8 && ch != 46 && ch != 32)
            {
                e.Handled = true;
                // Handled: go duoc
            }
        }

        private void tbCustomerPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "SELECT PassportEmployee FROM Employees Where IdEmployee = '" + tbEmployeeName.SelectedValue + "'";
            // SelectedValue là cho Id, tức là Id của EmployeeName
            command = conn.CreateCommand();
            command.CommandText = sql;
            SqlDataReader reader = command.ExecuteReader();


            if (reader.HasRows)
            {
                reader.Read();
                tbEmployeePassport.Text = reader.GetString(0).ToString(); // kieu du lieu cua Price trong db la float nhg trong day k dung dc GetFloat ma pai dung GetDouble
            }
        }

        private void tbCustomerPassport_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }



        private void btnTotalExCost_Click(object sender, EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            DateTime bookingDay = DateTime.ParseExact(dtBookingDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);
            DateTime exPaidDay = DateTime.ParseExact(dtExPaidDay.Text, new string[] { "dd/MM/yyyy" }, provider, DateTimeStyles.None);
            string BookingDay = bookingDay.ToString("yyyy-MM-dd");
            string ExPaidDay = exPaidDay.ToString("yyyy-MM-dd");

            System.TimeSpan diff = exPaidDay.Subtract(bookingDay);

            int sum = 0;

            foreach (DataGridViewRow row in dgvRoomChoose.Rows)
            {
                int RoomCost = Convert.ToInt32(row.Cells[1].Value);
                sum += RoomCost;
            }

            int valuediff = 0;
            valuediff = Convert.ToInt32(diff.TotalDays);

            int TotalExCost = 0;
            TotalExCost = valuediff * sum;

            tbTotalExCost.Text = TotalExCost.ToString();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            conn.Close();
            Close();
        }


        private void tbDeleteRoomChoose_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            commandRoomChoose = conn.CreateCommand();
            commandRoomChoose.CommandText = "DELETE FROM ListRoomChoose WHERE RoomName = '" + tbDeleteRoomChoose.Text + "'";
            commandRoomChoose.ExecuteNonQuery();
            loaddataChoose();
        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            commandRoom = conn.CreateCommand();
            if (cbMaxPeople.Text.Length > 0 && cbRoomType.Text.Length == 0)
            {
                commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked' AND MaxPeople = '" + cbMaxPeople.Text + "'";
            }
            else if (cbMaxPeople.Text.Length == 0 && cbRoomType.Text.Length > 0)
            {
                commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked' AND TypeRoom = '" + cbRoomType.Text + "'";
            }

            else if (cbMaxPeople.Text.Length > 0 && cbRoomType.Text.Length > 0)
            {
                commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked' AND MaxPeople = '" + cbMaxPeople.Text + "' AND TypeRoom = '" + cbRoomType.Text + "'";
            }
            else if (cbMaxPeople.Text.Length == 0 && cbRoomType.Text.Length == 0)
            {
                commandRoom.CommandText = "SELECT * FROM ListRoom WHERE Status = 'not booked'";
                MessageBox.Show("Please enter information to search");
            }


            adapter.SelectCommand = commandRoom;
            tableRoomList.Clear();
            adapter.Fill(tableRoomList);
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
            loaddataChoose();
            deletedatafromListRoomChoose();
            loadComboBoxEmployee();

            tbEmployeePassport.Enabled = false;
        }
    }
}
