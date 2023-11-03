using System;

namespace P05._Everest
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int initialHikingMeters = 5364;
            int thePeakHeight = 8848;
            int daysForHiking = 1;
            while (command != "END")
            {
                int metersToHike = int.Parse(Console.ReadLine());
                if (command == "Yes")
                {
                    daysForHiking++;
                    if (daysForHiking > 5)
                    {
                        Console.WriteLine("Failed!");
                        Console.WriteLine($"{initialHikingMeters}");
                        break;
                    }
                    initialHikingMeters += metersToHike;
                }
                else
                {
                    initialHikingMeters += metersToHike;
                }
                if (initialHikingMeters >= thePeakHeight)
                {
                    Console.WriteLine($"Goal reached for {daysForHiking} days!");
                    break;
                }
                command = Console.ReadLine();
            }
            if (command == "END")
            {
                if (initialHikingMeters >= thePeakHeight)
                {
                    Console.WriteLine($"Goal reached for {daysForHiking} days!");
                }
                else
                {
                    Console.WriteLine("Failed!");
                    Console.WriteLine($"{initialHikingMeters}");
                }
            }
        }
    }
}
