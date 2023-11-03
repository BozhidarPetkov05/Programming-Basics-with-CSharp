using System;

namespace P04._Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int totalVegetables = int.Parse(Console.ReadLine());
            int totalFruit = int.Parse(Console.ReadLine());

            double total = vegetablePrice * totalVegetables + fruitPrice * totalFruit;
            double priceInEuro = total / 1.94;
            Console.WriteLine($"{priceInEuro:f2}");
        }
    }
}
