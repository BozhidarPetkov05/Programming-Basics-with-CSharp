using System;

namespace P06._MulTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numOne = 0;
            int numTwo = 0;
            int numThree = 0;

            numOne = num % 10;
            numTwo = (num / 10) % 10;
            numThree = num / 100;
            for (int k = 1; k <= numOne; k++)
            {
                for (int a = 1; a <= numTwo; a++)
                {
                    for (int r = 1; r <= numThree; r++)
                    {
                        Console.WriteLine($"{k} * {a} * {r} = {k*a*r};");
                    }
                }
            }
        }
    }
}
