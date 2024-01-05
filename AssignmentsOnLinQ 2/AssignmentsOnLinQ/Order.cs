using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsOnLinQ
{
    internal class Order
    {
        public Order(int orderId,string itemName,DateTime orderDate,int quantity) 
        {
            OrderId = orderId;
            ItemName = itemName;
            OrderDate = orderDate;
            Quantity = quantity;

        }
        public int OrderId { get; set; } 
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
    }

   
}
