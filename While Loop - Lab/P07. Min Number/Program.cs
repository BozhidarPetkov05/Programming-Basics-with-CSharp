using System;

namespace P07._Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int minNum = int.MaxValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum < minNum)
                {
                    currentNum = minNum;
                }
            }
            Console.WriteLine(minNum);
        }
    }
}
