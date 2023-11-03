using System;

namespace P03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededMoney = int.Parse(Console.ReadLine());
            double collectedMoney = int.Parse(Console.ReadLine());
            string input;
            double money;
            int daysCount = 0;
            int spendCount = 0;
            while (collectedMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCount++;
                if (input == "save")
                {
                    collectedMoney += money;
                    spendCount = 0;
                }
                else
                {
                    spendCount++;
                    if (spendCount == 5)
                    {
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(daysCount);
                        break;
                    }
                    collectedMoney -= money;
                    if (collectedMoney < 0)
                    {
                        collectedMoney = 0;
                    }
                }
            }
            if (collectedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
