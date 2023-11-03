using System;

namespace P08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            string serialName = Console.ReadLine();
            int episodeLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());

            double timeForEpisode = breakLenght * 5 / 8;
            if (timeForEpisode >= episodeLenght)
            {
                double timeLeft = timeForEpisode - episodeLenght;
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                double neededTime = episodeLenght - timeForEpisode;
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(neededTime)} more minutes.");
            }
        }
    }
}
