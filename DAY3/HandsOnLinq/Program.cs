namespace HandsOnLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 12, 23, 34, 45, 56, 67, 78, 89, 76, 65, 54, 43, 32, 21 };
            var result = from k in n
                         where k < 50
                         select k;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
            //fetch square of arraY NO
            result = from k in n
                     select k * k;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
            //fetch square value>1000
            result = from k in n
                     where k * k > 1000
                     select k * k;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
            //use variable in linq
            result = from k in n
                     let i = k * k
                     where i > 10000
                     select i;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
            result = from k in n
                     let i = k * k
                     where i > 1000 && i < 3000
                     select i;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
            //fetch values >50 in sorted order
            result = from k in n
                     where k > 50
                     orderby k
                     select k;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
            //fetch value>50 in descending order
            result = from k in n
                     where k > 50
                     orderby k descending
                     select k;
            foreach (var i in result)
                Console.WriteLine(i);
            Console.WriteLine();
        }
    }
}
