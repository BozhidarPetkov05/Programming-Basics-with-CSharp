using System;

namespace P02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            double relaxingDay = double.Parse(Console.ReadLine());
            double workPlay = 365 - relaxingDay;
            double relaxTime = relaxingDay * 127;
            double workTime = workPlay * 63;
            double totalPlayTime = relaxTime + workTime;
            if (totalPlayTime <= 30000)
            {
                Console.WriteLine("Tom will run away");
                totalPlayTime = 30000 - totalPlayTime; 
                double hours = totalPlayTime / 60;
                double minutes = totalPlayTime - hours * 60;
                Console.WriteLine($"{hours:f0} hours and {minutes:f0} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                totalPlayTime = totalPlayTime - 30000;
                double hours = totalPlayTime / 60;
                double minutes = totalPlayTime - hours * 60;
                Console.WriteLine($"{hours:f0} hours and {minutes:f0} minutes less for play");
            }
        }
    }
}
