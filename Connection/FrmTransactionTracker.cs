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
    public partial class FrmTransactionTracker : Form
    {
        Transaction transaction;
        Customer customer = new Customer();
        public FrmTransactionTracker()
        {
            InitializeComponent();
        }

        private void FrmTransactionTracker_Load(object sender, EventArgs e)
        {

        }
        private void BtnProcess_Click(object sender, EventArgs e)
        {
            decimal amountP = Convert.ToDecimal(TxtAmountPaid.Text);
            DateTime date = DtpDateBorrowed.Value;
            lateTransacker(date , amountP);
            MessageBox.Show("processing Completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
        private void lateTransacker (DateTime dateB , decimal money)
        {
            decimal  lateFee = money * 0.2M ;
            DateTime returnDate = dateB.AddDays(7);

            TxtLRFee.Text = Convert.ToString(lateFee);
            DtpRdate.Value = returnDate;
        }
        private void Put_Transaction_Data(Transaction transaction)
        {
            transaction.CustomerID =Convert.ToInt32( txtCustomerID.Text);
            transaction.VideoName = TxtVideoName.Text;
            //The transaction id would be the int the format of customerID/BDate/RDate/Quantity
            transaction.TransactionID = txtCustomerID.Text + "/" + DtpDateBorrowed.Text + "/"+  DtpRdate.Value.ToString("mm");
            transaction.TdBorrowed = DtpDateBorrowed.Value.ToString("dd/MM/yyyy");
            transaction.RDate = DtpRdate.Value.ToString("dd/MM/yyyy");
            transaction.LatereturnFee =Convert.ToDecimal( TxtLRFee.Text);
            transaction.AmountPaid = Convert.ToDecimal(TxtAmountPaid.Text);
            transaction.Quantity = Convert.ToInt32(nudQuantity.Value);     
        }
        private bool IsValidData()
        {
            if(Validator.Ispresent(txtCustomerID) && Validator.Ispresent(TxtAmountPaid) 
                && Validator.Ispresent(TxtLRFee) &&
                Validator.Ispresent(TxtVideoName) 
                && Validator.Ispresent(DtpDateBorrowed) && Validator.Ispresent(DtpRdate))
            {
              
          
            }
            else
            {
                return false;
            }
            return true;
        }
        private void BtnMakeTrans_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                Transaction transaction = new Transaction();
                Put_Transaction_Data(transaction);
                try
                {
                    string message;
                    message = TransactionDB.AddTransaction(transaction);
                    MessageBox.Show(message, "Confirmation Message",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
            }
        }

        private void txtCustomerID_Validating(object sender, CancelEventArgs e)
        {
            //This method is to check if the customerID exists in database
            try
            {
                int ID = Convert.ToInt32(txtCustomerID.Text);
                customer = VideoDb.SelectCustomer_by_ID(ID);
                if (customer == null)
                    MessageBox.Show("No customer found with this ID. " + "Please try again.", "Customer Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
