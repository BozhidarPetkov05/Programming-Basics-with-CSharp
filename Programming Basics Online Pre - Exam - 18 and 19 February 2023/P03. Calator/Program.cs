using System;

namespace P03._Calator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            if (season == "spring")
            {
                if (people <= 5)
                {
                    double price = 50;
                    double total = price * people;
                    Console.WriteLine($"{total:f2} leva.");
                }
                else
                {
                    double price = 48;
                    double total = price * people;
                    Console.WriteLine($"{total:f2} leva.");
                }
            }
            else if (season == "summer")
            {
                if (people <= 5)
                {
                    double price = 48.50;
                    double total = price * people;
                    double discount = total - total * 0.15;
                    Console.WriteLine($"{discount:f2} leva.");
                }
                else
                {
                    double price = 45;
                    double total = price * people;
                    double discount = total - total * 0.15;
                    Console.WriteLine($"{discount:f2} leva.");
                }
            }
            else if (season == "autumn")
            {
                if (people <= 5)
                {
                    double price = 60;
                    double total = price * people;
                    Console.WriteLine($"{total:f2} leva.");
                }
                else
                {
                    double price = 49.50;
                    double total = price * people;
                    Console.WriteLine($"{total:f2} leva.");
                }
            }
            else if (season == "winter")
            {
                if (people <= 5)
                {
                    double price = 86;
                    double total = price * people;
                    double discount = total + total * 0.08;
                    Console.WriteLine($"{discount:f2} leva.");
                }
                else
                {
                    double price = 85;
                    double total = price * people;
                    double discount = total + total * 0.08;
                    Console.WriteLine($"{discount:f2} leva.");
                }
            }
        }
    }
}
