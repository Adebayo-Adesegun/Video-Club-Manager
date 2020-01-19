using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoClub
{
   public class Customer
    {
       //==========private properties======
       private int customerID;
       private string firstName;
       private string middleName;
       private string surname;
       private string dateofBirth;
       private string houseAddress1;
       private string houseAddress2;
       private string phoneNumber1;
       private string phoneNumber2;

       //=====constructor=====

       public Customer() { }

       //=======public properties
       public int CustomerID { get; set; }
       public string Firstname { get; set; }
       public string Middlename { get; set; }
       public string Surname { get; set; }
       public string Dateofbirth { get; set; }
       public string Houseaddress1 { get; set; }
       public string Houseaddress2 { get; set; }
       public string PhoneNumber1 { get; set; }
       public string PhoneNumber2 { get; set; }



    }
}
