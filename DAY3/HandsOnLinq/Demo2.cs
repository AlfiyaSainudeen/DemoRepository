using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo2
    {
        static void Main()
        {
            string[] flowers = { "rose", "lotus", "daliya" };
            string[] fruits = { "mango", "apple", "orange", "bannana" };

            //get fruits with name more than 5 letters
            var result = from s in fruits
                         where s.Length > 5
                         select s.ToUpper();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            //soring flowers
            var result1 = from f in flowers
                          orderby f
                          select f;
            foreach (var item in result1)
                Console.WriteLine(item);

        }
    }
}
