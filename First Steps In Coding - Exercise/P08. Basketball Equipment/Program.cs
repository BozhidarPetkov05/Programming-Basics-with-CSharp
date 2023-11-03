using System;

namespace P08._Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double yearPrice = double.Parse(Console.ReadLine());

            double shoes = yearPrice - yearPrice * 40 / 100;
            double clothes = shoes - shoes * 20 / 100;
            double ball = clothes * 1 / 4;
            double accessories = ball * 1 / 5;

            double totalPrice = yearPrice + shoes + clothes + ball + accessories;

            Console.WriteLine(totalPrice);
        }
    }
}
