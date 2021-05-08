using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void StaticInstanceCount()
        {
            //Arrange
            var customer = new Customer();
            customer.FirstName = "Linda";
            Customer.InstanceCount += 1;

            var customer2 = new Customer();
            customer.FirstName = "Norma";
            Customer.InstanceCount += 1;

            var customer3 = new Customer();
            customer.FirstName = "Betty";
            Customer.InstanceCount += 1;
            //Act 
            int actual = 3;

            //Assert
            Assert.AreEqual(Customer.InstanceCount, actual);
        }
        [TestMethod]
        public void FullNameTestValid()
        {
            //Arrange
            var customer = new Customer
            {
                FirstName = "Troy",
                LastName = "Nilo"
            };
            string expected = "Nilo, Troy";
            //Act 
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //Arrange
            var customer = new Customer
            {
                
                LastName = "Nilo"
            };
            string expected = "Nilo";
            //Act 
            string actual = customer.FullName;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
