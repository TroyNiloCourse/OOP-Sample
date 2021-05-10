using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }
        private AddressRepository addressRepository { get; set; }
        // Saves the current customer
        public bool Save(Customer customer)
        {
            // Codes that saves the passed customer
            return true;
        }

        // Retrieve one customer.
        public Customer Retrieve(int customerId)
        {
            // Creating instance of customer class
            // pass in the requested ID
            var customer = new Customer(customerId);

            // Codes that retrieve the defined customer
            if (customerId == 1)
            {

                // Temporary hard-coded value to return a populated customer
                customer.EmailAdress = "tnilo@sample.com";
                customer.LastName = "Nilo";
                customer.FirstName = "Troy";
                customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
            }
            return customer;
        }
    }
}
