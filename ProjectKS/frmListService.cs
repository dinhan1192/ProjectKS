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
    public partial class frmListService : Form
    {
        public frmListService()
        {
            InitializeComponent();
        }

        private void btnThemService_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
        }

        private bool Validate()
        {
            bool output = true;
            if (idServiceValue.Text.Length == 0 || nameServiceValue.Text.Length == 0 || priceValue.Text.Length == 0)
            {
                output = false;
            }

            int idService = 0;
            bool idServiceValid = int.TryParse(idServiceValue.Text , out idService);
            if (!idServiceValid)
            {
                output = false;
            }

            decimal priceService = 0;
            bool priceServiceValid = decimal.TryParse(priceValue.Text, out priceService);
            if (!priceServiceValid)
            {
                output = false;
            }
            if (idService < 0)
            {
                output = false;
            }
            if (priceService < 0)
            {
                output = false;
            }


            return output;
        }
    }
}
