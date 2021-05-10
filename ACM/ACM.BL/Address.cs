﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
   public class Address
    {
        public Address()
        {

        }
        public Address(int addressId)
        {
            AddressId = addressId;
        }
     public string StreetLine1 { get; set; }
     public string StreetLine2 { get; set; }
     public string City { get; set; }
     public string Province { get; set; }
     public string PostalCode { get; set; }
     public string Country { get; set; }
     public int AddressType { get; set; }
     public string State { get; set; }
     public int AddressId { get; private set; }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(City)) isValid = false;
            if (string.IsNullOrWhiteSpace(Province)) isValid = false;
            if (PostalCode == null) isValid = false;
            if (string.IsNullOrWhiteSpace(Country)) isValid = false;
            return isValid;
        }

    }
}
