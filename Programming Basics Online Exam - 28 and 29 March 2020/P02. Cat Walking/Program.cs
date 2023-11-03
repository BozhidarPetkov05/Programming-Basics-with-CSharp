using System;

namespace P02._Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutes = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            double caloriesPerDay = double.Parse(Console.ReadLine());

            double burntCalories = minutes * 5 * walksPerDay;

            if (caloriesPerDay*0.5 <= burntCalories)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burntCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burntCalories}.");
            }
        }
    }
}
