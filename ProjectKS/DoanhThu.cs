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
    public partial class DoanhThu : Form
    {
        public DoanhThu()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True";
        private void DoanhThu_Load(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open(); // mo ket noi

            string strDisplay = "SELECT CONVERT(varchar, TimeBill, 103) AS 'Date', SUM(TotalFee) as'doanh thu' FROM Bill Group By CONVERT(varchar, TimeBill, 103)";
            SqlCommand cm = new SqlCommand(strDisplay, connect);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            da.Fill(table); // do du lieu vao kho
            dataGridView1.DataSource = table;
        }
    }
}
