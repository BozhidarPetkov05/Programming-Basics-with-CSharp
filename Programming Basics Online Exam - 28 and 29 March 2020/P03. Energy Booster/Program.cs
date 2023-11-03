using System;

namespace P03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());
            if (size == "small")
            {
                if (fruit == "Watermelon")
                {
                    double price = 2 * 56 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (fruit == "Mango")
                {
                    double price = 2 * 36.66 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (fruit == "Pineapple")
                {
                    double price = 2 * 42.10 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (fruit == "Raspberry")
                {
                    double price = 2 * 20 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
            }
            else if (size == "big")
            {
                if (fruit == "Watermelon")
                {
                    double price = 5 * 28.70 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (fruit == "Mango")
                {
                    double price = 5 * 19.60 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (fruit == "Pineapple")
                {
                    double price = 5 * 24.80 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price * 0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price * 0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
                else if (fruit == "Raspberry")
                {
                    double price = 5 * 15.20 * sets;
                    if (price >= 400 && price <= 1000)
                    {
                        price = price - price*0.15;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else if (price > 1000)
                    {
                        price = price - price*0.5;
                        Console.WriteLine($"{price:f2} lv.");
                    }
                    else
                    {
                        Console.WriteLine($"{price:f2} lv.");
                    }
                }
            }
        }
    }
}
