using System;

namespace P04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int money = 0;
            for (int i = 1; i <= age; i++)
            {
                if (i%2 == 0)
                {
                    money += i*5 - 1;
                }
                else
                {
                    money += toyPrice;
                }
            }
            if (money >= price)
            {
                double left = money - price;
                Console.WriteLine($"Yes! {left:f2}");
            }
            else
            {
                double need = price - money;
                Console.WriteLine($"No! {need:f2}");
            }
        }
    }
}
