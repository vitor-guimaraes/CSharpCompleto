using CSharpCompleto.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public class OrderEx3
    {
        public DateTime Moment { get; set; }
        public OrderStatusEx3 Status { get; set; }

        List<OrderItemEx3> Items { get; set; } = new List<OrderItemEx3>();

        public void AddItem(OrderItemEx3 item)
        {
            Items.Add(item);
        }   
        public void RemoveItem(OrderItemEx3 item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double totalValue = 0;
                        
            foreach (var item in Items)
            {
                totalValue += item.Price;
            }

            return totalValue;
        }
    }
}
