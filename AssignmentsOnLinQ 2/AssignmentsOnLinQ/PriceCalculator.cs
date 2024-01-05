using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace AssignmentsOnLinQ
{
    class Bill 
    {
        public Bill(int orderid, string itemName, DateTime orderdate, int totalprice )
        {
            OrderId = orderid; 
            ItemName = itemName;
            OrderDate = orderdate;
            TotalPrice = totalprice;
        }
        public int OrderId {  get; set; }
        public string ItemName { get; set;}

        public DateTime OrderDate { get; set; }
        public int TotalPrice { get;  }
    
    }
    internal class PriceCalculator
    {
        static void Main() 
        {
            List<Order> orderList = new List<Order>()
            {
                new Order(1, "soap",new DateTime(2020, 2, 2),41),
                new Order(2, "toothpaste",new DateTime(2023, 3, 3),41),
                new Order(3, "salt",new DateTime(2021, 4, 13),42),
                new Order(4, "sugar",new DateTime(2010, 1, 20),13),
                new Order(5, "teapowder",new DateTime(2024, 12, 23),13),
                new Order(6, "washingpowder",new DateTime(2022, 10, 20),10),
            };

            List<Item> itemPriceList = new List<Item>() 
            {
                new Item("soap",35),
                new Item("toothpaste",107),
                new Item("salt",10),
                new Item("sugar",45),
                new Item("teapowder",95),
                new Item("washingpowder",189),
            };
            int Count = orderList.Count();
            //using anoymous types price list
            var priceList = from price in itemPriceList
                    join order in orderList
                    on price.ItemName equals order.ItemName
                    select new { orderId = order.OrderId, itemName = order.ItemName, orderDate = order.OrderDate, totalprice = order.Quantity * price.Price };
            Console.WriteLine("Order Price using Anonymous Types");
            foreach (var item in priceList)
            {
                Console.WriteLine($"OrderId: {item.orderId} ItemName:{item.itemName} OrderDate:{item.orderDate.ToShortDateString()} TotalPrice:{item.totalprice}");
            }



            var priceList1 = from order in orderList 
                        join price in itemPriceList
                        on  order.ItemName equals price.ItemName
                        select  new Bill(order.OrderId,price.ItemName,order.OrderDate,price.Price*order.Quantity);
            Console.WriteLine("Order Price");
            foreach (var item in priceList1)
            {
                Console.WriteLine($"OrderId: {item.OrderId} ItemName:{item.ItemName} OrderDate:{item.OrderDate.ToShortDateString()} TotalPrice:{item.TotalPrice}");
            }

            //Highest order placed

            var quanties = from q in orderList
                           where q.Quantity>0 //check if all 
                           orderby q.Quantity descending
                           select q;
            if (Count != quanties.Count())
            {
                Console.WriteLine("Not all quanties in the order list is above 0");
            }
            else
            {
                Console.WriteLine("All quanties in the order list is above 0");
            }

            var highestQuantityProduct = quanties.First().ItemName;
            Console.WriteLine("Highest Ordered Quantity Product");
            Console.WriteLine($"Name:{highestQuantityProduct}");
            
            //orders placed before Jan of this year
            DateTime dateTime = DateTime.Now;

            var ordersBeforeThisYear = from order in orderList
                                       where order.OrderDate.Year < dateTime.Year
                                       select order;

            foreach (var  o in ordersBeforeThisYear)
            {
                Console.WriteLine($"Id:{o.OrderId} Name:{o.ItemName} Date:{o.OrderDate} Quantity:{o.Quantity}");
            }

            //using query methods

            quanties = orderList.Where(o => o.Quantity > 0).OrderByDescending(o => o);
            
            if(Count!= quanties.Count()) 
            {
                Console.WriteLine("Not all quanties in the order list is above 0");
            }
            else 
            {
                Console.WriteLine("All quanties in the order list is above 0");
            }
            highestQuantityProduct = quanties.Select(q=>q.ItemName).First();
            Console.WriteLine($"Highest Quantity Product:{highestQuantityProduct}");



            //
            List<Order> orderList2 = new List<Order>()
            {
                new Order(1, "soap",new DateTime(2020, 2, 2),41),
                new Order(2, "soap",new DateTime(2023, 3, 3),20),
                new Order(3, "salt",new DateTime(2021, 4, 13),42),
                new Order(4, "salt",new DateTime(2010, 1, 20),13),
                new Order(5, "sugar",new DateTime(2024, 12, 23),13),
                new Order(6, "washingpowder",new DateTime(2022, 10, 20),10),
            };

            var orderquantity = orderList2.GroupBy(f => f.ItemName);
            var quantites = orderquantity.Where()

   
                                 

           







        }
    }
}
