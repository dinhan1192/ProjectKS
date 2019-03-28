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
    public partial class frmOrderService : Form
    {
        DataTable table;
        int index;
        string str = @"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True";
        public frmOrderService()
        {
            InitializeComponent();
        }

        private void frmOrderService_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            txtUnitPrice.Enabled = false;
            txtTotal.Enabled = false;
            btnDelete.Enabled = false;
            Matutang();
        }
//tim kiem IdBooking qua IdCustomer
        public void SearchBookingByID()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open(); 
            SqlCommand cmd = new SqlCommand("SELECT TOP 1 * FROM Booking where IdCustomer ='" + txtIdCustomer.Text + "'  Order by CheckIn desc", connect);
            var dr = cmd.ExecuteReader();
            var dt = new DataTable();
            dt.Load(dr);
            dr.Dispose();
            cbIdBooking.DisplayMember = "IdBooking";
            cbIdBooking.DataSource = dt;
        }
        private void txtIdCustomer_TextChanged(object sender, EventArgs e)
        {
            SearchBookingByID();
        }       
        public void Matutang()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT isnull(max(cast(IdOrder as int)),0)+1 From OrderService ", str);
            DataTable dt = new DataTable();
            da.Fill(dt);
            lbIdOrder.Text = dt.Rows[0][0].ToString();
        }

 // load danh sach service len combobox   
        public void LoadComboBox()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open(); // mo ket noi
            SqlCommand cmd2 = new SqlCommand("SELECT* FROM ListService", connect);
            var dr2 = cmd2.ExecuteReader();
            var dt2 = new DataTable();
            dt2.Load(dr2);
            dr2.Dispose();
            cbNameService.DisplayMember = "NameService"; //hien thi list chon la NameService
            cbNameService.ValueMember = "IdService";    //co the lay id nay bang cach cbNameService.SelectValue
            cbNameService.DataSource = dt2;

            connect.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtTotal.Text)||Int32.Parse(txtTotal.Text)==0)
            {
                MessageBox.Show("Vui long nhap hang hoa vao hoa don");
                return;
            }
            else
            {
                DateTime iDate = DateTime.Now;
                SqlConnection connect = new SqlConnection(str);
                connect.Open();
                string them = "INSERT INTO OrderService VALUES('" + lbIdOrder.Text + "','" + cbIdBooking.Text + "','" + iDate.ToString("yyy/M/d HH:mm:ss") + "','" + txtTotal.Text + "')";
                SqlCommand cmdthem = new SqlCommand(them, connect);
                cmdthem.ExecuteNonQuery();

                MessageBox.Show("Lưu hóa đơn thành công");

                for (int i = 0; i < listView.Items.Count; i++)
                {
                    string dbINSERT = "INSERT INTO OrderServiceDetail VALUES('" + lbIdOrder.Text + "','" + listView.Items[i].SubItems[0].Text + "','" + listView.Items[i].SubItems[1].Text + "','" + listView.Items[i].SubItems[2].Text + "','" + listView.Items[i].SubItems[3].Text + "','" + listView.Items[i].SubItems[4].Text + "')";
                    SqlCommand cmddbINSERT = new SqlCommand(dbINSERT, connect);
                    cmddbINSERT.ExecuteNonQuery();
                }
                Clear();
            }
        }
        void Clear()
        {
            listView.Items.Clear();
            lbIdOrder.Text = "";
            Matutang();
            txtIdCustomer.Clear();
            cbNameService.Text = "";
            txtAmount.Clear();
            txtUnitPrice.Clear();
        }
//auto load priceService
        private void cbNameService_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string sql = "SELECT *FROM ListService Where IdService='" + cbNameService.SelectedValue + "'";
            SqlCommand cn = new SqlCommand(sql, connect);
            SqlDataReader reader = cn.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                txtUnitPrice.Text = reader.GetDouble(2).ToString(); // kieu du lieu cua Price trong db la float nhg trong day k dung dc GetFloat ma pai dung GetDouble
            }
        }
//luu du lieu vao listview
        float total = 0;
        private void ADD()
        {
            if (string.IsNullOrEmpty(cbIdBooking.Text))
            {
                MessageBox.Show("Ma khach hang chua nhap hoac khong ton tai. Vui long kiem tra lai");
            }
            else if (string.IsNullOrEmpty(lbIdOrder.Text) || string.IsNullOrEmpty(cbNameService.Text) || string.IsNullOrEmpty(txtAmount.Text) || string.IsNullOrEmpty(txtUnitPrice.Text))
            {
                MessageBox.Show("Vui long nhap thong tin hang hoa");
                return;
            }
            else
            {
                btnDelete.Enabled = true;
                ListViewItem item = new ListViewItem(cbNameService.SelectedValue.ToString());
                item.SubItems.Add(cbNameService.Text);
                item.SubItems.Add(txtAmount.Text);
                item.SubItems.Add(txtUnitPrice.Text);
                item.SubItems.Add(thanhtien(txtUnitPrice.Text, txtAmount.Text).ToString());
                total = total + float.Parse(thanhtien(txtUnitPrice.Text, txtAmount.Text).ToString());
                listView.Items.Add(item);

                txtAmount.Clear();
                txtUnitPrice.Clear();
            }
            txtTotal.Text = total.ToString();
        }
//kiem tra xem IdBooking con hieu luc khong
        private bool CheckExistBookinginBill()
        {
            SqlConnection connect = new SqlConnection(str);
            connect.Open();
            string sql = "SELECT *FROM Bill";
            SqlCommand cn = new SqlCommand(sql, connect);
            SqlDataReader reader = cn.ExecuteReader();
            while (reader.Read())
            {
                if (cbIdBooking.Text == ((int)reader["IdBooking"]).ToString())
                {
                    MessageBox.Show("IdBooking da het hieu luc", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
            }
            return false;
        }
//Add Service len bang ao listview
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckExistBookinginBill())
            {
                Clear();
                return;
            }
            else
            {
                ADD();
            }   
        }
        private float thanhtien(string amount, string unitprice)
        {
            float thanhtien = Int32.Parse(amount) * float.Parse(unitprice);
            return thanhtien;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
                if (listView.Items.Count > 0)
                {
                    int hieu = int.Parse(txtTotal.Text) - int.Parse(listView.SelectedItems[0].SubItems[4].Text);
                    txtTotal.Text = hieu.ToString();
                    listView.Items.Remove(listView.SelectedItems[0]);
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) //!32 la SPACEBAR , 8 la  BACKSPACE, 46 la The DEL key.
            {
                e.Handled = true;
            }
        } 
        
    }
}
