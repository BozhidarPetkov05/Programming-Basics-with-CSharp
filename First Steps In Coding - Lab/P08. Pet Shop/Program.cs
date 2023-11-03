using System;

namespace P08._Pet_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double dogFood = 2.50;
            double catFood = 4;

            int dogFoodPacks = int.Parse(Console.ReadLine());
            int catFoodPacks = int.Parse(Console.ReadLine());
            double total = dogFoodPacks * dogFood + catFoodPacks * catFood;

            Console.WriteLine($"{total} lv.");
        }
    }
}
