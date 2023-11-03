using System;

namespace P05._Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            
            double wCentimeter = w * 100;
            double hCentimeter = h * 100;
            double hallWithoutCorridor = hCentimeter - 100;
            double upperHalfSeats = Math.Floor(hallWithoutCorridor / 70);
            double lowerHalfSeats = Math.Floor(wCentimeter / 120);
            double totalSeats = upperHalfSeats * lowerHalfSeats - 3;
            
            Console.WriteLine($"{totalSeats}");
        }
    }
}
