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
    public partial class ListBill : Form
    {
        
        public ListBill()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True";
//hien thi all cac bill
        private void Bill()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string bill = "Select Bill.IdBill, Bill.IdCustomer,Customer.FullNameCustomer, Bill.IdBooking, Bill.TimeBill, Bill.TotalRoomFee,Bill.TotalServiceFee,Bill.TotalFee From Customer, Bill  Where Customer.IdCustomer = Bill.IdCustomer Order By Bill.TimeBill desc";
            SqlCommand cm = new SqlCommand(bill, connect);
            SqlDataAdapter da = new SqlDataAdapter(cm);

            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
//tim kiem hoa don theo ngay
        private void SearchBillByDate()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            SqlCommand cm = new SqlCommand("SELECT *FROM Bill WHERE Day(TimeBill)='" + dateTimePicker1.Value.Day + "' and MONTH(TimeBill)='" + dateTimePicker1.Value.Month + "' AND Year(TimeBill) ='" + dateTimePicker1.Value.Year + "'", connect);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
 //tim kiem hoa don theo CMT or NameCustomer
        private void SearchBillByPassport()
        {

            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            if (txtPassport.Text == "Passport")
            {
                return;
            }
            else
            {
                string search = "Select Bill.IdBill,Bill.IdCustomer, Bill.IdBooking, Bill.TimeBill, Bill.TotalRoomFee,Bill.TotalServiceFee,Bill.TotalFee  From Customer, Bill  Where Customer.IdCustomer = Bill.IdCustomer AND PassportCustomer ='" + txtPassport.Text + "'";
                SqlCommand cm = new SqlCommand(search, connect);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            connect.Close();

        }

        private void ListBill_Load(object sender, EventArgs e)
        {
            Bill();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            Bill();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBillByDate();
            SearchBillByPassport();
        }

        private void txtPassport_Enter(object sender, EventArgs e)
        {
            if (txtPassport.Text == "Passport")
            {
                txtPassport.Text = "";
                txtPassport.ForeColor = Color.Black;
            }
        }

        private void txtPassport_Leave(object sender, EventArgs e)
        {
            if (txtPassport.Text == "")
            {
                txtPassport.Text = "Passport";
                txtPassport.ForeColor = Color.Silver;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Display_Service_Room_Bill displaybill_Detail = new Display_Service_Room_Bill();
            displaybill_Detail.lbIdBooking.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            displaybill_Detail.ShowDialog();
        }
    }
}
