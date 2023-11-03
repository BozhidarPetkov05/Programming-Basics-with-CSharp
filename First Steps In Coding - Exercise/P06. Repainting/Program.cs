using System;

namespace P06._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = 1.50;
            double paint = 14.50;
            double thinner = 5;

            int nylonNeeded = int.Parse(Console.ReadLine());
            double paintNeeded = double.Parse(Console.ReadLine());
            int thinnerNeeded = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonNeeded + 2) * nylon;
            double paintPrice = (paintNeeded + 0.1*paintNeeded) * paint;
            double thinnerPrice = thinnerNeeded * thinner;
            double bags = 0.40;
            
            double materialSum = nylonPrice + paintPrice + thinnerPrice + bags;
            double workers = (materialSum * 0.3) * hours;
            double total = materialSum + workers;

            Console.WriteLine(total);


        }
    }
}
