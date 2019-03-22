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
        string str = @"Data Source=DESKTOP-I7NUESG\SEKHARSQL;Initial Catalog = ProjectKS; Integrated Security = True";
        public frmBill()
        {
            InitializeComponent();
        }

     

        private void frmBill_Load(object sender, EventArgs e)
        {
            Matutang();
        }
        public void SearchBookingByID()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open(); // mo ket noi

            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Booking where IdCustomer ='" + txtCustomer.Text + "'  Order by CheckIn desc", connect);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
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


        private void timkiem() {

        }
    }
}
