using System;

namespace P06._Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double mackerelPrice = double.Parse(Console.ReadLine());
            double sprinklePrice = double.Parse(Console.ReadLine());
            double bonitoWeight = double.Parse(Console.ReadLine());
            double safridWeight = double.Parse(Console.ReadLine());
            double clamWeight = double.Parse(Console.ReadLine());

            double bonitoPrice = (mackerelPrice + mackerelPrice * 0.6) * bonitoWeight;
            double safridPrice = (sprinklePrice + sprinklePrice * 0.8) * safridWeight;
            double clamPrice = clamWeight * 7.50;

            double total = bonitoPrice + safridPrice + clamPrice;
            Console.WriteLine($"{total:f2}");
        }
    }
}
