using System;

namespace P08._Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            double won = 0;
            double wonPoints = 0;
            for (int i = 1; i <= tournaments; i++)
            {
                string stage = Console.ReadLine();
                if (stage == "W")
                {
                    wonPoints += 2000;
                    points += 2000;
                    won += 1;
                }
                else if (stage == "F")
                {
                    wonPoints += 1200;
                    points += 1200;
                }
                else if (stage == "SF")
                {
                    wonPoints += 720;
                    points += 720;
                }
            }
            Console.WriteLine($"Final points: {points}");
            Console.WriteLine($"Average points: {Math.Floor(wonPoints/tournaments)}");
            Console.WriteLine($"{won/tournaments*100:f2}%");
        }
    }
}
