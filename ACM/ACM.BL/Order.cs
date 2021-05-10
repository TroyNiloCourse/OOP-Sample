using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order() :this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItems>();
        }
        public int CustomerId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItems> OrderItems { get; set; }
        public int ShippingAddressId { get; set; }
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }
    }
}
