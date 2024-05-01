namespace DiceDistribution;


class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        List<int> tallies = new List<int>();
        for (int=0; i<=12; i++)
        {
            tallies.Add(0);

        }

        Console.WriteLine("Now rolling a billion pairs of dice...")
        Random randomgenerator = new Random();
        for (int roll=0; roll < 1_000_000_000; roll++)
        {
            int die1 = randomgenerator.Next(1,7);
            int die2 = randomgenerator.Next(1,7);
            int total = die1 + die2;
            tallies[total]++
        }
        Console.WriteLine("... finsished rolling. Distribution graph: ")

        int scale = 5_000_000;
        for (int i=2; i <= 12; i++)
        {
            Console.Write($"{i,2}: ");
            for (int graphUnit=0; graphUnit < tallies[i]/scale; graphUnit++)
            {
                Console.Write("#")
            }
            Console.WriteLine($" ({tallies[i]:n0})");
        }
        Console.WriteLine($" (Scale: each # represents {scale:n0} rolls) ")

    }
}