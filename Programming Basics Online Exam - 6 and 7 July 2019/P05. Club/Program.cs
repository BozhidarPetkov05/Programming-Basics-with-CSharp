using System;

namespace P05._Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double targetSum = double.Parse(Console.ReadLine());
            string cocktailName;
            double currentSum = 0;
            bool isReached = false;
            while ((cocktailName = Console.ReadLine()) != "Party!")
            {
                int cocktailCount = int.Parse(Console.ReadLine());
                double cocktailPrice = cocktailName.Length * cocktailCount;
                if (cocktailPrice %2 != 0)
                {
                    cocktailPrice -= cocktailPrice * 0.25;
                }
                currentSum += cocktailPrice;
                if (currentSum >= targetSum)
                {
                    isReached = true;
                    break;
                }
            }
            if (isReached)
            {
                Console.WriteLine("Target acquired.");
            }
            else
            {
                double needed = targetSum - currentSum;
                Console.WriteLine($"We need {needed:f2} leva more.");
            }
            Console.WriteLine($"Club income - {currentSum:f2} leva.");
        }
    }
}
