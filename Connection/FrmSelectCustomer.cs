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
    public partial class FrmSelectCustomer : Form
    {
        public Customer customer;
        public bool addCustomer;
        public FrmSelectCustomer()
        {
            InitializeComponent();
            Disable_all_form_control();
        }

        private void Displaycustomer()
        {
            TxtFirstName.Text = customer.Firstname;
            TxtMiddleName.Text = customer.Middlename;
            TxtSurname.Text = customer.Surname;
            TxtHomeNumber.Text = customer.PhoneNumber2;
            TxtPhoneNumber.Text = customer.PhoneNumber1;
            TxtPermAdd.Text = customer.Houseaddress1;
            TxtSuppAdd.Text = customer.Houseaddress2;
            DtpDateOFBirth.Value =Convert.ToDateTime( customer.Dateofbirth);
        }

        private void FrmSelectCustomer_Load(object sender, EventArgs e)
        {

        }

        private void PutcustomerData(Customer customer)
        {
            customer.Firstname = TxtFirstName.Text;
            customer.Middlename = TxtMiddleName.Text;
            customer.Surname = TxtSurname.Text;
            customer.Dateofbirth = DtpDateOFBirth.Value.ToString("MM/dd/yyyy"); ;
            customer.Houseaddress1 = TxtPermAdd.Text;
            customer.Houseaddress2 = TxtSuppAdd.Text;
            customer.PhoneNumber1 = TxtPhoneNumber.Text;
            customer.PhoneNumber2 = TxtHomeNumber.Text;
            customer.CustomerID = Convert.ToInt32(txtCustomerID.Text);
        }

        
        private void Disable_all_form_control()
        {
            txtCustomerID.Enabled = false;
            TxtFirstName.Enabled = false;
            TxtSurname.Enabled = false;
            TxtMiddleName.Enabled = false;
            TxtHomeNumber.Enabled = false;
            TxtPermAdd.Enabled = false;
            TxtPhoneNumber.Enabled = false;
            TxtSuppAdd.Enabled = false;
            DtpDateOFBirth.Enabled = false;
        }

        private void Enable_all_form_control()
        {
            txtCustomerID.Enabled = true;
            TxtFirstName.Enabled = true;
            TxtSurname.Enabled = true;
            TxtMiddleName.Enabled = true;
            TxtHomeNumber.Enabled = true;
            TxtPermAdd.Enabled = true;
            TxtPhoneNumber.Enabled = true;
            TxtSuppAdd.Enabled = true;
            DtpDateOFBirth.Enabled = true;
        }

        private void optCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            if (optCustomerID.Checked == true)
            {
                txtCustomerID.Enabled = true;
            }
            else if (optCustomerID.Checked == false)
            {
                txtCustomerID.Enabled = false;
            }

        }

        private void OptFNameSname_CheckedChanged(object sender, EventArgs e)
        {
            if (OptFNameSname.Checked == true)
            {
                TxtFirstName.Enabled = true;
                TxtSurname.Enabled = true;
            }
            else if (OptFNameSname.Checked == false)
            {

                TxtFirstName.Enabled = false;
                TxtSurname.Enabled = false;
            }
        }

        private void txtCustomerID_Validating(object sender, CancelEventArgs e)
        {
           
        }
       

        private void GetCustomer_by_ID (int customerID)
        {
            try
            {
                customer = VideoDb.SelectCustomer_by_ID(customerID);
                if (customer == null)
                    MessageBox.Show("No customer found with this ID. " + "Please try again.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
               
                    Displaycustomer();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
        private void GetCustomer_by_Fname_Surname (string firstname , string surname)
        {
            try
            {
                customer = VideoDb.SelectCustomer_by_Fname_Sname(firstname, surname);
                if(customer ==null)
                    MessageBox.Show("No customer found with this ID. " + "Please try again.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
               
                    Displaycustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGo_Click(object sender, EventArgs e)
        {
            if (optCustomerID.Checked == true)
            {
                if (Validator.Ispresent(txtCustomerID) && Validator.Isinteger(txtCustomerID))
                {
                    int customerID = Convert.ToInt32(txtCustomerID.Text);
                    GetCustomer_by_ID(customerID);
                }
            }
            else if (OptFNameSname.Checked ==true)
            {
                if(Validator.Ispresent(TxtFirstName) && Validator.Ispresent(TxtSurname))
                {
                    string firstname = Convert.ToString(TxtFirstName.Text);
                    string surname = Convert.ToString(TxtSurname.Text);
                    GetCustomer_by_Fname_Surname(firstname, surname);
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Customer newCustomer = new Customer();
            PutcustomerData(newCustomer);
            try
            {
                    bool confirmation = VideoDb.UpdateCustomer(newCustomer, customer);
                    if (confirmation == true)
                    {
                        MessageBox.Show("Customer details has been successfully updated.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (confirmation == false)
                    {
                        MessageBox.Show("Another user has updated or " + "deleted that vendor.", "Database Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    Disable_all_form_control();         
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Enable_all_form_control();
            
        }

       

       
       
    }
}
