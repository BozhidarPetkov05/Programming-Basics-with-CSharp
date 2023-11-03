using System;

namespace P05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = string.Empty;
            string accomodation = string.Empty;
            double price = 0;

            if (budget <= 100)
            {
                place = "Bulgaria";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    price = budget * 0.3;
                }
                else
                {
                    price = budget * 0.7;
                    accomodation = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                place = "Balkans";
                if (season == "summer")
                {
                    accomodation = "Camp";
                    price = budget * 0.4;
                }
                else
                {
                    price = budget * 0.8;
                    accomodation = "Hotel";
                }
            }
            else
            {
                place = "Europe";
                price = budget * 0.9;
                accomodation = "Hotel";
            }
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{accomodation} - {price:f2}");
        }
    }
}
