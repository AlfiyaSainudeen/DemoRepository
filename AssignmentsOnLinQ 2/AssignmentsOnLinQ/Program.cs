namespace AssignmentsOnLinQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Player> playersList1= new List<Player>();  
            List<Player> playersList2 = new List<Player>();

            playersList1.Add(new Player("Hari", "India"));
            playersList1.Add(new Player("Akanshu", "Nepal"));
            playersList1.Add(new Player("Shin Lee", "China"));

            playersList2.Add(new Player("Aromal", "India"));
            playersList2.Add(new Player("Henry", "USA"));
            playersList2.Add(new Player("Edward", "Uk"));


            var result = from p1 in playersList1
                         from p2 in playersList2
                         where p1.Country != p2.Country
                         select new { op = p1.Name, op2 = p2.Name };

            foreach (var p in result ) 
            {
                Console.WriteLine($"{p.op} vs {p.op2}");
            }
           
        }
    }
}
