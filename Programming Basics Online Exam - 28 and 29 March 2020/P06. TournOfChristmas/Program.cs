using System;

namespace P06._TournOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string sport;
            int winGame = 0;
            int loseGame = 0;
            int winDay = 0;
            int loseDay = 0;
            double prize = 20;
            double totalPrize = 0;
            for (int i = 1; i <= days; i++)
            {
                while ((sport = Console.ReadLine()) != "Finish")
                {
                    string stat = Console.ReadLine();
                    if (stat == "win")
                    {
                        winGame++;
                        
                        totalPrize += prize;
                    }
                    else if (stat == "lose")
                    {
                        loseGame++;
                    }
                }
                if (winGame > loseGame)
                {
                    winDay++;
                    totalPrize += totalPrize * 0.1;
                }
                else if (winGame < loseGame)
                {
                    loseDay++;
                }
            }
            if (winDay > loseDay)
            {
                totalPrize += totalPrize * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {totalPrize:f2}");
            }
            else if (winDay < loseDay)
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalPrize:f2}");
            }
        }
    }
}
