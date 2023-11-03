using System;

namespace P02._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 1; num <= 10; num++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{num}*{i} = {num*i}");
                }
            }
        }
    }
}
