using System;

namespace P06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double pointsAcademy = double.Parse(Console.ReadLine());
            int rate = int.Parse(Console.ReadLine());
            double ratePoints = 0;
            double pointsName = 0;
            double totalPoints = 0;
            int character = 0;
            for (int i = 1; i <= rate; i++)
            {
                string rateName = Console.ReadLine();
                ratePoints = double.Parse(Console.ReadLine());
                totalPoints = (ratePoints * rateName.Length) / 2;
                pointsAcademy += totalPoints;
                if (pointsAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {pointsAcademy:f1}!");
                    break;
                }
            }
            if (pointsAcademy < 1250.5)
            {
                double needed = 1250.5 - pointsAcademy;
                Console.WriteLine($"Sorry, {name} you need {needed:f1} more!");
            }


        }
    }
}
