using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectKS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuCheckIn_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmBooking")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmBooking frmBooking = new frmBooking();
                frmBooking.MdiParent = this;
                frmBooking.Show();
            }
        }

        private void menuSuDungDichVuPhong_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmOrderService")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmOrderService frmOrderService = new frmOrderService();
                frmOrderService.MdiParent = this;
                frmOrderService.Show();
            }
        }

        private void menuBill_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmBill")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmBill frmBill = new frmBill();
                frmBill.MdiParent = this;
                frmBill.Show();
            }
        }

        private void menuCustomer_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmCustomer")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmCustomer frmCustomer = new frmCustomer();
                frmCustomer.MdiParent = this;
                frmCustomer.Show();
            }
        }

        private void menuEmployee_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmEmployee")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmEmployee frmEmployee = new frmEmployee();
                frmEmployee.MdiParent = this;
                frmEmployee.Show();
            }
        }

        private void menuListRoom_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmListRoom")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmListRoom frmListRoom = new frmListRoom();
                frmListRoom.MdiParent = this;
                frmListRoom.Show();
            }
        }

        private void menuListService_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "frmListService")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                frmListService frmListService = new frmListService();
                frmListService.MdiParent = this;
                frmListService.Show();
            }
        }

        private void MenuListBill_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "ListBill")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                ListBill ListBill = new ListBill();
                ListBill.MdiParent = this;
                ListBill.Show();
            }
        }

        private void menuDoanhThu_Click(object sender, EventArgs e)
        {
            bool isExist = false;

            foreach (Form frmChildForm in this.MdiChildren)
            {
                if (frmChildForm.Name == "ListBill")
                {
                    frmChildForm.Activate();
                    isExist = true;
                }
            }
            if (!isExist)
            {
                DoanhThu DoanhThu = new DoanhThu();
                DoanhThu.MdiParent = this;
                DoanhThu.Show();
            }
        }
    }
}
