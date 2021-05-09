using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
    }
}
