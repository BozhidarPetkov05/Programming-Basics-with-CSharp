using System;

namespace P06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int maxNum = int.MinValue;
            while ((input = Console.ReadLine()) != "Stop")
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (currentNum > maxNum)
                {
                    currentNum = maxNum;
                }

            }
            Console.WriteLine(maxNum);
        }
    }
}
