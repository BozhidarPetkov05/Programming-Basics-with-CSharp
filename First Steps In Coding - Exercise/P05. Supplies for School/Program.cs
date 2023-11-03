using System;

namespace P05._Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            double chemicals = 5.80;
            double markers = 7.20;
            double cleaningDetergent = 1.20;

            double chemicalsNum = double.Parse(Console.ReadLine());
            double markersNum = double.Parse(Console.ReadLine());
            double cleaningDetergentNum = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double chemicalPrice = chemicals * chemicalsNum;
            double markersPrice = markers * markersNum;
            double cleaningDetergentPrice = cleaningDetergent * cleaningDetergentNum;
            double price = chemicalPrice + markersPrice + cleaningDetergentPrice;
            double totalPrice = price - (price * (discount / 100));

            Console.WriteLine(totalPrice);


        }
    }
}
