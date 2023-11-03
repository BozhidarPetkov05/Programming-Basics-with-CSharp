using System;

namespace P01._Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent * 0.2;
            double drinks = cake - cake * 0.45;
            double animator = rent * 1 / 3;

            double total = rent + cake + drinks + animator;
            Console.WriteLine(total);
        }
    }
}
