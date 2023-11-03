using System;

namespace P03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime;
            string input = Console.ReadLine();
            int primeSum = 0;
            int nonPrimeSum = 0;
            int num;
            while (input != "stop")
            {
                num = int.Parse(input);
                isPrime = true;
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num%i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime && num>0)
                {
                    primeSum += num;
                }
                else
                {
                    nonPrimeSum += num;
                }
            }
        }
    }
}
