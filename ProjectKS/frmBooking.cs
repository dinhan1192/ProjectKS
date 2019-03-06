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
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (nameValue.Text.Length == 0 || idValue.Text.Length == 0 || passportValue.Text.Length == 0 || phoneValue.Text.Length == 0)
            {
                output = false;
            }

            int idCustomer = 0;
            bool idCustomerValid = int.TryParse(idValue.Text, out idCustomer);
            if (!idCustomerValid)
            {
                output = false;
            }
            if (idCustomer <= 0)
            {
                output = false;
            }

            int passport = 0;
            bool passportValid = int.TryParse(passportValue.Text, out passport);
            if (!passportValid)
            {
                output = false;
            }

            int phoneNumber = 0;
            bool phoneNumberValid = int.TryParse(phoneValue.Text, out phoneNumber);
            if (!phoneNumberValid)
            {
                output = false;
            }

            return output;
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
