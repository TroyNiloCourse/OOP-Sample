using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public bool Save(Customer customer)
        {
            return true;
        }
        public Customer Retrieve(int customerId)
        {
            var customer = new Customer(customerId);
            if (customerId == 1)
            {
                customer.EmailAdress = "tnilo@sample.com";
                customer.LastName = "Nilo";
                customer.FirstName = "Troy";
            }
            return customer;
        }
    }
}
