using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsOnLinQ
{
    internal class Item
    {
        public Item(string name, int price) 
        {
            ItemName = name;
            Price = price;  
        }
        public string ItemName { get; set; }
        public int Price { get; set; }
    }
}
