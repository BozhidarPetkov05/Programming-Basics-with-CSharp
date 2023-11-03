using System;

namespace P04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            bool flag = false;
            for (int x1 = start; x1 <= stop; x1++)
            {
                for (int x2 = start; x2 <= stop; x2++)
                {
                    combination++;
                    int result = x1 + x2;
                    if (result == magicNumber)
                    {
                        Console.WriteLine($"Combination N: {combination} ({x1} + {x2} = {magicNumber})");
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
