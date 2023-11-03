using System;

namespace P04._Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitors = int.Parse(Console.ReadLine());
            int back = 0;
            int chest = 0;
            int legs = 0;
            int abs = 0;
            int proteinShake = 0;
            int proteinBar = 0;
            for (int i = 1; i <= visitors; i++)
            {
                string activity = Console.ReadLine();
                if (activity == "Back")
                {
                    back++;
                }
                else if (activity == "Chest")
                {
                    chest++;
                }
                else if (activity == "Legs")
                {
                    legs++;
                }
                else if (activity == "Abs")
                {
                    abs++;
                }
                else if (activity == "Protein shake")
                {
                    proteinShake++;
                }
                else if (activity == "Protein bar")
                {
                    proteinBar++;
                }
                
            }
            double peoplePercent = (double)(back + chest + abs + legs) * 100 / visitors;
            double proteinPercent = (double)(proteinBar + proteinShake) * 100 / visitors;
            Console.WriteLine($"{back} - back");
            Console.WriteLine($"{chest} - chest");
            Console.WriteLine($"{legs} - legs");
            Console.WriteLine($"{abs} - abs");
            Console.WriteLine($"{proteinShake} - protein shake");
            Console.WriteLine($"{proteinBar} - protein bar");
            Console.WriteLine($"{peoplePercent:f2}% - work out");
            Console.WriteLine($"{proteinPercent:f2}% - protein");
        }
    }
}
