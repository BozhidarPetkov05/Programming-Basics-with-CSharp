using System;

namespace P04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double puzzle = 2.60;
            double doll = 3.0;
            double teddyBear = 4.10;
            double minion = 8.20;
            double truck = 2.0;

            double vacationPrice = double.Parse(Console.ReadLine());
            int puzzleNum = int.Parse(Console.ReadLine());
            int dollNum = int.Parse(Console.ReadLine());
            int teddyBearNum = int.Parse(Console.ReadLine());
            int minionNum = int.Parse(Console.ReadLine());
            int truckNum = int.Parse(Console.ReadLine());

            int numToys = puzzleNum + dollNum + teddyBearNum + minionNum + truckNum;
            double priceToys = puzzle * puzzleNum + doll * dollNum + teddyBear * teddyBearNum + minion * minionNum + truck * truckNum;
            if (numToys >= 50)
            {
                double discount = priceToys * 0.25;
                double price = priceToys - discount;
                double priceShop = price * 0.1;
                double totalPrice = price - priceShop;
                if (vacationPrice > totalPrice)
                {
                    double needed = vacationPrice - totalPrice;
                    Console.WriteLine($"Not enough money! {needed:f2} lv needed.");
                }
                else
                {
                    double left = totalPrice - vacationPrice;
                    Console.WriteLine($"Yes! {left:f2} lv left.");
                }
            }
            else
            {
                double priceShop = priceToys * 0.1;
                double totalPrice = priceToys - priceShop;
                if (vacationPrice > totalPrice)
                {
                    double needed = vacationPrice - totalPrice;
                    Console.WriteLine($"Not enough money! {needed:f2} lv needed.");
                }
                else
                {
                    double left = totalPrice - vacationPrice;
                    Console.WriteLine($"Yes! {left:f2} lv left.");
                }
            }
        }
    }
}
