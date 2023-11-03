using System;

namespace P05._Travel
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string destination;
            int budget;
            while (input != "End")
            {
                destination = input;
                budget = int.Parse(Console.ReadLine());
                while (budget > 0)
                {
                    budget -= int.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                input = Console.ReadLine();
            }
        }
    }
}
