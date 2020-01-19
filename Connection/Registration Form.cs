using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub
{
    public partial class FrmRegForm : Form
    {
        Customer customer;
        public FrmRegForm()
        {
            InitializeComponent();
        }

        private void PutcustomerData(Customer customer  )
        {
            customer.Firstname = TxtFirstName.Text;
            customer.Middlename = TxtMiddleName.Text;
            customer.Surname = TxtSurname.Text;
            customer.Dateofbirth = DtpDateOFBirth.Value.ToString("dd/MM/yyyy"); ;
            customer.Houseaddress1 = TxtPermAdd.Text;
            customer.Houseaddress2 = TxtSuppAdd.Text;
            customer.PhoneNumber1 = TxtPhoneNumber.Text;
            customer.PhoneNumber2 = TxtHomeNumber.Text;
        }
        private bool IsValidData()
        {
            if(Validator.Ispresent(TxtFirstName) && 
                Validator.Ispresent(TxtMiddleName) &&
                Validator.Ispresent(TxtSurname) &&
                Validator.Ispresent(TxtPermAdd)&&
                Validator.Ispresent(TxtPhoneNumber))
            {
                if (DtpDateOFBirth.Value == DateTime.Now)
                    MessageBox.Show("Please enter a date of birth", "Date Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                Customer customer = new Customer();
                PutcustomerData(customer);
                try
                {

                    LblDisplayMessage.Text = VideoDb.AddCustomer(customer);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }

            }

        }

        private void FrmRegForm_Load(object sender, EventArgs e)
        {

        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {

        }
      
    }
}
