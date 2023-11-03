using System;

namespace P07._House_Painting
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double frontSide = (x * x) * 2 - (1.2 * 2);
            double sideSide = ((y * x) - (1.5 * 1.5)) * 2;
            double triangle = ((x * h) / 2) * 2;
            double roofSide = Math.Sqrt(((x / 2) * (x / 2)) + h * h);
            double roof = triangle + (roofSide * y) * 2;
            double greeenPaint = (frontSide + sideSide) / 3.4;
            double redPaint = roof / 4.3 - 0.02;
            Console.WriteLine($"{greeenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
