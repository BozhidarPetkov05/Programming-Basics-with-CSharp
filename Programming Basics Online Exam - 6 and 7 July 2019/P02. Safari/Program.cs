using System;

namespace P02._Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelNeeded = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double fuelPrice = fuelNeeded * 2.10;
            double totalPrice = fuelPrice + 100;
            if (dayOfWeek == "Saturday")
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (dayOfWeek == "Sunday")
            {
                totalPrice -= totalPrice * 0.20;
            }
            if (budget >= totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Safari time! Money left: {moneyLeft:f2} lv. ");
            }
            else
            {
                double moneyNeeded = totalPrice - budget;
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded:f2} lv.");
            }
        }
    }
}
