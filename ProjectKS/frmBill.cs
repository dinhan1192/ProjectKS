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
    public partial class frmBill : Form
    {
        DataTable table;
        int index;
        DataTable dt;
        string str = @"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True";
        public frmBill()
        {
            InitializeComponent();
        }

        private void frmBill_Load(object sender, EventArgs e)
        {
            Matutang();
            lockControl();
        }
       
        public void SearchBookingByID()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open(); // mo ket noi

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Booking where IdCustomer ='" + txtCustomer.Text + "' Order by CheckIn desc", connect);
            var dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbIdBooking.DisplayMember = "IdBooking";
            cbIdBooking.DataSource = dt;
        }

        private void Matutang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT isnull(max(cast(IdBill as int)),0)+1 From Bill", str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            txtIdBill.Text = dt.Rows[0][0].ToString();
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            SearchBookingByID();
        }


        public void lockControl() {
            IdCustomer.Enabled = false;
            FullName.Enabled = false;
            Passport.Enabled = false;
            Gender.Enabled = false;
            Phone.Enabled = false;
            Email.Enabled = false;
            roomFeeValue.Enabled = false;
            serviceFeeValue.Enabled = false;
            totalFeeValue.Enabled = false;
        }

        private void txtIdBill_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(str);
            SqlDataAdapter dat = new SqlDataAdapter("Select* from Customer Where IdCustomer='" + txtCustomer.Text + "'", connect);
            connect.Open();
            dt = new DataTable();
            dat.Fill(dt);
            IdCustomer.Text = dt.Rows[0][0].ToString();
            FullName.Text = dt.Rows[0][2].ToString();
            Passport.Text = dt.Rows[0][1].ToString();
            Phone.Text = dt.Rows[0][3].ToString();
            Gender.Text = dt.Rows[0][4].ToString();
            Email.Text= dt.Rows[0][5].ToString();
            connect.Close();
            connect.Open();
            SqlDataAdapter dap = new SqlDataAdapter("Select* from OrderService Where IdBooking='" + cbIdBooking.Text + "'", connect);
            dt = new DataTable();
            dap.Fill(dt);

            int d = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                d += Convert.ToInt32(dt.Rows[i][3]);
            }
            serviceFeeValue.Text = d.ToString();
            connect.Close();
            connect.Open();
            SqlDataAdapter das = new SqlDataAdapter("Select* from ListRoomBooking Where IdBooking='" + cbIdBooking.Text + "'", connect);
            dt = new DataTable();
            das.Fill(dt);
            int m = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                m += Convert.ToInt32(dt.Rows[i][3]);
            }
            roomFeeValue.Text = m.ToString();
            connect.Close();

            totalFeeValue.Text = (Convert.ToInt32(roomFeeValue.Text)+Convert.ToInt32(serviceFeeValue.Text)).ToString();

            connect.Open();
            dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("Select lr.RoomName,lr.TypeRoom,lb.RoomBookingFee from ListRoom as lr,ListRoomBooking as lb where lr.IdRoom=lb.IdRoom AND lb.IdBooking ='"+cbIdBooking.Text.ToString()+"'", connect);
                ad.Fill(dt);
                connect.Close();
                dataGridView1.DataSource = dt;

            connect.Open();
            dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("Select od.NameService, od.Amount,os.TimeUse,os.TotalFee from OrderService as os,OrderServiceDetail as od where os.IdOrder=od.IdOrder and IdBooking ='" + cbIdBooking.Text.ToString() + "'", connect);
            adap.Fill(dt);
            connect.Close();
            dataGridView2.DataSource = dt;

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            DateTime iDate = DateTime.Now;
            
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string sql = "Insert into Bill Values ('" + txtIdBill.Text.ToString() + "','" + IdCustomer.Text.ToString() + "','" + cbIdBooking.Text.ToString() + "','" + iDate.ToString("yyy/M/d HH:mm:ss") + "','" + roomFeeValue.Text.ToString() + "','" + serviceFeeValue.Text.ToString() + "','" + totalFeeValue.Text.ToString() + "')";
            SqlCommand command = connect.CreateCommand();
            command.CommandText = "If '" + iDate.ToString("yyy/M/d HH:mm:ss") + "'>=(Select top 1 TimeUse from OrderService where IdBooking='" + cbIdBooking.Text.ToString() + "'Order by TimeUse desc)And not exists(Select * from Bill where IdBooking='" + cbIdBooking.Text.ToString() + "') BEGIN " + sql + " END";
            command.ExecuteNonQuery();
            connect.Close();
            frmBill_Load(sender, e);
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            cbIdBooking.Text = null;
            IdCustomer.Text = null;
            txtCustomer.Text = null;
            FullName.Text = null;
            Passport.Text = null;
            Phone.Text = null;
            Gender.Text = null;
            Email.Text = null;
            roomFeeValue.Text = null;
            serviceFeeValue.Text = null;
            totalFeeValue.Text = null;
            connect.Open();
            SqlCommand cmd =new SqlCommand("Update ListRoom set Status='not booked' from ListRoom,ListRoomBooking where IdBooking='"+cbIdBooking.Text.ToString()+"'",connect);
            cmd.ExecuteNonQuery();
            connect.Close();
        }


    }
}
