using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsOnLinQ
{
    internal class OrderManagement
    {
        static void Main() 
        {
            List<Order> orderList = new List<Order>() 
            {
                new Order(1, "soap",new DateTime(2020, 2, 2),4),
                new Order(2, "toothpaste",new DateTime(2023, 3, 3),1),
                new Order(3, "salt",new DateTime(2021, 4, 13),2),
                new Order(4, "sugar",new DateTime(2010, 1, 20),3),
                new Order(5, "teapowder",new DateTime(2024, 12, 23),1),
                new Order(6, "washingpowder",new DateTime(2022, 10, 20),1),
            };
            //Day wise 
            var result = from f in orderList
                         orderby f.OrderDate.Day descending
                         select f;
            Console.WriteLine("Day wise:");
            foreach(var f in result)
            {
                Console.WriteLine($"Id:{f.OrderId} Name:{f.ItemName} Date:{f.OrderDate} Quantity:{f.Quantity}");
            }
            //By quantity wise
            result = orderList.OrderByDescending(f => f.Quantity);
            Console.WriteLine("Quantity wise:") ;
            foreach (var f in result)
            {
                Console.WriteLine($"Id:{f.OrderId} Name:{f.ItemName} Date:{f.OrderDate} Quantity:{f.Quantity}");
            }


            var result1 = orderList.OrderByDescending(f=> f.OrderDate).GroupBy(f => f.OrderDate.Month);

            Console.WriteLine();
            //month wise grouping and 
            foreach(var r in result1) 
            {
                Console.WriteLine("Month: " + r.Key);
                foreach(var o in r) 
                {
                    Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.OrderDate} Quantity:{o.Quantity}");
                }
            }

        }
    }
}
