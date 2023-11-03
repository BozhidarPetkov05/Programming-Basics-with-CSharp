using System;

namespace P05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodKg = int.Parse(Console.ReadLine());
            string input;
            int foodGram = foodKg * 1000;
            int totalFood = 0;
            while ((input = Console.ReadLine()) != "Adopted")
            {
                int eatenFood = int.Parse(input);
                totalFood += eatenFood;
            }
            int leftovers = foodGram - totalFood;
            int needed = Math.Abs(totalFood - foodGram);
            if (totalFood <= foodGram)
            {
                Console.WriteLine($"Food is enough! Leftovers: {leftovers} grams.");
            }
            else if (totalFood > foodGram)
            {
                Console.WriteLine($"Food is not enough. You need {needed} grams more.");
            }
        }
    }
}
