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
    public partial class Display_Service_Room_Bill : Form
    {
        public Display_Service_Room_Bill()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True";
        private void Display_Service_Room_Bill_Load(object sender, EventArgs e)
        {
            displayService();
            displayRoomFee();
        }
        private void displayService()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string str1 = "Select OrderService.IdOrder,OrderService.TimeUse,OrderServiceDetail.NameService,OrderServiceDetail.Amount,OrderServiceDetail.UnitPrice,OrderServiceDetail.Total" +
                " FROM OrderService" +
                " JOIN Booking On OrderService.IdBooking = Booking.IdBooking" +
                " JOIN OrderServiceDetail On OrderService.IdOrder = OrderServiceDetail.IdOrder" +
                " Where OrderService.IdBooking ='" + lbIdBooking.Text + "'";
            SqlCommand cm = new SqlCommand(str1, connect);
            SqlDataAdapter da = new SqlDataAdapter(cm);

            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void displayRoomFee()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string str1 = "SELECT RoomName,ListRoomBooking.RoomBookingFee" +
                " FROM Booking ,ListRoomBooking,ListRoom" +
                " Where Booking.IdBooking = ListRoomBooking.IdBooking AND ListRoomBooking.IdRoom=ListRoom.IdRoom And Booking.IdBooking = '" + lbIdBooking.Text + "'";
            SqlCommand cm = new SqlCommand(str1, connect);
            SqlDataAdapter da = new SqlDataAdapter(cm);

            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView2.DataSource = table;
        }

    }
}
