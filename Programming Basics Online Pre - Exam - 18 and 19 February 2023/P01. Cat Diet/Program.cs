using System;

namespace P01._Cat_Diet
{
    class Program
    {
        static void Main(string[] args)
        {
            double fats = double.Parse(Console.ReadLine());
            double protein = double.Parse(Console.ReadLine());
            double carbohydrates = double.Parse(Console.ReadLine());
            double totalCalories = double.Parse(Console.ReadLine());
            double water = double.Parse(Console.ReadLine());

            double fatsPercent = (fats / 100 * totalCalories) / 9;
            double proteinPercent = (protein / 100 * totalCalories) / 4;
            double carbohydratesPercent = (carbohydrates / 100 * totalCalories) / 4;

            double totalFood = fatsPercent + proteinPercent + carbohydratesPercent;
            double calories = (double)(totalCalories / totalFood);
            double caloriesWithoutWater = calories * (100 - water)/100;
            Console.WriteLine($"{caloriesWithoutWater:f4}");
        }
    }
}
