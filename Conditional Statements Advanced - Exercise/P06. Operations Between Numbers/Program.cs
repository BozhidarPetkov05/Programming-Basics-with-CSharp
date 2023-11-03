using System;

namespace P06._Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = Console.ReadLine();
            if (operation == '+' || operation == '-' || operation == '*')
            {

            }
            if (num2 == 0)
            {
                Console.WriteLine($"Cannot divide {num1} by zero");
            }
            else if (operation == '/')
            {
                
                double result = num1 / num2;
                Console.WriteLine($"{num1}/{num2} = {result:f2}");
            }
            else
            {
                Console.WriteLine($"{num1} % {num2} = {num1%num2}");
            }

        }
    }
}
