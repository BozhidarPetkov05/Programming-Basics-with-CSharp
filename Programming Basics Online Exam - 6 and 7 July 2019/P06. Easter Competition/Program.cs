using System;

namespace P06._Easter_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string topBakerName = string.Empty;
            int topBakerPoints = 0;
            for (int i = 0; i < n; i++)
            {
                string bakerName = Console.ReadLine();
                string command;
                int currentBakerPoints = 0;
                while ((command = Console.ReadLine()) != "Stop")
                {
                    int currentPoints = int.Parse(command);
                    currentBakerPoints += currentPoints;
                }
                Console.WriteLine($"{bakerName} has {currentBakerPoints} points.");
                if (currentBakerPoints > topBakerPoints)
                {
                    topBakerName = bakerName;
                    topBakerPoints = currentBakerPoints;
                    Console.WriteLine($"{topBakerName} is the new number 1!");
                }
            }
            Console.WriteLine($"{topBakerName} won competition with {topBakerPoints} points!");
        }
    }
}
