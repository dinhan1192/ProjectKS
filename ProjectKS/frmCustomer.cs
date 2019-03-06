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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
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
            bool passportValid = int.TryParse(passportValue.Text , out passport);
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
        

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Validate())
            {

            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again");
            }
            
        }

      
    }
}
