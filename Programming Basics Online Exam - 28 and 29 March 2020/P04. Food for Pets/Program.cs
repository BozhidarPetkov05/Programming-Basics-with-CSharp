using System;

namespace P04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double cookie = 0;
            double totalDog = 0;
            double totalCat = 0;
            double totalCookie = 0;
            for (int i = 1; i <= days; i++)
            {
                double dogFood = double.Parse(Console.ReadLine());
                double catFood = double.Parse(Console.ReadLine());
                if (i%3 == 0)
                {
                    cookie = Math.Ceiling((dogFood + catFood) * 0.1);
                    
                }
                totalDog += dogFood;
                totalCat += catFood;
            }
            double eatenFood = totalCat + totalDog;
            double percent = eatenFood * 100 / food;
            double dogPercent = totalDog * 100 / eatenFood;
            double catPercent = totalCat * 100 / eatenFood;
            Console.WriteLine($"Total eaten biscuits: {cookie}gr.");
            Console.WriteLine($"{percent:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogPercent:f2}% eaten from the dog.");
            Console.WriteLine($"{catPercent:f2}% eaten from the cat.");
        }
    }
}
