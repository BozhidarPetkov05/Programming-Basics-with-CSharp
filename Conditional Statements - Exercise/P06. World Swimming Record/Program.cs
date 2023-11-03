using System;

namespace P06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double delay = Math.Floor(distance / 15) * 12.5;
            double recordIvan = distance * secondsPerMeter + delay;
            if (recordIvan >= record)
            {
                double neededTime = recordIvan - record;
                Console.WriteLine($"No, he failed! He was {neededTime:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordIvan:f2} seconds.");
            }
        }
    }
}
