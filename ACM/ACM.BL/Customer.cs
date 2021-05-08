using System;

namespace ACM.BL
{
    public class Customer
    {
        public string FullName 
        {
            get
            {
                return LastName += FirstName;
            }
        }
        public int CustomerID { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        private string _lastname;
        public string LastName
        {
            get
            {
                return _lastname;
            }
            set
            {
                _lastname = value;
            }
        }
    }
}
