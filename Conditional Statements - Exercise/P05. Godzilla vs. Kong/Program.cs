using System;

namespace P05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());

            double decoration = budget * 0.1;
            double clothesPrice = people * clothes;
            if (clothesPrice > 150)
            {
                double discount = clothes * 0.1;
                double clothesTotal = clothesPrice - discount;
                if (clothesPrice + decoration > budget)
                {
                    double total = clothesPrice + decoration;
                    double needed = total - budget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {needed:f2} leva more.");
                }
                else
                {
                    double total = clothesPrice + decoration;
                    double left = budget - total;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
                }
            }
            else
            {
                if (clothesPrice + decoration > budget)
                {
                    double total = clothesPrice + decoration;
                    double needed = total - budget;
                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs {needed:f2} leva more.");
                }
                else
                {
                    double total = clothesPrice + decoration;
                    double left = budget - total;
                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {left:f2} leva left.");
                }
            }
        }
    }
}
