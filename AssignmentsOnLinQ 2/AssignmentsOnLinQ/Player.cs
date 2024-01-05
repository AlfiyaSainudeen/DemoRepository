using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsOnLinQ
{
    class Player
    {
        public Player(string name,string country) 
        {
            Name = name;
            Country = country;  
        }
        public string Name { get; set; }
        public string Country { get; set; }
    }
}
