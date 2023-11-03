using System;

namespace P10._Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int oddNum = 0;
            int evenNum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i%2 == 0)
                {
                    oddNum += currentNum;
                }
                else
                {
                    evenNum += currentNum;
                }
            }
            if (oddNum == evenNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddNum}");
            }
            else
            {
                int diff = Math.Abs(evenNum - oddNum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
