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
    public partial class frmListService : Form
    {
        DataTable table;
        int index;
        public frmListService()
        {
            InitializeComponent();
        }
        string str = @"Data Source=DESKTOP-CL7BVQ5\SEKHARSQL;Initial Catalog=Project_Quanlykhachsan;Integrated Security=True";

        private void Ketnoi()
        {
            try
            {
                SqlConnection connect = new SqlConnection(str);
                connect.Open(); // mo ket noi
                SqlDataAdapter con = new SqlDataAdapter("SELECT * FROM ListService", connect);

                table = new DataTable();
                con.Fill(table); // do du lieu vao kho
                dataGridView1.DataSource = table; // do du lieu trong kho ra datagridView
                dataGridView1.RefreshEdit();
            }
            catch
            {
                MessageBox.Show("Ket noi db bị lỗi!!Vui long thu lai");
            }
            finally
            {
                SqlConnection connect = new SqlConnection(str);
                connect.Close();
            }
        }

        private void frmListService_Load(object sender, EventArgs e)
        {
            btnThemService.Enabled = true;
            btnSuaService.Enabled = false;
            btnXoaService.Enabled = false;
            Ketnoi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index;

            txtNameService.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txtPriceService.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            btnThemService.Enabled = false;
            btnSuaService.Enabled = true;
            btnXoaService.Enabled = true;
            btnClear.Enabled = false;
        }
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(txtNameService.Text))
            {
                MessageBox.Show("Vui long nhap NameService", "THong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNameService.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPriceService.Text))
            {
                MessageBox.Show("Vui long nhap PriceService", "THong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPriceService.Focus();
                return false;
            }
            return true;
        }
        private void clear()
        {
            txtNameService.Clear();
            txtPriceService.Clear();
        }

        private void btnThemService_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                SqlConnection connect = new SqlConnection(str);
                connect.Open();
                string them = "INSERT INTO ListService VALUES('" + txtNameService.Text + "','" + txtPriceService.Text + "')";
                SqlCommand cmdthem = new SqlCommand(them, connect);
                cmdthem.ExecuteNonQuery();

                Ketnoi();
                MessageBox.Show("Them thanh cong");
                clear();
            }
            else
            {
                MessageBox.Show("Co loi xay ra", "THong bao loi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSuaService_Click(object sender, EventArgs e)
        {
            btnThemService.Enabled = true;
            btnClear.Enabled = true;
            btnSuaService.Enabled = false;
            btnXoaService.Enabled = false;

            try
            {
                SqlConnection connect = new SqlConnection(str);
                connect.Open();
                int currentIndex = dataGridView1.CurrentRow.Index;
                int userIdService = Convert.ToInt32(dataGridView1.Rows[currentIndex].Cells[0].Value.ToString());
                string sua = "UPDATE ListService SET  NameService='" + txtNameService.Text + "', PriceService='" + txtPriceService.Text + "' WHERE IdService = '" + userIdService + "' "; //table.Rows[index][0]
                SqlCommand cmdsua = new SqlCommand(sua, connect);
                cmdsua.ExecuteNonQuery();
                Ketnoi();
                MessageBox.Show("Sua thanh cong");
                clear();
            }
            catch
            {
                MessageBox.Show("Sua that bai ");
                clear();
            }
        }

        private void btnXoaService_Click(object sender, EventArgs e)
        {
            btnThemService.Enabled = true;
            btnClear.Enabled = true;
            btnSuaService.Enabled = false;
            btnXoaService.Enabled = false;


            if (MessageBox.Show("Ban chac chan xoa chu", "Xac nhan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection connect = new SqlConnection(str);
                connect.Open();
                int currentIndex = dataGridView1.CurrentRow.Index;
                int userIdService = Convert.ToInt32(dataGridView1.Rows[currentIndex].Cells[0].Value.ToString());
                string xoa = "DELETE ListService WHERE IdService='" + userIdService + "'";
                SqlCommand cmdxoa = new SqlCommand(xoa, connect);
                cmdxoa.ExecuteNonQuery();

                Ketnoi();
                clear();
            }
            else
            {
                return;
            }
        }

        private void txtPriceService_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46) //!32 la SPACEBAR , 8 la  BACKSPACE, 46 la The DEL key.
            {
                e.Handled = true;
            }
        }
    }
}
