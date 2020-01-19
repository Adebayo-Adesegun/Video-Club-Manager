using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoClub
{
    public class Transaction
    {
        private string transactionID;
        private int customerID;
        private string videoName;
        private DateTime tdBorrowed;
        private DateTime rDate;
        private decimal amountPaid;
        private decimal latereturnFee;
        private int quantity;

        public Transaction()
        { }

        //The transaction id would be the int the format of customerID/BDate/RDate/Quantity
        public string TransactionID { get; set ; }
        public int CustomerID { get; set; }
        public string VideoName { get; set; }
        public string TdBorrowed { get; set; }
        public string RDate { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal LatereturnFee { get; set; }
        public int Quantity { get; set; }

    }
}
