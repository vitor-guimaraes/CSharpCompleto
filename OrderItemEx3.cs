using System.Collections.Generic;

namespace CSharpCompleto.Entities
{
    public class OrderItemEx3
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        List<ProductEx3> Products { get; set; } = new List<ProductEx3>();
        public OrderItemEx3()
        {
                
        }
        public OrderItemEx3(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }
    }
}