using System;

namespace P04._Workout
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double distanceAfterDay = +distance;
            double total = +distance;
            for (int i = 1; i <= days; i++)
            {
                double percents = double.Parse(Console.ReadLine());
                distanceAfterDay += distanceAfterDay * percents / 100;
                total += distanceAfterDay;
                
            }
            if (total >= 1000)
            {
                double more = Math.Ceiling(total - 1000);
                Console.WriteLine($"You've done a great job running {more} more kilometers!");
            }
            else
            {
                double needed = Math.Ceiling(1000 - total); ;
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {needed} more kilometers");
            }
        }
    }
}
