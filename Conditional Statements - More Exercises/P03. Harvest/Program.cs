using System;

namespace P03._Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int needed = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalGrape = area * grape;
            double wine = totalGrape * 0.4;
            double totalWine = grape / 2.5;
            if (totalWine > needed)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {totalWine:f2} liters.”");
            }

        }
    }
}
