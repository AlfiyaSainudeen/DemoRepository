using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsOnLinQ
{
    internal class CubeOfNumbers
    {
        public static void Main() 
        {
            int[] arr = { 112, 22, 32, 42, 235, 36, 37, 8,23,22,109,11,88,66,45,41 ,2,4,5,65,6,7};

            var result = from i in arr
                         where i*i*i>100 && i*i*i < 1000
                         select i*i*i;

            foreach (var i in result)
                Console.WriteLine(i);
        }
    }
}
