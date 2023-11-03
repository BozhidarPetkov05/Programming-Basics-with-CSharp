using System;

namespace P05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    double price = 0.50;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    double price = 0.80;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    double price = 1.20;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    double price = 1.45;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "peanuts")
                {
                    double price = 1.60;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    double price = 0.40;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    double price = 0.70;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    double price = 1.15;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    double price = 1.30;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "peanuts")
                {
                    double price = 1.50;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
            }
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    double price = 0.45;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "water")
                {
                    double price = 0.70;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "beer")
                {
                    double price = 1.10;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "sweets")
                {
                    double price = 1.35;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }
                else if (product == "peanuts")
                {
                    double price = 1.55;
                    double total = price * quantity;
                    Console.WriteLine(total);
                }

            }
        }
    }
}
