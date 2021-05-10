using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest

    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange
            var customerRepsitory = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "tnilo@sample.com",
                FirstName = "Troy",
                LastName = "Nilo"
            };

            //Act

            var actual = customerRepsitory.Retrieve(1);
            //Assert
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
        }

        [TestMethod]
        public void RetrieveExistingEithAddress()
        {
            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAdress = "tnilo@sample.com",
                LastName = "Nilo",
                FirstName = "Troy",
                AddressList = new List<Address>()
                {
                    new Address()
                    {
                                AddressType = 1,
                                StreetLine1 = "Bag End",
                                StreetLine2 = "Bagshot Row",
                                City = "Hobbiton",
                                State = "Shire",
                                Country = "Middle Earth",
                                PostalCode = "144"
                     },
                    new Address()
                    {
                                AddressType = 1,
                                StreetLine1 = "Green Dragon",
                                City = "Bywater",
                                State = "Shire",
                                Country = "Middle Earth",
                                PostalCode = "146"
                    }
                 }
            };
            var actual = customerRepository.Retrieve(1);
            Assert.AreEqual(expected.CustomerId, actual.CustomerId);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAdress, actual.EmailAdress);

            for(int i = 0; i < 0; i++)
            {
                Assert.AreEqual(expected.AddressList[i].AddressType, actual.AddressList[i].AddressType);
                Assert.AreEqual(expected.AddressList[i].StreetLine1, actual.AddressList[i].StreetLine1);
                Assert.AreEqual(expected.AddressList[i].City, actual.AddressList[i].City);
                Assert.AreEqual(expected.AddressList[i].State, actual.AddressList[i].State);
                Assert.AreEqual(expected.AddressList[i].Country, actual.AddressList[i].Country);
                Assert.AreEqual(expected.AddressList[i].PostalCode, actual.AddressList[i].PostalCode);
            }
        }
    }
}
