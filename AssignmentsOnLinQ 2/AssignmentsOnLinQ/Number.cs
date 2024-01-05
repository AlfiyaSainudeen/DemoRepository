using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsOnLinQ
{
    internal class Number
    {
        static void Main() 
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11};

            var evenNumbers = from n in arr
                              where n % 2 == 0
                              select n;
            Console.WriteLine("Even Number Count:"+evenNumbers.Count());
            foreach ( var n in evenNumbers ) 
            {
                Console.WriteLine( n );
            }
        }
    }
}
