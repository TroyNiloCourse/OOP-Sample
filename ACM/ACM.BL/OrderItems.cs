using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderItems
    {
       

        public OrderItems()
        {

        }
        public OrderItems(int orderItemsId)
        {
            OrderItemsId = orderItemsId;
        }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int OrderItemsId{ get; private set; }
        public decimal? PurchasPrice { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (Quantity >= 0) isValid = false;
            if (ProductId >= 0) isValid = false;
            if (PurchasPrice == null) isValid = false;
            return isValid;
        }
        public OrderItems Retrieve(int orderItemsId)
        {
            return new OrderItems();
        }

        public bool Save()
        {
            return true;
        }
    }
}
