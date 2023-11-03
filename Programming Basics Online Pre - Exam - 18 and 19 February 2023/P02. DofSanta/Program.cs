using System;

namespace P02._DofSanta
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysLeft = int.Parse(Console.ReadLine());
            int foodKilo = int.Parse(Console.ReadLine());
            double deerOneFoodKilo = double.Parse(Console.ReadLine());
            double deerTwoFoodKilo = double.Parse(Console.ReadLine());
            double deerThreeFoodKilo = double.Parse(Console.ReadLine());

            double foodOne = daysLeft * deerOneFoodKilo;
            double foodTwo = daysLeft * deerTwoFoodKilo;
            double foodThree = daysLeft * deerThreeFoodKilo;

            double total = foodOne + foodTwo + foodThree;
            if (total <= foodKilo)
            {
                double left = Math.Floor(foodKilo - total);
                Console.WriteLine($"{left} kilos of food left.");
            }
            else
            {
                double needed = Math.Ceiling(total - foodKilo);
                Console.WriteLine($"{needed} more kilos of food are needed.");
            }
        }
    }
}
