using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public bool Save(Product product)
        {
            return true;
        }
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);
             if(productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "ShortDescription";
                product.CurrentPrice = 16.9M;
            }
            return product;
        }
    }
}
