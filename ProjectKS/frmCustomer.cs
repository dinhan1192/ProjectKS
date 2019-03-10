using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectKS
{
    public partial class frmCustomer : Form
    {
        SqlConnection conn;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-I7NUESG\SEKHARSQL;Initial Catalog=ProjectKS;Integrated Security=True";
        // có dấu \ thì phải thêm @
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loaddata()
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Customer";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCustomerList.DataSource = table;
        }

        void resetTB()
        {
            tbCustomerId.Text = "";
            tbCustomerName.Text = "";
            tbCustomerPassport.Text = "";
            cbCustomerGender.Text = "Male";
            tbCustomerPhoneNumber.Text = "";
            tbCustomerEmail.Text = "";
        }

        public frmCustomer()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (tbCustomerName.Text.Length == 0 || tbCustomerId.Text.Length == 0 || tbCustomerPassport.Text.Length == 0 || tbCustomerPhoneNumber.Text.Length == 0)
            {
                output = false;
            }   

            int idCustomer = 0;
            bool idCustomerValid = int.TryParse(tbCustomerId.Text, out idCustomer);
            if (!idCustomerValid)
            {
                output = false;
            }
            if (idCustomer <= 0)
            {
                output = false;
            }

            int passport = 0;
            bool passportValid = int.TryParse(tbCustomerPassport.Text , out passport);
            if (!passportValid)
            {
                output = false;
            }

            int phoneNumber = 0;
            bool phoneNumberValid = int.TryParse(tbCustomerPhoneNumber.Text, out phoneNumber);
            if (!phoneNumberValid)
            {
                output = false;
            }
            
            return output;
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                command = conn.CreateCommand();
                command.CommandText = "UPDATE Customer SET PassportCustomer = '"+tbCustomerPassport.Text+"', FullNameCustomer = '"+tbCustomerName.Text+"', PhoneNumberCustomer = '"+tbCustomerPhoneNumber.Text+"', GenderCustomer = '"+cbCustomerGender.Text+"', EmailCustomer = '"+tbCustomerEmail.Text+"' where IdCustomer = '"+tbCustomerId.Text+"'";
                command.ExecuteNonQuery();
                loaddata();
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
            
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void dgvCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbCustomerId.ReadOnly = true;
            int i;
            i = dgvCustomerList.CurrentRow.Index;
            tbCustomerId.Text = dgvCustomerList.Rows[i].Cells[0].Value.ToString();
            tbCustomerPassport.Text = dgvCustomerList.Rows[i].Cells[1].Value.ToString();
            tbCustomerName.Text = dgvCustomerList.Rows[i].Cells[2].Value.ToString();
            tbCustomerPhoneNumber.Text = dgvCustomerList.Rows[i].Cells[3].Value.ToString();
            cbCustomerGender.Text = dgvCustomerList.Rows[i].Cells[4].Value.ToString();
            tbCustomerEmail.Text = dgvCustomerList.Rows[i].Cells[5].Value.ToString();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            string str = "DELETE FROM Customer WHERE IdCustomer = '"+tbCustomerId.Text+"'";
            string str1 = "DELETE FROM Booking WHERE IdCustomer = '"+tbCustomerId.Text+"'";
            string str2 = "DELETE FROM ListRoomBooking WHERE IdBooking = (SELECT IdBooking FROM Booking WHERE IdCustomer = '" + tbCustomerId.Text + "')";
            string str3 = "DELETE FROM Bill WHERE IdBooking = (SELECT IdBooking FROM Booking WHERE IdCustomer = '" + tbCustomerId.Text + "')";
            string str4 = "DELETE FROM OrderService WHERE IdBooking = (SELECT IdBooking FROM Booking WHERE IdCustomer = '" + tbCustomerId.Text + "')";
            
            command.CommandText = "BEGIN " + str + str1 + str2 + str3 + str4 + " END";
            command.ExecuteNonQuery();
            loaddata();
            resetTB();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetTB();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "Begin DELETE FROM Customer DELETE FROM Booking END";
            command.ExecuteNonQuery();

            loaddata();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM Customer WHERE FullNameCustomer = '"+tbFindName.Text+"' ";
            command.ExecuteNonQuery();
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvCustomerList.DataSource = table;
        }
    }
}
