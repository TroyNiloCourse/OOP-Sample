using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest

    {
        [TestMethod]
        public void RetrieveValid()
        {
            //Arrange 
            var productRepository = new ProductRepository();
            var expected = new Product
            {
                ProductName = "Sunflower",
                ProductDescription = "ShortDescription",
                CurrentPrice = 16.9M
            };
            var actual = productRepository.Retrieve(2);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);

        }
    }
}
