using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        // Retrieve one address.
        public Address Retrieve(int addressId)
        {
            // Create instance of address class
            // Passed the requied ID
            var address = new Address(addressId);
            
            // Codes that retrieves the defined address
            // Temporary hard-coded value to return a populated address
            if(addressId == 1)
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            // Code thats retrieve the defined address for the customer

            // Temporary hard-coded to return a set of values to customer for a address
            var addressList = new List<Address>();
            var address = new Address(1);
            {
                address.AddressType = 1;
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot Row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }
            addressList.Add(address);

            address = new Address(2);
            {
                address.AddressType = 1;
                address.StreetLine1 = "Green Dragon";
                address.City = "Bywater";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "146";
            }
            addressList.Add(address);
            return addressList;
        }
        // Saves the current address
        public bool Save()
        {
            //Codes that saves the passed address
            return true;
        }
    }
}
