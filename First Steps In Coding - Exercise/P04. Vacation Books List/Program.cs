using System;

namespace P04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int timeNeeded = pages / pagesPerHour;
            int neededHours = timeNeeded / days;
            Console.WriteLine(neededHours);
        }
    }
}
