using System;

namespace P03._Deposit_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int depositTime = int.Parse(Console.ReadLine());
            double interestRate = double.Parse(Console.ReadLine());
            double percent = interestRate / 100;
            double totalSum = depositedSum + depositTime * ((depositedSum * percent) / 12);
            Console.WriteLine(totalSum);
        }
    }
}
